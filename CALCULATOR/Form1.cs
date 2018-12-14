using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form P;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;

            

            if(e.Node.Name== "Calculator")
            {
                Form2 P = new Form2();
                display.Controls.Clear();
                P = new Form2();
                P.TopLevel = false;
                this.display.Controls.Add(P);
                P.Dock = DockStyle.Fill;
                P.Show();



            }


           else  if (e.Node.Name == "Node1")
            {
                Form3 J = new Form3();
                display.Controls.Clear();
                J = new Form3();
                J.TopLevel = false;
                this.display.Controls.Add(J);
                J.Dock = DockStyle.Fill;
                J.Show();



            }

            else if (e.Node.Name == "Node3")
            {
                Form5 M = new Form5();
                display.Controls.Clear();
                M = new Form5();
                M.TopLevel = false;
                this.display.Controls.Add(M);
                M.Dock = DockStyle.Fill;
                M.Show();



            }
            else if (e.Node.Name == "Node4")
            {
                Form4image f = new Form4image();
                display.Controls.Clear();
                f = new Form4image();
                f.TopLevel = false;
                this.display.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();



            }

            else if (e.Node.Name == "Node5")
            {
                Form4image f = new Form4image();
                display.Controls.Clear();
                f = new Form4image();
                f.TopLevel = false;
                this.display.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();



            }

            else if (e.Node.Name == "Node4")
            {
                Form4image MAG = new Form4image();
                display.Controls.Clear();
                MAG = new Form4image();
                MAG.TopLevel = false;
                this.display.Controls.Add(MAG);
                MAG.Dock = DockStyle.Fill;
                MAG.Show();



            }



















           
        }
    }
}
