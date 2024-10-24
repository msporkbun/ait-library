﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerLocal;

namespace BusinessLogicLocal
{
    public class UserLogic
    {
        //attributes
        private UserDAO userDAO;
        private UserDS.TabUserDataTable userTable;

        public UserLogic()
        {
            userDAO = new UserDAO();
            userTable = new UserDS.TabUserDataTable();
        }

        public List<UserModel> GetListOfUsers()
        {
            List<UserModel> users = new List<UserModel>(); //build empty list first

            userTable = userDAO.GetUserDataTable(); //fill userTable from our userDAO

            //for each row in our user table...
            foreach (UserDS.TabUserRow userRow in userTable.Rows)
            {
                //conver that row to a userModel and add it to the list
                UserModel user = UserModel.Parse(userRow);
                users.Add(user);
            }

            return users; //return list of users :D
        }

        public List<UserModel> GetListOfUsersByLogin(string userName, string password)
        {
            List<UserModel> users = new List<UserModel>(); //build empty list first

            userTable = userDAO.GetUserByUserNamePassword(userName, password);

            //for each row in our user table...
            foreach (UserDS.TabUserRow userRow in userTable.Rows)
            {
                //conver that row to a userModel and add it to the list
                UserModel user = UserModel.Parse(userRow);
                users.Add(user);
            }

            return users; //return list of users :D
        }

        public int AddNewUser(string username, string password, int userLevel)
        {
            return userDAO.InsertNewUser(username, password, userLevel);
        }
        public int UpdatePassword(string newPassword, int userID, int adminLevel)
        {
            //need to be an admin to change user passwords (for some reason)
            if (adminLevel < 3)
                return -1;
            else
                return userDAO.UpdatePassword(newPassword, userID);
        }
        public int DeleteUserByUserID(int userID)
        {
            return userDAO.DeleteUserByUserID(userID);
        }
    }
}
