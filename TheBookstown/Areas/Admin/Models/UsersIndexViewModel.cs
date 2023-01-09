using Microsoft.AspNetCore.Identity;
using TheBookstown.Models;

namespace TheBookstown.Areas.Admin.Models
{
    public class UsersIndexViewModel
    {
        public IEnumerable<IdentityUser> Users { get; }
        public PageViewModel PageViewModel { get; }
        public UsersSortViewModel SortViewModel { get; }
        public UsersFilterViewModel FilterViewModel { get; }
        
        public UsersIndexViewModel(IEnumerable<IdentityUser> users, PageViewModel pageViewModel,
            UsersSortViewModel sortViewModel, UsersFilterViewModel filterViewModel)
        {
            Users = users;
            PageViewModel = pageViewModel;
            SortViewModel = sortViewModel;
            FilterViewModel = filterViewModel;
        }
    }
}
