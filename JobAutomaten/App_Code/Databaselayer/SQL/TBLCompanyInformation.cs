using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.SqlClient;
public class TBLCompanyInformation:Helperclass
{
string qry = ""; 
 public TBLCompanyInformation()
{
	//
	// TODO: Add constructor logic here
	//
}
public int updateCompanyInformation(DDCompanyInformation m_ddCompanyInformation)
{
SqlConnection con = new SqlConnection(constr);
con.Open();
 SqlCommand cmd = new SqlCommand("updateCompanyInformation_pro", con);
cmd.CommandType = CommandType.StoredProcedure;
cmd.Parameters.AddWithValue("@Email", m_ddCompanyInformation.Email);
cmd.Parameters.AddWithValue("@Password", m_ddCompanyInformation.Password);
cmd.Parameters.AddWithValue("@Company", m_ddCompanyInformation.Company);
cmd.Parameters.AddWithValue("@Address", m_ddCompanyInformation.Address);
cmd.Parameters.AddWithValue("@Area", m_ddCompanyInformation.Area);
cmd.Parameters.AddWithValue("@Postnumber", m_ddCompanyInformation.Postnumber);
cmd.Parameters.AddWithValue("@Telephonenumber", m_ddCompanyInformation.Telephonenumber);
int a = cmd.ExecuteNonQuery();
con.Close();
return a;
}
 public int insertCompanyInformation(DDCompanyInformation m_ddCompanyInformation)
{
SqlConnection con = new SqlConnection(constr);
con.Open();
 SqlCommand cmd = new SqlCommand("insertCompanyInformation_pro", con);
cmd.CommandType = CommandType.StoredProcedure;
cmd.Parameters.AddWithValue("@CompId", m_ddCompanyInformation.CompanyID);
cmd.Parameters.AddWithValue("@Email", m_ddCompanyInformation.Email);
cmd.Parameters.AddWithValue("@Password", m_ddCompanyInformation.Password);
cmd.Parameters.AddWithValue("@Company", m_ddCompanyInformation.Company);
cmd.Parameters.AddWithValue("@Address", m_ddCompanyInformation.Address);
cmd.Parameters.AddWithValue("@Area", m_ddCompanyInformation.Area);
cmd.Parameters.AddWithValue("@Postnumber", m_ddCompanyInformation.Postnumber);
cmd.Parameters.AddWithValue("@Telephonenumber", m_ddCompanyInformation.Telephonenumber);
int a = cmd.ExecuteNonQuery();
con.Close();
return a;
}
public DataTable GetAllCompanyInformation()
{
 SqlConnection con = new SqlConnection(constr);
SqlDataAdapter da = new SqlDataAdapter("GetAllCompanyInformation_pro", con);
da.SelectCommand.CommandType = CommandType.StoredProcedure;
DataSet dSet = new DataSet();
da.Fill(dSet, "CompanyInformation");
 con.Close();return dSet.Tables["CompanyInformation"];}
public DataTable GetAllCompanyInformationbyId(string id)
{
 SqlConnection con = new SqlConnection(constr);
SqlDataAdapter da = new SqlDataAdapter("GetAllCompanyInformationbyid_pro", con);
da.SelectCommand.Parameters.AddWithValue("@id",id );
da.SelectCommand.CommandType = CommandType.StoredProcedure;
DataSet dSet = new DataSet();
da.Fill(dSet, "CompanyInformation");
 con.Close();return dSet.Tables["CompanyInformation"];
}
}
