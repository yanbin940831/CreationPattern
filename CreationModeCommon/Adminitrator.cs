using CreationModeCommon.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationModeCommon
{
    public class Adminitrator : Role, IDisposable
    {
        public Adminitrator()
            : base(RoleType.Adminitrator)
        { }
        public override bool Login()
        {
            return true;
        }
        public override void Say(string word)
        {
            base.ConslseType();
            Console.WriteLine($"管理员：{word}");
        }

        public void Dispose()
        {

        }
    }
}
