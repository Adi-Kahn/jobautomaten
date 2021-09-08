using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobAutomaten.html
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DDJobDescription dd = new DDJobDescription();
            DMJobDescription dm = new DMJobDescription();

            Guid id = new Guid();
            dd.job_desc_id = id.ToString();
            dd.Regions = txtregions.Text;
            dd.JobCategory = txtjobcat.Text;
            dd.JobType = txtjobtype.Text;
            dd.JobRequirements = txtreq.Text;
            dd.StartDate = txtstartDate.Text;
            dd.ContactPerson = txtcontactPers.Text;
            dd.Position = txtPos.Text;
            dd.Email = txtemail.Text;
            dd.Telephon = txttel.Text;
            dd.Address = txtadd.Text;
            dd.JobDescriptions = txtjobdesc.Text;


            dm.insertJobDescription(dd);
        }
    }
}