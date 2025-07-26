namespace PRELIM_LAB3_31A2_RAYMOND_PEDRIÑA.Models
{
    public class VIP : Customer
    {
        public string MembershipLevel { get; set; }

        public override string Description()
        {
            return $"Premium Customer: {Name}, Email: {Email}, Level: {MembershipLevel}";
        }
    }
}
