namespace TheBookstown.Areas.Admin.Models
{
    public enum UsersSortState
    {
        UserNameAsc,
        UserNameDesc,
    }
    
    public class UsersSortViewModel
    {
        public UsersSortState UserNameSort { get; }
        public UsersSortState Current { get; }

        public UsersSortViewModel(UsersSortState sortOrder)
        {
            UserNameSort = sortOrder == UsersSortState.UserNameAsc ? UsersSortState.UserNameDesc : UsersSortState.UserNameAsc;
            Current = sortOrder;
        }
    }
}
