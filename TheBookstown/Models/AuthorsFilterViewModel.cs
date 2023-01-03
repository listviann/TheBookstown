namespace TheBookstown.Models
{
    public class AuthorsFilterViewModel
    {
        public string SelectedName { get; }

        public AuthorsFilterViewModel(string selectedName)
        {
            SelectedName = selectedName;
        }
    }
}
