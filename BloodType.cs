using System.Text;
namespace BloodClinic
{
    public class BloodType
    {
        public BloodType(string letter, char sign)
        {
            Letter = letter;
            Sign = sign;
        }
        
        public string Letter { get; set; } //O, A, B, AB
        public char Sign { get; set; } // -/+

        public string GetBloodType()
        {
            return Letter + Sign;
        }
        // TODO: Implement this
        public bool CanDonateTo(BloodType otherBloodType)
        {
            byte[] otherBlood = Encoding.ASCII.GetBytes(otherBloodType.GetBloodType());
            byte[] donorBlook = Encoding.ASCII.GetBytes(this.GetBloodType());
            if (donorBlook.Length < otherBlood.Length)
            {
                return true;
            }
            else if (donorBlook.Length == otherBlood.Length)
            {
                for (int i = 0; i < donorBlook.Length; i++)
                {
                    if (donorBlook[i] < otherBlood[i])
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;




        }
    }
}