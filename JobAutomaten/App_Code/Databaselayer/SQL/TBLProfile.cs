using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.SqlClient;
public class TBLProfile:Helperclass
{
string qry = ""; 
 public TBLProfile()
{
	//
	// TODO: Add constructor logic here
	//
}
public int updateProfile(DDProfile m_ddProfile)
{
SqlConnection con = new SqlConnection(constr);
con.Open();
 SqlCommand cmd = new SqlCommand("updateProfile_pro", con);
cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Profileid", m_ddProfile.ProfileID);
        cmd.Parameters.AddWithValue("@JobCategory", m_ddProfile.JobCategory);
        //cmd.Parameters.AddWithValue("@JobType", m_ddProfile.JobType);
        cmd.Parameters.AddWithValue("@Specialcond", m_ddProfile.SpecialCondition);
        //cmd.Parameters.AddWithValue("@ExtraInfo", m_ddProfile.ExtraInformation);
        //cmd.Parameters.AddWithValue("@Gender", m_ddProfile.Gender);
        cmd.Parameters.AddWithValue("@Earlierwork", m_ddProfile.EarlierWork);
        cmd.Parameters.AddWithValue("@Workexp", m_ddProfile.WorkExperience);
        cmd.Parameters.AddWithValue("@Educationlevel", m_ddProfile.EducationLevel);
        cmd.Parameters.AddWithValue("@Address", m_ddProfile.Address);
        cmd.Parameters.AddWithValue("@Telephon", m_ddProfile.Telephone);
        cmd.Parameters.AddWithValue("@Email", m_ddProfile.Email);
        cmd.Parameters.AddWithValue("@Profiletext", m_ddProfile.ProfileText);
        cmd.Parameters.AddWithValue("@fileUpload", m_ddProfile.VideoUpload);
        //cmd.Parameters.AddWithValue("@ProfilePic", m_ddProfile.ProfilePic);
        //cmd.Parameters.AddWithValue("@DateTime", m_ddProfile.DateTime);

        cmd.Parameters.AddWithValue("@kobenhavn", m_ddProfile.kobenhavn);
        cmd.Parameters.AddWithValue("@midtjylland", m_ddProfile.midtjylland);
        cmd.Parameters.AddWithValue("@nordjylland", m_ddProfile.nordjylland);
        cmd.Parameters.AddWithValue("@sjalland", m_ddProfile.sjalland);
        cmd.Parameters.AddWithValue("@sydjylland", m_ddProfile.sydjylland);
        cmd.Parameters.AddWithValue("@fyn", m_ddProfile.fyn);
        cmd.Parameters.AddWithValue("@bornholm", m_ddProfile.bornholm);
        cmd.Parameters.AddWithValue("@andet", m_ddProfile.andet);

        cmd.Parameters.AddWithValue("@fultid", m_ddProfile.Fuldtid);
        cmd.Parameters.AddWithValue("@deltid", m_ddProfile.Deltid);
        cmd.Parameters.AddWithValue("@frivillig", m_ddProfile.Frivillig);
        cmd.Parameters.AddWithValue("@fleks", m_ddProfile.Fleksjob);
        cmd.Parameters.AddWithValue("@lontilskud", m_ddProfile.Lontilskud);
        cmd.Parameters.AddWithValue("@besogven", m_ddProfile.Besogsven);
        cmd.Parameters.AddWithValue("@praktik", m_ddProfile.Praktik);
        cmd.Parameters.AddWithValue("@pensionist", m_ddProfile.Pensionist);
        cmd.Parameters.AddWithValue("@vikar", m_ddProfile.Vikar);
        cmd.Parameters.AddWithValue("@elev", m_ddProfile.Elevplads);

        cmd.Parameters.AddWithValue("@license", m_ddProfile.license);
        cmd.Parameters.AddWithValue("@storlicense", m_ddProfile.storlicense);
        cmd.Parameters.AddWithValue("@fluentdanish", m_ddProfile.fluentdanish);
        int a = cmd.ExecuteNonQuery();
con.Close();
return a;
}
 public int insertProfile(DDProfile m_ddProfile)
{
SqlConnection con = new SqlConnection(constr);
con.Open();
 SqlCommand cmd = new SqlCommand("insertProfile_pro", con);
cmd.CommandType = CommandType.StoredProcedure;
cmd.Parameters.AddWithValue("@Profileid", m_ddProfile.ProfileID);
cmd.Parameters.AddWithValue("@JobCategory", m_ddProfile.JobCategory);
//cmd.Parameters.AddWithValue("@JobType", m_ddProfile.JobType);
cmd.Parameters.AddWithValue("@Specialcond", m_ddProfile.SpecialCondition);
//cmd.Parameters.AddWithValue("@ExtraInfo", m_ddProfile.ExtraInformation);
//cmd.Parameters.AddWithValue("@Gender", m_ddProfile.Gender);
cmd.Parameters.AddWithValue("@Earlierwork", m_ddProfile.EarlierWork);
cmd.Parameters.AddWithValue("@Workexp", m_ddProfile.WorkExperience);
cmd.Parameters.AddWithValue("@Educationlevel", m_ddProfile.EducationLevel);
cmd.Parameters.AddWithValue("@Address", m_ddProfile.Address);
cmd.Parameters.AddWithValue("@Telephon", m_ddProfile.Telephone);
cmd.Parameters.AddWithValue("@Email", m_ddProfile.Email);
cmd.Parameters.AddWithValue("@Profiletext", m_ddProfile.ProfileText);
cmd.Parameters.AddWithValue("@fileUpload", m_ddProfile.VideoUpload);
        //cmd.Parameters.AddWithValue("@ProfilePic", m_ddProfile.ProfilePic);
        //cmd.Parameters.AddWithValue("@DateTime", m_ddProfile.DateTime);

        cmd.Parameters.AddWithValue("@kobenhavn", m_ddProfile.kobenhavn);
        cmd.Parameters.AddWithValue("@midtjylland", m_ddProfile.midtjylland);
        cmd.Parameters.AddWithValue("@nordjylland", m_ddProfile.nordjylland);
        cmd.Parameters.AddWithValue("@sjalland", m_ddProfile.sjalland);
        cmd.Parameters.AddWithValue("@sydjylland", m_ddProfile.sydjylland);
        cmd.Parameters.AddWithValue("@fyn", m_ddProfile.fyn);
        cmd.Parameters.AddWithValue("@bornholm", m_ddProfile.bornholm);
        cmd.Parameters.AddWithValue("@andet", m_ddProfile.andet);

        cmd.Parameters.AddWithValue("@fultid", m_ddProfile.Fuldtid);
        cmd.Parameters.AddWithValue("@deltid", m_ddProfile.Deltid);
        cmd.Parameters.AddWithValue("@frivillig", m_ddProfile.Frivillig);
        cmd.Parameters.AddWithValue("@fleks", m_ddProfile.Fleksjob);
        cmd.Parameters.AddWithValue("@lontilskud", m_ddProfile.Lontilskud);
        cmd.Parameters.AddWithValue("@besogven", m_ddProfile.Besogsven);
        cmd.Parameters.AddWithValue("@praktik", m_ddProfile.Praktik);
        cmd.Parameters.AddWithValue("@pensionist", m_ddProfile.Pensionist);
        cmd.Parameters.AddWithValue("@vikar", m_ddProfile.Vikar);
        cmd.Parameters.AddWithValue("@elev", m_ddProfile.Elevplads);

        cmd.Parameters.AddWithValue("@license", m_ddProfile.license);
        cmd.Parameters.AddWithValue("@storlicense", m_ddProfile.storlicense);
        cmd.Parameters.AddWithValue("@fluentdanish", m_ddProfile.fluentdanish);
        int a = cmd.ExecuteNonQuery();
con.Close();
return a;
}
public DataTable GetAllProfile()
{
 SqlConnection con = new SqlConnection(constr);
SqlDataAdapter da = new SqlDataAdapter("GetAllProfile_pro", con);
da.SelectCommand.CommandType = CommandType.StoredProcedure;
DataSet dSet = new DataSet();
da.Fill(dSet, "Profile");
 con.Close();return dSet.Tables["Profile"];}
public DataTable GetAllProfilebyId(string id)
{
 SqlConnection con = new SqlConnection(constr);
SqlDataAdapter da = new SqlDataAdapter("GetAllProfilebyid_pro", con);
da.SelectCommand.Parameters.AddWithValue("@id",id );
da.SelectCommand.CommandType = CommandType.StoredProcedure;
DataSet dSet = new DataSet();
da.Fill(dSet, "Profile");
 con.Close();return dSet.Tables["Profile"];
}
}
