namespace BethanysPieShop.Models
{
    public class Pie
    {
        public int PieID { get; set; }
        public string PieName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription  { get; set; }  
        public string AllergyInformatioon   { get; set; }  
        public decimal Price { get; set; }  
        public string ImageURL { get; set; }    
        public string ImageThumnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
