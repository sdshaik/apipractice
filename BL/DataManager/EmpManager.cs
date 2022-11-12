using DAl.Models;
using IObjects.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DataManager
{
    public class EmpManager : IDataRepositry<Employee>
    {
        readonly EmpContext _empContext;
        public EmpManager(EmpContext empContext)
        {
            _empContext = empContext;
        }
    
        public void Add(Employee entity)
        {
            _empContext.Employees.Add(entity);
            _empContext.SaveChanges();  
        }

        public void Delete(Employee entity)
        {
            _empContext.Employees.Remove(entity);
            _empContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _empContext.Employees.ToList();
        }

        public Employee Getbyid(int id)
        {
            return _empContext.Employees.FirstOrDefault(x => x.EmpID == id);
        }

        public void Update(Employee entity, Employee entity1)
        {
           entity.EmpName=entity1.EmpName;
            entity.Empsal=entity1.Empsal;
            _empContext.SaveChanges();
        }
    }
}
