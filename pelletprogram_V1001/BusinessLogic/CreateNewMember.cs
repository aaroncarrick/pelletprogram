using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CreateNewMember
    {
        IMember Aaron = Factory.NewMember();
        public List<string> MyList = Factory.NewStringList();
        
        public void MakeAaron()
        {
            Aaron.FirstName = "Aaron";
            Aaron.LastName = "Carrick";
            Aaron.IsAceRewardsMember = false;
            Aaron.PhoneNumber = "6198573827";
            Aaron.History = Factory.NewStringList();
            Aaron.History.Add("Member Created");
            MyList.Add(Aaron.FirstName);
            MyList.Add(Aaron.LastName);
            MyList.Add(Aaron.PhoneNumber);
            MyList.Add("-----HISTORY BELOW-----");
            foreach (var item in Aaron.History)
            {
                MyList.Add(item);
            }
            MyList.Add("-----END HISTORY-----");
        }
    }
}
