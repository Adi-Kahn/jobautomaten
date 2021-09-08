using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
public class DMProfile
{
public DMProfile()
{
//
// TODO: Add constructor logic here
//
}
public int updateProfile(DDProfile m_ddProfile)
{
TBLProfile pDAL = new TBLProfile();
try
{
return pDAL.updateProfile(m_ddProfile);
}
catch
{
throw;
}
finally
{
pDAL = null;
}
}
public int insertProfile(DDProfile m_ddProfile)
{
TBLProfile pDAL = new TBLProfile();
try
{
return pDAL.insertProfile(m_ddProfile);
}
catch
{
throw;
}
finally
{
pDAL = null;
}
}
public DataTable GetAllProfile()
{
TBLProfile pDAL = new TBLProfile();
try
{
return pDAL.GetAllProfile();
}
catch
{
throw;
}
finally
{
pDAL = null;
}
}
 public DataTable GetAllProfilebyid(string id)
{
TBLProfile pDAL = new TBLProfile();
try
{
return pDAL.GetAllProfilebyId(id);
}
catch
{
throw;
}
finally
{
pDAL = null;
}
}
}
