using CreationModeCommon.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationModeCommon
{
    public class User : Role, IDisposable
    {
        public User()
            :base(RoleType.User)
        { }
        public override bool Login()
        {
            return false;
        }

        public override void Say(string word)
        {
            base.ConslseType();
            Console.WriteLine($"用户：{word}");
        }

        public void Dispose()
        {
            
        }

    }
}
