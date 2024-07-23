﻿using Entities.Concrete;
using Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccessLayer.Abstract
{
    //metotlar burada User tarafından kullanılabilir oldu yani Ientityrepository yi implement ettik
    public interface IUserRepository:IEntityRepository<Entities.Concrete.User>
    {
        //kendimiz bir şey eklemek istiyorsak 
        IList<User> GetUsersByName(string name);
    }
}
