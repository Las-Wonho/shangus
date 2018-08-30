using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFight
{
    public partial class Form1 : Form
    {
        String userName;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socket_.post("match "+userName);
            userName = textBox1.Text; 
            this.Visible = false;
            Form2 frm = new Form2(userName);
            frm.Owner = this;
            frm.Show();
        }
    }
}
