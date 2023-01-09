namespace TheBookstown.Areas.Admin.Models
{
    public class PTFFilterViewModel
    {
        public string SelectedTitle { get; }
        public string SelectedCodeWord { get; }

        public PTFFilterViewModel(string name, string codeWord)
        {
            SelectedTitle = name;
            SelectedCodeWord = codeWord;
        }
    }
}
