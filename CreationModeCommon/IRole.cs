using CreationModeCommon.Enums;
using System;

namespace CreationModeCommon
{
    public interface IRole
    {
        RoleType UserType { get;}

        string UserName { get; set; }
        string Password { get; set; }

        bool Login();

        void Say(string word);
    }
}
