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
    public partial class FrmAdd : Form
    {
        private frmQL f;
        public FrmAdd(frmQL f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMssv.Text == "" || txtTen.Text == "" || cmbKhoa.SelectedIndex == -1 || txtTB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(int.TryParse(txtMssv.Text, out int mssv) == false)
            {
                MessageBox.Show("Mã số sinh viên phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(txtTB.Text, out float diemTb) || diemTb < 0 || diemTb > 10)
            {
                MessageBox.Show("Điểm trung bình phải là số từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (ListViewItem item in f.lsvQuanLy.Items)
            {
                if(item.SubItems[2].Text == txtMssv.Text)
                {
                    DialogResult kq = MessageBox.Show("Mã số sinh viên đã tồn tại, Bạn có muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(kq == DialogResult.Yes)
                    {
                        item.SubItems[3].Text = txtTen.Text;
                        item.SubItems[4].Text = cmbKhoa.SelectedItem.ToString();
                        item.SubItems[5].Text = txtTB.Text;
                        Close();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            f.lsvQuanLy.Items.Add(new ListViewItem(new string[] {
                "",
                (f.lsvQuanLy.Items.Count + 1).ToString(),
                txtMssv.Text,
                txtTen.Text,
                cmbKhoa.SelectedItem.ToString(),
                txtTB.Text
            }));
        }
    }
}
