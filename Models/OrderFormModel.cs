namespace dotnetdodo.Models
{
public class OrderFormModel
{
    //public OrderFormModel OrderFormModel => ViewData.Model as OrderFormModel;

    public List<int> Widths { get; set; }
    public List<int> Demands { get; set; }
    public int StockItemWidth { get; set; }
}
}