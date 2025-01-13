namespace NotepadPro__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// Help Menu <summary>

        //About Notepad Pro++ of Help Menu
        private void aboutNotepadMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fb=new Form2 ();  
            fb.ShowDialog();
        }


    }
}
