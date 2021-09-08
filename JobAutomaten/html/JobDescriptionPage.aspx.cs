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
    public partial class JobDescriptionPage : System.Web.UI.Page
    {
        string job_desc_id = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (Request.QueryString["job_desc_id"]!=null)
            {
                job_desc_id = Request.QueryString["job_desc_id"].ToString();
                DataSet ds = GetData();

                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
            else
            {
                Response.Redirect("job-og-ledige-stillinger.aspx");
            }

           
        }

        private DataSet GetData()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from JobDescription where job_desc_id='"+ job_desc_id +"'" , con);

                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }

        }
    }
}