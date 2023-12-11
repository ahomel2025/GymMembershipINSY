using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipINSY.model;

public class Members //class for members
    {
        public List<Member> members { get; set; } //get and setter method for a list of members

        public Members() //property to create list for members 
        {
            members = new List<Member>(); //creation of new list
        }

        public Member Authenticate(string username, string password) //creation of string username and string password
        {
            var m = members.Where(o => (o.Username == username) && (o.Password == password)); //variable to label what username and password mean

            if(m.Count() > 0) //if statement to return members first name if given a member
            {
                return m.First(); //returning first name
            }
            else //else statement
            {
                return null; //return null if no amount of members is given
            }
        }
    }
