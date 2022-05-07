using ApiDene2.Models;
using Bogus;

namespace ApiDene2.Fake
{
    public static class FakeData
    {
        private static List<User> _users;
        public static List<User> GetUsers(int number)
        {
            _users = new Faker<User>()
                .RuleFor(p => p.Id, f => f.IndexFaker)
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Address, f => f.Address.StreetAddress())
                .Generate(number);
            return _users;
        }



    }
}
