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

        //Open File feature of Menu Strip
        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".txt")
                {
                    rtbTextArea.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
                {
                    rtbTextArea.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text = Path.GetFileName(openFileDialog1.FileName) + " - Notepad Pro++";
            }
        }

        //Save As feature of Menu Strip
        private void saveAsFileMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if(Path.GetExtension(saveFileDialog1.FileName)==".txt")
                {
                    rtbTextArea.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else if(Path.GetExtension(saveFileDialog1.FileName)==".rtf")
                {
                    rtbTextArea.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text= Path.GetFileName(saveFileDialog1.FileName)+" - Notepad Pro++";
            }
        }
    }
}
