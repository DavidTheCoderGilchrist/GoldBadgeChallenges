using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChallengeTwo_Repository;


namespace ChallengeTwo_Tests
{
    [TestClass]
    public class ChallengeTwoTests
    {
        private ClaimsContentRepository claimsTest = new ClaimsContentRepository();
       

        [TestInitialize]
        private void SeedClaimList()
        {
            ClaimsContent claimOne = new ClaimsContent(1, ClaimType.Car, "Car accident on 465", 400.00m, new DateTime(2018, 4, 25), new DateTime.Day(2018, 4, 27), true);
            ClaimsContent claimTwo = new ClaimsContent(2, ClaimType.Home, "House fire in kitchen", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 27), true);
            ClaimsContent claimThree = new ClaimsContent(3, ClaimType.Theft, "Stolen pancakes", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 4, 27), false);

            claimsTest.AddNewClaim(claimOne);
            claimsTest.AddNewClaim(claimTwo);
            claimsTest.AddNewClaim(claimThree);
        }

        [TestMethod]
        public void SeeAllClaimsTestMethod()
        {
            claimsTest.SeeAllClaims();
        }

        [TestMethod]
        public void NextClaimTestMethod()
        {
            claimsTest.NextClaim ();
        }

        [TestMethod]
        public void TakeAwayClaimTestMethod()
        {
            claimsTest.TakeAwayClaim();
        }

        
    }
}
