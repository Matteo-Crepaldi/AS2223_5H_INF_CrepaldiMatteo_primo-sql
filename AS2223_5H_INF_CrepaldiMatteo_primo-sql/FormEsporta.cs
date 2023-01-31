using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2223_5H_INF_CrepaldiMatteo_primo_sql
{
    public partial class FormEsporta : Form
    {
        private string html;

        public FormEsporta(string html)
        {
            InitializeComponent();
            this.html = html;
        }

        // Selezione del file .html utilizzato per esportare il contenuto di html

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();

            opDialog.InitialDirectory = Application.StartupPath;
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
            StreamWriter sw = new StreamWriter(txtPath.Text);

            sw.Flush();

            sw.WriteLine(html);
            sw.Close();

            MessageBox.Show("Esportazione avvenuta con successo");
            this.Close();
        }
    }
}
