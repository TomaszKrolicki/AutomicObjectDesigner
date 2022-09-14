using System.Configuration;
using System.Data;
using AutomicObjectDesigner.Models.Registration;
using AutomicObjectDesignerBack.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.Data.SqlClient;
using ConfigurationManager = Microsoft.Extensions.Configuration.ConfigurationManager;

namespace AutomicObjectDesignerBack.Controllers;



[ApiController]
public class RegisterController : Controller
{
    private readonly SqlConnection conn = new (connectionString: "AutomicObjectDesignerConnection");
    private readonly SqlCommand cmd = null;

    //[HttpPost]
    //[Route("[controller]/Registration")
    
}