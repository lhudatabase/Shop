using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;

namespace Models
{
    public class AccountModel
    {
        private ShopDbContext context = null;

        public AccountModel()
        {
            context = new ShopDbContext();
        }

        public bool Login(string userName, string password)
        {
            object[] sqlParam =
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password)
            };
            var res = context.Database.SqlQuery<bool>("SP_Account_Login @UserName, @Password", sqlParam).SingleOrDefault();
            return res;
        }
    }
}
