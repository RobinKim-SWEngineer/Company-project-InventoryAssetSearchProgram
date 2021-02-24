using TotalInventory;

namespace QueryResultPrinter
{
    public partial class ProductInOutDetail : TotalInventoryStatus
    {
        public ProductInOutDetail()
            :base()
        {
            labelTotalSummary.Text = "Total Product In/Out Summary";
            labelTotalDetail.Text = "Product In/Out Detail By Location";
            this.Text = "Product In/Out";
            this.Name = "Product In/Out";
        }
    }
}
