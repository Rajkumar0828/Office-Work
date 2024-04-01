using System.ComponentModel.DataAnnotations;
namespace APICrudclient.Models
{
public class OrderModel
{
    [Key]
    public int Order_Id { get; set; }
    public int  Customer_Id { get; set; }
    
    public DateTime Order_date { get; set; }

    public int  Total_price { get; set; }
}
}