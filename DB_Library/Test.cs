using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Functions
{

    class Tests
    {


        [TestMethod]
        [TestCategory("Integration")]
        [Conditional("DB_INTEGRATION")]
        public void Test()
        {
            var dbContextFactory = new DbContextFactory();
            var userRepository = new EfUserRepository(dbContextFactory);

            var username = Utils.GenerateRandomString(200);
            var user1 = userRepository.Create(username);
            var user2 = userRepository.ReadById(user1);
        }
    }
}