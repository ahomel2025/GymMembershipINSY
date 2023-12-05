using System;

namespace GymMembershipINSY.model;  
    internal class GymMembership  
    {
  
     public string MemberName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public string MembershipType { get; set; }

       

        public GymMembership(string name, DateTime startDate, DateTime endDate, string membershipType)
        {
            MemberName = name;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = true;
            MembershipType = membershipType;
        }

        public void RenewMembership(int months)
        {
            EndDate = EndDate.AddMonths(months);
            IsActive = true;
            Console.WriteLine($"{MemberName}'s {MembershipType} membership has been renewed until {EndDate.ToShortDateString()}");
        }

        public void CheckMembershipStatus()
        {
            if (IsActive)
            {
                Console.WriteLine($"{MemberName}'s {MembershipType} membership is active until {EndDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"{MemberName}'s {MembershipType} membership has expired");
            }
        }
    }

