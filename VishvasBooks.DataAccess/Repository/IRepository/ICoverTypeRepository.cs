using VishvasBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace VishvasBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
