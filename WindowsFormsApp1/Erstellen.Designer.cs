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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBegriff = new System.Windows.Forms.TextBox();
            this.txtDefintion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxFolders = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLernset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.start_Lernset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(398, 398);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Begriff";
            // 
            // txtBegriff
            // 
            this.txtBegriff.Location = new System.Drawing.Point(52, 123);
            this.txtBegriff.Name = "txtBegriff";
            this.txtBegriff.Size = new System.Drawing.Size(100, 26);
            this.txtBegriff.TabIndex = 7;
            // 
            // txtDefintion
            // 
            this.txtDefintion.Location = new System.Drawing.Point(52, 213);
            this.txtDefintion.Name = "txtDefintion";
            this.txtDefintion.Size = new System.Drawing.Size(100, 26);
            this.txtDefintion.TabIndex = 9;
            this.txtDefintion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDefintion_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Definition";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "Lernsets";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxFolders
            // 
            this.comboBoxFolders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFolders.FormattingEnabled = true;
            this.comboBoxFolders.Location = new System.Drawing.Point(189, 121);
            this.comboBoxFolders.Name = "comboBoxFolders";
            this.comboBoxFolders.Size = new System.Drawing.Size(195, 28);
            this.comboBoxFolders.TabIndex = 16;
            this.comboBoxFolders.SelectedIndexChanged += new System.EventHandler(this.comboBoxFolders_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ordner auswählen";
            // 
            // comboBoxLernset
            // 
            this.comboBoxLernset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLernset.FormattingEnabled = true;
            this.comboBoxLernset.Location = new System.Drawing.Point(189, 210);
            this.comboBoxLernset.Name = "comboBoxLernset";
            this.comboBoxLernset.Size = new System.Drawing.Size(195, 28);
            this.comboBoxLernset.TabIndex = 18;
            this.comboBoxLernset.SelectedIndexChanged += new System.EventHandler(this.comboBoxLernset_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lernset auswählen";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(189, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 34);
            this.button4.TabIndex = 20;
            this.button4.Text = "Lernset laden";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // start_Lernset
            // 
            this.start_Lernset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.start_Lernset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start_Lernset.Location = new System.Drawing.Point(189, 333);
            this.start_Lernset.Name = "start_Lernset";
            this.start_Lernset.Size = new System.Drawing.Size(195, 33);
            this.start_Lernset.TabIndex = 21;
            this.start_Lernset.Text = "Lernen";
            this.start_Lernset.UseVisualStyleBackColor = false;
            this.start_Lernset.Click += new System.EventHandler(this.start_Lernset_Click);
            // 
            // Erstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_Lernset);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLernset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFolders);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDefintion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBegriff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Erstellen";
            this.Text = "Lernset Laden";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBegriff;
        private System.Windows.Forms.TextBox txtDefintion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxFolders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLernset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button start_Lernset;
    }
}