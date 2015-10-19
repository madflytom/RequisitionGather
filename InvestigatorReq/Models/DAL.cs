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
            // create requisition object
            Requisition testReq = new Requisition();

            //Accession ID will come through as part of the link (QR Code)
            testReq.AccessionID = requisitionID;

            //Investigator, Project ID, Sponsor, Visit Description, etc. will neeed actual methods to retreive the data from database
            //based on the accession ID that was passed.
            testReq.Investigator = "Dr. Demo";
            testReq.ProjectID = "ABCD123";
            testReq.Sponsor = "Medium Pharmaceutical, Inc.";
            testReq.VisitDescription = "Screening Visit";

            //Question array will have to be pulled from the demographic and administration questions that are stored in the database
            //for study design.  Questions below are for demonstration purposes.
            string dateOfBirth = "<label for='day'>Date of Birth</label><div id='date2' class='datefield'><input id = 'day' type='tel' maxlength='2' placeholder='DD' required /> / <input id = 'month' type='tel' maxlength='2' placeholder='MM' required /> / <input id = 'year' type='tel' maxlength='4' placeholder='YYYY' required /></div>";
            testReq.ReqQuestions.Add(dateOfBirth);

            string patientWeight = "<label for='patientWeight'>Patient Weight</label><br /><input id='patientWeight' type='text' placeholder='Enter patient weight' required />";
            testReq.ReqQuestions.Add(patientWeight);

            string patientNumber = "<label for='patientNumber'>Patient Number</label><br /><input id='patientNumber' type='text' placeholder='Enter patient number' required />";
            testReq.ReqQuestions.Add(patientNumber);

            string isPatientFasting = "<label for='isPatientFasting'>Is Patient Fasting?</label><br /><input type='checkbox' id='isPatientFasting' required /> Check for Yes";
            testReq.ReqQuestions.Add(isPatientFasting);

            //Return the full requisition object to the requesting view.
            return testReq;
        }
    }
}