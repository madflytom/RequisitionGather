using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvestigatorReq.Models
{
    public class Requisition
    {
        public String AccessionID { get; set; }
        [AllowHtml]
        public List<string> ReqQuestions { get; set; }

        //constructor
        public Requisition() { ReqQuestions = new List<string>(); }
    }
}