using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Account
{
    public interface IAccountService
    {
      Guid Register(AccountEntity account);
        List<AccountEntity> GetAccounts();
    }
}
