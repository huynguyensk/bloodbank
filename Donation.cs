using System;

namespace BloodClinic
{
    public class Donation
    {
        public Guid Id { get; set; }
        public Donor Donor { get; set; }
        public DateTime DonationDate { get; set; }

        public Donation(Donor donor,DateTime donationDate){
            Donor = donor;
            DonationDate = donationDate;
        }
        public Donation(){
            
        }
    }
}