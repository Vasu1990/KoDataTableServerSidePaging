using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KODatatableServerSidePaging.Models
{
    
        public class TableModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
        public class GlobalSearchText
        {
            public string value { get; set; }
            public string regex { get; set; }
        }
        public class DataTableConfig
        {
            public string ColumnName { get; set; }
            public bool IsSorted { get; set; }
            public string SearchText { get; set; }
            public bool IsSearchable { get; set; }
            public string SortDirection { get; set; }

        }
    
}