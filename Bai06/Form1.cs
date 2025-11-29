using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string SourceName = "";
        string DestinationName = "";
        private void btnNguon_Click(object sender, EventArgs e)
        {
            using(FileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    SourceName = ofd.FileName;
                    string dirPath = Path.GetDirectoryName(ofd.FileName);
                    txtNguon.Text = dirPath;
                }
            }
        }

        private void btnDich_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(SourceName))
            {
                MessageBox.Show("Vui lòng chọn file nguồn trước!");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = Path.GetFileName(SourceName);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DestinationName = sfd.FileName;
                    string dirPath = Path.GetDirectoryName(sfd.FileName);
                    txtDich.Text = dirPath;
                }
            }
        }

        private void btnCoppy_Click(object sender, EventArgs e)
        {
            string nguon = SourceName;
            string dich = DestinationName;
            if (string.IsNullOrEmpty(nguon) || string.IsNullOrEmpty(dich))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ đường dẫn nguồn và đích!");
                return;
            }
            if (!File.Exists(nguon))
            {
                MessageBox.Show("File nguồn không tồn tại!");
                return;
            }
            progressBar1.Value = 0;
            using (FileStream fsNguon = new FileStream(nguon, FileMode.Open, FileAccess.Read))
            using (FileStream fsDich = new FileStream(dich, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024 * 10];
                long totalBytes = fsNguon.Length;
                long bytesCopied = 0;
                int bytesRead;
                tooltipTrangThai.Show($"Đang sao chép: {SourceName}", groupBox2);
                toolStripStatusLabel1.Text = $"Đang sao chép: {SourceName}";
                while ((bytesRead = fsNguon.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsDich.Write(buffer, 0, bytesRead);
                    bytesCopied += bytesRead;
                    int percentComplete = (int)(bytesCopied * 100 / totalBytes);
                    progressBar1.Value = percentComplete;
                    progressBar1.Refresh();
                    Application.DoEvents();
                }
                if(progressBar1.Value == 100)
                {
                    tooltipTrangThai.Show("Sao chép hoàn tất!", groupBox2);
                    toolStripStatusLabel1.Text = "Sao chép hoàn tất!";
                    DialogResult = MessageBox.Show("Sao chép file thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(DialogResult == DialogResult.OK)
                    {
                        Reset();
                    }
                }
            }
        }
        private void Reset()
        {
            SourceName = "";
            DestinationName = "";
            txtNguon.Text = "";
            txtDich.Text = "";
            progressBar1.Value = 0;
            toolStripStatusLabel1.Text = "";
            tooltipTrangThai.Hide(groupBox2);
        }
    }
}