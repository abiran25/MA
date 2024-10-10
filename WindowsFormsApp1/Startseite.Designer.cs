namespace WindowsFormsApp1
{
    partial class Startseite
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
            this.btn_Begriff = new System.Windows.Forms.Button();
            this.btn_Defintion = new System.Windows.Forms.Button();
            this.btn_Schreibmodus = new System.Windows.Forms.Button();
            this.btn_Lernmodus = new System.Windows.Forms.Button();
            this.btn_gemischt = new System.Windows.Forms.Button();
            this.comBF_Lernset = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBF_Ordner = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Begriff
            // 
            this.btn_Begriff.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Begriff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Begriff.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Begriff.Location = new System.Drawing.Point(569, 245);
            this.btn_Begriff.Name = "btn_Begriff";
            this.btn_Begriff.Size = new System.Drawing.Size(191, 54);
            this.btn_Begriff.TabIndex = 0;
            this.btn_Begriff.Text = "Definition";
            this.btn_Begriff.UseVisualStyleBackColor = false;
            this.btn_Begriff.Click += new System.EventHandler(this.Begriff_Click);
            // 
            // btn_Defintion
            // 
            this.btn_Defintion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Defintion.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Defintion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Defintion.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Defintion.Location = new System.Drawing.Point(201, 245);
            this.btn_Defintion.Name = "btn_Defintion";
            this.btn_Defintion.Size = new System.Drawing.Size(194, 54);
            this.btn_Defintion.TabIndex = 1;
            this.btn_Defintion.Text = "Begriff";
            this.btn_Defintion.UseVisualStyleBackColor = false;
            this.btn_Defintion.Click += new System.EventHandler(this.Definition_Click);
            // 
            // btn_Schreibmodus
            // 
            this.btn_Schreibmodus.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Schreibmodus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Schreibmodus.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Schreibmodus.Location = new System.Drawing.Point(201, 145);
            this.btn_Schreibmodus.Name = "btn_Schreibmodus";
            this.btn_Schreibmodus.Size = new System.Drawing.Size(272, 54);
            this.btn_Schreibmodus.TabIndex = 4;
            this.btn_Schreibmodus.Text = "Schreibmodus";
            this.btn_Schreibmodus.UseVisualStyleBackColor = false;
            this.btn_Schreibmodus.Click += new System.EventHandler(this.Schreibmodus_Click);
            // 
            // btn_Lernmodus
            // 
            this.btn_Lernmodus.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Lernmodus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lernmodus.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Lernmodus.Location = new System.Drawing.Point(474, 145);
            this.btn_Lernmodus.Name = "btn_Lernmodus";
            this.btn_Lernmodus.Size = new System.Drawing.Size(286, 54);
            this.btn_Lernmodus.TabIndex = 5;
            this.btn_Lernmodus.Text = "Lernmodus";
            this.btn_Lernmodus.UseVisualStyleBackColor = false;
            this.btn_Lernmodus.Click += new System.EventHandler(this.Lernmodus_Click);
            // 
            // btn_gemischt
            // 
            this.btn_gemischt.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_gemischt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gemischt.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_gemischt.Location = new System.Drawing.Point(391, 245);
            this.btn_gemischt.Name = "btn_gemischt";
            this.btn_gemischt.Size = new System.Drawing.Size(182, 54);
            this.btn_gemischt.TabIndex = 6;
            this.btn_gemischt.Text = "gemischt";
            this.btn_gemischt.UseVisualStyleBackColor = false;
            this.btn_gemischt.Click += new System.EventHandler(this.Gemischt_Click);
            // 
            // comBF_Lernset
            // 
            this.comBF_Lernset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBF_Lernset.FormattingEnabled = true;
            this.comBF_Lernset.Location = new System.Drawing.Point(0, 271);
            this.comBF_Lernset.Name = "comBF_Lernset";
            this.comBF_Lernset.Size = new System.Drawing.Size(201, 28);
            this.comBF_Lernset.TabIndex = 8;
            this.comBF_Lernset.SelectedIndexChanged += new System.EventHandler(this.comboBox_Lernset_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(0, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ordner ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(0, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lernset";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.comBF_Lernset);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comBF_Ordner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 411);
            this.panel1.TabIndex = 11;
            // 
            // comBF_Ordner
            // 
            this.comBF_Ordner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBF_Ordner.FormattingEnabled = true;
            this.comBF_Ordner.Location = new System.Drawing.Point(0, 145);
            this.comBF_Ordner.Name = "comBF_Ordner";
            this.comBF_Ordner.Size = new System.Drawing.Size(201, 28);
            this.comBF_Ordner.TabIndex = 7;
            this.comBF_Ordner.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ordner_SelectedIndexChanged);
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(750, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_gemischt);
            this.Controls.Add(this.btn_Lernmodus);
            this.Controls.Add(this.btn_Schreibmodus);
            this.Controls.Add(this.btn_Defintion);
            this.Controls.Add(this.btn_Begriff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Startseite";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Begriff;
        private System.Windows.Forms.Button btn_Defintion;
        private System.Windows.Forms.Button btn_Schreibmodus;
        private System.Windows.Forms.Button btn_Lernmodus;
        private System.Windows.Forms.Button btn_gemischt;
        private System.Windows.Forms.ComboBox comBF_Lernset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comBF_Ordner;
    }
}