using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMVC.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
