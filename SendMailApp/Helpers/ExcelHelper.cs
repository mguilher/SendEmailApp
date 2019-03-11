using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendMailApp.Objects;

namespace SendMailApp.Helpers
{
    public class ExcelHelper
    {
        private Action<string> _log;

        public ExcelHelper(Action<string> log)
        {
            _log = log;
        }

        public List<string> GetSheetNames(string file)
        {
            try
            {
                string connString =$"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={file};Extended Properties=Excel 8.0;";

                if (file.TrimEnd().ToLower().EndsWith("x"))
                {
                    connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{file}';" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                }

                using (var objConn = new OleDbConnection(connString))
                {
                    objConn.Open();
                    System.Data.DataTable dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (dt == null)
                    {
                        return null;
                    }

                    var result = new List<string>(dt.Rows.Count);

                    foreach (DataRow row in dt.Rows)
                    {
                        result.Add(row["TABLE_NAME"].ToString());
                    }


                    return result;
                }
            }
            catch (Exception ex)
            {
                _log?.Invoke(ex.ToString());
                return null;
            }
        }


        public List<string> GetSheetColumnNames(string file,string table)
        {
            try
            {
                string connString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={file};Extended Properties=Excel 8.0;";

                if (file.TrimEnd().ToLower().EndsWith("x"))
                {
                    connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{file}';Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                }

                using (var objConn = new OleDbConnection(connString))
                {
                    objConn.Open();
                    System.Data.DataTable dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new Object[] { null, null, table, null });
                    if (dt == null)
                    {
                        return null;
                    }

                    var result = new List<string>(dt.Rows.Count);
                    //COLUMN_NAME
                    foreach (DataRow row in dt.Rows)
                    {
                        result.Add(row["COLUMN_NAME"].ToString());
                    }



                    return result;
                }
            }
            catch (Exception ex)
            {
                _log?.Invoke(ex.ToString());
                return null;
            }
        }



        private DataTable LoadXLS(string strFile, String sheetName, String column, String value)
        {
            DataTable dtXLS = new DataTable("XLS");
            try
            {
                string strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection SQLConn = new OleDbConnection(strConnectionString);
                SQLConn.Open();
                OleDbDataAdapter SQLAdapter = new OleDbDataAdapter();
                OleDbCommand selectCMD = new OleDbCommand("SELECT * FROM [" + sheetName + "$] WHERE " + column + " = @" + column, SQLConn);
                selectCMD.Parameters.Add("@" + column, OleDbType.VarChar).Value = value;
                SQLAdapter.SelectCommand = selectCMD;

                SQLAdapter.Fill(dtXLS);
                SQLConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dtXLS;
        }



        public void SendMail(Config _config,string file)
        {
            try
            {

                string connString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={file};Extended Properties=Excel 8.0;";

                if (file.TrimEnd().ToLower().EndsWith("x"))
                {
                    connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{file}';Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                }

                using (var conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand($" select * from [{_config.Sheet}] ", conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    var tpParser = new TemplateParser(_config.TemplatePath);
                    var sm=new SendMail(_config);

                    while (reader.Read())
                    {
                        var row=new List<ColumnObject>();
                        string email = "";
                        foreach (ColumnConfig c in _config.ConfigColumns)
                        {
                            var cc = new ColumnObject();
                            cc.Value=reader.GetValue(c.Position).ToString();
                            cc.ReplaceKey = c.ReplaceKey;
                            cc.IsEmail = c.IsMailColumn;
                            if (c.IsMailColumn)
                            {
                                email = cc.Value;
                            }
                            row.Add(cc);
                        }


                        sm.Send(email, tpParser.GetBodyMail(row), tpParser.GetReplaceText(row, _config.EmailSubject),_config.TemplateIsHtml);
                    }
                }
            }
            catch (Exception ex)
            {
                _log?.Invoke(ex.ToString());
            }

        }



    }
}
