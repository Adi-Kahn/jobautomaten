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
cmd.Parameters.AddWithValue("@Regions", m_ddJobDescription.Regions);
cmd.Parameters.AddWithValue("@JobCategory", m_ddJobDescription.JobCategory);
cmd.Parameters.AddWithValue("@JobType", m_ddJobDescription.JobType);
cmd.Parameters.AddWithValue("@JobRequirements", m_ddJobDescription.JobRequirements);
cmd.Parameters.AddWithValue("@StartDate", m_ddJobDescription.StartDate);
cmd.Parameters.AddWithValue("@ContactPerson", m_ddJobDescription.ContactPerson);
cmd.Parameters.AddWithValue("@Position", m_ddJobDescription.Position);
cmd.Parameters.AddWithValue("@Email", m_ddJobDescription.Email);
cmd.Parameters.AddWithValue("@Telephon", m_ddJobDescription.Telephon);
cmd.Parameters.AddWithValue("@Address", m_ddJobDescription.Address);
cmd.Parameters.AddWithValue("@JobDescription", m_ddJobDescription.JobDescription);
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
cmd.Parameters.AddWithValue("@Regions", m_ddJobDescription.Regions);
cmd.Parameters.AddWithValue("@JobCategory", m_ddJobDescription.JobCategory);
cmd.Parameters.AddWithValue("@JobType", m_ddJobDescription.JobType);
cmd.Parameters.AddWithValue("@JobRequirements", m_ddJobDescription.JobRequirements);
cmd.Parameters.AddWithValue("@StartDate", m_ddJobDescription.StartDate);
cmd.Parameters.AddWithValue("@ContactPerson", m_ddJobDescription.ContactPerson);
cmd.Parameters.AddWithValue("@Position", m_ddJobDescription.Position);
cmd.Parameters.AddWithValue("@Email", m_ddJobDescription.Email);
cmd.Parameters.AddWithValue("@Telephon", m_ddJobDescription.Telephon);
cmd.Parameters.AddWithValue("@Address", m_ddJobDescription.Address);
cmd.Parameters.AddWithValue("@JobDescription", m_ddJobDescription.JobDescription);
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
