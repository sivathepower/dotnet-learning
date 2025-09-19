
using CookieWebSolution.Models;
using Microsoft.AspNetCore.Mvc;
namespace CookieWebSolution.Services
{
    public class UserService
    {
        public List<User> users;

        public UserService()
        {
            users = new List<User>();
            users.Add(new User { Username = "test1@g.com", Password = "12345" });
            users.Add(new User { Username = "test2@g.com", Password = "12345" });
        }
        public User Validate(string username, string password)
        {
            return users.FirstOrDefault(a => a.Username == username && a.Password == password);
        }
    }
}