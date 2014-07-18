using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository.Mock
{
    public class MockPlayerRepository: IPlayerRepository
    {
        public static readonly Guid DennyId = new Guid("7e1009d6-d456-45bd-a0a5-1ad3f4c36560");
        public static readonly Guid HeatherId = new Guid("d9df67e7-99e7-4884-b356-01b48a7297e2");
        public static readonly Guid RobertId = new Guid("32eae10e-dc73-4787-8f44-75e1fbd0ffb0");

        public bool Delete(Guid id)
        {
            return true;
        }

        public bool Create(User entity)
        {
            return true;
        }

        public IList<User> List(int skip, int take)
        {
            List<User> results = new List<User>();

            results.Add(Denny);
            results.Add(Heather);
            results.Add(Robert);

            return results;
        }

        public User GetById(Guid id)
        {
            User result = new User();

            if (id == DennyId)
                result = Denny;
            else if (id == HeatherId)
                result = Heather;
            else if (id == RobertId)
                result = Robert;

            return result;
        }

        public bool Update(User entity)
        {
            return true;
        }

        public static User Denny
        {
            get
            {
                User result = new User();
                result.UserId = DennyId;
                result.Name = "Denny";
                result.IsAdmin = true;
                result.EmailAddress = "email@email.com";

                return result;
            }
        }

        public static User Heather
        {
            get
            {
                User result = new User();
                result.UserId = HeatherId;
                result.Name = "Heather";
                result.IsAdmin = false;
                result.EmailAddress = "email@email.com";

                return result;
            }
        }

        public static User Robert
        {
            get
            {
                User result = new User();
                result.UserId = RobertId;
                result.Name = "Robert";
                result.IsAdmin = false;
                result.EmailAddress = "email@email.com";

                return result;
            }
        }
    }
}
