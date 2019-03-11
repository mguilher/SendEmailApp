using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp.Objects
{
    public class ColumnObject
    {
        public string Value { get; set; }
        public string ReplaceKey { get; set; }
        public bool IsEmail { get; set; }
    }
}
