using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for DDJobDescription
/// </summary>
public class DDJobDescription
{
public DDJobDescription()
{
	//
	// TODO: Add constructor logic here
	//
}
public string job_desc_id { get;set;}
public string Company_id { get; set; }
//public string  Regions {get;set;}
public string  JobCategory {get;set;}
public string  JobType {get;set;}
public string  JobRequirements {get;set;}
public string  StartDate {get;set;}
public string  ContactPerson {get;set;}
public string  Position {get;set;}
public string  Email {get;set;}
public string  Telephon {get;set;}
public string  Address {get;set;}
public string CompanyLogo { get; set; }
public string  JobDescriptions {get;set;}
    public int  kobenhavn { get; set; }
    public int sjalland { get; set; }
    public int bornholm { get; set; }
    public int fyn { get; set; }
    public int midtjylland { get; set; }
    public int nordjylland { get; set; }
    public int sydjylland { get; set; }
    public int andet { get; set; }

    public int Fuldtid { get; set; }
    public int Deltid { get; set; }
    public int Frivillig { get; set; }
    public int Fleksjob { get; set; }
    public int Lontilskud { get; set; }
    public int Besogsven { get; set; }
    public int Praktik { get; set; }
    public int Pensionist { get; set; }
    public int Vikar { get; set; }
    public int Elevplads { get; set; }

    public int license { get; set; }
    public int storlicense { get; set; }
    public int fluentdanish { get; set; }

}
