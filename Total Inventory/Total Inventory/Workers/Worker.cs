using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace QueryResultPrinter.Workers
{
    public static class Worker
    {
        public static List<string> ChangeSelectionOrder(string formName, List<string> originalSelectionOrder)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>()
            {
                {
                    "TotalInventoryStatus", originalSelectionOrder.OrderBy(i => i == "Semi-finished In/Out")
                                                                  .ThenBy(i => i == "Product In/Out")
                                                                  .ThenBy(i => i == "CKD")
                                                                  .ThenBy(i => i == "Material In/Out").ToList()
                },

                {
                    "Product In/Out", originalSelectionOrder.OrderBy(i => i == "SK_Depot_Assembly")
                                                            .ThenBy(i => i == "HMMC Buffer")
                                                            .ThenBy(i => i == "PCZ Shipping")
                                                            .ThenBy(i => i == "Disassembly").ToList()
                },

                {
                    "Semi-finished In/Out", originalSelectionOrder.OrderBy(i => i =="D1010")
                                                                  .ThenBy(i => i == "D1020")
                                                                  .ThenBy(i => i == "D2020")
                                                                  .ThenBy(i => i == "D3010")
                                                                  .ThenBy(i => i == "D3015")
                                                                  .ThenBy(i => i == "D3020")
                                                                  .ThenBy(i => i == "D3030")
                                                                  .ThenBy(i => i == "D5010")
                                                                  .ThenBy(i => i == "D5015")
                                                                  .ThenBy(i => i == "D5020")
                                                                  .ThenBy(i => i == "D5025")
                                                                  .ThenBy(i => i == "D5030")
                                                                  .ThenBy(i => i == "D6010")
                                                                  .ThenBy(i => i == "D9230")
                                                                  .ThenBy(i => i == "D9240").ToList()                                                         
                }
            };

            return dictionary[formName];
        }

        public static void AddSecondArguments(string formName, SqlCommand sqlCommand, string argument)
        {

            Action<SqlCommand> addSecondArgumentActionForTotalInventory = sqlCommand =>
            {
                sqlCommand.Parameters.Add("@costAccount", System.Data.SqlDbType.NVarChar, 35);
                sqlCommand.Parameters["@costAccount"].Value = argument;
            };

            Action<SqlCommand> addSecondArgumentActionForProductionSemi = sqlCommand =>
                {
                    sqlCommand.Parameters.Add("@workname_EN", System.Data.SqlDbType.NVarChar, 40);
                    sqlCommand.Parameters["@workname_EN"].Value = argument;
                };

            Dictionary<string, Action<SqlCommand>> secondArgumentDictionary = new Dictionary<string, Action<SqlCommand>>()
            {
                {"TotalInventoryStatus", addSecondArgumentActionForTotalInventory},
                {"Semi-finished In/Out", addSecondArgumentActionForProductionSemi},
                {"Product In/Out", addSecondArgumentActionForProductionSemi}
            };

            secondArgumentDictionary[formName](sqlCommand);
        }
    }
}
