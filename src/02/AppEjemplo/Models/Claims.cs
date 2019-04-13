using System;

namespace AppEjemplo.Models
{
    public partial class Claims
    {
        public int ClaimId { get; set; }
        public int PracticeAssociationId { get; set; }
        public short? ClaimStatus { get; set; }
        public short ClaimType { get; set; }
        public int? RelatedClaimId { get; set; }
        public bool IsEpsdt { get; set; }
        public string AuthorizationNumber { get; set; }
        public int? InsurerId { get; set; }
        public string InsurerName { get; set; }
        public string InsurerAddress1 { get; set; }
        public string InsurerAddress2 { get; set; }
        public string InsurerCity { get; set; }
        public string InsurerState { get; set; }
        public string InsurerZip { get; set; }
        public string SubscriberFirstName { get; set; }
        public string SubscriberLastName { get; set; }
        public char? SubscriberMiddleInitial { get; set; }
        public string SubscriberNameSuffix { get; set; }
        public string SubscriberAddress1 { get; set; }
        public string SubscriberAddress2 { get; set; }
        public string SubscriberCity { get; set; }
        public string SubscriberState { get; set; }
        public string SubscriberZip { get; set; }
        public DateTime SubscriberDOB { get; set; }
        public char SubscriberGender { get; set; }
        public string SubscriberPlanGroupNumber { get; set; }
        public string SubscriberEmployerName { get; set; }
        public string SubscriberId { get; set; }        
    }
}
