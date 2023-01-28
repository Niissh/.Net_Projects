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
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            this.Text = "Untitled-Notepad";
            rtext.WordWrap = false;
            statusDate.Text = DateTime.Now.ToLongDateString();
            statusTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusDate.Text = DateTime.Now.ToLongDateString();
            statusTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void opennFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";
            ofd.DefaultExt = "txt";
            ofd.FilterIndex = 1;
            try
            {
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    if (ofd.FilterIndex == 1) rtext.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    if (ofd.FilterIndex == 2) rtext.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    this.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            rtext.Text = "";
            this.Text = "Untitled - Notepad";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitIcon_Click(sender,e);   
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show("Do you want to close it?", "Exit", MessageBoxButtons.YesNo);
           if (dr == DialogResult.Yes)
               this.Close();
        }

        private void colorIcon_Click(object sender, EventArgs e)
        {
            clrd.ShowDialog();
            rtext.SelectionColor = clrd.Color;
        }
        private void fontIcon_Click(object sender, EventArgs e)
        {
            ft_d.ShowDialog();
            rtext.SelectionFont = ft_d.Font;
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (ofd.FileName != "")
                rtext.SaveFile(ofd.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveAsFile_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
            if (sfd.FileName != "") {
                rtext.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtext.Cut();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtext.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtext.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtext.SelectedText = "";
        }

        private void openIcon_Click(object sender, EventArgs e)
        {
            
        }

        private void leftIcon_Click(object sender, EventArgs e)
        {
            rtext.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centereIcon_Click(object sender, EventArgs e)
        {
            rtext.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightIcon_Click(object sender, EventArgs e)
        {
            rtext.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtext.WordWrap = !rtext.WordWrap;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtext.CanUndo)
                rtext.Undo();
        }

        private void statusBarItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = !statusStrip.Visible;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtext.ZoomFactor <= 62)
                rtext.ZoomFactor += (float)1.1;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtext.ZoomFactor >= 1.2)
                rtext.ZoomFactor -= (float)1.1;
        }

        private void zoomResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtext.ZoomFactor = 1;
        }
    }
}
