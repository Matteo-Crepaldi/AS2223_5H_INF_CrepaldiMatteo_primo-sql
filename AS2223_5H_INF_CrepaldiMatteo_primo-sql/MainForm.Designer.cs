namespace AS2223_5H_INF_CrepaldiMatteo_primo_sql
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnFileDB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.txtParametro1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParametro3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParametro2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParametro5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParametro6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParametro4 = new System.Windows.Forms.TextBox();
            this.btnSelectQuery = new System.Windows.Forms.Button();
            this.txtPathQuery = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbQuery = new System.Windows.Forms.ComboBox();
            this.btnCaricaQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnEsporta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path database:";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPath.Location = new System.Drawing.Point(123, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(331, 27);
            this.txtPath.TabIndex = 1;
            // 
            // btnFileDB
            // 
            this.btnFileDB.Location = new System.Drawing.Point(460, 26);
            this.btnFileDB.Name = "btnFileDB";
            this.btnFileDB.Size = new System.Drawing.Size(27, 27);
            this.btnFileDB.TabIndex = 2;
            this.btnFileDB.Text = "...";
            this.btnFileDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFileDB.UseVisualStyleBackColor = true;
            this.btnFileDB.Click += new System.EventHandler(this.btnFileDB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Query:";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 266);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(475, 259);
            this.dataGrid.TabIndex = 5;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEsegui.Location = new System.Drawing.Point(136, 213);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(113, 33);
            this.btnEsegui.TabIndex = 6;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // txtParametro1
            // 
            this.txtParametro1.Location = new System.Drawing.Point(99, 538);
            this.txtParametro1.Name = "txtParametro1";
            this.txtParametro1.Size = new System.Drawing.Size(135, 23);
            this.txtParametro1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parametro 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Parametro 3:";
            // 
            // txtParametro3
            // 
            this.txtParametro3.Location = new System.Drawing.Point(99, 596);
            this.txtParametro3.Name = "txtParametro3";
            this.txtParametro3.Size = new System.Drawing.Size(135, 23);
            this.txtParametro3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Parametro 2:";
            // 
            // txtParametro2
            // 
            this.txtParametro2.Location = new System.Drawing.Point(99, 566);
            this.txtParametro2.Name = "txtParametro2";
            this.txtParametro2.Size = new System.Drawing.Size(135, 23);
            this.txtParametro2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Parametro 5:";
            // 
            // txtParametro5
            // 
            this.txtParametro5.Location = new System.Drawing.Point(359, 566);
            this.txtParametro5.Name = "txtParametro5";
            this.txtParametro5.Size = new System.Drawing.Size(135, 23);
            this.txtParametro5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Parametro 6:";
            // 
            // txtParametro6
            // 
            this.txtParametro6.Location = new System.Drawing.Point(359, 596);
            this.txtParametro6.Name = "txtParametro6";
            this.txtParametro6.Size = new System.Drawing.Size(135, 23);
            this.txtParametro6.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Parametro 4:";
            // 
            // txtParametro4
            // 
            this.txtParametro4.Location = new System.Drawing.Point(359, 538);
            this.txtParametro4.Name = "txtParametro4";
            this.txtParametro4.Size = new System.Drawing.Size(135, 23);
            this.txtParametro4.TabIndex = 13;
            // 
            // btnSelectQuery
            // 
            this.btnSelectQuery.Location = new System.Drawing.Point(460, 59);
            this.btnSelectQuery.Name = "btnSelectQuery";
            this.btnSelectQuery.Size = new System.Drawing.Size(27, 27);
            this.btnSelectQuery.TabIndex = 21;
            this.btnSelectQuery.Text = "...";
            this.btnSelectQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectQuery.UseVisualStyleBackColor = true;
            this.btnSelectQuery.Click += new System.EventHandler(this.btnSelectQuery_Click);
            // 
            // txtPathQuery
            // 
            this.txtPathQuery.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPathQuery.Location = new System.Drawing.Point(123, 59);
            this.txtPathQuery.Name = "txtPathQuery";
            this.txtPathQuery.Size = new System.Drawing.Size(331, 27);
            this.txtPathQuery.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(36, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Path query:";
            // 
            // cmbQuery
            // 
            this.cmbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuery.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbQuery.FormattingEnabled = true;
            this.cmbQuery.Location = new System.Drawing.Point(123, 92);
            this.cmbQuery.Name = "cmbQuery";
            this.cmbQuery.Size = new System.Drawing.Size(331, 28);
            this.cmbQuery.TabIndex = 22;
            this.cmbQuery.SelectedIndexChanged += new System.EventHandler(this.cmbQuery_SelectedIndexChanged);
            // 
            // btnCaricaQuery
            // 
            this.btnCaricaQuery.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaricaQuery.Location = new System.Drawing.Point(254, 213);
            this.btnCaricaQuery.Name = "btnCaricaQuery";
            this.btnCaricaQuery.Size = new System.Drawing.Size(113, 33);
            this.btnCaricaQuery.TabIndex = 23;
            this.btnCaricaQuery.Text = "Carica Query";
            this.btnCaricaQuery.UseVisualStyleBackColor = true;
            this.btnCaricaQuery.Click += new System.EventHandler(this.btnCaricaQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuery.Location = new System.Drawing.Point(123, 122);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(330, 74);
            this.txtQuery.TabIndex = 24;
            // 
            // btnEsporta
            // 
            this.btnEsporta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEsporta.Location = new System.Drawing.Point(185, 637);
            this.btnEsporta.Name = "btnEsporta";
            this.btnEsporta.Size = new System.Drawing.Size(113, 33);
            this.btnEsporta.TabIndex = 25;
            this.btnEsporta.Text = "Esporta";
            this.btnEsporta.UseVisualStyleBackColor = true;
            this.btnEsporta.Click += new System.EventHandler(this.btnEsporta_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 682);
            this.Controls.Add(this.btnEsporta);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnCaricaQuery);
            this.Controls.Add(this.cmbQuery);
            this.Controls.Add(this.btnSelectQuery);
            this.Controls.Add(this.txtPathQuery);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtParametro5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtParametro6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtParametro4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtParametro2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParametro3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParametro1);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFileDB);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Primo sql";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPath;
        private Button btnFileDB;
        private Label label2;
        private DataGridView dataGrid;
        private Button btnEsegui;
        private TextBox txtParametro1;
        private Label label3;
        private Label label4;
        private TextBox txtParametro3;
        private Label label5;
        private TextBox txtParametro2;
        private Label label6;
        private TextBox txtParametro5;
        private Label label7;
        private TextBox txtParametro6;
        private Label label8;
        private TextBox txtParametro4;
        private Button btnSelectQuery;
        private TextBox txtPathQuery;
        private Label label9;
        private ComboBox cmbQuery;
        private Button btnCaricaQuery;
        private TextBox txtQuery;
        private Button btnEsporta;
    }
}