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
using PBL3.DTO;

namespace PBL3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            List<DTOTable> tableList = TableDAO.Instance.LoadTableList();

            foreach (DTOTable item in tableList)
            {
                Button btn = new Button() { Width = 50, Height = 50 };
                
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                /*
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                */
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as DTOTable).ID;
            ShowBill(tableID);
        }
        void ShowBill(int id)
        {
            listView1.Items.Clear();
            List<DTOMonAn> listBillInfo = DALMon.Instance.GetListMenuByTable(id);
            float totalprice = 0;
            //foreach (PBL3.DTO.DTOMonAn item in listBillInfo)
            foreach (DTOMonAn item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Foodname.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Totalprice.ToString());
                totalprice += item.Totalprice;
                listView1.Items.Add(lsvItem);
            }
            textBox1.Text = totalprice.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DTOTable table = listView1.Tag as DTOTable;
            int idBill = BILLDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            if (idBill != -1)
            {
                
                    BILLDAO.Instance.CheckOut(idBill);
                    ShowBill(table.ID);

                    LoadTable();
                
            }
            MessageBox.Show("Hoa don da dc in");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*
            List<DTOTable> tableList = TableDAO.Instance.LoadTableList();

            foreach (DTOTable item in tableList)
            {
                Button btn = new Button() { Width = 50, Height = 50 };
                /*
                btn.Text = item.Name + Environment.NewLine + item.Status;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                
                panel1.Controls.Add(btn);
            
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
