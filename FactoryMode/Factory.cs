using CreationModeCommon;
using CreationModeCommon.Enums;
using System;

namespace FactoryMode
{

    public static class RoleFactory
    {
        public static Role CreatorRole(RoleType type)
        {
            Role role = null;

            switch (type)
            {
                case RoleType.User:
                    role = new User();
                    break;
                case RoleType.Adminitrator:
                    role = new Adminitrator();
                    break;
            }
            return role;
        }

    }
}
