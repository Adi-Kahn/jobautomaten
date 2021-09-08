using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.SqlClient;
public class TBLJobDescription:Helperclass
{
string qry = ""; 
 public TBLJobDescription()
{
	//
	// TODO: Add constructor logic here
	//
}
public int updateJobDescription(DDJobDescription m_ddJobDescription)
{
SqlConnection con = new SqlConnection(constr);
con.Open();
 SqlCommand cmd = new SqlCommand("updateJobDescription_pro", con);
cmd.CommandType = CommandType.StoredProcedure;        
cmd.Parameters.AddWithValue("@job_desc_id", m_ddJobDescription.job_desc_id);
//cmd.Parameters.AddWithValue("@Regions", m_ddJobDescription.Regions);
cmd.Parameters.AddWithValue("@JobCategory", m_ddJobDescription.JobCategory);
cmd.Parameters.AddWithValue("@JobType", m_ddJobDescription.JobType);
cmd.Parameters.AddWithValue("@JobRequirements", m_ddJobDescription.JobRequirements);
cmd.Parameters.AddWithValue("@StartDate", m_ddJobDescription.StartDate);
cmd.Parameters.AddWithValue("@ContactPerson", m_ddJobDescription.ContactPerson);
cmd.Parameters.AddWithValue("@Position", m_ddJobDescription.Position);
cmd.Parameters.AddWithValue("@Email", m_ddJobDescription.Email);
cmd.Parameters.AddWithValue("@Telephon", m_ddJobDescription.Telephon);
cmd.Parameters.AddWithValue("@Address", m_ddJobDescription.Address);
cmd.Parameters.AddWithValue("@JobDescriptions", m_ddJobDescription.JobDescriptions);
        cmd.Parameters.AddWithValue("@kobenhavn", m_ddJobDescription.kobenhavn);
        cmd.Parameters.AddWithValue("@midtjylland", m_ddJobDescription.midtjylland);
        cmd.Parameters.AddWithValue("@nordjylland", m_ddJobDescription.nordjylland);
        cmd.Parameters.AddWithValue("@sjalland", m_ddJobDescription.sjalland);
        cmd.Parameters.AddWithValue("@sydjylland", m_ddJobDescription.sydjylland);
        cmd.Parameters.AddWithValue("@fyn", m_ddJobDescription.fyn);
        cmd.Parameters.AddWithValue("@bornholm", m_ddJobDescription.bornholm);
        cmd.Parameters.AddWithValue("@andet", m_ddJobDescription.andet);

        cmd.Parameters.AddWithValue("@fultid", m_ddJobDescription.Fuldtid);
        cmd.Parameters.AddWithValue("@deltid", m_ddJobDescription.Deltid);
        cmd.Parameters.AddWithValue("@frivillig", m_ddJobDescription.Frivillig);
        cmd.Parameters.AddWithValue("@fleks", m_ddJobDescription.Fleksjob);
        cmd.Parameters.AddWithValue("@lontilskud", m_ddJobDescription.Lontilskud);
        cmd.Parameters.AddWithValue("@besogven", m_ddJobDescription.Besogsven);
        cmd.Parameters.AddWithValue("@praktik", m_ddJobDescription.Praktik);
        cmd.Parameters.AddWithValue("@pensionist", m_ddJobDescription.Pensionist);
        cmd.Parameters.AddWithValue("@vikar", m_ddJobDescription.Vikar);
        cmd.Parameters.AddWithValue("@elev", m_ddJobDescription.Elevplads);

        cmd.Parameters.AddWithValue("@license", m_ddJobDescription.license);
        cmd.Parameters.AddWithValue("@storlicense", m_ddJobDescription.storlicense);
        cmd.Parameters.AddWithValue("@fluentdanish", m_ddJobDescription.fluentdanish);

        int a = cmd.ExecuteNonQuery();
con.Close();
return a;
}
 public int insertJobDescription(DDJobDescription m_ddJobDescription)
{
SqlConnection con = new SqlConnection(constr);
con.Open();
 SqlCommand cmd = new SqlCommand("insertJobDescription_pro", con);
cmd.CommandType = CommandType.StoredProcedure;
cmd.Parameters.AddWithValue("@job_desc_id", m_ddJobDescription.job_desc_id);
cmd.Parameters.AddWithValue("@Company_id", m_ddJobDescription.Company_id);
//cmd.Parameters.AddWithValue("@Regions", m_ddJobDescription.Regions);
cmd.Parameters.AddWithValue("@JobCategory", m_ddJobDescription.JobCategory);
//cmd.Parameters.AddWithValue("@JobType", m_ddJobDescription.JobType);
//cmd.Parameters.AddWithValue("@JobRequirements", m_ddJobDescription.JobRequirements);
cmd.Parameters.AddWithValue("@StartDate", m_ddJobDescription.StartDate);
cmd.Parameters.AddWithValue("@ContactPerson", m_ddJobDescription.ContactPerson);
cmd.Parameters.AddWithValue("@Position", m_ddJobDescription.Position);
cmd.Parameters.AddWithValue("@Email", m_ddJobDescription.Email);
cmd.Parameters.AddWithValue("@Telephon", m_ddJobDescription.Telephon);
cmd.Parameters.AddWithValue("@Address", m_ddJobDescription.Address);
cmd.Parameters.AddWithValue("@JobDescriptions", m_ddJobDescription.JobDescriptions);
        cmd.Parameters.AddWithValue("@companyLogo", m_ddJobDescription.CompanyLogo);

        cmd.Parameters.AddWithValue("@kobenhavn", m_ddJobDescription.kobenhavn);
        cmd.Parameters.AddWithValue("@midtjylland", m_ddJobDescription.midtjylland);
        cmd.Parameters.AddWithValue("@nordjylland", m_ddJobDescription.nordjylland);
        cmd.Parameters.AddWithValue("@sjalland", m_ddJobDescription.sjalland);
        cmd.Parameters.AddWithValue("@sydjylland", m_ddJobDescription.sydjylland);
        cmd.Parameters.AddWithValue("@fyn", m_ddJobDescription.fyn);
        cmd.Parameters.AddWithValue("@bornholm", m_ddJobDescription.bornholm);
        cmd.Parameters.AddWithValue("@andet", m_ddJobDescription.andet);
            cmd.Parameters.AddWithValue("@fultid", m_ddJobDescription.Fuldtid);
            cmd.Parameters.AddWithValue("@deltid", m_ddJobDescription.Deltid);
            cmd.Parameters.AddWithValue("@frivillig", m_ddJobDescription.Frivillig);
            cmd.Parameters.AddWithValue("@fleks", m_ddJobDescription.Fleksjob);
            cmd.Parameters.AddWithValue("@lontilskud", m_ddJobDescription.Lontilskud);
            cmd.Parameters.AddWithValue("@besogven", m_ddJobDescription.Besogsven);
            cmd.Parameters.AddWithValue("@praktik", m_ddJobDescription.Praktik);
            cmd.Parameters.AddWithValue("@pensionist", m_ddJobDescription.Pensionist);
            cmd.Parameters.AddWithValue("@vikar", m_ddJobDescription.Vikar);
            cmd.Parameters.AddWithValue("@elev", m_ddJobDescription.Elevplads);

        cmd.Parameters.AddWithValue("@license", m_ddJobDescription.license);
        cmd.Parameters.AddWithValue("@storlicense", m_ddJobDescription.storlicense);
        cmd.Parameters.AddWithValue("@fluentdanish", m_ddJobDescription.fluentdanish);

        int a = cmd.ExecuteNonQuery();
con.Close();
return a;
}
public DataTable GetAllJobDescription()
{
 SqlConnection con = new SqlConnection(constr);
SqlDataAdapter da = new SqlDataAdapter("GetAllJobDescription_pro", con);
da.SelectCommand.CommandType = CommandType.StoredProcedure;
DataSet dSet = new DataSet();
da.Fill(dSet, "JobDescription");
 con.Close();return dSet.Tables["JobDescription"];}
public DataTable GetAllJobDescriptionbyId(string id)
{
 SqlConnection con = new SqlConnection(constr);
SqlDataAdapter da = new SqlDataAdapter("GetAllJobDescriptionbyid_pro", con);
da.SelectCommand.Parameters.AddWithValue("@id",id );
da.SelectCommand.CommandType = CommandType.StoredProcedure;
DataSet dSet = new DataSet();
da.Fill(dSet, "JobDescription");
 con.Close();return dSet.Tables["JobDescription"];
}
}
