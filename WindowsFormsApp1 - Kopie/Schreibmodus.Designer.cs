namespace WindowsFormsApp1
{
    partial class Schreibmodus
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtB_Antwort = new System.Windows.Forms.TextBox();
            this.textB_Anzeige = new System.Windows.Forms.TextBox();
            this.btn_Wörter = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Startseite = new System.Windows.Forms.Button();
            this.btn_Zurücksetzen = new System.Windows.Forms.Button();
            this.Progbar_Forschritt = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtB_Antwort
            // 
            this.txtB_Antwort.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Antwort.Location = new System.Drawing.Point(303, 240);
            this.txtB_Antwort.Name = "txtB_Antwort";
            this.txtB_Antwort.Size = new System.Drawing.Size(255, 29);
            this.txtB_Antwort.TabIndex = 7;
            this.txtB_Antwort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answer_KeyDown);
            // 
            // textB_Anzeige
            // 
            this.textB_Anzeige.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_Anzeige.Location = new System.Drawing.Point(303, 134);
            this.textB_Anzeige.Name = "textB_Anzeige";
            this.textB_Anzeige.ReadOnly = true;
            this.textB_Anzeige.Size = new System.Drawing.Size(255, 29);
            this.textB_Anzeige.TabIndex = 6;
            // 
            // btn_Wörter
            // 
            this.btn_Wörter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Wörter.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Wörter.Location = new System.Drawing.Point(0, 76);
            this.btn_Wörter.Name = "btn_Wörter";
            this.btn_Wörter.Size = new System.Drawing.Size(200, 40);
            this.btn_Wörter.TabIndex = 8;
            this.btn_Wörter.Text = "Bearbeiten";
            this.btn_Wörter.UseVisualStyleBackColor = true;
            this.btn_Wörter.Click += new System.EventHandler(this.btn_Wörter_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Start.Location = new System.Drawing.Point(303, 349);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(255, 36);
            this.btn_Start.TabIndex = 10;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // btn_Startseite
            // 
            this.btn_Startseite.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Startseite.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Startseite.Location = new System.Drawing.Point(0, 134);
            this.btn_Startseite.Name = "btn_Startseite";
            this.btn_Startseite.Size = new System.Drawing.Size(200, 40);
            this.btn_Startseite.TabIndex = 11;
            this.btn_Startseite.Text = "Startseite";
            this.btn_Startseite.UseVisualStyleBackColor = true;
            this.btn_Startseite.Click += new System.EventHandler(this.btn_Startseite_Click);
            // 
            // btn_Zurücksetzen
            // 
            this.btn_Zurücksetzen.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Zurücksetzen.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Zurücksetzen.Location = new System.Drawing.Point(0, 189);
            this.btn_Zurücksetzen.Name = "btn_Zurücksetzen";
            this.btn_Zurücksetzen.Size = new System.Drawing.Size(200, 38);
            this.btn_Zurücksetzen.TabIndex = 12;
            this.btn_Zurücksetzen.Text = "Zurücksetzen";
            this.btn_Zurücksetzen.UseVisualStyleBackColor = true;
            this.btn_Zurücksetzen.Click += new System.EventHandler(this.btn_Zurücksetzen_Click);
            // 
            // Progbar_Forschritt
            // 
            this.Progbar_Forschritt.Location = new System.Drawing.Point(626, 12);
            this.Progbar_Forschritt.Name = "Progbar_Forschritt";
            this.Progbar_Forschritt.Size = new System.Drawing.Size(171, 23);
            this.Progbar_Forschritt.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btn_Wörter);
            this.panel1.Controls.Add(this.btn_Startseite);
            this.panel1.Controls.Add(this.btn_Zurücksetzen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 15;
            // 
            // Schreibmodus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Progbar_Forschritt);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txtB_Antwort);
            this.Controls.Add(this.textB_Anzeige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Schreibmodus";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtB_Antwort;
        private System.Windows.Forms.TextBox textB_Anzeige;
        private System.Windows.Forms.Button btn_Wörter;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Startseite;
        private System.Windows.Forms.Button btn_Zurücksetzen;
        private System.Windows.Forms.ProgressBar Progbar_Forschritt;
        private System.Windows.Forms.Panel panel1;
    }
}

