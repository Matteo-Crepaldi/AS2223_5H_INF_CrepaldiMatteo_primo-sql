namespace AS2223_5H_INF_CrepaldiMatteo_primo_sql
{
    partial class FormEsporta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFileDB = new System.Windows.Forms.Button();
            this.btnEsporta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPath.Location = new System.Drawing.Point(61, 21);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(263, 27);
            this.txtPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // btnFileDB
            // 
            this.btnFileDB.Location = new System.Drawing.Point(330, 21);
            this.btnFileDB.Name = "btnFileDB";
            this.btnFileDB.Size = new System.Drawing.Size(27, 27);
            this.btnFileDB.TabIndex = 3;
            this.btnFileDB.Text = "...";
            this.btnFileDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFileDB.UseVisualStyleBackColor = true;
            this.btnFileDB.Click += new System.EventHandler(this.btnFileDB_Click);
            // 
            // btnEsporta
            // 
            this.btnEsporta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEsporta.Location = new System.Drawing.Point(125, 64);
            this.btnEsporta.Name = "btnEsporta";
            this.btnEsporta.Size = new System.Drawing.Size(113, 33);
            this.btnEsporta.TabIndex = 26;
            this.btnEsporta.Text = "Conferma";
            this.btnEsporta.UseVisualStyleBackColor = true;
            this.btnEsporta.Click += new System.EventHandler(this.btnEsporta_Click);
            // 
            // FormEsporta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 119);
            this.Controls.Add(this.btnEsporta);
            this.Controls.Add(this.btnFileDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEsporta";
            this.Text = "Path esportazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPath;
        private Label label1;
        private Button btnFileDB;
        private Button btnEsporta;
    }
}