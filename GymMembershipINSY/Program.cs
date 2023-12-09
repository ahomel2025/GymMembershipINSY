using GymMembershipINSY.model;
using System.ComponentModel.Design;


namespace GymMembershipINSY;

    internal class Program
    {
        static void Main(string[] args)
        {


        Console.WriteLine("Loading...");
        Initialize();
        Menu();


    }


    static void Initialize()
    {
        Gym A = new Gym();
        
        object a = Gym.CreateMembership("Adam", DateTime.Now, DateTime.Now.AddMonths(12), "Gold");

        
        
        }

    static void Menu()
    {

    }
}
