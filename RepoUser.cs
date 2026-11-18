using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ConsoleApp8.Entities;

namespace ConsoleApp8.Repo
{
    public class RepoUser
    {
        Context Context = new Context();
        public bool CreateUser(User user)
        { 
            Context.Users.Add(user);
            return Context.SaveChanges() > 0;
        }
        public List<User> GetAllUsers()
        {
            return Context.Users.AsNoTracking().ToList();
        }

        public User? GetUserById(int id)
        {
            return Context.Users.Find(id);
        }
        public List<User> UsersBornAfter2000()
        {
            return Context.Users.AsNoTracking()
                .Where(u => u.BirthDate.Year > 2000)
                .ToList();
        }
        public bool UpdateAnyUser(User user)
        {
            User? User1 = GetUserById(user.ID);

            if (User1== null)
                return false;

            User1.UserName = user.UserName;
            User1.BirthDate = user.BirthDate;
            User1.Role = user.Role;
            User1.IsBlocked = user.IsBlocked;
            
            return Context.SaveChanges() > 0;
        }
        public bool UpdateUser(User user)
        {

            Context.Users.Update(user);
            return Context.SaveChanges() > 0;
        }
        public bool DeleteUser(int id)
        {
            User? user = Context.Users.FirstOrDefault(u => u.ID== id);

            if (user == null)
                return false;

            Context.Users.Remove(user);
            return Context.SaveChanges() > 0;
        }

    }
}
