using Activity2.DataAccess;
using Activity2.Entities;
using Activity2.Models;
using AutoMapper;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Activity2.Controllers
{
    [Route("api/employees/")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeDbContext context;
        private readonly IMapper _mapper;
        public EmployeeController(EmployeeDbContext employeeDbContext, IMapper mapper)
        {
            context = employeeDbContext;
            _mapper = mapper;
        }


        [HttpGet]
        //public ActionResult<IEnumerable<Employee>> GetEmployees()
        //{
        //    var employees = context.Employees.Where(e => !e.IsDeleted);
        //    return Ok(employees);
        //}

        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetEmployees(EmployeeDbContext context)
        {
            var employees = await context.Employees.Where(e => !e.IsDeleted).ToListAsync();
            var employeeDTOs = _mapper.Map<List<EmployeeDTO>>(employees);
            return Ok(employeeDTOs);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(Guid id)
        {
            var employeeToReturn = context.Employees.FirstOrDefault(c => c.Id == id);

            if (employeeToReturn == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<EmployeeDTO>(employeeToReturn));
        }

        [HttpPost]

        public ActionResult<Employee> CreateEmployee(string Name, string Email, string Position, float Salary, string SSSNumber, string PagIbigNumber)
        {
            var finalEmployee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = Name,
                Email = Email,
                Position = Position,
                Salary = Salary,
                SSSNumber = SSSNumber,
                PagIbigNumber = PagIbigNumber,
            };

            if (context.Employees.Any(e => e.Email == Email && !e.IsDeleted))
            {
                return BadRequest($"Email must be unique.");
            }

            context.Employees.Add(finalEmployee);
            context.SaveChanges();

            return Ok(_mapper.Map<EmployeeDTO>(finalEmployee));
        }

        [HttpPut("{id}")]

        public ActionResult<Employee> UpdateEmployee(Guid id, string Name, string Email, string Position, float Salary, string SSSNumber, string PagIbigNumber)
        {
            var employee = context.Employees.FirstOrDefault(c => c.Id == id);
            if (context.Employees.Any(e => e.Email == Email && !e.IsDeleted))
            {
                return BadRequest($"Email must be unique.");
            }
            employee.Name = Name;
            employee.Email = Email;
            employee.Position = Position;
            employee.Salary = Salary;
            employee.SSSNumber = SSSNumber;
            employee.PagIbigNumber = PagIbigNumber;

            context.Update(employee);
            context.SaveChanges();
            return Ok(_mapper.Map<EmployeeDTO>(employee));
        }

        [HttpDelete("{id}")]
        public ActionResult<Employee> DeleteEmployee(Guid id)
        {
            var employee = context.Employees.FirstOrDefault(c => c.Id == id);
            employee.IsDeleted = true;

            context.Update(employee);
            context.SaveChanges();
            return Ok(_mapper.Map<EmployeeDTO>(employee));
        }
    }
}
