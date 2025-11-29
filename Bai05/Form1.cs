using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class frmQL : Form
    {
        public frmQL()
        {
            InitializeComponent();
            lsvQuanLy.FullRowSelect = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvQuanLy.Columns.Add(" ");
            lsvQuanLy.Columns.Add("Số STT");
            lsvQuanLy.Columns.Add("Mã Số SV");
            lsvQuanLy.Columns.Add("Tên Sinh Viên");
            lsvQuanLy.Columns.Add("Khoa");
            lsvQuanLy.Columns.Add("Điểm TB");
            lsvQuanLy.View = View.Details;
            lsvQuanLy.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmAdd f = new FrmAdd(this);
            f.Show();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = toolStripTextBox1.Text.Trim().ToLower();
            foreach (ListViewItem item in lsvQuanLy.Items)
            {
                string name = item.SubItems[3].Text.ToLower();
                if (name.Contains(keyword) && toolStripTextBox1.Text != "")
                {
                    item.BackColor = Color.Yellow;
                    item.SubItems[0].Text = ">";
                }
                else
                {
                    item.BackColor = Color.White;
                    item.SubItems[0].Text = "";
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
        }

    }
}


