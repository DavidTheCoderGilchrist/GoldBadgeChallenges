using System;

namespace ChallengeTwo_Repository
{
    public enum ClaimType
    {
        Car,
        Home,
        Theft,
    }
    
    public class ClaimsContent
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfAccident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public ClaimsContent() { }

        public ClaimsContent(int claimID, ClaimType claimType, string description, decimal claimAmount, DateTime dateOfAccident, DateTime dateofClaim, bool isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateofClaim;
            IsValid = isValid;
        }
    }
}
