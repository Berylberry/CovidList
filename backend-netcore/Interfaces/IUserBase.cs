using System;
using System.Collections.Generic;
using System.Linq;
using backend_netcore.Entities;

namespace backend_netcore.Interfaces
{
    /*
    the interface which defines the user service which is responsible for all database interaction and core business 
    logic related to user authentication, registration and management
    */
    public interface IUserBase
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);
    }
}