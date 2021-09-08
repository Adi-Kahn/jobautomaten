using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace JobAutomaten.html
{
    public partial class Search_result_jobs : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private DataSet GetData()
        {

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select TOP 5 * from JobDescription order by DatePub Desc", con);

                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }

        }
    }
}