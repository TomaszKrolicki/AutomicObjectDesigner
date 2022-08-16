using System.Data;
using AutomicObjectDesigner.Models.Registration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AutomicObjectDesignerBack.Controllers;

[ApiController]

public class LoginController : Controller
{

    [HttpPost]
    [Route("Login")]
    public string Login(User user)
    {
        return "";
    }
}