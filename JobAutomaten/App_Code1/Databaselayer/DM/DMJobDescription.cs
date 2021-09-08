using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
public class DMJobDescription
{
public DMJobDescription()
{
//
// TODO: Add constructor logic here
//
}
public int updateJobDescription(DDJobDescription m_ddJobDescription)
{
TBLJobDescription pDAL = new TBLJobDescription();
try
{
return pDAL.updateJobDescription(m_ddJobDescription);
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
public int insertJobDescription(DDJobDescription m_ddJobDescription)
{
TBLJobDescription pDAL = new TBLJobDescription();
try
{
return pDAL.insertJobDescription(m_ddJobDescription);
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
public DataTable GetAllJobDescription()
{
TBLJobDescription pDAL = new TBLJobDescription();
try
{
return pDAL.GetAllJobDescription();
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
 public DataTable GetAllJobDescriptionbyid(string id)
{
TBLJobDescription pDAL = new TBLJobDescription();
try
{
return pDAL.GetAllJobDescriptionbyId(id);
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
