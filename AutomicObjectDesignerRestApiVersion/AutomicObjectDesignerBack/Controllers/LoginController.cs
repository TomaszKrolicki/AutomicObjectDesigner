using System.Data;
using AutomicObjectDesigner.Models.Registration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AutomicObjectDesignerBack.Controllers;

[ApiController]

public class LoginController : Controller
{
    SqlConnection conn = new SqlConnection(connectionString: "AutomicObjectDesignerConnection");
    private SqlCommand cmd = null;
    SqlDataAdapter adapter = null;

    [HttpPost]
    [Route("Login")]
    public string Login(User user)
    {
        string msg = string.Empty;
        try
        {
            adapter = new SqlDataAdapter("", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@UserName", user.UserName);
            adapter.SelectCommand.Parameters.AddWithValue("@Password", user.Password);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                msg = "User is valid.";

            }else
            {
                msg = "User is not valid.";
            }
            ;
            conn.Open();
        }
        catch (Exception ex)
        {

        }
        return "";
    }
}