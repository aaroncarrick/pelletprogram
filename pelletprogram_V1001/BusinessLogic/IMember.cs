using System;

namespace BusinessLogic
{
    public interface IMember
    {
        string FirstName { get; set; }
        System.Collections.Generic.List<string> History { get; set; }
        bool IsAceRewardsMember { get; set; }
        string LastName { get; set; }
        DateTime MemberAction { get; set; }
        string Notice { get; set; }
        string PhoneNumber { get; set; }
    }
}