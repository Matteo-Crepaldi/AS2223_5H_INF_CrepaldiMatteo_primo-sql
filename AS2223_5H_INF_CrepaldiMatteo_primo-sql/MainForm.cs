using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace AS2223_5H_INF_CrepaldiMatteo_primo_sql
{
    public partial class MainForm : Form
    {
        List<Query> queryList;
        DataTable dt;

        public MainForm()
        {
            InitializeComponent();
            queryList = new List<Query>();
        }

        private void btnFileDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();

            opDialog.InitialDirectory = Application.StartupPath;
            opDialog.Filter = "Sqlite files (*.db)|*.db|Mdb files (*.mdb)|*mdb|Xls files (*.xls)|*xls";
            opDialog.FilterIndex = 1;
            opDialog.RestoreDirectory = true;
            opDialog.InitialDirectory = @"C:/";

            DialogResult dialogResult = opDialog.ShowDialog();

            if(dialogResult == DialogResult.OK) txtPath.Text = opDialog.FileName;
        }

        private void btnSelectQuery_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();

            opDialog.InitialDirectory = Application.StartupPath;
            opDialog.Filter = "Text files (*.txt)|*.txt";
            opDialog.FilterIndex = 1;
            opDialog.RestoreDirectory = true;
            opDialog.InitialDirectory = @"C:/";

            DialogResult dialogResult = opDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) txtPathQuery.Text = opDialog.FileName;
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source={txtPath.Text};Version=3", queryString = txtQuery.Text;

            if(txtPath.Text == "" || txtPathQuery.Text == "")
            {
                MessageBox.Show("Compilare tutti i campi");
                return;
            }

            if(cmbQuery.SelectedItem == null)
            {
                MessageBox.Show("Selezionare una query");
                return;
            }

             dt = new DataTable();

            queryString = ReplaceParameters(queryString);
            if (queryString == string.Empty) return;

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(queryString, connectionString);

            try 
            { 
                dataAdapter.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string ReplaceParameters(string input)
        {
            for(int K = 1; K <= 6; K++)
            {
                var txt = (TextBox)this.Controls.Find($"txtParametro{K}", true)[0];

                if (input.Contains($"@PAR{K}@"))
                {
                    if (txt.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show($"Inserire valore per @PAR{K}@");
                        return string.Empty;
                    }
                    else input = input.Replace($"@PAR{K}@", txt.Text);
                }
            }

            return input;
        }

        private List<Query> DecodeFile(string input)
        {
            List<Query> output = new List<Query>();
            string[] contentSplitted = input.Split('#'), rowSplitted;
            string content, titolo;

            foreach(string queryString in contentSplitted)
            {
                if (queryString == "") continue;

                content = "";

                rowSplitted = queryString.Split("\r\n");

                titolo = rowSplitted[0];

                content = string.Join(" ", rowSplitted.Skip(1));

                Query q = new Query(titolo, content.Trim());
                output.Add(q);
            }

            return output;
        }

        private void btnCaricaQuery_Click(object sender, EventArgs e)
        {
            string fileContent;

            try
            {
                StreamReader sr = new StreamReader(txtPathQuery.Text);
                fileContent = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            queryList = DecodeFile(fileContent);

            cmbQuery.DataSource = queryList;

            cmbQuery.DisplayMember = "Titolo";
            cmbQuery.ValueMember = "Contenuto";
        }

        private void cmbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = (Query)cmbQuery.SelectedItem;
            if (query != null) { txtQuery.Text = query.Contenuto; }
        }

        private void btnEsporta_Click(object sender, EventArgs e)
        {
            FormEsporta esporta = new FormEsporta(ConvertToHTML());

            esporta.ShowDialog();
        }

        string ConvertToHTML()
        {
            string html = "<html><head><title>Table</title><style>table, tr, td { border: 1px solid black; padding: 5px; text-align: center; } </style></head><body><table style=\"border\"><tr>", content;

            foreach(DataColumn dt in dt.Columns)
            {
                html += $"<td>{dt.ColumnName}</td>";
            }

            html += "</tr>";

            foreach(DataRow dataRow in dt.Rows)
            {
                html += "<tr>";

                foreach(DataColumn dataColumn in dt.Columns)
                {
                    content = dataRow[dataColumn.ColumnName].ToString();

                    if(content == null) html += $"<td>null</td>";
                    else html += $"<td>{content}</td>";
                }

                html += "</tr>";
            }

            return html + "</table></body></html>";
        }
    }
}