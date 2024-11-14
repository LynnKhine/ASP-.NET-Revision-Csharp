using APItest.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace APItest.Controllers;



[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    [HttpGet]
    [Route("GetHelloWorld")]
    public IActionResult GetHelloWorld()
    {
        return Ok("Hello World");
    }

    [HttpGet]
    [Route("GetStatusById")]
    public IActionResult GetStatusById(int id)
    {
        switch (id)
        {
            case 1:
                return Ok("200 OK: Request successful.");
            case 2:
                return BadRequest("400 Bad Request");
            case 3:
                return NotFound("404 Not Found");
            case 4:
                return StatusCode(500, "500 Server Error");
            default:
                return StatusCode(418, "Unsupported Id");
        }
    }

    [HttpPost]
    [Route("UserInfo")]

    public IActionResult UserInfo(UserRequestModel request)
    {
        UserResponseModel response = new UserResponseModel()
        {
            Name = request.Name,
            Phone = request.Phone,
            Email = request.Email,
            Id = Guid.NewGuid().ToString()
        };

            return Ok(response);
        }

    [HttpPost]
    [Route("UserInfoList")]

    public IActionResult UserInfoList()
    {
        var response = new UserListResponseModel();

        UserRequestModel requestUser1 = new UserRequestModel()
        {
            Name = "Linn",
            Phone = "1234",
            Email = "linn@gmail.com"
        };
        response.Users.Add(requestUser1);

        UserRequestModel requestUser2 = new UserRequestModel()
        {
            Name = "pk",
            Phone = "1234",
            Email = "pk@gmail.com"
        };
        response.Users.Add(requestUser2);

        UserRequestModel requestUser3 = new UserRequestModel()
        {
            Name = "Jack",
            Phone = "1234",
            Email = "jack@gmail.com"
        };
        response.Users.Add(requestUser3);

        UserRequestModel requestUser4 = new UserRequestModel()
        {
            Name = "mkn",
            Phone = "1234",
            Email = "mkn@gmail.com"
        };
        response.Users.Add(requestUser4);

        return Ok(response);
    }
}

