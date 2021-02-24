namespace TotalInventory
{
    public static class DB_Configuration
    {
        public static readonly string ConnectionString = @"Data Source=DESKTOP-3R33MSJ\SQLEXPRESS;Initial Catalog=TotalInventory;Integrated Security=True";
                               
        public static readonly string SP_GET_TOTAL_INVENTORY = "[dbo].[GET_TOTAL_INVENTORY]";

        public static readonly string SP_GET_TOTAL_PRODUCT = "[dbo].[GET_TOTAL_PRODUCT]";

        public static readonly string SP_GET_TOTAL_SEMI_FINISHED = "[dbo].[GET_TOTAL_SEMI_FINISHED]";

        public static readonly string SP_GET_DETAIL_INVENTORY = "[dbo].[GET_DETAIL_INVENTORY]";

        public static readonly string SP_GET_DETAIL_PRODUCT = "[dbo].[GET_DETAIL_PRODUCT]";

        public static readonly string SP_GET_DETAIL_SEMI_FINISHED = "[dbo].[GET_DETAIL_SEMI_FINISHED]";

        public static readonly string FUNC_GET_CLOSED_MONTHS_tqtInOut = "SELECT * FROM [dbo].[getClosedMonthsTqtInOut]() ORDER BY [Closed months] DESC";

        public static readonly string FUNC_GET_CLOSED_MONTHS_tqtInOutCKD = "SELECT * FROM [dbo].[getClosedMonthsTqtInOutCKD]() ORDER BY [Closed months] DESC";

        public static readonly string FUNC_GET_CLOSED_MONTHS_tmtInOutProd = "SELECT * FROM [dbo].[getClosedMonthsTmtInOutProd]() ORDER BY [Closed months] DESC";

        public static readonly string FUNC_GET_CLOSED_MONTHS_tmtInOutSemi = "SELECT * FROM [dbo].[getClosedMonthsTmtInOutSemi]() ORDER BY [Closed months] DESC";
    }
}
