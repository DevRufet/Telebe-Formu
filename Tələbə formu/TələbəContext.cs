using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tələbə_formu
{
    public class TələbəContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
