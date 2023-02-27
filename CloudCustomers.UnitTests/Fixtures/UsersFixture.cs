using CloudCustomers.API.Models;
using System.Xml.Linq;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new() {
                new User
                {
                    Id = 1,
                    Name = "Jane",
                    Email = "jane@ab.ab",
                    Address = new Address
                    {
                        Street = "54 streer name",
                        City = "city_name",
                        ZipCode = "451078"
                    }
                },
                 new User
                 {
                    Id = 1,
                    Name = "Kane",
                    Email = "Kane@ab.ab",
                    Address = new Address
                    {
                        Street = "66 streer name",
                        City = "city_name2",
                        ZipCode = "11111"
                    }
                 }
        };

    }
}
