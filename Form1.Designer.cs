namespace Proiect
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_incarca = new System.Windows.Forms.Button();
            this.btn_salveaza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_hist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_incarca
            // 
            this.btn_incarca.Location = new System.Drawing.Point(2, 13);
            this.btn_incarca.Name = "btn_incarca";
            this.btn_incarca.Size = new System.Drawing.Size(180, 23);
            this.btn_incarca.TabIndex = 1;
            this.btn_incarca.Text = "Incarca imagine";
            this.btn_incarca.UseVisualStyleBackColor = true;
            this.btn_incarca.Click += new System.EventHandler(this.btn_incarca_Click);
            // 
            // btn_salveaza
            // 
            this.btn_salveaza.Location = new System.Drawing.Point(189, 13);
            this.btn_salveaza.Name = "btn_salveaza";
            this.btn_salveaza.Size = new System.Drawing.Size(133, 23);
            this.btn_salveaza.TabIndex = 2;
            this.btn_salveaza.Text = "Salveaza";
            this.btn_salveaza.UseVisualStyleBackColor = true;
            this.btn_salveaza.Click += new System.EventHandler(this.btn_salveaza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 22);
            this.textBox1.TabIndex = 5;
            // 
            // btn_hist
            // 
            this.btn_hist.Location = new System.Drawing.Point(340, 12);
            this.btn_hist.Name = "btn_hist";
            this.btn_hist.Size = new System.Drawing.Size(118, 23);
            this.btn_hist.TabIndex = 6;
            this.btn_hist.Text = "Histagram";
            this.btn_hist.UseVisualStyleBackColor = true;
            this.btn_hist.Click += new System.EventHandler(this.btn_hist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salveaza);
            this.Controls.Add(this.btn_incarca);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_incarca;
        private System.Windows.Forms.Button btn_salveaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_hist;
    }
}

