namespace WindowsFormsApp1
{
    partial class Erstellen
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
            this.btn_Schliessen = new System.Windows.Forms.Button();
            this.btn_erstellenOrdner = new System.Windows.Forms.Button();
            this.btn_erstellenLernset = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_Schliessen
            // 
            this.btn_Schliessen.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Schliessen.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Schliessen.Location = new System.Drawing.Point(643, 12);
            this.btn_Schliessen.Name = "btn_Schliessen";
            this.btn_Schliessen.Size = new System.Drawing.Size(133, 51);
            this.btn_Schliessen.TabIndex = 0;
            this.btn_Schliessen.Text = "Zurück";
            this.btn_Schliessen.UseVisualStyleBackColor = true;
            this.btn_Schliessen.Click += new System.EventHandler(this.Schliessen_Click);
            // 
            // btn_erstellenOrdner
            // 
            this.btn_erstellenOrdner.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_erstellenOrdner.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btn_erstellenOrdner.Location = new System.Drawing.Point(12, 170);
            this.btn_erstellenOrdner.Name = "btn_erstellenOrdner";
            this.btn_erstellenOrdner.Size = new System.Drawing.Size(756, 92);
            this.btn_erstellenOrdner.TabIndex = 1;
            this.btn_erstellenOrdner.Text = "Ordner erstellen";
            this.btn_erstellenOrdner.UseVisualStyleBackColor = true;
            this.btn_erstellenOrdner.Click += new System.EventHandler(this.btn_erstellenOrdner_Click);
            // 
            // btn_erstellenLernset
            // 
            this.btn_erstellenLernset.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_erstellenLernset.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_erstellenLernset.Location = new System.Drawing.Point(12, 294);
            this.btn_erstellenLernset.Name = "btn_erstellenLernset";
            this.btn_erstellenLernset.Size = new System.Drawing.Size(756, 108);
            this.btn_erstellenLernset.TabIndex = 3;
            this.btn_erstellenLernset.Text = "Lernset erstellen";
            this.btn_erstellenLernset.UseVisualStyleBackColor = true;
            this.btn_erstellenLernset.Click += new System.EventHandler(this.btn_erstellenLernset_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Erstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_erstellenLernset);
            this.Controls.Add(this.btn_erstellenOrdner);
            this.Controls.Add(this.btn_Schliessen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Erstellen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Schliessen;
        private System.Windows.Forms.Button btn_erstellenOrdner;
        private System.Windows.Forms.Button btn_erstellenLernset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}