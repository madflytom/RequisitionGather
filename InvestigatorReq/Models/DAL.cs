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

            string dateOfBirth = "<label for='day'>Date of Birth</label><div id='date2' class='datefield'><input id = 'day' type='tel' maxlength='2' placeholder='DD' required /> / <input id = 'month' type='tel' maxlength='2' placeholder='MM' required /> / <input id = 'year' type='tel' maxlength='4' placeholder='YYYY' required /></div>";
            testReq.ReqQuestions.Add(dateOfBirth);

            string patientWeight = "<label for='patientWeight'>Patient Weight</label><br /><input id='patientWeight' type='text' placeholder='Enter patient weight' required />";
            testReq.ReqQuestions.Add(patientWeight);

            string patientNumber = "<label for='patientNumber'>Patient Number</label><br /><input id='patientNumber' type='text' placeholder='Enter patient number' required />";
            testReq.ReqQuestions.Add(patientNumber);

            string isPatientFasting = "<label for='isPatientFasting'>Is Patient Fasting?</label><br /><input type='checkbox' id='isPatientFasting' required /> Check for Yes";
            testReq.ReqQuestions.Add(isPatientFasting);

            return testReq;
        }
    }
}