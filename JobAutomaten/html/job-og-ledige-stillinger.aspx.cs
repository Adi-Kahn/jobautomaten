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
    public partial class job_og_ledige_stillinger : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        DDJobogLedige ddjob = new DDJobogLedige();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = GetData();

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            DataSet ds = GetReloadData();

            GridView1.DataSource = ds;
            GridView1.DataBind();
            //Response.Redirect("Search_result_jobs.aspx");
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

        private DataSet GetReloadData()
        {
            DataSet ds = new DataSet();
            ddjob.Fuldtid = chbxFullTime.Checked ? 1 : 0;
            ddjob.Deltid = chbxDeltid.Checked ? 1 : 0;
            ddjob.Elevplads = chbxElev.Checked ? 1 : 0;
            ddjob.Besogsven = chbxBesogven.Checked ? 1 : 0;
            ddjob.Fleksjob = chbxFleksjob.Checked ? 1 : 0;
            ddjob.Lontilskud = chbxLontilskud.Checked ? 1 : 0;
            ddjob.Pensionist = chbxPensionist.Checked ? 1 : 0;
            ddjob.Vikar = chbxVikar.Checked ? 1 : 0;
            ddjob.Praktik = chbxPraktik.Checked ? 1 : 0;
            ddjob.Frivillig = chbxFrivilig.Checked ? 1 : 0;

            ddjob.kobenhavn = kobenhavnchbx.Checked ? 1 : 0;
            ddjob.sjalland = sjallandchbx.Checked ? 1 : 0;
            ddjob.midtjylland = midjyllandchbx.Checked ? 1 : 0;
            ddjob.nordjylland = nordjyllandchbx.Checked ? 1 : 0;
            ddjob.bornholm = bornholmchbx.Checked ? 1 : 0;
            ddjob.fyn = fynchbx.Checked ? 1 : 0;
            ddjob.sydjylland = sydjyllandchbx.Checked ? 1 : 0;
            ddjob.andet = chbxAndet.Checked ? 1 : 0;

            ddjob.Search = Txtsearch.ToString();

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Return_Specified_Jobs", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fultid", ddjob.Fuldtid);
                cmd.Parameters.AddWithValue("@deltid", ddjob.Deltid);
                cmd.Parameters.AddWithValue("@frivillig", ddjob.Frivillig);
                cmd.Parameters.AddWithValue("@fleks", ddjob.Fleksjob);
                cmd.Parameters.AddWithValue("@lontilskud", ddjob.Lontilskud);
                cmd.Parameters.AddWithValue("@besogven", ddjob.Besogsven);
                cmd.Parameters.AddWithValue("@praktik", ddjob.Besogsven);
                cmd.Parameters.AddWithValue("@pensionist", ddjob.Pensionist);
                cmd.Parameters.AddWithValue("@vikar", ddjob.Vikar);
                cmd.Parameters.AddWithValue("@elev", ddjob.Elevplads);

                cmd.Parameters.AddWithValue("@kobenhavn", ddjob.kobenhavn);
                cmd.Parameters.AddWithValue("@midtjylland", ddjob.midtjylland);
                cmd.Parameters.AddWithValue("@nordjylland", ddjob.nordjylland);
                cmd.Parameters.AddWithValue("@sjalland", ddjob.sjalland);
                cmd.Parameters.AddWithValue("@sydjylland", ddjob.sydjylland);
                cmd.Parameters.AddWithValue("@fyn", ddjob.fyn);
                cmd.Parameters.AddWithValue("@bornholm", ddjob.bornholm);
                cmd.Parameters.AddWithValue("@andet", ddjob.andet);

                cmd.Parameters.AddWithValue("@Search", ddjob.Search);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                con.Close();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
        }
    }
}
