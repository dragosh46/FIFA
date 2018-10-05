namespace WindowsFormsApp1.Forms
{
    partial class Campionat
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Echipe = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Nume";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 498);
            this.listBox1.TabIndex = 0;
         
            // 
            // Echipe
            // 
            this.Echipe.AutoSize = true;
            this.Echipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Echipe.Location = new System.Drawing.Point(203, 21);
            this.Echipe.Name = "Echipe";
            this.Echipe.Size = new System.Drawing.Size(195, 22);
            this.Echipe.TabIndex = 1;
            this.Echipe.Text = "Echipele din campionat";
            // 
            // listBox2
            // 
            this.listBox2.DisplayMember = "Nume";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(323, 62);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(254, 498);
            this.listBox2.TabIndex = 2;
       
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(722, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Arata ultimele rezultate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ArataUltimeleRezultateBTN);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(722, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 100);
            this.button2.TabIndex = 4;
            this.button2.Text = "Porneste un meci";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Campionat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Echipe);
            this.Controls.Add(this.listBox1);
            this.Name = "Campionat";
            this.Text = "Campionat";
            this.Load += new System.EventHandler(this.Campionat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Echipe;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}