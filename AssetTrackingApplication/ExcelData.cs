using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingApplication
{
    public class ExcelData {
        public ExcelData(string name) {
            Name = name;
        }

        public string Name { get; set; }
    }

    public class ExcelRowList : ExcelData {
        public ExcelRowList(string name, int row) : base(name) {
            Name = name;
            Row = row;
        }

        public int Row { get; set; }

        public int GetAssetRow(string assetName, ExcelRowList assetList) {
            var assetRow =
                from a in assetList.Name
                where assetList.Name == assetName
                select assetList.Row;
            return assetRow.First();
        }
    }

    public class ExcelColumnList : ExcelData {
        public ExcelColumnList(string name, string column) : base(name) {
            Name = name;
            Column = column;
        }

        public string Column { get; set; }

        public string GetExcelColumn(string columnName, ExcelColumnList columnList) {
            var excelColumn =
                from column in columnList.Name
                where columnList.Name == columnName
                select columnList.Column;
            return excelColumn.First();
        }
    }
}
