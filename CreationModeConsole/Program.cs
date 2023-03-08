// See https://aka.ms/new-console-template for more information

using CreationModeCommon;
using CreationModeCommon.Enums;
using FactoryMode;

Role role1 = RoleFactory.CreatorRole(RoleType.User);

Role role2 = RoleFactory.CreatorRole(RoleType.Adminitrator);

role1.Say("Hello!");
role2.Say("Hello!");

