using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    abstract class ReportTemplate
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Report Header");
            FetchData();
            FormatData();
            DisplayReport();
        }

        protected abstract void FetchData();
        protected abstract void FormatData();
        private void DisplayReport()
        {
            Console.WriteLine("Displaying Report");
        }
    }
}
