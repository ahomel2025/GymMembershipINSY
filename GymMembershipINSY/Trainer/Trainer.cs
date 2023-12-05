using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipINSY.Trainer
{
    internal class Trainer
    {
        public string TrainerName { get; set; }
        public string Category { get; set; }

        public Trainer(string name, string category)
        {
            TrainerName = name;
            Category = category;

        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Trainer: {TrainerName}, Category: {Category}");

        }


    }
}
