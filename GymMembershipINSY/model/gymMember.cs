using System;

namespace GymMembershipINSY.model;  
    public class GymMembership  
    {

        public string MemberFirstName { get; set; } //grabs members first name
        public string MemberLastName { get; set; } //grabs members last name
        public DateTime StartDate { get; set; } //logs the start date
        public DateTime EndDate { get; set; } //logs the end date
        public bool IsActive { get; set; } //bools from membership if still valid
        public string MembershipType { get; set; } // shows if member has Blue or Gold membership status

       
        public GymMembership(string name, DateTime startDate, DateTime endDate, string membershipType)
        {
            MemberFirstName = firstName;
            MemberLastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = true; //if membership is active
            MembershipType = membershipType; //able to get into the gym
        }

        public static int autoIncrement;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }

        public GymMembership()
        {
            autoIncreament++;
            Id = autoIncreament;
        }
    
        public void RenewMembership(int months) //if membership needs to be renewed soon
        {
            EndDate = EndDate.AddMonths(months);
            IsActive = true;
            Console.WriteLine($"{MemberFirstName}'s {MembershipType} membership has been renewed until {EndDate.ToShortDateString()}"); //shows message that membership has been renewed
        }

        public void CheckMembershipStatus() //checks membership status
        {
            if (IsActive) //if status is active, it presents a message
            {
                Console.WriteLine($"{MemberFirstName}'s {MembershipType} membership is active until {EndDate.ToShortDateString()}");
            }
            else //if status is expired, it presents a different message
            {
                Console.WriteLine($"{MemberFirstName}'s {MembershipType} membership has expired");
            }
        }
    }

