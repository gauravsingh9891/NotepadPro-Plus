namespace NotepadPro__
{
    public partial class Form1 : Form
    {
        private bool IsFileAlreadySaved;
        private bool IsFileModified;
        private string CurrOpenFileName;
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
            if (IsFileModified)
            {
                DialogResult dr=MessageBox.Show("Do you want to save this file ?","File Save",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);   
                switch(dr)
                    {
                        case DialogResult.Yes: SaveFileMenu();
                            ClearScreen();
                            break;
                        case DialogResult.No: ClearScreen();
                            break;
                    } 
                
            }
            ClearScreen();
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

                IsFileAlreadySaved = true;
                IsFileModified = false;
                CurrOpenFileName = openFileDialog1.FileName;
            }
        }

        //Save As feature of Menu Strip
        private void saveAsFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFileMenu();
        }

        private void SaveAsFileMenu()
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog1.FileName) == ".txt")
                {
                    rtbTextArea.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (Path.GetExtension(saveFileDialog1.FileName) == ".rtf")
                {
                    rtbTextArea.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text = Path.GetFileName(saveFileDialog1.FileName) + " - Notepad Pro++";
                IsFileAlreadySaved = true;
                IsFileModified = false;
                CurrOpenFileName = saveFileDialog1.FileName;
            }
        }

        //Save feature of Menu Strip
        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileMenu();
        }

        private void SaveFileMenu()
        {
            if (IsFileAlreadySaved)
            {
                if (Path.GetExtension(CurrOpenFileName) == ".txt")
                {
                    rtbTextArea.SaveFile(CurrOpenFileName, RichTextBoxStreamType.PlainText);
                }
                else if (Path.GetExtension(CurrOpenFileName) == ".rtf")
                {
                    rtbTextArea.SaveFile(CurrOpenFileName, RichTextBoxStreamType.RichText);
                }
                IsFileModified = false;
                this.Text = Path.GetFileName(CurrOpenFileName) + " - Notepad Pro++";
            }
            else
            {
                if (IsFileModified)
                {
                    SaveAsFileMenu();
                }
                else
                {
                    ClearScreen();
                }
            }
        }

        private void ClearScreen()
        {
            rtbTextArea.Clear();
            this.Text = "Untitled - Notepad Pro++";
            IsFileModified = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsFileAlreadySaved = false;
            IsFileModified = false;
            CurrOpenFileName = "Untitled";
            this.Text = CurrOpenFileName + " - Notepad Pro++";
        }

        //Implementing: TextArea Text Changed Event 
        private void rtbTextArea_TextChanged(object sender, EventArgs e)
        {
            IsFileModified = true;
            //if (CurrOpenFileName != Path.GetFileName(CurrOpenFileName))
            //    CurrOpenFileName = Path.GetFileName(CurrOpenFileName);
            //this.Text = "*" + CurrOpenFileName + "- Notepad Pro++";
        }
    }
}
