using GymMembershipINSY.model;
using System.ComponentModel.Design;


namespace GymMembershipINSY;

    internal class Program
    {
       Private static Members members;
	Private static List<WorkoutClass> workoutClasses;
	Private static List<MemberWorkoutClass> memberWorkoutClass;
	Private static Member authenticatedUser;
//once someone logs in they can be in there
//by initializing all of these it allows me to use them 
//static because we do not want to create objects out of it


Static void Main(string[] args) 
    {

    Console.WriteLine(“Loading…”);
    Initializing();
    Menu();
    }

Static void Initialize()
    { 
    Var m1 = new Member
        {
        FirstName = “Brian”,
        LastName = “Gertsberg”,
        UserName =”brbri123”,
        Password = "gertsy456"
        };
        Var w1 = new WorkoutClass();
        Var w2 = new WorkoutClass();
        Var w3 = new WorkoutClass();

        Var mwc1 = new MemberWorkoutClass (m1, w1);
        Var mwc2 = new MemberWorkoutClass (m2, w2);



        Members = new Members();
        member.members.Add(m1);
        member.memberss.Add(m2);
//now an abject of the member class, at any point i can see how many members I have 

        workoutClasses = new List<WorkoutClass>();
        workoutClasses.Add(w1);
        workoutClasses.Add(w2);
        workoutClassess.Add(w3);

        memberWorkoutClasses = new List<MemberWorkoutClass>();
        memberWorkoutClassses.Add(mwc1);
        memberWorkoutClasses.Add(mwc20;
}

Static void Menu()
{
//we want to code this menu by creating an infinite event loop
        bool done = false;
//this means the program is not done, once i say done it is done
    while(!done)
	{
		console.writeline(“Options: Login: 1— SihnUp: 2— Logout: 3— WorkoutClass: 4— Quit: q”);
		console.write(“choice: “);
		String choice = Console.ReadLine();

		    switch(choice)
		    {  
		    Case “1”;
			LoginMenu();
            break;
			//if its 1 then 
		    Case “2”;
			SignUpMenu();
			break;
		    Case “3”
			LogoutMenu();
			break;
		    Case “4”
			WorkoutClassMenu;
			break;
		    Case “q”
			Done = true;
			break;
		    Default:
		    Console.Writeline("Invalid command!");
            break;
                    
		    }
	
   
        }
    
}
                                 
                                 
        Static void LoginMenu()
        {
    
            if(authentiactedMember == null)
            {
            Console.Write(“Enter username: “);
            String username = Console.ReadLine();
            Console.Write(“Enter password: “);
            String password = Console.ReadLine();
            authenticatedMember = members.Authenticate(username, password);

                if(authenticatedMember !=null)
                {
                Console.WriteLine($”Welcome {authenticatedMember.FirstName}”);
                }

                Else 
                {
                Console.WriteLine(“Invalid username or password.”)
            //never say if the username or password is specifically wrong, lets people get hacked faster 

            }
                Else 
                {
	Console.Writeline($”You are already logged in as {authenticatedMember.UserName};
                }
           }


                      

        Static void LogoutMenu()
    {
    authenticatedMember =  null;
    Console.WriteLine(“Logged out.”);
    }

    Static void SignUpMenu()
    {
    	Console.Write(“First name: “);
        String firstname = Console.ReadLine();
    	Console.Write(“Last name: “);
        String lastname = Console.ReadLine();
    	Console.Write(“username: “);
        String username= Console.ReadLine();
    	Console.Write(“password: “);
        String password = Console.ReadLine();


        Var newCustomer = new Customer
     {
	FirstName = firstname,
    LastName = lastname,
    UserName = username,
    Password = password
    };
    member.members.Add(newMember);
    Console.WriteLine(“Profile created”);
    }



    Static void WorkoutClassMenu()
    {
    //im gonna search and view results
    //i wanna show workout classes for current user

        
        if(authenticatedUser == null)
        {
        Console.WriteLine(“You are not logged in”);
        Console.WriteLine(“You need to log in before viewing your workout classes. “);
        Return;
        //return means we are done with this method, basically like else
        }
        
        Var memberworkoutwlass = memberWorkoutClass.Where( o => o.member.UserName == authenticatedMember.UserName); 
        //within the list of members and workout classes, it finds the specific app for the user
        
	    if(memberWorkoutClass.Count() == 0)
	    {
	    Console.WriteLine(“You don’t have any workout classes scheduled.”);

	    }
        
        Else
        {
	foreach(var memberworkoutclasses in memberWorkoutClasses)
		{
			Console.WriteLine(memberWorkoutClasses.workoutClass.);
		}

}
}

}
