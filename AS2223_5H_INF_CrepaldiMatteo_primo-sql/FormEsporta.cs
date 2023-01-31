using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AS2223_5H_INF_CrepaldiMatteo_primo_sql
{
    public partial class FormEsporta : Form
    {
        DataTable dt;

        public FormEsporta(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        // Selezione del file .html utilizzato per esportare il contenuto di html

        private void btnFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog opDialog = new SaveFileDialog();

            opDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opDialog.Filter = "Html files (*.html)|*.html";
            opDialog.FilterIndex = 1;
            opDialog.RestoreDirectory = true;
            opDialog.InitialDirectory = @"C:/";

            DialogResult dialogResult = opDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) txtPath.Text = opDialog.FileName;
        }

        //  Esporta il contenuto di html per poi chiudere la form

        private void btnEsporta_Click(object sender, EventArgs e)
        {
            string html = ConvertToHTML(dt);

            if(txtPath.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Specificare il percorso del file di destinazione");
                return;
            }

            StreamWriter sw = new StreamWriter(txtPath.Text);

            sw.WriteLine(html);
            sw.Flush();
            sw.Close();

            MessageBox.Show("Esportazione avvenuta con successo");
            Process.Start("explorer.exe", txtPath.Text);
            this.Close();
        }

        //  Conversione del contenuto del dataTable in una table html

        string ConvertToHTML(DataTable dataTable)
        {
            StringBuilder html = new StringBuilder();
            string content;

            html.Append("<html><head><title>Table</title><style>table, tr, td, th { border: 1px solid black; padding: 5px; text-align: center; } </style></head><body><table><tr>");

            foreach (DataColumn dc in dataTable.Columns)
            {
                 html.Append($"<th>{dc.ColumnName}</th>");
            }

            html.Append("</tr>");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                html.Append("<tr>");

                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    content = dataRow[dataColumn.ColumnName].ToString();

                    if (string.IsNullOrEmpty(content.Trim()) && cbNull.Checked == true) html.Append($"<td>null</td>");
                    else html.Append($"<td>{content}</td>");
                }

                html.Append("</tr>");
            }

            return html + "</table></body></html>";
        }
    }
}
