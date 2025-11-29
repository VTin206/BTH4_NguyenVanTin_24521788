using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        string currentfilepath = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }

            toolStripComboBox1.ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripComboBox1.ComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontname = toolStripComboBox1.SelectedItem.ToString();
            Font current;
            if (richTextBox1.SelectionFont != null)
            {
                current = richTextBox1.SelectionFont;
            }
            else
            {
                current = richTextBox1.Font;
            }
            richTextBox1.SelectionFont = new Font(fontname, current.Size, current.Style);
        }
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = float.Parse(toolStripComboBox2.SelectedItem.ToString());
            Font current;
            if(richTextBox1.SelectionFont != null)
            {
                current = richTextBox1.SelectionFont;
            }
            else
            {
                current = richTextBox1.Font;
            }
            richTextBox1.SelectionFont = new Font(current.FontFamily, size, current.Style);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0) return;
            int start = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;
            for(int i = 0; i < length; i++)
            {
                richTextBox1.Select(start + i, 1);
                Font current = richTextBox1.SelectionFont;
                if(current != null)
                {
                    richTextBox1.SelectionFont = new Font(current.FontFamily, current.Size, current.Style ^ FontStyle.Bold);
                }
            }
            richTextBox1.Select(start, length);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0) return;
            int start = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;
            for (int i = 0; i < length; i++)
            {
                richTextBox1.Select(start + i, 1);
                Font current = richTextBox1.SelectionFont;
                if(current != null)
                {
                    richTextBox1.SelectionFont = new Font(current.FontFamily, current.Size, current.Style ^ FontStyle.Italic);
                }
            }
            richTextBox1.Select(start, length);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0) return;
            int start = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;
            for(int i = 0; i < length; i++)
            {
                richTextBox1.Select(start + i, 1);
                Font current = richTextBox1.SelectionFont;
                if(current != null)
                {
                    richTextBox1.SelectionFont = new Font(current.FontFamily, current.Size, current.Style ^ FontStyle.Underline);
                }
            }
            richTextBox1.Select(start, length);
        }

        private void TypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; 
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                if(openfiledialog.FileName.EndsWith(".rtf"))
                {
                    richTextBox1.LoadFile(openfiledialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.LoadFile(openfiledialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            currentfilepath = openfiledialog.FileName;
        }
        private void CreateNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentfilepath))
            {
                SaveFileDialog savedlg = new SaveFileDialog();
                savedlg.Filter = "Rich Text File(*.rtf)|*.rtf";
                if (savedlg.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(savedlg.FileName, RichTextBoxStreamType.RichText);
                    currentfilepath = savedlg.FileName;
                    MessageBox.Show("Lưu thành công!");
                }
            }
            else
            {
                richTextBox1.SaveFile(currentfilepath);
                MessageBox.Show("Lưu thành công!");
            }
        }
    }
}
