using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace AS2223_5H_INF_CrepaldiMatteo_primo_sql
{
    public partial class MainForm : Form
    {
        //  Definizione delle variabili globali

        List<Query> queryList;
        DataTable dt;

        public MainForm()
        {
            InitializeComponent();
            queryList = new List<Query>();
            dt = new DataTable();
        }

        //  Selezione del file .db e .txt

        private void btnFileDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();

            opDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opDialog.Filter = "Sqlite files (*.db)|*.db|Mdb files (*.mdb)|*mdb|Xls files (*.xls)|*xls";
            opDialog.FilterIndex = 1;
            opDialog.RestoreDirectory = true;

            DialogResult dialogResult = opDialog.ShowDialog();

            if(dialogResult == DialogResult.OK) txtPath.Text = opDialog.FileName;
        }

        private void btnSelectQuery_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();

            opDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opDialog.Filter = "Text files (*.txt)|*.txt";
            opDialog.FilterIndex = 1;
            opDialog.RestoreDirectory = true;

            DialogResult dialogResult = opDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) txtPathQuery.Text = opDialog.FileName;
        }

        //  Button per l'eseczione della query selezionata

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source={txtPath.Text};Version=3", queryString = txtQuery.Text;

            //  Controllo per assicurarsi che i path dei file .db e .txt siano stati inseriti

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

            //  Creazione della dataTable, sostituzione dei parametri e esecuzione dell'interrogazione al database

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

        //  Sostituisce i parametri con i valori corrispondenti

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

        //  Conversione del contenuto del file delle query in una lista di oggetti Query

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

        //  Lettura del file query e rimepimento del comboBox

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

        //  Modifica del contenuto della textbox quando una diversa query è selezionata 

        private void cmbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = (Query)cmbQuery.SelectedItem;
            if (query != null) { txtQuery.Text = query.Contenuto; }
        }

        //  Chiamta della form per la seleziona del file di output

        private void btnEsporta_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Impossibile esportare: il dataGrid è vuoto");
                return;
            }

            FormEsporta esporta = new FormEsporta(dt);

            esporta.ShowDialog();
        }
    }
}