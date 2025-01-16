namespace NotepadLogic
{
    public class FindNextResult
    {
        bool _SearchStatus;
        int _SelectionStart;

        public bool SearchStatus 
        {
            get { return _SearchStatus; }
            set { _SearchStatus = value; } 
        }
        public int SelectionStart 
        {
            get { return _SelectionStart; }
            set { _SelectionStart = value; }
        }
    }
}
