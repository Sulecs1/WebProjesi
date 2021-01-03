using System;
using System.Collections.Generic;
using System.Text;
using BlogProjem.DataAccess.Interfaces;
using BlogProjem.Entities.Concrete;

namespace BlogProjem.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>, IAppUserDal
    {
    }
}
