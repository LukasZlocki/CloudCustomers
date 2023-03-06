using CloudCustomers.API.Models;
using System.Xml.Linq;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new() {
                new User
                {
                    Name = "Test User 1",
                    Email = "test.user.1@ab.ab",
                    Address = new Address
                    {
                        Street = "54 streer name",
                        City = "city_name1",
                        ZipCode = "111111"
                    }
                },
                 new User
                 {
                    Name = "Test User 2",
                    Email = "test.user.2@ab.ab",
                    Address = new Address
                    {
                        Street = "66 streer name",
                        City = "city_name2",
                        ZipCode = "222222"
                    }
                 },
                 new User
                 {
                    Name = "Test User 2",
                    Email = "test.user.3@ab.ab",
                    Address = new Address
                    {
                        Street = "66 streer name",
                        City = "city_name3",
                        ZipCode = "333333"
                    }
                 }
        };

    }
}
