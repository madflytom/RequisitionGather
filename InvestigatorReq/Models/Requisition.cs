using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvestigatorReq.Models
{
    public class Requisition
    {
        public string AccessionID { get; set; }
        public string ProjectID { get; set; }
        public string Sponsor { get; set; }
        public string Investigator { get; set; }
        public string VisitDescription { get; set; }
        [AllowHtml]
        public List<string> ReqQuestions { get; set; }

        //constructor
        public Requisition() { ReqQuestions = new List<string>(); }
    }
}