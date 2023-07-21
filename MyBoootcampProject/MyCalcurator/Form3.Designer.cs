
namespace MyCalcurator
{
    partial class калькулятор
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(калькулятор));
            this.ldlfirstnomber = new System.Windows.Forms.Label();
            this.ldlsecondnomber = new System.Windows.Forms.Label();
            this.textBnumber1 = new System.Windows.Forms.TextBox();
            this.textBnumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonmines = new System.Windows.Forms.Button();
            this.buttondivision = new System.Windows.Forms.Button();
            this.buttonmultiply = new System.Windows.Forms.Button();
            this.lblResalt = new System.Windows.Forms.Label();
            this.labelresalt = new System.Windows.Forms.Label();
            this.labelexit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ldlfirstnomber
            // 
            this.ldlfirstnomber.AutoSize = true;
            this.ldlfirstnomber.BackColor = System.Drawing.Color.Transparent;
            this.ldlfirstnomber.Font = new System.Drawing.Font("Snap ITC", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlfirstnomber.ForeColor = System.Drawing.Color.MediumOrchid;
            this.ldlfirstnomber.Location = new System.Drawing.Point(195, 136);
            this.ldlfirstnomber.Name = "ldlfirstnomber";
            this.ldlfirstnomber.Size = new System.Drawing.Size(0, 35);
            this.ldlfirstnomber.TabIndex = 0;
            // 
            // ldlsecondnomber
            // 
            this.ldlsecondnomber.AutoSize = true;
            this.ldlsecondnomber.BackColor = System.Drawing.Color.Transparent;
            this.ldlsecondnomber.Font = new System.Drawing.Font("Segoe UI Black", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlsecondnomber.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ldlsecondnomber.Location = new System.Drawing.Point(471, 134);
            this.ldlsecondnomber.Name = "ldlsecondnomber";
            this.ldlsecondnomber.Size = new System.Drawing.Size(236, 37);
            this.ldlsecondnomber.TabIndex = 1;
            this.ldlsecondnomber.Text = "/второе число\\";
            // 
            // textBnumber1
            // 
            this.textBnumber1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBnumber1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.textBnumber1.Location = new System.Drawing.Point(194, 233);
            this.textBnumber1.Name = "textBnumber1";
            this.textBnumber1.Size = new System.Drawing.Size(100, 24);
            this.textBnumber1.TabIndex = 2;
            this.textBnumber1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_keyDown);
            this.textBnumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // textBnumber2
            // 
            this.textBnumber2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBnumber2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.textBnumber2.Location = new System.Drawing.Point(539, 233);
            this.textBnumber2.Name = "textBnumber2";
            this.textBnumber2.Size = new System.Drawing.Size(100, 24);
            this.textBnumber2.TabIndex = 3;
            this.textBnumber2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_keyDown);
            this.textBnumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(149, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "/первое число\\";
            // 
            // buttonplus
            // 
            this.buttonplus.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonplus.FlatAppearance.BorderSize = 0;
            this.buttonplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonplus.Font = new System.Drawing.Font("Rage Italic", 67F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonplus.ForeColor = System.Drawing.Color.Cyan;
            this.buttonplus.Location = new System.Drawing.Point(194, 317);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(87, 87);
            this.buttonplus.TabIndex = 5;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = false;
            this.buttonplus.Click += new System.EventHandler(this.btn_Click);
            // 
            // buttonmines
            // 
            this.buttonmines.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonmines.FlatAppearance.BorderSize = 0;
            this.buttonmines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmines.Font = new System.Drawing.Font("NSimSun", 67F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmines.ForeColor = System.Drawing.Color.Cyan;
            this.buttonmines.Location = new System.Drawing.Point(307, 317);
            this.buttonmines.Name = "buttonmines";
            this.buttonmines.Size = new System.Drawing.Size(87, 87);
            this.buttonmines.TabIndex = 6;
            this.buttonmines.Text = "-";
            this.buttonmines.UseVisualStyleBackColor = false;
            this.buttonmines.Click += new System.EventHandler(this.btn_Click);
            // 
            // buttondivision
            // 
            this.buttondivision.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttondivision.FlatAppearance.BorderSize = 0;
            this.buttondivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondivision.Font = new System.Drawing.Font("Pivot Classic", 67F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondivision.ForeColor = System.Drawing.Color.Cyan;
            this.buttondivision.Location = new System.Drawing.Point(430, 317);
            this.buttondivision.Name = "buttondivision";
            this.buttondivision.Size = new System.Drawing.Size(100, 87);
            this.buttondivision.TabIndex = 7;
            this.buttondivision.Text = ":";
            this.buttondivision.UseVisualStyleBackColor = false;
            this.buttondivision.Click += new System.EventHandler(this.btn_Click);
            // 
            // buttonmultiply
            // 
            this.buttonmultiply.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonmultiply.FlatAppearance.BorderSize = 0;
            this.buttonmultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmultiply.Font = new System.Drawing.Font("Lucida Console", 67F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmultiply.ForeColor = System.Drawing.Color.Cyan;
            this.buttonmultiply.Location = new System.Drawing.Point(552, 317);
            this.buttonmultiply.Name = "buttonmultiply";
            this.buttonmultiply.Size = new System.Drawing.Size(87, 87);
            this.buttonmultiply.TabIndex = 8;
            this.buttonmultiply.Text = "x";
            this.buttonmultiply.UseVisualStyleBackColor = false;
            this.buttonmultiply.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblResalt
            // 
            this.lblResalt.AutoSize = true;
            this.lblResalt.BackColor = System.Drawing.Color.Transparent;
            this.lblResalt.Font = new System.Drawing.Font("Segoe UI Black", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResalt.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblResalt.Location = new System.Drawing.Point(300, 458);
            this.lblResalt.Name = "lblResalt";
            this.lblResalt.Size = new System.Drawing.Size(181, 37);
            this.lblResalt.TabIndex = 9;
            this.lblResalt.Text = "результат";
            // 
            // labelresalt
            // 
            this.labelresalt.AutoSize = true;
            this.labelresalt.BackColor = System.Drawing.Color.Transparent;
            this.labelresalt.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresalt.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelresalt.Location = new System.Drawing.Point(503, 458);
            this.labelresalt.Name = "labelresalt";
            this.labelresalt.Size = new System.Drawing.Size(34, 47);
            this.labelresalt.TabIndex = 10;
            this.labelresalt.Text = "*";
            // 
            // labelexit
            // 
            this.labelexit.AutoSize = true;
            this.labelexit.BackColor = System.Drawing.Color.Transparent;
            this.labelexit.Font = new System.Drawing.Font("Rage Italic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelexit.Location = new System.Drawing.Point(765, 521);
            this.labelexit.Name = "labelexit";
            this.labelexit.Size = new System.Drawing.Size(44, 18);
            this.labelexit.TabIndex = 11;
            this.labelexit.Text = "выход";
            this.labelexit.Click += new System.EventHandler(this.btn_exit);
            // 
            // калькулятор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 548);
            this.Controls.Add(this.labelexit);
            this.Controls.Add(this.labelresalt);
            this.Controls.Add(this.lblResalt);
            this.Controls.Add(this.buttonmultiply);
            this.Controls.Add(this.buttondivision);
            this.Controls.Add(this.buttonmines);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBnumber2);
            this.Controls.Add(this.textBnumber1);
            this.Controls.Add(this.ldlsecondnomber);
            this.Controls.Add(this.ldlfirstnomber);
            this.Font = new System.Drawing.Font("Rage Italic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "калькулятор";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "калькулятор";
            this.Load += new System.EventHandler(this.калькулятор_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldlfirstnomber;
        private System.Windows.Forms.Label ldlsecondnomber;
        private System.Windows.Forms.TextBox textBnumber1;
        private System.Windows.Forms.TextBox textBnumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonmines;
        private System.Windows.Forms.Button buttondivision;
        private System.Windows.Forms.Button buttonmultiply;
        private System.Windows.Forms.Label lblResalt;
        private System.Windows.Forms.Label labelresalt;
        private System.Windows.Forms.Label labelexit;
    }
}