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
        }

        public int Saved
        {
            get { return _Saved; }
            set
            {
                _Saved = value;
                switch (_Saved)
                {
                    case 0:
                        this.Text = "Scriptura (unsaved)";
                        break;
                    case 1:
                        this.Text = "Scriptura";
                        break;
                }
            }
        }

        private int _Saved;

        private String dirPath
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
            bookmarksToolStripMenuItem.ForeColor = Color.White;

            toolsToolStripMenuItem.ForeColor = Color.White;
            fontToolStripMenuItem.ForeColor = Color.White;
            colorToolStripMenuItem.ForeColor = Color.White;
            linkToolStripMenuItem.ForeColor = Color.White;

            projectToolStripMenuItem.ForeColor = Color.White;
            buildToolStripMenuItem.ForeColor = Color.White;
            synthesizeToolStripMenuItem.ForeColor = Color.White;
            decryptToolStripMenuItem.ForeColor = Color.White;

            helpToolStripMenuItem.ForeColor = Color.White;
            gettingStartedToolStripMenuItem.ForeColor = Color.White;
            tipsAndTricksToolStripMenuItem.ForeColor = Color.White;
            documentationToolStripMenuItem.ForeColor = Color.White;
            aboutScripturaToolStripMenuItem.ForeColor = Color.White;
            gitHubToolStripMenuItem.ForeColor = Color.White;
        }

        // exports text to file and saves acc
        private void exportTypeSave()
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

        // attempt at saving to existing file pathing, otherwise will assume non-existent
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

        private void saveWarn()
        {
            Save savePopup = new Save();
            DialogResult result = savePopup.ShowDialog();
            if (result == DialogResult.Yes)
            {
                baseTypeSave();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved == 0)
            {
                saveWarn();
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
                saveWarn();
            }
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved == 0)
            {
                saveWarn();
            }
            exportTypeSave();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baseTypeSave();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}