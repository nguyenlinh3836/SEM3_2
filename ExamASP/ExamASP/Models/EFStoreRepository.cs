using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamASP.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private DataContext context;

        public EFStoreRepository(DataContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
