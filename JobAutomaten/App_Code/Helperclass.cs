using System;
using System.Collections;
using System.IO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net;

using System.Text.RegularExpressions;

/// <summary>
/// Summary description for Helperclass
/// </summary>
public class Helperclass : System.Web.UI.Page
{

    //public void insertFaktura(DDtbl_economic_faktura dd_fak, FakturaDetailCollection fak_detail_coll)
    //{
    //    DMtbl_economic_faktura dm_fak = new DMtbl_economic_faktura();
    //    DMtbl_economic_faktura_detail dm_fak_detail = new DMtbl_economic_faktura_detail();

    //    dm_fak.inserttbl_economic_faktura(dd_fak);
    //    for (int i = 0; i < fak_detail_coll.Count; i++)
    //    {
    //        dm_fak_detail.inserttbl_economic_faktura_detail(fak_detail_coll[i]);
    //    }

    //}
    public bool checktwotxt(string txt1, string txt2)
    {
        if (txt1 == txt2)
            return true;
        else
            return false;
    }
    public bool CheckCarAvailibility(DataTable dt, string startdatetime, string enddatetime)
    {
        bool val = false;
        System.Globalization.CultureInfo cultureinfo =
       new System.Globalization.CultureInfo("da");
        DataTable dtfinal = new DataTable();
        dtfinal.Columns.Add("startdatetime");
        dtfinal.Columns.Add("enddatetime");

        if (DateTime.Parse(startdatetime, cultureinfo) < DateTime.Parse(dt.Rows[0]["startdatetime"].ToString(), cultureinfo) && DateTime.Parse(enddatetime, cultureinfo) < DateTime.Parse(dt.Rows[0]["startdatetime"].ToString(), cultureinfo))
        {
            val = true;
            return val;
        }
        else
            if (DateTime.Parse(startdatetime, cultureinfo) > DateTime.Parse(dt.Rows[dt.Rows.Count - 1]["enddatetime"].ToString(), cultureinfo))
            {
                val = true;
                return val;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (DateTime.Parse(startdatetime, cultureinfo) >= DateTime.Parse(dt.Rows[i]["startdatetime"].ToString(), cultureinfo) && DateTime.Parse(startdatetime, cultureinfo) <= DateTime.Parse(dt.Rows[i]["enddatetime"].ToString(), cultureinfo))
                    {
                        val = false;
                        return val;
                    }

                }
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    if (DateTime.Parse(startdatetime, cultureinfo) > DateTime.Parse(dt.Rows[i]["enddatetime"].ToString(), cultureinfo) && DateTime.Parse(enddatetime, cultureinfo) < DateTime.Parse(dt.Rows[i + 1]["startdatetime"].ToString(), cultureinfo))
                    {
                        val = true;
                        return val;
                    }

                }
            }





        return val;

    }

    public string GetDanishDate(string date)
    {
        string date1 =

            int.Parse(Convert.ToDateTime(date).Day.ToString()) < 10 ? "0" + Convert.ToDateTime(date).Day.ToString() : Convert.ToDateTime(date).Day.ToString();
        //Convert.ToDateTime(date).Day.ToString() + "-";
        date1 += "-";
        date1 += int.Parse(Convert.ToDateTime(date).Month.ToString()) < 10 ? "0" + Convert.ToDateTime(date).Month.ToString() : Convert.ToDateTime(date).Month.ToString();
        date1 += "-" + Convert.ToDateTime(date).Year.ToString();
        return date1;

    }
    //if(i==0)
    //       {
    //       dtfinal.Rows.Add(DateTime.Parse(dt.Rows[0]["startdatetime"].ToString(),cultureinfo).ToString(),DateTime.Parse(dt.Rows[0]["enddatetime"].ToString(),cultureinfo).ToString());
    //       }
    //       else
    //           if(i!=dt.Rows.Count-1)
    //       {
    //           dtfinal.Rows.Add(DateTime.Parse(dt.Rows[i-1]["enddatetime"].ToString(),cultureinfo).ToString(),DateTime.Parse(dt.Rows[i]["startdatetime"].ToString(),cultureinfo).ToString());
    //       }
    //        else
    //           if(i==dt.Rows.Count-1)
    //       {
    //           dtfinal.Rows.Add(DateTime.Parse(dt.Rows[i]["startdatetime"].ToString(),cultureinfo).ToString(),DateTime.Parse(dt.Rows[i]["enddatetime"].ToString(),cultureinfo).ToString());
    //       }
    public string returnLanguage()
    {
        if (Session["myapplication.language"] == null)
        {

            Session["myapplication.language"] = "da";
        }
        return Session["myapplication.language"].ToString();
    }
    public bool datevalidation(string date)
    {
        string date1 = date;
        if (date == "")
        {
            return false;
        }
        try
        {
            System.Globalization.CultureInfo cultureinfo =
          new System.Globalization.CultureInfo("da");
            date = DateTime.Parse(date1, cultureinfo).Day.ToString().Length == 1 ? "0" + DateTime.Parse(date1, cultureinfo).Day.ToString() : DateTime.Parse(date1, cultureinfo).Day.ToString();
            date += "-";
            date += DateTime.Parse(date1, cultureinfo).Month.ToString().Length == 1 ? "0" + DateTime.Parse(date1, cultureinfo).Month.ToString() : DateTime.Parse(date1, cultureinfo).Month.ToString();
            date += "-" + DateTime.Parse(date1, cultureinfo).Year.ToString();
        }
        catch
        {
            return false;
        }


        string pattern = "dd-MM-yyyy";
        DateTime parsedDate;


        if (DateTime.TryParseExact(date, pattern, null,
                                  System.Globalization.DateTimeStyles.None, out parsedDate))
        {

        }
        else
        {
            Console.WriteLine("Unable to convert '{0}' to a date and time.",
                              date);
            return false;
        }


        return true;
    }
    public Helperclass()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public ArrayList Gettextboxpanel(Panel pnl, string tblname)
    {
        ArrayList arl = new ArrayList();
        Table t = (Table)pnl.FindControl("tb" + tblname);
        TextBox tbox;


        foreach (TableRow tr in t.Rows)
        {
            foreach (TableCell tc in tr.Cells)
            {
                foreach (Control c in tc.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        tbox = (TextBox)c;
                        arl.Add(tbox.Text);

                    }
                }
            }
        }
        return arl;
    }
    public ArrayList Gettextboxpanel(Panel pnl)
    {
        ArrayList arl = new ArrayList();
        Table t = (Table)pnl.FindControl("tb1");
        TextBox tbox;


        foreach (TableRow tr in t.Rows)
        {
            foreach (TableCell tc in tr.Cells)
            {
                foreach (Control c in tc.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        tbox = (TextBox)c;
                        arl.Add(tbox.Text);

                    }
                }
            }
        }
        return arl;
    }
    public Panel settextboxpanel(int numb, Panel pnl, string[,] txtname, string cssclass, int[] Requriedfielarray)
    {
        Table tb = new Table();
        tb.ID = "tb1";
        TableRow tr = new TableRow();


        for (int i = 0; i < numb; i++)
        {
            tr = new TableRow();
            TextBox tbox = new TextBox();
            tbox.ID = "txt" + txtname[i, 0] + txtname[i, 1];



            TableCell tc = new TableCell();

            tr.Controls.Add(newCell(txtname[i, 0] + " " + txtname[i, 1], cssclass));
            tc = new TableCell();
            tc.Controls.Add(tbox);
            tr.Cells.Add(tc);
            tc = new TableCell();
            bool val = false;
            for (int j = 0; j < Requriedfielarray.Length; j++)
            {
                if (i == Requriedfielarray[j])
                    val = true;
            }
            if (!val)
            {
                RequiredFieldValidator reqfield = new RequiredFieldValidator();
                reqfield.ControlToValidate = "txt" + txtname[i, 0] + txtname[i, 1];
                reqfield.CssClass = "Validation";

                reqfield.ErrorMessage = "*";
                tc.Controls.Add(reqfield);
                tr.Cells.Add(tc);
            }
            tb.Rows.Add(tr);
        }
        pnl.Controls.Add(tb);
        return pnl;
    }
    public Panel settextboxpanel(int tabelindex, int numb, Panel pnl, string[,] txtname, string cssclass, int[] Requriedfielarray, string multiline)
    {
        Table tb = new Table();
        tb.ID = "tb" + tabelindex.ToString();
        tb.BorderColor = System.Drawing.Color.Black;
        tb.BorderStyle = BorderStyle.Solid;
        tb.BorderWidth = 1;


        pnl.Controls.Add(new LiteralControl(txtname[0, 1]));
        TableRow tr = new TableRow();


        for (int i = 0; i < numb; i++)
        {
            tr = new TableRow();
            TextBox tbox = new TextBox();
            tbox.ID = "txt" + txtname[i, 0] + txtname[i, 1];
            if (multiline == "yes")
            {
                tbox.TextMode = TextBoxMode.MultiLine;
                tbox.Height = 200;
            }

            TableCell tc = new TableCell();

            tr.Controls.Add(newCell(txtname[i, 0] + " ", cssclass));
            tc = new TableCell();
            tc.Controls.Add(tbox);
            tr.Cells.Add(tc);
            tc = new TableCell();
            bool val = false;
            for (int j = 0; j < Requriedfielarray.Length; j++)
            {
                if (i == Requriedfielarray[j])
                    val = true;
            }
            if (!val)
            {

                RequiredFieldValidator reqfield = new RequiredFieldValidator();
                reqfield.ControlToValidate = "txt" + txtname[i, 0] + txtname[i, 1];
                reqfield.CssClass = "Validation";

                reqfield.ErrorMessage = "*";
                tc.Controls.Add(reqfield);
                tr.Cells.Add(tc);
            }
            tb.Rows.Add(tr);
        }
        pnl.Controls.Add(tb);
        pnl.Controls.Add(new LiteralControl("<br />"));
        return pnl;
    }
    private TableCell newCell(String cellText, string cssclass)
    {
        return newCell(cellText, HorizontalAlign.Left, cssclass);
    }
    private TableCell newCell(String cellText, HorizontalAlign alignment, String cssClass)
    {
        return newCell(cellText, alignment, cssClass, 1);
    }
    private TableCell newCell(String cellText, HorizontalAlign alignment, String cssClass, Int32 colSpan)
    {
        TableCell tc = new TableCell();
        tc.Text = cellText;
        tc.HorizontalAlign = alignment;
        tc.VerticalAlign = VerticalAlign.Top;
        tc.CssClass = cssClass;
        tc.Width = 150;
        tc.ColumnSpan = colSpan;
        return tc;
    }
    public string constr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
    public DataTable sel(string qry)
    {
        SqlConnection con = new SqlConnection(constr); con.Open();
        SqlDataAdapter da = new SqlDataAdapter(qry, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Close();
        return dt;
    }
    public decimal ConvertGOOG(decimal amount, string fromCurrency, string toCurrency)
    {
        WebClient web = new WebClient();
        string url = string.Format("http://www.google.com/ig/calculator?hl=en&q={2}{0}%3D%3F{1}", fromCurrency.ToUpper(), toCurrency.ToUpper(), amount);
        string response = web.DownloadString(url);
        Regex regex = new Regex("rhs: \\\"(\\d*.\\d*)");
        decimal rate = System.Convert.ToDecimal(regex.Match(response).Groups[1].Value);
        return rate;
    }
    public DropDownList PopulateDropDownlist(DropDownList ddl, string DefaultDropDownText, DataTable dt, string DDLTextColumn, string DDLValueColumn)
    {
        bool val = true;

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (DefaultDropDownText == dt.Rows[i][DDLTextColumn].ToString() || DefaultDropDownText == dt.Rows[i][DDLValueColumn].ToString())
            {
                val = false;

            }

        }
        ddl.Items.Clear();

        ListItem li = new ListItem();
        li.Text = DefaultDropDownText;
        li.Value = DefaultDropDownText; ;
        ddl.Items.Add(li);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            li = new ListItem();
            li.Text = dt.Rows[i][DDLTextColumn].ToString();
            li.Value = dt.Rows[i][DDLValueColumn].ToString();
            ddl.Items.Add(li);
        }
        return ddl;
    }
    public DropDownList PopulateDropDownlist(DropDownList ddl, string Newdefaulttext, string DefaultDropDownText, DataTable dt, string DDLTextColumn, string DDLValueColumn)
    {
        bool val = false;

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (Newdefaulttext == dt.Rows[i][DDLTextColumn].ToString() || DefaultDropDownText == dt.Rows[i][DDLValueColumn].ToString())
            {
                val = true;

            }

        }
        if (val)
        {
            ddl.Items.Clear();

            ListItem li = new ListItem();
            li.Text = Newdefaulttext;
            li.Value = Newdefaulttext; ;
            ddl.Items.Add(li);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                li = new ListItem();
                li.Text = dt.Rows[i][DDLTextColumn].ToString();
                li.Value = dt.Rows[i][DDLValueColumn].ToString();
                ddl.Items.Add(li);
            }
        }
        else
        {
            ddl.Items.Clear();

            ListItem li = new ListItem();
            li.Text = DefaultDropDownText;
            li.Value = DefaultDropDownText; ;
            ddl.Items.Add(li);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                li = new ListItem();
                li.Text = dt.Rows[i][DDLTextColumn].ToString();
                li.Value = dt.Rows[i][DDLValueColumn].ToString();
                ddl.Items.Add(li);
            }
        }
        return ddl;
    }
    public DataTable GetDatatableHeader(string columnslist)
    {
        string[] ar;
        DataTable dt = new DataTable();
        ar = columnslist.Split(',');
        for (int i = 0; i < ar.Length; i++)
        {
            dt.Columns.Add(ar[i]);
        }
        return dt;




    }
    public bool ValidateFileDimensions(FileUpload FileUpload1, int width, int height)
    {
        using (System.Drawing.Image myImage =
               System.Drawing.Image.FromStream(FileUpload1.PostedFile.InputStream))
        {
            return (myImage.Height == height && myImage.Width == width);
        }
    }
    public string fileupload(FileUpload flupload, string id, string path)
    {
        string m_ext = "";
        if (flupload.FileName != "")
        {
            try
            {
                ArrayList fn = new ArrayList();// = flupload.FileName[.Substring(0,FileUpload1.FileName.Length);
                int ind = 0;
                string Extension = "";

                for (int i = flupload.FileName.Length - 1; i > 0; i--)
                {
                    ind++;
                    if (flupload.FileName[i] == '.')
                    {

                        Extension = flupload.FileName.Substring(i, ind);

                    }
                }

                //string Extension = flupload.FileName.Substring(i, 3);
                m_ext = Extension;
                string fln = path + id + "." + Extension.Substring(1);
                flupload.SaveAs(HttpContext.Current.Server.MapPath(fln));
                // Response.Write(m_ext);
                return m_ext;
            }
            catch (Exception ex)
            {
                return "";
            }

        }
        else
            return "";
    }
    public string StringFilterEncoder(string SourceString, string FilterString)
    {

        return SourceString.Replace(SourceString, FilterString);

    }
    public string StringFilterdecoder(string SourceString, string FilterString)
    {
        return SourceString.Replace(SourceString, FilterString);

    }
    public GridView GridDataBind(GridView gv, DataTable dt)
    {
        gv.DataSource = dt;
        gv.DataBind();
        return gv;
    }


}