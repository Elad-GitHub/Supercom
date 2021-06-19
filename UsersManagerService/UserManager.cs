using System.Collections.Generic;
using System.Linq;

namespace UsersManagerService
{
    public sealed class UserManager
    {
        private static readonly UserManager instance = new UserManager();
        private Dictionary<int, User> Users = new Dictionary<int, User>();
        //private SupercomEntities db = new SupercomEntities();

        static UserManager()
        {
        }

        private UserManager()
        {
        }

        public static UserManager Instance
        {
            get
            {
                return instance;
            }
        }


        public void RemoveUser(int id)//User user)
        {
            //db.Users.Remove(user);
            //db.SaveChanges();

            if (Users.ContainsKey(id))
            {
                Users.Remove(id);
            }
        }

        public void AddUser(User user)
        {
            //var userList = db.GetUsers().ToList();

            //db.Users.Add(user);
            //db.SaveChanges();

            if (Users.ContainsKey(user.ID))
            {
                Users[user.ID] = user;
            }
            else
            {
                Users.Add(user.ID, user);
            }
        }
    }
}
