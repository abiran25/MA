namespace datagridview
{
    partial class Tabelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBegriff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDefintion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Speichern = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begriff";
            // 
            // txtBegriff
            // 
            this.txtBegriff.Location = new System.Drawing.Point(67, 133);
            this.txtBegriff.Name = "txtBegriff";
            this.txtBegriff.Size = new System.Drawing.Size(100, 26);
            this.txtBegriff.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Definition";
       
            // 
            // txtDefintion
            // 
            this.txtDefintion.Location = new System.Drawing.Point(67, 220);
            this.txtDefintion.Name = "txtDefintion";
            this.txtDefintion.Size = new System.Drawing.Size(100, 26);
            this.txtDefintion.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(575, 395);
            this.dataGridView1.TabIndex = 4;
            // 
            // Speichern
            // 
            this.Speichern.Location = new System.Drawing.Point(67, 267);
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(100, 32);
            this.Speichern.TabIndex = 5;
            this.Speichern.Text = "Speichern";
            this.Speichern.UseVisualStyleBackColor = true;
            this.Speichern.Click += new System.EventHandler(this.Speichern_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Location = new System.Drawing.Point(71, 327);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(96, 32);
            this.btnLöschen.TabIndex = 6;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // Tabelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.Speichern);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDefintion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBegriff);
            this.Controls.Add(this.label1);
            this.Name = "Tabelle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBegriff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefintion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Speichern;
        private System.Windows.Forms.Button btnLöschen;
    }
}

