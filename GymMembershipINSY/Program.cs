using GymMembershipINSY.model;
using System.ComponentModel.Design;


namespace GymMembershipINSY;

    internal class Program
    {
       private static Member members;
	private static List<WorkoutClass> workoutClasses;
	private static List<MemberWorkoutClass> memberWorkoutClass;
	private static Member authenticatedUser;
//once someone logs in they can be in there
//by initializing all of these it allows me to use them 
//static because we do not want to create objects out of it

private static Member members;	    
Static void Main(string[] args) 
    {

    Console.WriteLine(“Loading…”);
    Initializing();//this is the creation and initialization of all the objects
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

        Var mwc1 = new MemberWorkoutClass (m1, w1);


        members = new Member();
        members.members.Add(m1);
//now an abject of the member class, at any point i can see how many members I have 

        workoutClasses = new List<WorkoutClass>();
        workoutClasses.Add(w1);

        memberWorkoutClasses = new List<MemberWorkoutClass>();
        memberWorkoutClasses.Add(mwc1);
}

static void Menu()
{
//we want to code this menu by creating an infinite event loop
        bool done = false;
//this means the program is not done, once i say done it is done
    while(!done)
	{
		console.writeline(“Options: Login: 1— SihnUp: 2— Logout: 3— WorkoutClass: 4— Quit: q”);
		console.write(“Choice: “);
		String choice = Console.ReadLine();

		    switch(choice)
		    {  
		    case “1”;
			LoginMenu();
           		 break;
			//if its 1 then 
		    case “2”;
			SignUpMenu();
			break;
		    case “3”
			LogoutMenu();
			break;
		    case “4”
			WorkoutClassMenu;
			break;
		    case “q”
			Done = true;
			break;
		    default:
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
            string username = Console.ReadLine();
            Console.Write(“Enter password: “);
            string password = Console.ReadLine();
            authenticatedMember = members.Authenticate(username, password);
	   if(authenticatedMember !=null)
                {
               	 Console.WriteLine($”Welcome {authenticatedMember.FirstName}”);
                }

                Else 
                {
               	 Console.WriteLine(“Invalid username or password.”)
            //never say if the username or password is specifically wrong,
	 // lets people get hacked faster, this just tells user either one is wrong without specification
          	  }
		    
                Else 
                {
	Console.Writeline($”You are already logged in as {authenticatedMember.UserName};
                }
           }
                      

        Static void LogoutMenu()
    {
    authenticatedMember =  null;
    Console.WriteLine(“Logged out!”);
    }

    static void SignUpMenu()
    {
    	Console.Write(“First name: “);
        string firstname = Console.ReadLine();
    	Console.Write(“Last name: “);
        string lastname = Console.ReadLine();
    	Console.Write(“username: “);
        string username= Console.ReadLine();
    	Console.Write(“password: “);
        string password = Console.ReadLine();


        var newMember = new Member
     {
	FirstName = firstname,
   	 LastName = lastname,
   	 UserName = username,
   	 Password = password
    };
	    
    members.members.Add(newMember);
	    
    Console.WriteLine(“Profile created!”);
	    
    }


    static void WorkoutClassMenu()
    {
    //im gonna search and view results
    //i wanna show workout classes for current user
        if(authenticatedUser == null)
        {
       		 Console.WriteLine(“You are not logged in”);
       		 Console.WriteLine(“You need to log in before viewing your workout classes. “);
       		 return;
        //return means we are done with this method, basically like else
        }
        
var memberworkoutwlass = memberWorkoutClass.Where( o => o.members.UserName == authenticatedMember.UserName); 
        //within the list of members and workout classes, it finds the specific app for the user
        
  if(memberWorkoutClass.Count() == 0)
  {
	Console.WriteLine(“0 workout classes scheduled.”);
  }
        
 else
 {
	foreach(var memberworkoutclasses in memberWorkoutClasses)
	 {
		Console.WriteLine(memberWorkoutClasses.workoutClass.date);
	}

}
}


