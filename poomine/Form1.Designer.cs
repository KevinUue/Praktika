namespace poomine
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Guesses = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Word = new System.Windows.Forms.TextBox();
            this.lbl_Missed = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Letter = new System.Windows.Forms.TextBox();
            this.btn_Letter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(403, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 306);
            this.panel1.TabIndex = 7;
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(6, 272);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(78, 15);
            this.lbl_Length.TabIndex = 8;
            this.lbl_Length.Text = "Sõna pikkus: ";
            // 
            // lbl_Guesses
            // 
            this.lbl_Guesses.AutoSize = true;
            this.lbl_Guesses.Location = new System.Drawing.Point(241, 340);
            this.lbl_Guesses.Name = "lbl_Guesses";
            this.lbl_Guesses.Size = new System.Drawing.Size(87, 15);
            this.lbl_Guesses.TabIndex = 9;
            this.lbl_Guesses.Text = "Arvamisi järgi: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Word);
            this.groupBox2.Controls.Add(this.lbl_Missed);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txt_Letter);
            this.groupBox2.Controls.Add(this.lbl_Length);
            this.groupBox2.Controls.Add(this.lbl_Guesses);
            this.groupBox2.Controls.Add(this.btn_Letter);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 369);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txt_Word
            // 
            this.txt_Word.Location = new System.Drawing.Point(99, 337);
            this.txt_Word.Name = "txt_Word";
            this.txt_Word.Size = new System.Drawing.Size(136, 22);
            this.txt_Word.TabIndex = 13;
            // 
            // lbl_Missed
            // 
            this.lbl_Missed.AutoSize = true;
            this.lbl_Missed.Location = new System.Drawing.Point(150, 305);
            this.lbl_Missed.Name = "lbl_Missed";
            this.lbl_Missed.Size = new System.Drawing.Size(125, 15);
            this.lbl_Missed.TabIndex = 9;
            this.lbl_Missed.Text = "Valesti arvatud tähed: ";
            this.lbl_Missed.Click += new System.EventHandler(this.lbl_Missed_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Arva sõna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Letter
            // 
            this.txt_Letter.Location = new System.Drawing.Point(101, 304);
            this.txt_Letter.Name = "txt_Letter";
            this.txt_Letter.Size = new System.Drawing.Size(32, 22);
            this.txt_Letter.TabIndex = 12;
            // 
            // btn_Letter
            // 
            this.btn_Letter.Location = new System.Drawing.Point(6, 299);
            this.btn_Letter.Name = "btn_Letter";
            this.btn_Letter.Size = new System.Drawing.Size(87, 27);
            this.btn_Letter.TabIndex = 10;
            this.btn_Letter.Text = "Arva täht";
            this.btn_Letter.UseVisualStyleBackColor = true;
            this.btn_Letter.Click += new System.EventHandler(this.btn_Letter_Click_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(403, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(510, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 57);
            this.button3.TabIndex = 12;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 391);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poomine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Guesses;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Word;
        private System.Windows.Forms.TextBox txt_Letter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Letter;
        private System.Windows.Forms.Label lbl_Missed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

