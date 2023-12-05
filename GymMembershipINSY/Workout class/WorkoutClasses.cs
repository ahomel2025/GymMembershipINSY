using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipINSY.Workout_class
{
    internal class WorkoutClasses
    {
        Gym gym = new Gym(); //creating new gym

        Gym.CreateMembership("John Doe", DateTime.Now, DateTime.Now.AddMonths(6), "Standard"); //creating membership for john doe for 6 months and standard
        gym.CreateMembership("Jane Smith", DateTime.Now, DateTime.Now.AddMonths(3), "Premium"); //creating memberhsip for Jane smith now for 3 months and premium

        gym.CheckMembershipStatus("John Doe"); //checking status of john does membership
        gym.CheckMembershipStatus("Jane Smith"); //checking status of jane smitch membership

        gym.RenewMembership("John Doe", 3); //renewing john doe membership for 3 months
        gym.CheckMembershipStatus("John Doe"); //checking john does status

        gym.AddTrainer("Mike", "Weightlifting"); //adding trainer Mike who does weighlifting
        gym.AddTrainer("Sarah", "Yoga"); //adding trainer sarah who teaches yoga

        gym.DisplayTrainers(); //displays trainers
    }
}
