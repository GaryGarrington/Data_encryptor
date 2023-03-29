namespace Data_encryption
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_load = new System.Windows.Forms.Button();
            this.txb_input = new System.Windows.Forms.TextBox();
            this.txb_output = new System.Windows.Forms.TextBox();
            this.btn_cypher = new System.Windows.Forms.Button();
            this.txb_seed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_decypher = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(88, 33);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Načíst soubor";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txb_input
            // 
            this.txb_input.Location = new System.Drawing.Point(106, 12);
            this.txb_input.Multiline = true;
            this.txb_input.Name = "txb_input";
            this.txb_input.Size = new System.Drawing.Size(292, 258);
            this.txb_input.TabIndex = 2;
            // 
            // txb_output
            // 
            this.txb_output.Location = new System.Drawing.Point(496, 12);
            this.txb_output.Multiline = true;
            this.txb_output.Name = "txb_output";
            this.txb_output.Size = new System.Drawing.Size(292, 258);
            this.txb_output.TabIndex = 3;
            // 
            // btn_cypher
            // 
            this.btn_cypher.Location = new System.Drawing.Point(404, 12);
            this.btn_cypher.Name = "btn_cypher";
            this.btn_cypher.Size = new System.Drawing.Size(85, 33);
            this.btn_cypher.TabIndex = 4;
            this.btn_cypher.Text = "Zašifrovat";
            this.btn_cypher.UseVisualStyleBackColor = true;
            this.btn_cypher.Click += new System.EventHandler(this.btn_cypher_Click);
            // 
            // txb_seed
            // 
            this.txb_seed.Location = new System.Drawing.Point(404, 100);
            this.txb_seed.Name = "txb_seed";
            this.txb_seed.Size = new System.Drawing.Size(85, 20);
            this.txb_seed.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seed:";
            // 
            // btn_decypher
            // 
            this.btn_decypher.Location = new System.Drawing.Point(404, 153);
            this.btn_decypher.Name = "btn_decypher";
            this.btn_decypher.Size = new System.Drawing.Size(85, 33);
            this.btn_decypher.TabIndex = 7;
            this.btn_decypher.Text = "Dešifrovat";
            this.btn_decypher.UseVisualStyleBackColor = true;
            this.btn_decypher.Click += new System.EventHandler(this.btn_decypher_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(794, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 40);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Uložit do souboru";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 277);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_decypher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_seed);
            this.Controls.Add(this.btn_cypher);
            this.Controls.Add(this.txb_output);
            this.Controls.Add(this.txb_input);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            this.Text = "Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txb_input;
        private System.Windows.Forms.TextBox txb_output;
        private System.Windows.Forms.Button btn_cypher;
        private System.Windows.Forms.TextBox txb_seed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_decypher;
        private System.Windows.Forms.Button btn_save;
    }
}

