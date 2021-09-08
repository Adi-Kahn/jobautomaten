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
    public partial class IndryknewannounceTest : System.Web.UI.Page
    {
        DDJobDescription dd = new DDJobDescription();
        DMJobDescription dm = new DMJobDescription();


        string final_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["CompanyId"];
            if (cookie != null)
            {
                dd.Company_id = cookie["Id"].ToString();                
            }
        }

        StringBuilder sbchk = new StringBuilder();
        StringBuilder req = new StringBuilder();
        string jobcategoryrdbt;

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            ArrayList sd = new ArrayList();
            int regionval = 1;

            
            Guid id = Guid.NewGuid();
            Guid CompanyId = Guid.NewGuid();

            // For uploading CompanyLogo
            string LogoName = CompanylogoC.PostedFile.FileName.ToString();
            //sets the image path
            string LogoPath = "~/CompanyLogo/" + LogoName;
            //save it to folder
            CompanylogoC.SaveAs(Server.MapPath(LogoPath));
            //get the size in bytes
            int LogoSize = CompanylogoC.PostedFile.ContentLength;

            // Validation for Radio Buttons
            if (RdInformationteknologi.Checked)
            {
                jobcategoryrdbt = "InformationsTeknologi";
            }
            if (RdEngineer.Checked)
            {
                jobcategoryrdbt = "Ingeniør og teknik";
            }
            if (RdHandel.Checked)
            {
                jobcategoryrdbt = "Handel og service";
            }
            if (RdIndustri.Checked)
            {
                jobcategoryrdbt = "Industri og håndværk";
            }
            if (RdKontor.Checked)
            {
                jobcategoryrdbt = "Kontor og økonomi";
            }
            if (RdSale.Checked)
            {
                jobcategoryrdbt = "Salg og kommunikation";
            }
            if (RdLedelse.Checked)
            {
                jobcategoryrdbt = "Ledelse og personale";
            }
            if (RdSocial.Checked)
            {
                jobcategoryrdbt = "Social og sundhed";
            }
            if (RdUndervisning.Checked)
            {
                jobcategoryrdbt = "Undervisning";
            }
            if (RdAndet.Checked)
            {
                jobcategoryrdbt = "Andet";
            }

            //foreach (int s in sd)
            //{

                    dd.job_desc_id = id.ToString();                    
                    
                    //dd.Regions = s.ToString();
                    dd.JobCategory = jobcategoryrdbt.ToString();
                    //dd.JobType = "";
                    //dd.JobRequirements = "";
                    dd.StartDate = txtstartDate.Text;
                    dd.ContactPerson = txtName.Text;
                    dd.Position = txtPos.Text;
                    dd.Email = txtemail.Text;
                    dd.Telephon = txttel.Text;
                    dd.Address = txtadd.Text;
                dd.CompanyLogo = LogoPath.ToString();
                dd.JobDescriptions = txtjobdesc.Text;

                dd.kobenhavn = kobenhavnchbx.Checked ? 1 : 0;
                dd.sjalland = sjallandchbx.Checked ? 1 : 0;
                dd.midtjylland = midjyllandchbx.Checked ? 1 : 0;
                dd.nordjylland = nordjyllandchbx.Checked ? 1 : 0;
                dd.bornholm = bornholmchbx.Checked ? 1 : 0;
                dd.fyn = fynchbx.Checked ? 1 : 0;
                dd.sydjylland = sydjyllandchbx.Checked ? 1 : 0;
                dd.andet = andetchbx.Checked ? 1 : 0;

            dd.Fuldtid = chbxFullTime.Checked ? 1 : 0;
            dd.Deltid = chbxDeltid.Checked ? 1 : 0;
            dd.Elevplads = chbxElev.Checked ? 1 : 0;
            dd.Besogsven = chbxBesogven.Checked ? 1 : 0;
            dd.Fleksjob = chbxFleksjob.Checked ? 1 : 0;
            dd.Lontilskud = chbxLontilskud.Checked ? 1 : 0;
            dd.Pensionist = chbxPensionist.Checked ? 1 : 0;
            dd.Frivillig = chbxFrivilig.Checked ? 1 : 0;
            dd.Praktik = chbxPraktik.Checked ? 1 : 0;
            dd.Vikar = chbxVikar.Checked ? 1 : 0;
           

            dd.license = chbxLicense.Checked ? 1 : 0;
            dd.storlicense = chbxBigLicense.Checked ? 1 : 0;
            dd.fluentdanish = chbxDanish.Checked ? 1 : 0;

            dm.insertJobDescription(dd);
                //}
            }
    }
}