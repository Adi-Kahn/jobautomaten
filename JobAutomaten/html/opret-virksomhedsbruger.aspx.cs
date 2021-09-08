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
    public partial class opret_virksomhedsbruger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButon_Click(object sender, EventArgs e)
        {
            DDCompanyInformation ddcompInfo = new DDCompanyInformation();
            DMCompanyInformation dmcompInfo = new DMCompanyInformation();

            Guid companyid = Guid.NewGuid();

            ddcompInfo.CompanyID = companyid.ToString();
            ddcompInfo.Email = TxtEmail.Text;
            ddcompInfo.Password = TxtPassword.Text;
            ddcompInfo.Company = TxtVirksomhed.Text;
            ddcompInfo.Address = TxtAddress.Text;
            ddcompInfo.Area = TxtBy.Text;
            ddcompInfo.Postnumber = TxtPost.Text;
            ddcompInfo.Telephonenumber = TxtTelefon.Text;

            dmcompInfo.insertCompanyInformation(ddcompInfo);

            Server.Transfer("virksomhedsbruger-log-ind.aspx", true);

        }
    }
}