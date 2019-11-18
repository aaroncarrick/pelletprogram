using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Factory
    {
        public static IMember NewMember()
        {
            return new Member();
        }

        public static List<string> NewStringList()
        {
            return new List<string>();
        }

        public static CreateNewMember MakeMember()
        {
            return new CreateNewMember();
        }
    }
}
