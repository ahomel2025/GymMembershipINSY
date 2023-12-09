using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipINSY.model;

public class Members
    {
        public List<Member> members { get; set; }

        public Members()
        {
            members = new List<Member>();
        }

        public Member Authenticate(string username, string password)
        {
            var m = members.Where(o => (o.Username == username) && (o.Password == password));

            if(m.Count() > 0)
            {
                return m.First();
            }
            else
            {
                return null;
            }
        }
    }
