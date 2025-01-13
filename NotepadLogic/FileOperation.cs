namespace NotepadLogic
{
    public class FileOperation
    {
        private string _filename;
        private bool _isFileSaved;
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public bool IsFileSaved
        {
            get { return _isFileSaved; }
            set { _isFileSaved = value; }
        }

        public void InitializeNewFile()
        {
            this.Filename = "Untitled.txt";
            this.IsFileSaved = true;
        }
    }
}
