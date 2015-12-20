namespace TTNM_2
{
    partial class Help
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Pen");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Speak");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Keyboard");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Các giao diện", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("File");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Format");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("View");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Help");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Chức năng", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Pen";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Speak";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Keyboard";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Các giao diện";
            treeNode5.Name = "Node8";
            treeNode5.Text = "File";
            treeNode6.Name = "Node10";
            treeNode6.Text = "Edit";
            treeNode7.Name = "Node11";
            treeNode7.Text = "Format";
            treeNode8.Name = "Node12";
            treeNode8.Text = "View";
            treeNode9.Name = "Node13";
            treeNode9.Text = "Help";
            treeNode10.Name = "Node7";
            treeNode10.Text = "Chức năng";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(181, 450);
            this.treeView1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(200, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(775, 449);
            this.webBrowser1.TabIndex = 1;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 474);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}