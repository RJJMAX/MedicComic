namespace MedicComic.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string Cardname { get; set; } = string.Empty;
        public string Cardtype { get; set; } = string.Empty;

        public int UserId { get; set; } 
        public User User { get; set; }
        public CreditCard() { }



    }
}
