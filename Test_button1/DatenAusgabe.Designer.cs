namespace Test_button1
{
    partial class DatenAusgabe
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1_form2 = new System.Windows.Forms.Label();
            this.label2_form2 = new System.Windows.Forms.Label();
            this.button1_form2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 26);
            this.textBox2.TabIndex = 1;
            // 
            // label1_form2
            // 
            this.label1_form2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1_form2.Location = new System.Drawing.Point(49, 116);
            this.label1_form2.Name = "label1_form2";
            this.label1_form2.Size = new System.Drawing.Size(186, 28);
            this.label1_form2.TabIndex = 2;
            this.label1_form2.Text = "Begriff";
            this.label1_form2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_form2
            // 
            this.label2_form2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2_form2.Location = new System.Drawing.Point(47, 218);
            this.label2_form2.Name = "label2_form2";
            this.label2_form2.Size = new System.Drawing.Size(188, 36);
            this.label2_form2.TabIndex = 4;
            this.label2_form2.Text = "Definition";
            this.label2_form2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1_form2
            // 
            this.button1_form2.Location = new System.Drawing.Point(49, 304);
            this.button1_form2.Name = "button1_form2";
            this.button1_form2.Size = new System.Drawing.Size(151, 35);
            this.button1_form2.TabIndex = 5;
            this.button1_form2.Text = "Erstellen";
            this.button1_form2.UseVisualStyleBackColor = true;
            this.button1_form2.Click += new System.EventHandler(this.button1_form2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(539, 347);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_form2);
            this.Controls.Add(this.label2_form2);
            this.Controls.Add(this.label1_form2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1_form2;
        private System.Windows.Forms.Label label2_form2;
        private System.Windows.Forms.Button button1_form2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}