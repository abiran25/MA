namespace WindowsFormsApp1
{
    partial class Bearbeiten
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
            this.dataGV_Erstellen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_Begriff = new System.Windows.Forms.TextBox();
            this.txtB_Definition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Lernset = new System.Windows.Forms.Button();
            this.comBF_Ordner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBF_Lernset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_LernsetLaden = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Löschen = new System.Windows.Forms.Button();
            this.btn_Speichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Erstellen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_Erstellen
            // 
            this.dataGV_Erstellen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Erstellen.Location = new System.Drawing.Point(402, 0);
            this.dataGV_Erstellen.Name = "dataGV_Erstellen";
            this.dataGV_Erstellen.RowHeadersWidth = 62;
            this.dataGV_Erstellen.Size = new System.Drawing.Size(399, 453);
            this.dataGV_Erstellen.TabIndex = 5;
            this.dataGV_Erstellen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Erstellen_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(206, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Begriff";
            // 
            // txtB_Begriff
            // 
            this.txtB_Begriff.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Begriff.Location = new System.Drawing.Point(206, 68);
            this.txtB_Begriff.Name = "txtB_Begriff";
            this.txtB_Begriff.Size = new System.Drawing.Size(190, 29);
            this.txtB_Begriff.TabIndex = 7;
            // 
            // txtB_Definition
            // 
            this.txtB_Definition.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Definition.Location = new System.Drawing.Point(208, 217);
            this.txtB_Definition.Name = "txtB_Definition";
            this.txtB_Definition.Size = new System.Drawing.Size(190, 29);
            this.txtB_Definition.TabIndex = 9;
            this.txtB_Definition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDefintion_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(206, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Definition";
            // 
            // btn_Lernset
            // 
            this.btn_Lernset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Lernset.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lernset.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Lernset.Location = new System.Drawing.Point(3, 396);
            this.btn_Lernset.Name = "btn_Lernset";
            this.btn_Lernset.Size = new System.Drawing.Size(197, 32);
            this.btn_Lernset.TabIndex = 14;
            this.btn_Lernset.Text = "Erstellen";
            this.btn_Lernset.UseVisualStyleBackColor = false;
            this.btn_Lernset.Click += new System.EventHandler(this.btn_Lernset_Click_1);
            // 
            // comBF_Ordner
            // 
            this.comBF_Ordner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBF_Ordner.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBF_Ordner.FormattingEnabled = true;
            this.comBF_Ordner.Location = new System.Drawing.Point(0, 53);
            this.comBF_Ordner.Name = "comBF_Ordner";
            this.comBF_Ordner.Size = new System.Drawing.Size(200, 29);
            this.comBF_Ordner.TabIndex = 16;
            this.comBF_Ordner.SelectedIndexChanged += new System.EventHandler(this.comboBoxFolders_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(-22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ordner ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comBF_Lernset
            // 
            this.comBF_Lernset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBF_Lernset.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBF_Lernset.FormattingEnabled = true;
            this.comBF_Lernset.Location = new System.Drawing.Point(0, 146);
            this.comBF_Lernset.Name = "comBF_Lernset";
            this.comBF_Lernset.Size = new System.Drawing.Size(200, 29);
            this.comBF_Lernset.TabIndex = 18;
            this.comBF_Lernset.SelectedIndexChanged += new System.EventHandler(this.comboBoxLernset_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(-22, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 50);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lernset ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_LernsetLaden
            // 
            this.btn_LernsetLaden.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LernsetLaden.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_LernsetLaden.Location = new System.Drawing.Point(3, 192);
            this.btn_LernsetLaden.Name = "btn_LernsetLaden";
            this.btn_LernsetLaden.Size = new System.Drawing.Size(195, 34);
            this.btn_LernsetLaden.TabIndex = 20;
            this.btn_LernsetLaden.Text = "Lernset laden";
            this.btn_LernsetLaden.UseVisualStyleBackColor = true;
            this.btn_LernsetLaden.Click += new System.EventHandler(this.btn_LernsetLaden_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Start.Location = new System.Drawing.Point(3, 357);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(195, 33);
            this.btn_Start.TabIndex = 21;
            this.btn_Start.Text = "Startseite";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.btn_Lernset);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_LernsetLaden);
            this.panel1.Controls.Add(this.comBF_Ordner);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comBF_Lernset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 22;
            // 
            // btn_Löschen
            // 
            this.btn_Löschen.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Löschen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Löschen.Location = new System.Drawing.Point(206, 383);
            this.btn_Löschen.Name = "btn_Löschen";
            this.btn_Löschen.Size = new System.Drawing.Size(192, 45);
            this.btn_Löschen.TabIndex = 13;
            this.btn_Löschen.Text = "Löschen";
            this.btn_Löschen.UseVisualStyleBackColor = true;
            this.btn_Löschen.Click += new System.EventHandler(this.btn_Löschen_Click_1);
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Speichern.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Speichern.Location = new System.Drawing.Point(206, 339);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(192, 38);
            this.btn_Speichern.TabIndex = 12;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(this.btn_Speichern_Click);
            // 
            // Bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtB_Begriff);
            this.Controls.Add(this.txtB_Definition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Löschen);
            this.Controls.Add(this.btn_Speichern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGV_Erstellen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bearbeiten";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Erstellen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_Erstellen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_Begriff;
        private System.Windows.Forms.TextBox txtB_Definition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Lernset;
        private System.Windows.Forms.ComboBox comBF_Ordner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBF_Lernset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_LernsetLaden;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Löschen;
        private System.Windows.Forms.Button btn_Speichern;
    }
}