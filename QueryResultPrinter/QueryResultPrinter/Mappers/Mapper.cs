using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalInventory;

namespace QueryResultPrinter.Mappers
{
    public static class Mapper
    {
        public static string GetReferenceColumnName(string formName)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"TotalInventoryStatus", "Cost Account"}, 
                {"Semi-finished In/Out", "Location"},
                {"Product In/Out", "Location"}
            };

            return dictionary[formName];
        }

        public static string GetGridViewSummaryCommand(string formName)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"TotalInventoryStatus", DB_Configuration.SP_GET_TOTAL_INVENTORY},
                {"Product In/Out", DB_Configuration.SP_GET_TOTAL_PRODUCT},
                {"Semi-finished In/Out", DB_Configuration.SP_GET_TOTAL_SEMI_FINISHED}
            };

            return dictionary[formName];
        }

        public static string GetGirdViewDetailCommand(string forName)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"TotalInventoryStatus", DB_Configuration.SP_GET_DETAIL_INVENTORY},
                {"Product In/Out", DB_Configuration.SP_GET_DETAIL_PRODUCT},
                {"Semi-finished In/Out", DB_Configuration.SP_GET_DETAIL_SEMI_FINISHED}
            };

            return dictionary[forName];
        }
    }
}
