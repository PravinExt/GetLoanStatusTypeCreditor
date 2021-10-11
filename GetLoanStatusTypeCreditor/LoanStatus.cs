using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetLoanStatusTypeCreditor
{
    public class LoanStatus
    {
        public string Status_ID { get; set; }
        public int Status { get; set; }

    }

    public enum CreditorLoanStaus : int
    {
        Submitted = 1,
        InReview = 2,
        Rejected = 3,
        MoreInfoRequested = 4,
        Approved = 5,
        SentToDecisionEngine = 6,
        ApprovedbyDecisionEngine = 7,
        ClosedbyExternalService = 8

    }
}
