namespace ProgettoCifrarioCesare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_cripta = new Button();
            btn_cripta2 = new Button();
            lbl_titolo = new Label();
            lbl_stringa = new Label();
            lbl_stringa2 = new Label();
            txt_stringa = new TextBox();
            txt_stringa2 = new TextBox();
            lbl_chiave = new Label();
            lbl_chiave2 = new Label();
            txt_chiave = new TextBox();
            txt_chiave2 = new TextBox();
            txt_risultato = new TextBox();
            txt_risultato2 = new TextBox();
            SuspendLayout();
            // 
            // btn_cripta
            // 
            btn_cripta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cripta.ForeColor = Color.Black;
            btn_cripta.Location = new Point(34, 292);
            btn_cripta.Name = "btn_cripta";
            btn_cripta.Size = new Size(94, 29);
            btn_cripta.TabIndex = 0;
            btn_cripta.Text = "CRIPTA";
            btn_cripta.UseVisualStyleBackColor = true;
            // 
            // btn_cripta2
            // 
            btn_cripta2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cripta2.ForeColor = Color.Black;
            btn_cripta2.Location = new Point(466, 292);
            btn_cripta2.Name = "btn_cripta2";
            btn_cripta2.Size = new Size(94, 29);
            btn_cripta2.TabIndex = 1;
            btn_cripta2.Text = "CRIPTA";
            btn_cripta2.UseVisualStyleBackColor = true;
            btn_cripta2.Click += button2_Click;
            // 
            // lbl_titolo
            // 
            lbl_titolo.AutoSize = true;
            lbl_titolo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titolo.Location = new Point(234, 60);
            lbl_titolo.Name = "lbl_titolo";
            lbl_titolo.Size = new Size(291, 38);
            lbl_titolo.TabIndex = 2;
            lbl_titolo.Text = "CIFRARIO DI CESARE";
            // 
            // lbl_stringa
            // 
            lbl_stringa.AutoSize = true;
            lbl_stringa.Location = new Point(34, 133);
            lbl_stringa.Name = "lbl_stringa";
            lbl_stringa.Size = new Size(141, 20);
            lbl_stringa.TabIndex = 3;
            lbl_stringa.Text = "Inserisci una stringa:";
            // 
            // lbl_stringa2
            // 
            lbl_stringa2.AutoSize = true;
            lbl_stringa2.Location = new Point(466, 133);
            lbl_stringa2.Name = "lbl_stringa2";
            lbl_stringa2.Size = new Size(141, 20);
            lbl_stringa2.TabIndex = 4;
            lbl_stringa2.Text = "Inserisci una stringa:";
            // 
            // txt_stringa
            // 
            txt_stringa.Location = new Point(212, 130);
            txt_stringa.Name = "txt_stringa";
            txt_stringa.Size = new Size(125, 27);
            txt_stringa.TabIndex = 5;
            // 
            // txt_stringa2
            // 
            txt_stringa2.Location = new Point(645, 130);
            txt_stringa2.Name = "txt_stringa2";
            txt_stringa2.Size = new Size(125, 27);
            txt_stringa2.TabIndex = 6;
            // 
            // lbl_chiave
            // 
            lbl_chiave.AutoSize = true;
            lbl_chiave.Location = new Point(34, 195);
            lbl_chiave.Name = "lbl_chiave";
            lbl_chiave.Size = new Size(138, 20);
            lbl_chiave.TabIndex = 7;
            lbl_chiave.Text = "Inserisci una chiave:";
            // 
            // lbl_chiave2
            // 
            lbl_chiave2.AutoSize = true;
            lbl_chiave2.Location = new Point(466, 195);
            lbl_chiave2.Name = "lbl_chiave2";
            lbl_chiave2.Size = new Size(138, 20);
            lbl_chiave2.TabIndex = 8;
            lbl_chiave2.Text = "Inserisci una chiave:";
            // 
            // txt_chiave
            // 
            txt_chiave.Location = new Point(212, 192);
            txt_chiave.Name = "txt_chiave";
            txt_chiave.Size = new Size(125, 27);
            txt_chiave.TabIndex = 9;
            // 
            // txt_chiave2
            // 
            txt_chiave2.Location = new Point(645, 195);
            txt_chiave2.Name = "txt_chiave2";
            txt_chiave2.Size = new Size(125, 27);
            txt_chiave2.TabIndex = 10;
            // 
            // txt_risultato
            // 
            txt_risultato.Location = new Point(212, 292);
            txt_risultato.Name = "txt_risultato";
            txt_risultato.Size = new Size(125, 27);
            txt_risultato.TabIndex = 11;
            // 
            // txt_risultato2
            // 
            txt_risultato2.Location = new Point(645, 292);
            txt_risultato2.Name = "txt_risultato2";
            txt_risultato2.Size = new Size(125, 27);
            txt_risultato2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(txt_risultato2);
            Controls.Add(txt_risultato);
            Controls.Add(txt_chiave2);
            Controls.Add(txt_chiave);
            Controls.Add(lbl_chiave2);
            Controls.Add(lbl_chiave);
            Controls.Add(txt_stringa2);
            Controls.Add(txt_stringa);
            Controls.Add(lbl_stringa2);
            Controls.Add(lbl_stringa);
            Controls.Add(lbl_titolo);
            Controls.Add(btn_cripta2);
            Controls.Add(btn_cripta);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cripta;
        private Button btn_cripta2;
        private Label lbl_titolo;
        private Label lbl_stringa;
        private Label lbl_stringa2;
        private TextBox txt_stringa;
        private TextBox txt_stringa2;
        private Label lbl_chiave;
        private Label lbl_chiave2;
        private TextBox txt_chiave;
        private TextBox txt_chiave2;
        private TextBox txt_risultato;
        private TextBox txt_risultato2;
    }
}
