using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Member : IMember
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAceRewardsMember { get; set; }
        public DateTime MemberAction { get; set; }
        public string Notice { get; set; }
        public List<string> History { get; set; }
    }
}
