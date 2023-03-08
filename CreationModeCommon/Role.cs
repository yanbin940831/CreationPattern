using CreationModeCommon.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationModeCommon
{
    public abstract class Role : IRole
    {
        public Role(RoleType type)
        {
            UserType = type;
        }
        public RoleType UserType { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public abstract bool Login();
        public abstract void Say(string word);

        protected void ConslseType()
        {
            Console.WriteLine($"我是{UserType.ToString()}");
        }
    }
}
