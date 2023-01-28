namespace Treeview
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dell");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Lenovo");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Acer");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Laptop", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("LG");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Computer", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mobile");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Electronics", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Shirts");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Pants");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Men\'s Wear", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Women\'s Wear");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Garments", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Dell";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Lenovo";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Acer";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Laptop";
            treeNode5.Name = "Node6";
            treeNode5.Text = "LG";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Computer";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Mobile";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Electronics";
            treeNode9.Name = "Node12";
            treeNode9.Text = "Shirts";
            treeNode10.Name = "Node13";
            treeNode10.Text = "Pants";
            treeNode11.Name = "Node10";
            treeNode11.Text = "Men\'s Wear";
            treeNode12.Name = "Node11";
            treeNode12.Text = "Women\'s Wear";
            treeNode13.Name = "Node9";
            treeNode13.Text = "Garments";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(221, 327);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 338);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;

    }
}

