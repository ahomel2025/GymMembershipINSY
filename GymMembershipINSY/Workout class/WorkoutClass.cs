using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipINSY.Workout_class
{
    public class WorkoutClasses
    {
       private static int autoIncrement;//used to have autoincrements assigned 
        public int Id { get; set; }//this retrieves the ID for the workout class
        public DateTime date { get; set; }//this gets the specific date of the workout class
        
        public WorkoutClasses()
        {
            autoIncrement++;//this increases the increments of each new workout class
            Id = autoIncrement;//this assigns a value to each ID created 
        }
         
    }
}
