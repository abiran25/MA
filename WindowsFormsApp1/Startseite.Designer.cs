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
            this.Begriff = new System.Windows.Forms.Button();
            this.Definition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Schreibmodus = new System.Windows.Forms.Button();
            this.Lernmodus = new System.Windows.Forms.Button();
            this.gemischt = new System.Windows.Forms.Button();
            this.comboBox_Ordner = new System.Windows.Forms.ComboBox();
            this.comboBox_Lernset = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Begriff
            // 
            this.Begriff.Location = new System.Drawing.Point(123, 303);
            this.Begriff.Name = "Begriff";
            this.Begriff.Size = new System.Drawing.Size(112, 35);
            this.Begriff.TabIndex = 0;
            this.Begriff.Text = "Begriff";
            this.Begriff.UseVisualStyleBackColor = true;
            this.Begriff.Click += new System.EventHandler(this.button1_Click);
            // 
            // Definition
            // 
            this.Definition.Location = new System.Drawing.Point(289, 303);
            this.Definition.Name = "Definition";
            this.Definition.Size = new System.Drawing.Size(112, 35);
            this.Definition.TabIndex = 1;
            this.Definition.Text = "Defintion";
            this.Definition.UseVisualStyleBackColor = true;
            this.Definition.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(276, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Antworten mit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modus wählen: ";
            // 
            // Schreibmodus
            // 
            this.Schreibmodus.Location = new System.Drawing.Point(208, 202);
            this.Schreibmodus.Name = "Schreibmodus";
            this.Schreibmodus.Size = new System.Drawing.Size(143, 40);
            this.Schreibmodus.TabIndex = 4;
            this.Schreibmodus.Text = "Schreibmodus";
            this.Schreibmodus.UseVisualStyleBackColor = true;
            this.Schreibmodus.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lernmodus
            // 
            this.Lernmodus.Location = new System.Drawing.Point(389, 202);
            this.Lernmodus.Name = "Lernmodus";
            this.Lernmodus.Size = new System.Drawing.Size(136, 40);
            this.Lernmodus.TabIndex = 5;
            this.Lernmodus.Text = "Lernmodus";
            this.Lernmodus.UseVisualStyleBackColor = true;
            this.Lernmodus.Click += new System.EventHandler(this.button4_Click);
            // 
            // gemischt
            // 
            this.gemischt.Location = new System.Drawing.Point(456, 303);
            this.gemischt.Name = "gemischt";
            this.gemischt.Size = new System.Drawing.Size(118, 35);
            this.gemischt.TabIndex = 6;
            this.gemischt.Text = "gemischt";
            this.gemischt.UseVisualStyleBackColor = true;
            this.gemischt.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox_Ordner
            // 
            this.comboBox_Ordner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ordner.FormattingEnabled = true;
            this.comboBox_Ordner.Location = new System.Drawing.Point(87, 85);
            this.comboBox_Ordner.Name = "comboBox_Ordner";
            this.comboBox_Ordner.Size = new System.Drawing.Size(179, 28);
            this.comboBox_Ordner.TabIndex = 7;
            this.comboBox_Ordner.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ordner_SelectedIndexChanged);
            // 
            // comboBox_Lernset
            // 
            this.comboBox_Lernset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Lernset.FormattingEnabled = true;
            this.comboBox_Lernset.Location = new System.Drawing.Point(404, 85);
            this.comboBox_Lernset.Name = "comboBox_Lernset";
            this.comboBox_Lernset.Size = new System.Drawing.Size(182, 28);
            this.comboBox_Lernset.TabIndex = 8;
            this.comboBox_Lernset.SelectedIndexChanged += new System.EventHandler(this.comboBox_Lernset_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ordner auswählen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lernset wählen";
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Lernset);
            this.Controls.Add(this.comboBox_Ordner);
            this.Controls.Add(this.gemischt);
            this.Controls.Add(this.Lernmodus);
            this.Controls.Add(this.Schreibmodus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Definition);
            this.Controls.Add(this.Begriff);
            this.Name = "Startseite";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Begriff;
        private System.Windows.Forms.Button Definition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Schreibmodus;
        private System.Windows.Forms.Button Lernmodus;
        private System.Windows.Forms.Button gemischt;
        private System.Windows.Forms.ComboBox comboBox_Ordner;
        private System.Windows.Forms.ComboBox comboBox_Lernset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}