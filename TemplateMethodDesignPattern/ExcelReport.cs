using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TemplateMethodDesignPattern
{
    internal class ExcelReport : ReportTemplate
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching Data for Excel Report") ;
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting Data for Excel Report") ;
        }
    }
}
