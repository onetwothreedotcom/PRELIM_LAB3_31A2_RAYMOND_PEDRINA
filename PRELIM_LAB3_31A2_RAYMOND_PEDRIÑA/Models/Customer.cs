namespace PRELIM_LAB3_31A2_RAYMOND_PEDRIÑA.Models
{
    public class Customer : BaseEntity, IDescribable
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual string Description()
        {
            return $"Customer: {Name}, Email: {Email}";
        }
    }

}
