using Newtonsoft.Json;
using SendMailApp.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendMailApp.Helpers;

namespace SendMailApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Config _config;
        private List<ComboValue> _configFiles;

        private void Form1_Load(object sender, EventArgs e)
        {
            _config = new Config();
            lbConfigs.DataSource = _config.ConfigColumns;
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            _configFiles = new List<ComboValue>();
            var configs = Directory.GetFiles(dir, "*.csvmailconfig");
            _configFiles.AddRange(configs.Select(a => new ComboValue() { Name = Path.GetFileNameWithoutExtension(a), Value = a }));

            cbConfigName.DataSource = _configFiles;
        }
        

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|HTML (*.html)|*.html|HTM (*.htm)|*.htm";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    txtTemplate.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnColAdd_Click(object sender, EventArgs e)
        {
            int position = 0;
            int.TryParse(txtPosition.Text, out position);
            _config.AddColumnConfig(txtColReplace.Text, position, cbColHeader.Text, ckbColMail.Checked);
            lbConfigs.DataSource = null;
            lbConfigs.DataSource = _config.ConfigColumns;

            txtColReplace.Text = "";
            cbColHeader.Text = "";
            ckbColMail.Checked = false;
            txtPosition.Text = "0";
        }

        private void btnFindConfig_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                openFileDialog.Filter = "Csv Mail Config (*.csvmailconfig)|*.csvmailconfig";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCsvFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnNewConfig_Click(object sender, EventArgs e)
        {
            cbColHeader.Text = "";
            txtColReplace.Text = "";
            cbConfigName.Text = "";
            //txtCsvFile.Text = "";
            txtEmail.Text = "";
            txtPort.Text = "";
            txtPosition.Text = "";
            txtSmtp.Text = "";
            txtSkipLines.Text = "";
            txtPwd.Text = "";
            txtSubject.Text = "";
            txtTemplate.Text = "";
        }

        private void btnDelColConfig_Click(object sender, EventArgs e)
        {
            if (lbConfigs.SelectedIndex >= 0)
            {
                _config.RemoveCsvConfig(lbConfigs.SelectedIndex);
                lbConfigs.DataSource = null;
                lbConfigs.DataSource = _config.ConfigColumns;
            }
            else
            {
                MessageBox.Show("Selecione uma configuração", "Configuração");
            }
        }

        private void cbConfigName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = (ComboValue)cbConfigName.SelectedItem;
            var json = File.ReadAllText(sel.Value);
            _config = JsonConvert.DeserializeObject<Config>(json);

            txtEmail.Text = _config.Email ?? "";
            txtPort.Text = _config.EmailPort.ToString();
            txtSmtp.Text = _config.EmailSmtp ?? "";
            txtSkipLines.Text = _config.Email ?? "";
            txtPwd.Text = _config.Pwd ?? "";
            txtSubject.Text = _config.EmailSubject ?? "";
            txtTemplate.Text = _config.TemplatePath ?? "";
            rbtHtml.Checked = _config.TemplateIsHtml;
            rbtSsl.Checked = _config.Ssl;
            rbtTsl.Checked = _config.Tsl;
            rbtNoCript.Checked = _config.Ssl==false && _config.Tsl==false;
            txtSkipLines.Text = _config.SkipLines.ToString();
            lbConfigs.DataSource = _config.ConfigColumns;
            txtCsvFile.Text = _config.SourcePath ?? "";
            cbSheets.Text = _config.Sheet ?? "";
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O e-mail deve ser preenchido", "Erro");
                txtEmail.Focus();
                return;
            }
            _config.Email = txtEmail.Text;

            int port=0;
            if(int.TryParse(txtPort.Text,out port))
            {
                _config.EmailPort = port;
            }
            else
            {
                MessageBox.Show("A porta smtp deve ser um valor numerico", "Erro");
                txtPort.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSmtp.Text))
            {
                MessageBox.Show("O servidor de smtp deve ser preenchido", "Erro");
                txtSmtp.Focus();
                return;
            }
            _config.EmailSmtp = txtSmtp.Text;

            _config.Pwd = txtPwd.Text;

            if (string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("O assunto do e-mail deve ser preenchido", "Erro");
                txtSubject.Focus();
                return;
            }

            _config.EmailSubject = txtSubject.Text;

            if (string.IsNullOrWhiteSpace(txtTemplate.Text))
            {
                MessageBox.Show("O template deve ser preenchido", "Erro");
                txtTemplate.Focus();
                return;
            }
            _config.TemplatePath = txtTemplate.Text;
            _config.TemplateIsHtml = rbtHtml.Checked;
            _config.Ssl = rbtSsl.Checked;
            _config.Tsl = rbtTsl.Checked;

            if (!string.IsNullOrWhiteSpace(txtSkipLines.Text))
            {
                int skip = 0;
                if (int.TryParse(txtSkipLines.Text, out skip))
                {
                    _config.SkipLines = skip;
                }
                else
                {
                    MessageBox.Show("Numero de linhas a pular deve ser um valor numerico", "Erro");
                    txtSkipLines.Focus();
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(cbConfigName.Text))
            {
                MessageBox.Show("O nome da configuração deve ser preenchido", "Erro");
                cbConfigName.Focus();
                return;
            }

            _config.SourcePath = txtCsvFile.Text;
            _config.Sheet = cbSheets.Text;

            string fileName = $"{AppDomain.CurrentDomain.BaseDirectory}\\{cbConfigName.Text}.csvmailconfig";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            string output = JsonConvert.SerializeObject(_config);
            File.WriteAllText(fileName, output);

            MessageBox.Show("Configuração salva", "Alerta");
        }

        private void btnFindCsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "xlsx (*.xlsx)|*.xlsx|xls (*.xls)|*.xls|txt files (*.txt)|*.txt|CSV (*.csv)|*.csv";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    txtCsvFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnLoadColumns_Click(object sender, EventArgs e)
        {
            var eh = new ExcelHelper((a) => { MessageBox.Show(a, "Erro"); });
            cbSheets.DataSource= eh.GetSheetNames(txtCsvFile.Text);
        }

        private void cbColHeader_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var eh = new ExcelHelper((a) => { MessageBox.Show(a, "Erro"); });
            cbColHeader.DataSource = eh.GetSheetColumnNames(txtCsvFile.Text,cbSheets.SelectedItem.ToString());
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            _config.Pwd = txtPwd.Text;
            if (_config.Valid())
            {
                var eh = new ExcelHelper((a) => { MessageBox.Show(a, "Erro"); });
                eh.SendMail(_config, txtCsvFile.Text);
                MessageBox.Show("Emails enviados", "Alerta");
            }
            else
            {
                MessageBox.Show("Configuração invalida", "Alerta");
            }
        }
    }
}
