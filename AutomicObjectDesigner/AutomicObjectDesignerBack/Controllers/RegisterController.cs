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
    SqlConnection conn = new SqlConnection(connectionString: "AutomicObjectDesignerConnection");
    private SqlCommand cmd = null;

    //[HttpPost]
    //[Route("[controller]/Registration")
    
}