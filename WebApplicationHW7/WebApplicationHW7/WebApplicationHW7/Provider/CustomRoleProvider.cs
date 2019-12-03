﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebApplicationHW7.DataAccess;
using WebApplicationHW7.Models;

namespace WebApplicationHW7.Provider
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            string[] roles = new string[] { };
            using (UserContext context = new UserContext())
            {
                User user = context.Users.FirstOrDefault(x => x.Email == username);
                if (user != null)
                {
                    Role userRole = context.Roles.Find(user.RoleId);
                    if (userRole != null)
                    {
                        roles = new string[] { user.RoleName.Name };
                    }
                }
                return roles;
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            bool outputContext = false;

            using (UserContext context = new UserContext())
            {
                User user = context.Users.FirstOrDefault(x => x.Email == username);

                if (user != null)
                {
                    Role userRole = context.Roles.Find(user.RoleId);
                    if (userRole != null && userRole.Name == roleName)
                    {
                        outputContext = true;
                    }
                }
                return outputContext;
            }
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}