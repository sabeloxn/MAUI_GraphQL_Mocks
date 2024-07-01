
namespace SampSupps.Models;

public class items : BaseEntity
    {
        
        public string name {get; set;}
        
        public string[] tags {get; set;}
        
        public decimal price {get; set;}
        
        public int quantity {get; set;}
    }