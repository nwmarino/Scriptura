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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // verify saved
            Pad.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pad.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Generic Text File|*.txt|PDF File|*.pdf|Config File|*.json";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, Pad.Text);
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
    }
}