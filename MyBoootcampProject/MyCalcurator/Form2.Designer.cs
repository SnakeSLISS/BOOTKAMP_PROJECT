
namespace MyCalcurator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblpasword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textbpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblpasword
            // 
            this.lblpasword.AutoSize = true;
            this.lblpasword.Font = new System.Drawing.Font("MS Outlook", 40F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasword.ForeColor = System.Drawing.Color.Aqua;
            this.lblpasword.Location = new System.Drawing.Point(107, 25);
            this.lblpasword.Name = "lblpasword";
            this.lblpasword.Size = new System.Drawing.Size(437, 62);
            this.lblpasword.TabIndex = 0;
            this.lblpasword.Text = "введите пароль";
            this.lblpasword.Click += new System.EventHandler(this.lblpasword_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("MV Boli", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button1.Location = new System.Drawing.Point(265, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "войти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textbpassword
            // 
            this.textbpassword.Location = new System.Drawing.Point(243, 112);
            this.textbpassword.Name = "textbpassword";
            this.textbpassword.PasswordChar = '#';
            this.textbpassword.Size = new System.Drawing.Size(170, 20);
            this.textbpassword.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImage = global::MyCalcurator.Properties.Resources._1679698677_phonoteka_org_p_tekhno_fon_foni_oboi_97;
            this.ClientSize = new System.Drawing.Size(650, 281);
            this.Controls.Add(this.textbpassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblpasword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "калькулятор";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpasword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbpassword;
    }
}