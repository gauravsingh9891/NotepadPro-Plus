namespace NotepadPro__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// Help Menu Strip
        //About Notepad Pro++ of Help Menu
        private void aboutNotepadMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fb = new Form2();
            fb.ShowDialog();
        }


        /// File Menu Strip <summary>
        //New File feature of Menu Strip
        private void newFileMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextArea.Clear();
        }

        //Exit Application feature of Menu Strip
        private void exitFileMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
