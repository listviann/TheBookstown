namespace TheBookstown.Areas.Admin.Models
{
    public class GenresFilterViewModel
    {
        public string SelectedName { get; }

        public GenresFilterViewModel(string name)
        {
            SelectedName = name;
        }
    }
}
