using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class ExcelFile
    {
        public int ExcelFileId { get; set; }
        public string Path { get; set; } = "excelfiles";
        public string Name { get; set; } = "template.xlsx";
        //public string Extension { get; set; } = "";
        public string FullPath => $"{Path}/{Name}";
        //public string FullName => $"{Name}.{Extension}";
    }
}
