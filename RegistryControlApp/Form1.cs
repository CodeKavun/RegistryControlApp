using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistryControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RegistryKey[] rootKeys =
            {
                Registry.ClassesRoot,
                Registry.LocalMachine,
                Registry.CurrentUser,
                Registry.Users,
                Registry.CurrentConfig
            };

            for (int i = 0; i < rootKeys.Length; i++)
            {
                regKeysView.Nodes.Add(rootKeys[i].Name);
                InitializeRegistryKeysTree(rootKeys[i], regKeysView.Nodes[i].Nodes);
            }

            valuesListView.View = View.Details;
        }

        private void InitializeRegistryKeysTree(RegistryKey rootKey, TreeNodeCollection nodes)
        {
            try
            {
                string[] keys = rootKey.GetSubKeyNames();

                int nodeIndex = 0;
                foreach (string key in keys)
                {
                    RegistryKey subKey = rootKey.OpenSubKey(key);
                    nodes.Add(subKey.Name);

                    if (subKey != null)
                    {
                        InitializeRegistryKeysTree(subKey, nodes[nodeIndex].Nodes);
                    }

                    nodeIndex++;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void regKeysView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            valuesListView.Items.Clear();

            string registryPath = regKeysView.SelectedNode.Text;
            string[] splittedPath = registryPath.Split('\\');

            RegistryKey rootKey = GetRootKey(splittedPath[0]);

            splittedPath.ToList().RemoveAt(0);
            string pathWithoutRoot = string.Join("\\", splittedPath).Remove(0, splittedPath[0].Length);

            RegistryKey selectedKey = rootKey.OpenSubKey(pathWithoutRoot) ?? rootKey;
            string[] valueNames = selectedKey.GetValueNames();

            foreach (string valueName in valueNames)
            {
                object value = selectedKey.GetValue(valueName);
                RegistryValueKind valueKind = selectedKey.GetValueKind(valueName);

                string[] datas = { valueName, valueKind.ToString(), value.ToString() };

                ListViewItem valueListItem = new ListViewItem(datas);
                valuesListView.Items.Add(valueListItem);
            }
        }

        private RegistryKey GetRootKey(string name)
        {
            switch (name)
            {
                case "HKEY_CLASSES_ROOT":
                    return Registry.ClassesRoot;
                case "HKEY_LOCAL_MACHINE":
                    return Registry.LocalMachine;
                case "HKEY_CURRENT_USER":
                    return Registry.CurrentUser;
                case "HKEY_USERS":
                    return Registry.Users;
                case "HKEY_CURRENT_CONFIG":
                    return Registry.CurrentConfig;
                default:
                    return Registry.LocalMachine;
            }
        }
    }
}
