using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobAutomaten.html
{
    public partial class virksomhedsbruger_log_ind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Guid UserId;

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Company_LoginProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Eparameter = new SqlParameter("@Email", TxtEmail.Text);
                SqlParameter Pparameter = new SqlParameter("@Password", TxtPassword.Text);

                cmd.Parameters.Add(Eparameter);
                cmd.Parameters.Add(Pparameter);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    UserId = (Guid)reader["CompanyId"];

                    HttpCookie cookie = new HttpCookie("CompanyID");
                    cookie["Id"] = UserId.ToString();

                    Response.Cookies.Add(cookie);
                    Response.Redirect("indryk-ny-jobannonce.aspx");

                }
                else
                {
                    lblLogin.Text = "Incorrect Email or Password";
                    
                }
            }
            }

        }
}


