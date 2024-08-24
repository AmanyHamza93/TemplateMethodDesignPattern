using TemplateMethodDesignPattern;

ReportTemplate pdfReport = new PdfReport();
pdfReport.GenerateReport();

ReportTemplate excelReport = new ExcelReport();
excelReport.GenerateReport();
