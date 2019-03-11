using SendMailApp.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp.Helpers
{
    public class TemplateParser
    {
        private string _template;
        public TemplateParser(string templatepath)
        {
            _template = File.ReadAllText(templatepath);
        }
        public string GetBodyMail(List<ColumnObject> dados)
        {
            return GetReplaceText(dados, _template);
        }

        public string GetReplaceText(List<ColumnObject> dados, string body)
        {
            foreach (ColumnObject obj in dados)
            {
                body = body.Replace(obj.ReplaceKey, obj.Value);
            }

            return body;
        }
    }
}
