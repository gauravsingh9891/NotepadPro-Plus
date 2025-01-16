namespace NotepadLogic
{
    public class FindSearchNext
    {
        string _SearchString;
        string _Direction;
        bool _MatchCase;
        string _Content;
        int _Position;
        bool _Success;

        public string SearchString
        {
            get { return _SearchString; }
            set { _SearchString = value; }
        }
        public string Direction
        {
            get { return _Direction; }
            set { _Direction = value; }
        }
        public bool MatchCase
        {
            get { return _MatchCase; }
            set { _MatchCase = value; }
        }
        public string Content
        {
            get { return _Content; }
            set { _Content = value; }
        }
        public int Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
        public bool Success
        {
            get { return _Success; }
            set { _Success = value; }
        }
    }
}
