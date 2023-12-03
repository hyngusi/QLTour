using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTour
{
    class User_BLL
    {
        User_DAL dalUser;
        public User_BLL()
        {
            dalUser = new User_DAL();
        }

        public string PhQuyen(tbl_User user)
        {
            return dalUser.PhQuyen(user);
        }
    }
}
