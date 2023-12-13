using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipINSY.Trainer
{
    internal class Trainer
    {
        public string TrainerName { get; set; }//grabs the trainer name 
        public string Category { get; set; }//grabs the category the trainer teaches workout classes in 

        public Trainer(string name, string category)//this is the constructor
        {
            TrainerName = name;
            Category = category;

        }

        public void DisplayDetails()//the result of this tells you the trainers name and category 
        {
            Console.WriteLine($"Trainer: {TrainerName}, Category: {Category}");

        }


    }
}
