using System;

namespace BloodClinic
{
    public class Donor : Member
    {
        public Donor(string firstName, string lastName, DateTime dateOfBirth, BloodType memberBloodType, string email) 
            : base(firstName, lastName, dateOfBirth, memberBloodType, email) {
            LastDonatedDate = DateTime.MinValue;
            NumTimesDonated = 0;
        }

        public DateTime LastDonatedDate { get; private set; }
        public int NumTimesDonated { get; private set; }

        public void Donate() {
            if ((DateTime.Now - LastDonatedDate).Days < 40) {
                throw new Exception("Donor cannot donate yet.");
            }

            LastDonatedDate = DateTime.Now;
            NumTimesDonated++;
        }

        public override void SendUpdate() {
            Console.WriteLine("\nHello donor!");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Num times donated: {NumTimesDonated}");
            Console.WriteLine($"Last Donation Date: {LastDonatedDate}\n");
        }

        public override string ToString() {
            string details = "";
            details += $"Name: {FullName}\n";
            details += $"Blood Type: {MemberBloodType.Letter}{MemberBloodType.Sign}\n";
            details += $"Last Donation Date: {LastDonatedDate}\n"; 
            return details;
        }
    }
}