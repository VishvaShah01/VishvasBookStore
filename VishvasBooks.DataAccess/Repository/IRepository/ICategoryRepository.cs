using VishvasBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace VishvasBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
