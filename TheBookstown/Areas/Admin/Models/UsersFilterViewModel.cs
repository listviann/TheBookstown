namespace TheBookstown.Areas.Admin.Models
{
    public class UsersFilterViewModel
    {
        public string SelectedUserName { get; }

        public UsersFilterViewModel(string selectedUserName)
        {
            SelectedUserName = selectedUserName;
        }
    }
}
