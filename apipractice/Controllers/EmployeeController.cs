using DAl.Models;
using IObjects.DataRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apipractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepositry<Employee> _datarepository;

        public EmployeeController(IDataRepositry<Employee> datarepository)
        {
            _datarepository = datarepository;   
        }
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee>emp= _datarepository.GetAll();
            return Ok(emp);
        }
        [HttpGet("Id")]
        public IActionResult GetbyID(int id)
        {
            Employee emp=_datarepository.Getbyid(id);
            if(emp==null)
            {
                return NotFound();
            }
            return Ok(emp);
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            _datarepository.Add(employee);
            return Ok(employee);
        }
        [HttpPut("Id")]
        public IActionResult Put(int id,Employee employee)
        {
            Employee emptoupdate=_datarepository.Getbyid(id);
            _datarepository.Update(emptoupdate, employee);
            return NoContent();
        }
        [HttpDelete("Id")]
        public IActionResult Delete(int id)
        {
            Employee emptodelete = _datarepository.Getbyid(id);
            _datarepository.Delete(emptodelete);
            return NoContent();
        }

    }
}
