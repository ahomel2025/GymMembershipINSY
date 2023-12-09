using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipINSY.Workout_class
{
    public class WorkoutClasses
    {
       private static int autoIncrement;
        public int Id { get; set; }
        public DateTime date { get; set; }
        
        public WorkoutClasses()
        {
            autoIncrement++;
            Id = autoIncrement;
        }
         
    }
}
