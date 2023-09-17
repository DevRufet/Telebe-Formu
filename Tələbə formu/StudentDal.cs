using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tələbə_formu
{
    public class StudentDal
    {
        public List<Student> GetAll()
        {
            using (TələbəContext context = new TələbəContext())
            {
                return context.Students.ToList();
            }
        }
        public void Add(Student student)
        {
            using(TələbəContext context=new TələbəContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
        public void Update(Student student)
        {
            using(TələbəContext context=new TələbəContext())
            {
                var entity=context.Entry(student);
                entity.State=EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Student student)
        {
            using (TələbəContext context = new TələbəContext())
            {
                var entity = context.Entry(student);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
