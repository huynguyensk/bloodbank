using System;

namespace BloodClinic
{
    public interface IStoreDonors
    {
        void Create(Donor donorToCreate);
        Donor GetById(Guid donorId);
    }
}