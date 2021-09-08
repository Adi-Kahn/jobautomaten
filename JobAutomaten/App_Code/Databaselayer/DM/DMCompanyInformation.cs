using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
public class DMCompanyInformation
{
public DMCompanyInformation()
{
//
// TODO: Add constructor logic here
//
}
public int updateCompanyInformation(DDCompanyInformation m_ddCompanyInformation)
{
TBLCompanyInformation pDAL = new TBLCompanyInformation();
try
{
return pDAL.updateCompanyInformation(m_ddCompanyInformation);
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
public int insertCompanyInformation(DDCompanyInformation m_ddCompanyInformation)
{
TBLCompanyInformation pDAL = new TBLCompanyInformation();
try
{
return pDAL.insertCompanyInformation(m_ddCompanyInformation);
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
public DataTable GetAllCompanyInformation()
{
TBLCompanyInformation pDAL = new TBLCompanyInformation();
try
{
return pDAL.GetAllCompanyInformation();
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
 public DataTable GetAllCompanyInformationbyid(string id)
{
TBLCompanyInformation pDAL = new TBLCompanyInformation();
try
{
return pDAL.GetAllCompanyInformationbyId(id);
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
