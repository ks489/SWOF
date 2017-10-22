using SWOF.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWOF.Service.TempDatabase
{
    public static class ScheduleDatabase
    {
        public static class ScheduleTable
        {
            
            public static List<Schedule> table = new List<Schedule>()
            {
                                
                new Schedule() { Date = DateTime.Parse("01/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[0], ShiftTable.table[1]) },
                new Schedule() { Date = DateTime.Parse("02/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[2], ShiftTable.table[3]) },
                new Schedule() { Date = DateTime.Parse("03/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[4], ShiftTable.table[5]) },
                new Schedule() { Date = DateTime.Parse("04/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[6], ShiftTable.table[7]) },
                new Schedule() { Date = DateTime.Parse("05/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[8], ShiftTable.table[9]) },
                new Schedule() { Date = DateTime.Parse("08/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[10], ShiftTable.table[11]) },
                new Schedule() { Date = DateTime.Parse("09/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[12], ShiftTable.table[13]) },
                new Schedule() { Date = DateTime.Parse("10/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[14], ShiftTable.table[15]) },
                new Schedule() { Date = DateTime.Parse("11/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[16], ShiftTable.table[17]) },
                new Schedule() { Date = DateTime.Parse("12/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[18], ShiftTable.table[19]) },
                new Schedule() { Date = DateTime.Parse("15/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[20], ShiftTable.table[21]) },
                new Schedule() { Date = DateTime.Parse("16/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[22], ShiftTable.table[23]) },
                new Schedule() { Date = DateTime.Parse("17/01/2017"), Shifts = new Tuple<Shift, Shift>(ShiftTable.table[24], ShiftTable.table[25]) }
            };
            
        }

        public static class ShiftTable
        {
            public static List<Shift> table = new List<Shift>()
            {
                //Week 1
                new Shift(){ ID = 1, StartTime = DateTime.Parse("01/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[0], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 2, StartTime = DateTime.Parse("01/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[1], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 3, StartTime = DateTime.Parse("02/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[2], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 4, StartTime = DateTime.Parse("02/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[3], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 5, StartTime = DateTime.Parse("03/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[4], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 6, StartTime = DateTime.Parse("03/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[5], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 7, StartTime = DateTime.Parse("04/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[6], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 8, StartTime = DateTime.Parse("04/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[7], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 9, StartTime = DateTime.Parse("05/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[8], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 10, StartTime = DateTime.Parse("05/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[9], TypeOfShift = Enums.ShiftType.Afternoon},
                //Week 2
                new Shift(){ ID = 11, StartTime = DateTime.Parse("08/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[0], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 12, StartTime = DateTime.Parse("08/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[1], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 13, StartTime = DateTime.Parse("09/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[2], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 14, StartTime = DateTime.Parse("09/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[3], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 15, StartTime = DateTime.Parse("10/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[4], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 16, StartTime = DateTime.Parse("10/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[5], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 17, StartTime = DateTime.Parse("11/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[6], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 18, StartTime = DateTime.Parse("11/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[7], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 19, StartTime = DateTime.Parse("12/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[8], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 20, StartTime = DateTime.Parse("12/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[9], TypeOfShift = Enums.ShiftType.Afternoon},

                //Week 3
                new Shift(){ ID = 21, StartTime = DateTime.Parse("15/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[0], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 22, StartTime = DateTime.Parse("15/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[1], TypeOfShift = Enums.ShiftType.Afternoon},                
                new Shift(){ ID = 23, StartTime = DateTime.Parse("16/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[2], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 24, StartTime = DateTime.Parse("16/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[3], TypeOfShift = Enums.ShiftType.Afternoon},
                new Shift(){ ID = 25, StartTime = DateTime.Parse("17/01/2017 08:00:00"), EndTime = DateTime.Parse("01/01/2017 13:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[4], TypeOfShift = Enums.ShiftType.Morning},
                new Shift(){ ID = 26, StartTime = DateTime.Parse("17/01/2017 13:00:00"), EndTime = DateTime.Parse("01/01/2017 18:00:00"), AssignedEngineer = UsersDatabase.UserTable.table[5], TypeOfShift = Enums.ShiftType.Afternoon}
            };
        }
    }
}
