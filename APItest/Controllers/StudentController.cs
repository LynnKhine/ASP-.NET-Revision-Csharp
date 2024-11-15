using APItest.Entities;
using APItest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APItest.Models.Student;

namespace APItest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : Controller
{
    private readonly AppDbContext _context;


    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("GetStudentById")]
    public IActionResult GetStudentById(string id)
    {
        var response = _context.StudentDbSet.Where(s => s.Id == id).FirstOrDefault();

        return Ok(response);
    }


    [HttpPost]
    [Route("GetStudentList")]
    public IActionResult GetStudentList()
    {
        var response = _context.StudentDbSet.ToList();

        return Ok(response);
    }

    [HttpPost]
    [Route("CreateStudent")]
    public IActionResult CreateStudent(CreateStudentRequestModel request)
    {
        if (request.Name == null || request.Name == "")
        {
            return BadRequest("Name Required");
        }

        if (request.IdNumber == null || request.IdNumber == "")
        {
            return BadRequest("Id Number Required");
        }

        StudentEntity student = new StudentEntity()
        {
            Id = Guid.NewGuid().ToString(),
            Name = request.Name,
            IdNumber = request.IdNumber,
            Phone = request.Phone,
            Email = request.Email,
            Address = request.Address,
            CreatedUserId = Guid.NewGuid().ToString(),
            UpdatedUserId = request.UpdatedUserId,
            CreatedDateTime = DateTime.Now,
            UpdatedDateTime = DateTime.Now
        };

        _context.StudentDbSet.Add(student);
        _context.SaveChanges();


        return Ok();
    }

    [HttpGet]
    [Route("DeleteStudentById")]
    public IActionResult DeleteStudentById(string id)
    {
        var student = _context.StudentDbSet.Where(s => s.Id == id).FirstOrDefault();

        _context.StudentDbSet.Remove(student);
        _context.SaveChanges();

        return Ok(student);
    }

    [HttpGet]
    [Route("UpdateStudent")]
    public IActionResult UpdateStudent(string id, string name, string idnumber, string phone, string email, string address, string updateduserid, DateTime updateddatetime)
    {
        StudentEntity student = _context.StudentDbSet.Where(s => s.Id == id).FirstOrDefault();

        student.Name = name;
        student.IdNumber = idnumber;
        student.Phone = phone;
        student.Email = email;
        student.IdNumber = idnumber;
        student.Address = address;
        student.UpdatedUserId = updateduserid;
        student.UpdatedDateTime = updateddatetime;

        _context.StudentDbSet.Update(student);
        _context.SaveChanges();

        return Ok(student);
    }

}
