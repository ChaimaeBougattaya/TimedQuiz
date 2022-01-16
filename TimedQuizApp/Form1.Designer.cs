
namespace TimedQuizApp
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
            this.components = new System.ComponentModel.Container();
            this.Timelabel = new System.Windows.Forms.Label();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.equallabel1 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.equallabel2 = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.equallabel3 = new System.Windows.Forms.Label();
            this.multiplication = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.equallabel4 = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.Label();
            this.divisionRightLabel = new System.Windows.Forms.Label();
            this.divisionLeftLabel = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.timerquiz = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // Timelabel
            // 
            this.Timelabel.BackColor = System.Drawing.Color.LightBlue;
            this.Timelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Timelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Timelabel.Location = new System.Drawing.Point(290, 9);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(112, 30);
            this.Timelabel.TabIndex = 0;
            this.Timelabel.Text = "00:00";
            this.Timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTimeLeft.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeLeft.ForeColor = System.Drawing.Color.Black;
            this.labelTimeLeft.Location = new System.Drawing.Point(179, 9);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(105, 30);
            this.labelTimeLeft.TabIndex = 1;
            this.labelTimeLeft.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusLeftLabel.Location = new System.Drawing.Point(71, 83);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(40, 30);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusRightLabel.Location = new System.Drawing.Point(192, 83);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(40, 30);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(128, 80);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 30);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equallabel1
            // 
            this.equallabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equallabel1.Location = new System.Drawing.Point(259, 81);
            this.equallabel1.Name = "equallabel1";
            this.equallabel1.Size = new System.Drawing.Size(40, 30);
            this.equallabel1.TabIndex = 5;
            this.equallabel1.Text = "=";
            this.equallabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.Window;
            this.sum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(339, 78);
            this.sum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(80, 39);
            this.sum.TabIndex = 2;
            // 
            // difference
            // 
            this.difference.BackColor = System.Drawing.SystemColors.Window;
            this.difference.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difference.Location = new System.Drawing.Point(339, 128);
            this.difference.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(80, 39);
            this.difference.TabIndex = 3;
            // 
            // equallabel2
            // 
            this.equallabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equallabel2.Location = new System.Drawing.Point(259, 131);
            this.equallabel2.Name = "equallabel2";
            this.equallabel2.Size = new System.Drawing.Size(40, 30);
            this.equallabel2.TabIndex = 10;
            this.equallabel2.Text = "=";
            this.equallabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(130, 131);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 30);
            this.minus.TabIndex = 9;
            this.minus.Text = "-";
            this.minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusRightLabel.Location = new System.Drawing.Point(192, 134);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(40, 30);
            this.minusRightLabel.TabIndex = 8;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusLeftLabel.Location = new System.Drawing.Point(72, 131);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(40, 30);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.SystemColors.Window;
            this.product.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.product.Location = new System.Drawing.Point(339, 176);
            this.product.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(80, 39);
            this.product.TabIndex = 4;
            // 
            // equallabel3
            // 
            this.equallabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equallabel3.Location = new System.Drawing.Point(259, 176);
            this.equallabel3.Name = "equallabel3";
            this.equallabel3.Size = new System.Drawing.Size(40, 30);
            this.equallabel3.TabIndex = 15;
            this.equallabel3.Text = "=";
            this.equallabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplication.Location = new System.Drawing.Point(130, 176);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(40, 30);
            this.multiplication.TabIndex = 14;
            this.multiplication.Text = "x";
            this.multiplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timesRightLabel.Location = new System.Drawing.Point(192, 179);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(40, 30);
            this.timesRightLabel.TabIndex = 13;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timesLeftLabel.Location = new System.Drawing.Point(71, 179);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(40, 30);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.BackColor = System.Drawing.SystemColors.Window;
            this.quotient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quotient.Location = new System.Drawing.Point(339, 226);
            this.quotient.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(80, 39);
            this.quotient.TabIndex = 5;
            // 
            // equallabel4
            // 
            this.equallabel4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equallabel4.Location = new System.Drawing.Point(259, 229);
            this.equallabel4.Name = "equallabel4";
            this.equallabel4.Size = new System.Drawing.Size(40, 30);
            this.equallabel4.TabIndex = 20;
            this.equallabel4.Text = "=";
            this.equallabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.division.Location = new System.Drawing.Point(130, 229);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(40, 30);
            this.division.TabIndex = 19;
            this.division.Text = "÷";
            this.division.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisionRightLabel
            // 
            this.divisionRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divisionRightLabel.Location = new System.Drawing.Point(192, 232);
            this.divisionRightLabel.Name = "divisionRightLabel";
            this.divisionRightLabel.Size = new System.Drawing.Size(40, 30);
            this.divisionRightLabel.TabIndex = 18;
            this.divisionRightLabel.Text = "?";
            this.divisionRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisionLeftLabel
            // 
            this.divisionLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divisionLeftLabel.Location = new System.Drawing.Point(71, 229);
            this.divisionLeftLabel.Name = "divisionLeftLabel";
            this.divisionLeftLabel.Size = new System.Drawing.Size(40, 30);
            this.divisionLeftLabel.TabIndex = 17;
            this.divisionLeftLabel.Text = "?";
            this.divisionLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startbtn
            // 
            this.startbtn.AutoSize = true;
            this.startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startbtn.Location = new System.Drawing.Point(164, 305);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(146, 40);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Start The Quiz";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // timerquiz
            // 
            this.timerquiz.Interval = 1000;
            this.timerquiz.Tick += new System.EventHandler(this.timerquiz_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.equallabel4);
            this.Controls.Add(this.division);
            this.Controls.Add(this.divisionRightLabel);
            this.Controls.Add(this.divisionLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.equallabel3);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.equallabel2);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.equallabel1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.Timelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label equallabel1;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label equallabel2;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label equallabel3;
        private System.Windows.Forms.Label multiplication;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label equallabel4;
        private System.Windows.Forms.Label division;
        private System.Windows.Forms.Label divisionRightLabel;
        private System.Windows.Forms.Label divisionLeftLabel;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Timer timerquiz;
    }
}

