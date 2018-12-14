namespace Menu
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("A");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("B");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("C");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Mag");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Manzi");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("JAVA");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("PHP");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Python");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("VB");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Dev c++");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("C++");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("C#");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("ruby");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Utilities", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.display = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.display.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "A";
            treeNode2.Name = "Node2";
            treeNode2.Text = "B";
            treeNode3.Name = "Node3";
            treeNode3.Text = "C";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Mag";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Manzi";
            treeNode6.Name = "Node3";
            treeNode6.Text = "JAVA";
            treeNode7.Name = "Node4";
            treeNode7.Text = "PHP";
            treeNode8.Name = "Node5";
            treeNode8.Text = "Python";
            treeNode9.Name = "Node6";
            treeNode9.Text = "VB";
            treeNode10.Name = "Node7";
            treeNode10.Text = "Dev c++";
            treeNode11.BackColor = System.Drawing.Color.DodgerBlue;
            treeNode11.Name = "Node8";
            treeNode11.Text = "C++";
            treeNode12.Name = "Node9";
            treeNode12.Text = "C#";
            treeNode13.BackColor = System.Drawing.Color.Blue;
            treeNode13.Name = "Node10";
            treeNode13.Text = "ruby";
            treeNode14.Name = "Calculator";
            treeNode14.Text = "Calculator";
            treeNode15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            treeNode15.Name = "Node0";
            treeNode15.Text = "Utilities";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(800, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.WindowText;
            this.display.Controls.Add(this.label1);
            this.display.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.display.Location = new System.Drawing.Point(276, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(526, 452);
            this.display.TabIndex = 1;
            this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(249, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.display);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.display.ResumeLayout(false);
            this.display.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel display;
        private System.Windows.Forms.Label label1;
    }
}

