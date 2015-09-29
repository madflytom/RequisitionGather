using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InvestigatorReq.Models;

namespace InvestigatorReq.Models
{
    public class DAL
    {
        public static Requisition BuildFormElements(string requisitionID)
        {
            // Method is just for demonstration purposes.  Creates HTML for the form to display to the user for the Req ID.

            Requisition testReq = new Requisition();

            testReq.AccessionID = requisitionID;
            string dateOfBirth = "<input type='text' placeholder='This is a test' />";
            testReq.ReqQuestions.Add(dateOfBirth);

            string patientWeight = "<input type='text' placeholder='Enter patient weight' />";
            testReq.ReqQuestions.Add(patientWeight);

            return testReq;
        }
    }
}