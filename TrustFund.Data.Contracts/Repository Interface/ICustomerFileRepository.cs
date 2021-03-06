﻿using Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrustFund.Business.Entities;

namespace TrustFund.Data.Contracts.Repository_Interface
{
    
    public interface ICustomerFileRepository:IDataRepository<CustomerFile>
    {
        IEnumerable<CustomerFile> GetCustomerFilesByAccount(Account account);

        CustomerFile GetByName(string name);
    }
}
