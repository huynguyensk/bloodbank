using System;
using System.Collections.Generic;
using BloodClinic;

namespace comitbloodbank
{
    public class DonationStorageList : IStoreDonations
    {
        private List<Donation> _donations;
        public void Create(Donation donationToCreate)
        {
            _donations.Add(donationToCreate);
        }

        public Donation GetById(Guid donationId)
        {            
            foreach(var donation in _donations ){
                if(donation.Id == donationId){
                    Console.WriteLine($"Found Donation name! {donation.Donor.FullName}");
                    return donation;
                }
            }
            return null;            
        }
    }
}