using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Attendance
    {
        public int TotalWorkingDays {get;set;}
        public int LeavesTaken {get;set;}
        public int PermissionTaken {get;set;}
        public Attendance (int totalWorkingDays,int leavesTaken,int permissionTaken)
        {
            TotalWorkingDays=totalWorkingDays;
            LeavesTaken=leavesTaken;
            PermissionTaken=permissionTaken;
        }
        public static Attendance operator+(Attendance a1,Attendance a2)
        {
            return new Attendance(a1.TotalWorkingDays+a2.TotalWorkingDays,a1.LeavesTaken+a2.LeavesTaken,a1.PermissionTaken+a2.PermissionTaken);
        }
        public int CalculateSalary()
        {
            int daysWorked=TotalWorkingDays-LeavesTaken-PermissionTaken;
            return daysWorked*500;
        }
    }
}