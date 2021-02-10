using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Account
{
    public class AccountService : IAccountService
    {
        public Guid Register(AccountEntity accountEntity)
        {
            try
            {
                var path = @".\Account.json";
                var accounts = new List<AccountEntity>();

                if (File.Exists(path))
                {
                    var jsonFile = File.ReadAllText(path);
                    accounts = JsonConvert.DeserializeObject<List<AccountEntity>>(jsonFile);
                }

                var userAccount = accounts.FirstOrDefault(x => x.Email == accountEntity.Email);
                if (userAccount != null)
                    throw new Exception("User already exist.");

                var newAccount = new AccountEntity()
                {
                    UserId = Guid.NewGuid(),
                    Email = accountEntity.Email,
                    Password = accountEntity.Password
                };
                accounts.Add(newAccount);

                var result = string.Empty;
                foreach (var account in accounts)
                {
                    result += JsonConvert.SerializeObject(account, Formatting.Indented) + ",";
                }
                File.WriteAllText(path, "[" + result + "]");
                return newAccount.UserId;
            }
            catch(Exception e)
            {
                return Guid.Empty;
            }
        }

        public List<AccountEntity> GetAccounts()
        {
            var path = @".\Account.json";
            var accounts = new List<AccountEntity>();
            if (!File.Exists(path))
                return accounts;

            var result = File.ReadAllText(path);
            accounts = JsonConvert.DeserializeObject<List<AccountEntity>>(result);
            return accounts;
        }
    }
}
