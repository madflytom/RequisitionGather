using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvestigatorReq.Models
{
    public class Requisition
    {
        String AccessionID { get; set; }
        List<object> ReqQuestions { get; set; }
    }
}