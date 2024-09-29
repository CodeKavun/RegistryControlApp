namespace RegistryControlApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regKeysView = new System.Windows.Forms.TreeView();
            this.valuesListView = new System.Windows.Forms.ListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // regKeysView
            // 
            this.regKeysView.Location = new System.Drawing.Point(12, 12);
            this.regKeysView.Name = "regKeysView";
            this.regKeysView.Size = new System.Drawing.Size(227, 426);
            this.regKeysView.TabIndex = 0;
            this.regKeysView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.regKeysView_AfterSelect);
            // 
            // valuesListView
            // 
            this.valuesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.typeCol,
            this.valueCol});
            this.valuesListView.HideSelection = false;
            this.valuesListView.Location = new System.Drawing.Point(246, 12);
            this.valuesListView.Name = "valuesListView";
            this.valuesListView.Size = new System.Drawing.Size(542, 426);
            this.valuesListView.TabIndex = 1;
            this.valuesListView.UseCompatibleStateImageBehavior = false;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            this.nameCol.Width = 70;
            // 
            // typeCol
            // 
            this.typeCol.Text = "Type";
            this.typeCol.Width = 50;
            // 
            // valueCol
            // 
            this.valueCol.Text = "Value";
            this.valueCol.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valuesListView);
            this.Controls.Add(this.regKeysView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView regKeysView;
        private System.Windows.Forms.ListView valuesListView;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader typeCol;
        private System.Windows.Forms.ColumnHeader valueCol;
    }
}

