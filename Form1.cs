using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAO;

namespace PBL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (Login(username,password))
            {
                Form4 f = new Form4();
                this.Hide();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau");
            }
        }
    }
}
