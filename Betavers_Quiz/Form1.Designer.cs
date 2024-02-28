namespace Betavers_Quiz
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vok_F = new System.Windows.Forms.TextBox();
            this.new_voc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 26);
            this.textBox1.TabIndex = 1;
            // 
            // vok_F
            // 
            this.vok_F.Location = new System.Drawing.Point(275, 224);
            this.vok_F.Name = "vok_F";
            this.vok_F.Size = new System.Drawing.Size(206, 26);
            this.vok_F.TabIndex = 3;
            // 
            // new_voc
            // 
            this.new_voc.Location = new System.Drawing.Point(634, 33);
            this.new_voc.Name = "new_voc";
            this.new_voc.Size = new System.Drawing.Size(140, 40);
            this.new_voc.TabIndex = 4;
            this.new_voc.Text = "New voc";
            this.new_voc.UseVisualStyleBackColor = true;
            this.new_voc.Click += new System.EventHandler(this.new_voc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.new_voc);
            this.Controls.Add(this.vok_F);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox vok_F;
        private System.Windows.Forms.Button new_voc;
    }
}

