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

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}