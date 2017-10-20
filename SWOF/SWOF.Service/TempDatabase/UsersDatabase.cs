using SWOF.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.TempDatabase
{
    public static class UsersDatabase
    {
        public static class UserTable
        {
            public static List<Engineer> table = new List<Engineer>()
            {
                new Engineer(){ Id = 1, FirstName = "Peter1", Surname = "Smith1" },
                new Engineer(){ Id = 2, FirstName = "Peter2", Surname = "Smith2" },
                new Engineer(){ Id = 3, FirstName = "Peter3", Surname = "Smith3" },
                new Engineer(){ Id = 4, FirstName = "Peter4", Surname = "Smith4" },
                new Engineer(){ Id = 5, FirstName = "Peter5", Surname = "Smith5" },
                new Engineer(){ Id = 6, FirstName = "Peter6", Surname = "Smith6" },
                new Engineer(){ Id = 7, FirstName = "Peter7", Surname = "Smith7" },
                new Engineer(){ Id = 8, FirstName = "Peter8", Surname = "Smith8" },
                new Engineer(){ Id = 9, FirstName = "Peter9", Surname = "Smith9" },
                new Engineer(){ Id = 10, FirstName = "Peter10", Surname = "Smith10" }
            };
        }
    }
}
