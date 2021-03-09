using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PCZInventory.Model
{
    #nullable enable
    class QueryCommandModel
    {
        public string storedProcedure { get; set; }
        public DateTimePicker dateTimePicker { get; set; }
        public List<String>? userSelection { get; set; }

        public QueryCommandModel(string storedProcedure, DateTimePicker dateTimePicker, List<String>? userSelection)
        {
            this.storedProcedure = storedProcedure;
            this.dateTimePicker = dateTimePicker;
            this.userSelection = userSelection;
        }
    }
    #nullable disable
}
