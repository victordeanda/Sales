using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sales.Domain.Models
{
    public class DataContext :  DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
                
        }
    }
}
