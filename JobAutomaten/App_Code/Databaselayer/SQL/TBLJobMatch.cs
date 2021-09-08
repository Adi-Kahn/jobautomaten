using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.SqlClient;
using JobAutomaten.html;

public class TBLJobMatch:Helperclass
{
string qry = ""; 
 public TBLJobMatch()
{
	//
	// TODO: Add constructor logic here
	//
}
public int updateJobMatch(DDJobMatch m_ddJobMatch)
{
SqlConnection con = new SqlConnection(constr);
con.Open();
 SqlCommand cmd = new SqlCommand("updateJobMatch_pro", con);
cmd.CommandType = CommandType.StoredProcedure;
cmd.Parameters.AddWithValue("@Name", m_ddJobMatch.Name);
cmd.Parameters.AddWithValue("@Company", m_ddJobMatch.Company);
cmd.Parameters.AddWithValue("@MobileTelephon", m_ddJobMatch.MobileTelephon);
cmd.Parameters.AddWithValue("@Email", m_ddJobMatch.Email);
cmd.Parameters.AddWithValue("@Message", m_ddJobMatch.Message);
int a = cmd.ExecuteNonQuery();
con.Close();
return a;
}
 public int insertJobMatch(DDJobMatch m_ddJobMatch)
{
SqlConnection con = new SqlConnection(constr);
con.Open();
 SqlCommand cmd = new SqlCommand("insertJobMatch_pro", con);
cmd.CommandType = CommandType.StoredProcedure;
cmd.Parameters.AddWithValue("@Name", m_ddJobMatch.Name);
cmd.Parameters.AddWithValue("@Company", m_ddJobMatch.Company);
cmd.Parameters.AddWithValue("@MobileTelephon", m_ddJobMatch.MobileTelephon);
cmd.Parameters.AddWithValue("@Email", m_ddJobMatch.Email);
cmd.Parameters.AddWithValue("@Message", m_ddJobMatch.Message);
int a = cmd.ExecuteNonQuery();
con.Close();
return a;
}
public DataTable GetAllJobMatch()
{
 SqlConnection con = new SqlConnection(constr);
SqlDataAdapter da = new SqlDataAdapter("GetAllJobMatch_pro", con);
da.SelectCommand.CommandType = CommandType.StoredProcedure;
DataSet dSet = new DataSet();
da.Fill(dSet, "JobMatch");
 con.Close();return dSet.Tables["JobMatch"];}
public DataTable GetAllJobMatchbyId(string id)
{
 SqlConnection con = new SqlConnection(constr);
SqlDataAdapter da = new SqlDataAdapter("GetAllJobMatchbyid_pro", con);
da.SelectCommand.Parameters.AddWithValue("@id",id );
da.SelectCommand.CommandType = CommandType.StoredProcedure;
DataSet dSet = new DataSet();
da.Fill(dSet, "JobMatch");
 con.Close();return dSet.Tables["JobMatch"];
}
}
