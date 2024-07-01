
namespace SampSupps.Models;
public class sale : BaseEntity
{
    
    public DateTime saleDate {get; set;}
    
    public items[] items {get; set;}
    
    public string storeLocation {get; set;}
    
    public customer customer {get; set;}
    
    public bool couponUsed {get; set;}

    public string purchaseMethod {get; set;}
}