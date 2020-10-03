using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace ChallengeTwo_Repository
{
    public class ClaimsContentRepository
    {
        private Queue<ClaimsContent> _listOfClaims = new Queue<ClaimsContent>();

        //See All Claims
        public void SeeAllClaims()
        {
            Console.WriteLine($"{"ID",10} {"Type",10} {"Description",30}{"Amount",10}{"DateOfIncident",20}{"DateOfClaim",20}{"IsValid",20}");

            foreach (ClaimsContent claim in _listOfClaims)
            {
                Console.WriteLine($"{claim.ClaimID,10} {claim.ClaimType, 10 }{claim.Description,30} {claim.ClaimAmount,10} {claim.DateOfAccident,20} {claim.DateOfClaim,20}{claim.IsValid,20}");
            }

        }

        //Next Claim

        public ClaimsContent NextClaim()
        {
            ClaimsContent next = _listOfClaims.Peek();
            Console.WriteLine("ClaimID: " + next.ClaimID + "\n" +
                "Type: " + next.ClaimType + "\n" +
                "Description: " + next.Description + "\n" +
                "Amount: " + next.ClaimAmount + "\n" +
                "Date of Incident: " + next.DateOfAccident + "\n" +
                "Date of Claim: " + next.DateOfClaim + "\n" +
                "Is Valid: " + next.IsValid);
            return next;
            
        }

        //Take Away Claim

        public void TakeAwayClaim()
        {
            _listOfClaims.Dequeue();
        }

        //Enter New Claim

        public void AddNewClaim (ClaimsContent addClaim)
        {
            _listOfClaims.Enqueue(addClaim);
        }
    }   
}
