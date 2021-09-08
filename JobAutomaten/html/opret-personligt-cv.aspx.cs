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
using System.IO;

namespace JobAutomaten.html
{
    public partial class opret_personligt_cv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        int jobcategoryrdbt;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            ArrayList sd = new ArrayList();
            
            DDProfile ddprofile = new DDProfile();
            DMProfile dmprofile = new DMProfile();
            Guid id = Guid.NewGuid();

            // Get the name of posted file
            string fileName = VideoUploadfield.PostedFile.FileName.ToString();
            //sets the image path
            string filePath = "~/Videoupload/" + fileName;
            //save it to folder
            VideoUploadfield.SaveAs(Server.MapPath(filePath));
            //get the size in bytes
            int fileSize = VideoUploadfield.PostedFile.ContentLength;

           //validate before uploading
            //if (VideoUploadfield.PostedFile != null && VideoUploadfield.PostedFile.FileName != "")
            //{
            //    if (VideoUploadfield.PostedFile.ContentLength > 5120)
            //    {
            //        Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "alert", "alert('Error in execution')", true);
            //    }
            //    else
            //    {
            //        //call the method to excute insertion of data
            //        ddprofile.VideoUpload = VideoUploadfield.ToString();

            //    }
            //}
            
            // Validation for Radio Buttons
            if (RdInformationteknologi.Checked)
            {
                jobcategoryrdbt = 1;
            }
            if (RdEngineer.Checked)
            {
                jobcategoryrdbt = 2;
            }
            if (RdHandel.Checked)
            {
                jobcategoryrdbt = 3;
            }
            if (RdIndustri.Checked)
            {
                jobcategoryrdbt = 4;
            }
            if (RdKontor.Checked)
            {
                jobcategoryrdbt = 5;
            }
            if (RdSale.Checked)
            {
                jobcategoryrdbt = 6;
            }
            if (RdLedelse.Checked)
            {
                jobcategoryrdbt = 7;
            }
            if (RdSocial.Checked)
            {
                jobcategoryrdbt = 8;
            }
            if (RdUndervisning.Checked)
            {
                jobcategoryrdbt = 9;
            }
            if (RdAndet.Checked)
            {
                jobcategoryrdbt = 10;
            }

                           
                ddprofile.ProfileID = id.ToString();
            //dd.Regions = s.ToString();
            ddprofile.JobCategory = jobcategoryrdbt.ToString();
            ddprofile.SpecialCondition = txtSpecialCond.Text;
            ddprofile.EarlierWork = txtArbejder.Text;
            ddprofile.WorkExperience = txtPreviousWork.Text;
            ddprofile.Email = txtEmail.Text;
            ddprofile.Telephone = txtTelefon.Text;
            ddprofile.Address = txtaddress.Text;
            ddprofile.ProfileText = txtProfileText.Text;
            ddprofile.VideoUpload = filePath.ToString();
            ddprofile.EducationLevel = txtuddannelse.Text;

            ddprofile.kobenhavn = kobenhavnchbx.Checked ? 1 : 0;
            ddprofile.sjalland = sjallandchbx.Checked ? 1 : 0;
            ddprofile.midtjylland = midjyllandchbx.Checked ? 1 : 0;
            ddprofile.nordjylland = nordjyllandchbx.Checked ? 1 : 0;
            ddprofile.bornholm = bornholmchbx.Checked ? 1 : 0;
            ddprofile.fyn = fynchbx.Checked ? 1 : 0;
            ddprofile.sydjylland = sydjyllandchbx.Checked ? 1 : 0;
            ddprofile.andet = andetchbx.Checked ? 1 : 0;

            ddprofile.Fuldtid = chbxFullTime.Checked ? 1 : 0;
            ddprofile.Deltid = chbxDeltid.Checked ? 1 : 0;
            ddprofile.Elevplads = chbxElev.Checked ? 1 : 0;
            ddprofile.Besogsven = chbxBesogven.Checked ? 1 : 0;
            ddprofile.Fleksjob = chbxFleksjob.Checked ? 1 : 0;
            ddprofile.Lontilskud = chbxLontilskud.Checked ? 1 : 0;
            ddprofile.Pensionist = chbxPensionist.Checked ? 1 : 0;
            ddprofile.Vikar = chbxVikar.Checked ? 1 : 0;
            ddprofile.Praktik = chbxPraktik.Checked ? 1 : 0;
            ddprofile.Vikar = chbxVikar.Checked ? 1 : 0;
            ddprofile.Elevplads = chbxElev.Checked ? 1 : 0;

            ddprofile.license = chbxLicense.Checked ? 1 : 0;
            ddprofile.storlicense = chbxBigLicense.Checked ? 1 : 0;
            ddprofile.fluentdanish = chbxDanish.Checked ? 1 : 0;

            dmprofile.insertProfile(ddprofile);
          }
    }
}

    