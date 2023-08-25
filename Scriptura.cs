using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Diagnostics;

namespace Scriptura
{
    public partial class Scriptura : Form
    {
        public Scriptura()
        {
            InitializeComponent();
            menuStrip.Renderer = new SxRenderer(Color.FromArgb(30, 30, 30));
            Saved = 1;
            dirPath = "";
            FormClosing += ClosingVerify;
        }

        public int Saved
        {
            get { return _Saved; }
            set
            {
                _Saved = value;
                switch (value)
                {
                    case 0:
                        this.Text = "Scriptura*";
                        break;
                    case 1:
                        this.Text = "Scriptura";
                        break;
                }
            }
        }

        private int _Saved;

        private string dirPath
        {
            get; set;
        }

        private void Scriptura_Load(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.White;
            newToolStripMenuItem.ForeColor = Color.White;
            openToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.ForeColor = Color.White;
            exportToolStripMenuItem.ForeColor = Color.White;
            printToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.ForeColor = Color.White;

            editToolStripMenuItem.ForeColor = Color.White;
            undoToolStripMenuItem.ForeColor = Color.White;
            redoToolStripMenuItem.ForeColor = Color.White;
            cutToolStripMenuItem.ForeColor = Color.White;
            copyToolStripMenuItem.ForeColor = Color.White;
            pasteToolStripMenuItem.ForeColor = Color.White;
            selectAllToolStripMenuItem.ForeColor = Color.White;

            toolsToolStripMenuItem.ForeColor = Color.White;
            fontToolStripMenuItem.ForeColor = Color.White;
            colorToolStripMenuItem.ForeColor = Color.White;
            linkToolStripMenuItem.ForeColor = Color.White;

            helpToolStripMenuItem.ForeColor = Color.White;
            gettingStartedToolStripMenuItem.ForeColor = Color.White;
            tipsAndTricksToolStripMenuItem.ForeColor = Color.White;
            documentationToolStripMenuItem.ForeColor = Color.White;
            aboutScripturaToolStripMenuItem.ForeColor = Color.White;
            gitHubToolStripMenuItem.ForeColor = Color.White;
        }

        private void ClosingVerify(object sender, FormClosingEventArgs e)
        {
            bool result = true;
            if (Saved == 0) 
                result = saveWarn();
            if (!result) e.Cancel = true;
        }

        private void openFile()
        {
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pad.Text = File.ReadAllText(openFileDialog.FileName);
                dirPath = Path.GetFullPath(openFileDialog.FileName);
                Saved = 1;
            }
        }

        private void exportTypeSave()
        {
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Generic Text File|*.txt|PDF File|*.pdf|Config File|*.json";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, Pad.Text);
                Saved = 1;
            }
        }

        private void baseTypeSave()
        {
            if (!dirPath.Equals(""))
            {
                File.WriteAllText(dirPath, Pad.Text);
                Saved = 1;
            }
            else
            {
                exportTypeSave();
            }
        }

        private bool saveWarn()
        {
            Save savePopup = new Save();
            DialogResult result = savePopup.ShowDialog();
            if (result == DialogResult.Yes)
            {
                baseTypeSave();
            }
            if (result == DialogResult.Cancel)
            {
                return false;
            }
            return true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved == 0)
            {
                bool result = saveWarn();
                if (!result) return;
            }
            Pad.Clear();
            Saved = 1;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved == 0)
            {
                bool result = saveWarn();
                if (!result) return;
            }
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved == 0)
            {
                bool result = saveWarn();
                if (!result) return;
            }
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baseTypeSave();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportTypeSave();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pad.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pad.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pad.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pad.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pad.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pad.SelectAll();
        }

        private void Pad_TextChanged(object sender, EventArgs e)
        {
            Saved = 0;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                Pad.Font = fontDialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                Pad.ForeColor = colorDialog.Color;
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo githubLink = new ProcessStartInfo
            {
                FileName = "https://github.com/nickmxrino/Scriptura",
                UseShellExecute = true
            };
            Process.Start(githubLink);
        }
    }
}