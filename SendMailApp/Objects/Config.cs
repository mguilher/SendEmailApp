using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp.Objects
{
    public class Config
    {
        public string Email { get; set; }
        public string Pwd { get; set; }

        public string TemplatePath { get; set; }
        public bool TemplateIsHtml { get; set; }

        public string EmailSubject { get; set; }

        public string EmailSmtp { get; set; }

        public int EmailPort { get; set; }

        public int SkipLines { get; set; }

        public bool Ssl { get; set; }
        public bool Tsl { get; set; }


        public string Sheet { get; set; }

        public Config()
        {
            ConfigColumns = new List<ColumnConfig>();
        }

        public List<ColumnConfig> ConfigColumns { get; set; }
        public string SourcePath { get; set; }

        public void AddColumnConfig(string replaceKey, int position, string key, bool isMailColumn)
        {
            int id = ConfigColumns.Count + 1;
            ConfigColumns.Add(new ColumnConfig() { Id = id, ReplaceKey = replaceKey, Position = position, Key = key, IsMailColumn = isMailColumn });
        }

        public void RemoveCsvConfig(int id)
        {
            id++;
            var cf = ConfigColumns.FirstOrDefault(a => a.Id == id);
            if (cf != null)
            {
                ConfigColumns.Remove(cf);

                for (int i = 0; i < ConfigColumns.Count; i++)
                {
                    ConfigColumns[i].Id = i + 1;
                }
            }
        }


        public string GetQuery()
        {
            var sb=new StringBuilder();
            sb.Append("select ");
            for (var i = 0; i < ConfigColumns.Count; i++)
            {
                ColumnConfig column = ConfigColumns[i];
                sb.Append(column.Key);
                if (i < ConfigColumns.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append($" from [{Sheet}] ");
            return sb.ToString();
        }

        public bool Valid()
        {
            return !string.IsNullOrWhiteSpace(Email) &&
                   !string.IsNullOrWhiteSpace(EmailPort.ToString()) &&
            !string.IsNullOrWhiteSpace(EmailSmtp) &&
            !string.IsNullOrWhiteSpace(Email) &&
            !string.IsNullOrWhiteSpace(Pwd) &&
            !string.IsNullOrWhiteSpace(EmailSubject) &&
            !string.IsNullOrWhiteSpace(TemplatePath) &&
            !string.IsNullOrWhiteSpace(SkipLines.ToString()) &&
            ConfigColumns.Count>0;
        }
    }

    public class ColumnConfig
    {
        public int Id { get; set; }
        public bool IsMailColumn { get; set; }
        public string Key { get; set; }
        public int Position { get; set; }
        public string ReplaceKey { get; set; }

        public override string ToString()
        {
            return $"{Id}-Coluna:{Key}- Posição:{Position}-Substituição:{ReplaceKey}";
        }
    }
    
}
