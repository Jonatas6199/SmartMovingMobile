using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SmartMovingMobileApp.Models
{   
    //entidade do relatório
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Stream PdfFileStream { get; set; }
    }
}
