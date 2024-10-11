namespace WindowsFormsApp1
{
    partial class Lernmodus
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
            this.btn_schwierig = new System.Windows.Forms.Button();
            this.btn_unmöglich = new System.Windows.Forms.Button();
            this.btn_machbar = new System.Windows.Forms.Button();
            this.btn_einfach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Wörter = new System.Windows.Forms.Button();
            this.btn_Weiter = new System.Windows.Forms.Button();
            this.btn_Zurücksetzen = new System.Windows.Forms.Button();
            this.progBar_Fortschritt = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Startseite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_schwierig
            // 
            this.btn_schwierig.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_schwierig.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_schwierig.Location = new System.Drawing.Point(494, 281);
            this.btn_schwierig.Name = "btn_schwierig";
            this.btn_schwierig.Size = new System.Drawing.Size(129, 79);
            this.btn_schwierig.TabIndex = 0;
            this.btn_schwierig.Text = "schwierig";
            this.btn_schwierig.UseVisualStyleBackColor = true;
            this.btn_schwierig.Click += new System.EventHandler(this.btn_schwierig_Click);
            // 
            // btn_unmöglich
            // 
            this.btn_unmöglich.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unmöglich.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_unmöglich.Location = new System.Drawing.Point(629, 282);
            this.btn_unmöglich.Name = "btn_unmöglich";
            this.btn_unmöglich.Size = new System.Drawing.Size(133, 79);
            this.btn_unmöglich.TabIndex = 1;
            this.btn_unmöglich.Text = "unmöglich";
            this.btn_unmöglich.UseVisualStyleBackColor = true;
            this.btn_unmöglich.Click += new System.EventHandler(this.btn_unmöglich_Click);
            // 
            // btn_machbar
            // 
            this.btn_machbar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_machbar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_machbar.Location = new System.Drawing.Point(355, 281);
            this.btn_machbar.Name = "btn_machbar";
            this.btn_machbar.Size = new System.Drawing.Size(133, 79);
            this.btn_machbar.TabIndex = 2;
            this.btn_machbar.Text = "machbar";
            this.btn_machbar.UseVisualStyleBackColor = true;
            this.btn_machbar.Click += new System.EventHandler(this.btn_machbar_Click);
            // 
            // btn_einfach
            // 
            this.btn_einfach.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_einfach.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_einfach.Location = new System.Drawing.Point(216, 281);
            this.btn_einfach.Name = "btn_einfach";
            this.btn_einfach.Size = new System.Drawing.Size(133, 79);
            this.btn_einfach.TabIndex = 3;
            this.btn_einfach.Text = "einfach";
            this.btn_einfach.UseVisualStyleBackColor = true;
            this.btn_einfach.Click += new System.EventHandler(this.btn_einfach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.TabIndex = 6;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Start.Location = new System.Drawing.Point(0, 405);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(200, 33);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Starten";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // btn_Wörter
            // 
            this.btn_Wörter.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Wörter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Wörter.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Wörter.Location = new System.Drawing.Point(-3, 104);
            this.btn_Wörter.Name = "btn_Wörter";
            this.btn_Wörter.Size = new System.Drawing.Size(200, 40);
            this.btn_Wörter.TabIndex = 9;
            this.btn_Wörter.Text = "Bearbeiten";
            this.btn_Wörter.UseVisualStyleBackColor = false;
            this.btn_Wörter.Click += new System.EventHandler(this.btn_Wörter_Click_1);
            // 
            // btn_Weiter
            // 
            this.btn_Weiter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Weiter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Weiter.Location = new System.Drawing.Point(216, 366);
            this.btn_Weiter.Name = "btn_Weiter";
            this.btn_Weiter.Size = new System.Drawing.Size(546, 72);
            this.btn_Weiter.TabIndex = 10;
            this.btn_Weiter.Text = "WEITER";
            this.btn_Weiter.UseVisualStyleBackColor = true;
            this.btn_Weiter.Click += new System.EventHandler(this.weiter_Click_1);
            // 
            // btn_Zurücksetzen
            // 
            this.btn_Zurücksetzen.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Zurücksetzen.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Zurücksetzen.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btn_Zurücksetzen.Location = new System.Drawing.Point(0, 215);
            this.btn_Zurücksetzen.Name = "btn_Zurücksetzen";
            this.btn_Zurücksetzen.Size = new System.Drawing.Size(200, 32);
            this.btn_Zurücksetzen.TabIndex = 12;
            this.btn_Zurücksetzen.Text = "Zurücksetzen";
            this.btn_Zurücksetzen.UseVisualStyleBackColor = false;
            this.btn_Zurücksetzen.Click += new System.EventHandler(this.Zurücksetzen_Click);
            // 
            // progBar_Fortschritt
            // 
            this.progBar_Fortschritt.Location = new System.Drawing.Point(618, 24);
            this.progBar_Fortschritt.Name = "progBar_Fortschritt";
            this.progBar_Fortschritt.Size = new System.Drawing.Size(170, 26);
            this.progBar_Fortschritt.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.Startseite);
            this.panel1.Controls.Add(this.btn_Wörter);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.btn_Zurücksetzen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 450);
            this.panel1.TabIndex = 16;
            // 
            // Startseite
            // 
            this.Startseite.BackColor = System.Drawing.Color.AliceBlue;
            this.Startseite.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startseite.ForeColor = System.Drawing.Color.LightSlateGray;
            this.Startseite.Location = new System.Drawing.Point(0, 156);
            this.Startseite.Name = "Startseite";
            this.Startseite.Size = new System.Drawing.Size(200, 40);
            this.Startseite.TabIndex = 13;
            this.Startseite.Text = "Startseite";
            this.Startseite.UseVisualStyleBackColor = false;
            this.Startseite.Click += new System.EventHandler(this.Startseite_Click);
            // 
            // Lernmodus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progBar_Fortschritt);
            this.Controls.Add(this.btn_Weiter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_einfach);
            this.Controls.Add(this.btn_machbar);
            this.Controls.Add(this.btn_unmöglich);
            this.Controls.Add(this.btn_schwierig);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lernmodus";
            this.Load += new System.EventHandler(this.Lernmodus_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_schwierig;
        private System.Windows.Forms.Button btn_unmöglich;
        private System.Windows.Forms.Button btn_machbar;
        private System.Windows.Forms.Button btn_einfach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Wörter;
        private System.Windows.Forms.Button btn_Weiter;
        private System.Windows.Forms.Button btn_Zurücksetzen;
        private System.Windows.Forms.ProgressBar progBar_Fortschritt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Startseite;
    }
}