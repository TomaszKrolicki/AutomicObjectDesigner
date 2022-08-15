using System.Configuration;
using System.Data;
using AutomicObjectDesigner.Models.Registration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ConfigurationManager = Microsoft.Extensions.Configuration.ConfigurationManager;

namespace AutomicObjectDesignerBack.Controllers;



[ApiController]
public class RegisterController : Controller
{
    SqlConnection conn = new SqlConnection(connectionString: "AutomicObjectDesignerConnection");
    private SqlCommand cmd = null;

    [HttpPost]
    [Route("Registration")]
    public string Registration(User user)
    {
        string msg = string.Empty;
        try
        {
            cmd = new SqlCommand("usp_Registration", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            cmd.Parameters.AddWithValue("@LastName", user.LastName);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@HasEmailConfirmed", "false");
            cmd.Parameters.AddWithValue("@IsAdministrator", "false");

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                msg = "Data inserted. Registration completed.";
            }
            else
            {
                msg = "Error. Registration not completed.";
            }
        }
        catch (Exception ex)
        {
            msg = ex.Message;
        }
        
        return msg;
    }
}