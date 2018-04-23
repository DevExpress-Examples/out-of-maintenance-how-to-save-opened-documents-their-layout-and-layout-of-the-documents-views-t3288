using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXSample {
    public class ModuleDescription {
        public ModuleDescription(string documentType, string title){
            DocumentType = documentType;
            Title = title;
        }
        public string DocumentType { get; set;}
        public string Title { get; set; }
    }
}
