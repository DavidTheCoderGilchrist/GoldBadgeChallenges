using ChallengeTwo_Repository;
using System;


namespace ChallengeTwo_Console
{
    class ProgramUI
    {
        public ClaimsContentRepository _claimsRepo = new ClaimsContentRepository();
        
        public void Run()
        {
            SeedClaimList();
            Menu();
        }

        //Manager Menu
        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                //Display Options to Manager

                Console.Clear();
                Console.WriteLine("Komodo Claims Department Menu \n" +
                    "Please Select an Option\n" +
                    "\n" +
                    "1. See all claims\n" +
                    "2. Take care of the next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        _claimsRepo.SeeAllClaims();
                        Console.WriteLine("\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "2":
                        TakeNextClaim();                        
                        break;

                    case "3":
                        EnterNewClaim();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }

            }
                Console.WriteLine("\n" +
                    "Press any key to continue...");
                Console.ReadKey();
                
        }

        public void TakeNextClaim()
        {
            Console.Clear();

            ClaimsContent nextClaim = _claimsRepo.NextClaim();
            Console.WriteLine("Do you want to deal with this claim now (y/n)?");

            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                _claimsRepo.TakeAwayClaim();
                Console.WriteLine("Once finished.  Press any key to save");
                Console.ReadKey();
                Menu();
            }

            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("Press any key to return to Main Menu");
                Console.ReadKey();
                Menu();
            }

            else
            {
                Console.WriteLine("Please enter y or n\n" +
                    "\n" +
                    "Press any key to continue");
                Console.ReadKey();
                TakeNextClaim();
            }

        }

        private void EnterNewClaim()
        {
            Console.Clear();
            ClaimsContent newClaim = new ClaimsContent();
            Console.WriteLine("What is the claim ID?");
            string claimID = Console.ReadLine();
            newClaim.ClaimID = int.Parse(claimID);

            Console.WriteLine("What is the Claim Type: Car, Home, Theft?");

            string type = Console.ReadLine();

            if (type.ToLower() == "car")
            {
                ClaimType claimType = ClaimType.Car;                
            }

            else if (type.ToLower() == "home")
            {
                ClaimType claimType = ClaimType.Home;
            }

            else if (type.ToLower() == "theft")
            {
                ClaimType claimType = ClaimType.Theft;
            }

            else
            {
                Console.WriteLine("Please enter Car, Home, or Theft \n" +
                    "\n" +
                    "Press any key to continue");
                Console.ReadKey();
                EnterNewClaim();
            }

            Console.WriteLine("List the description of the claim?");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Amount?");
            string claimAmount = Console.ReadLine();
            newClaim.ClaimAmount = decimal.Parse(claimAmount);

            Console.WriteLine("What is Date of the Accident");
            string dateOfIncident = Console.ReadLine();
            newClaim.DateOfAccident = DateTime.Parse(dateOfIncident);

            Console.WriteLine("What is Date of the Claim");
            string dateOfClaim = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(dateOfClaim);

            Console.WriteLine("Is it valid (true or false)");
            string isValid = Console.ReadLine();
            newClaim.IsValid = bool.Parse(isValid);

            _claimsRepo.AddNewClaim(newClaim);

            Console.WriteLine("\n" +
                "Claim Added.\n" +
                "\n" +
                "Press any key to return to menu");
            Console.ReadKey();
            Menu();

        }

        private void SeedClaimList()
        {
            ClaimsContent claimOne = new ClaimsContent(1, ClaimType.Car, "Car accident on 465", 400.00m, new DateTime(2018,4,25), new DateTime(2018,4,27), true);
            ClaimsContent claimTwo = new ClaimsContent(2, ClaimType.Home, "House fire in kitchen", 4000.00m, new DateTime(2018,4,11), new DateTime(2018,4,27), true);
            ClaimsContent claimThree = new ClaimsContent(3, ClaimType.Theft, "Stolen pancakes", 4.00m, new DateTime(2018,4,27), new DateTime(2018,4,27), false);


            _claimsRepo.AddNewClaim(claimOne);
            _claimsRepo.AddNewClaim(claimTwo);
            _claimsRepo.AddNewClaim(claimThree);
        }
    }
}

