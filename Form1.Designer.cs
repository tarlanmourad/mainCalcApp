namespace mainCalcApp
{
    partial class frmCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalc));
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeven.Location = new System.Drawing.Point(31, 246);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(142, 47);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEight.Location = new System.Drawing.Point(181, 246);
            this.btnEight.Margin = new System.Windows.Forms.Padding(4);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(142, 47);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNine.Location = new System.Drawing.Point(331, 246);
            this.btnNine.Margin = new System.Windows.Forms.Padding(4);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(142, 47);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivide.Location = new System.Drawing.Point(481, 356);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(142, 47);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCE.Location = new System.Drawing.Point(31, 191);
            this.btnCE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(142, 47);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnC.Location = new System.Drawing.Point(181, 191);
            this.btnC.Margin = new System.Windows.Forms.Padding(4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(142, 47);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiply.Location = new System.Drawing.Point(481, 301);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(142, 47);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSix.Location = new System.Drawing.Point(331, 301);
            this.btnSix.Margin = new System.Windows.Forms.Padding(4);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(142, 47);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFive.Location = new System.Drawing.Point(181, 301);
            this.btnFive.Margin = new System.Windows.Forms.Padding(4);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(142, 47);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFour.Location = new System.Drawing.Point(31, 301);
            this.btnFour.Margin = new System.Windows.Forms.Padding(4);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(142, 47);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinus.Location = new System.Drawing.Point(481, 246);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(142, 47);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThree.Location = new System.Drawing.Point(331, 356);
            this.btnThree.Margin = new System.Windows.Forms.Padding(4);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(142, 47);
            this.btnThree.TabIndex = 12;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTwo.Location = new System.Drawing.Point(181, 356);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(142, 47);
            this.btnTwo.TabIndex = 11;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOne.Location = new System.Drawing.Point(31, 356);
            this.btnOne.Margin = new System.Windows.Forms.Padding(4);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(142, 47);
            this.btnOne.TabIndex = 10;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(45)))));
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEqual.Location = new System.Drawing.Point(331, 411);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(293, 47);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.Location = new System.Drawing.Point(481, 191);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(142, 47);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecimal.Location = new System.Drawing.Point(181, 411);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(142, 47);
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZero.Location = new System.Drawing.Point(31, 411);
            this.btnZero.Margin = new System.Windows.Forms.Padding(4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(142, 47);
            this.btnZero.TabIndex = 15;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Result.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(217, 37);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(341, 54);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox_Result_TextChanged);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.labelCurrentOperation.Location = new System.Drawing.Point(24, 15);
            this.labelCurrentOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 29);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.textBox_Result);
            this.panel1.Controls.Add(this.labelCurrentOperation);
            this.panel1.Location = new System.Drawing.Point(31, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 130);
            this.panel1.TabIndex = 22;
            // 
            // btnBS
            // 
            this.btnBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBS.Location = new System.Drawing.Point(331, 191);
            this.btnBS.Margin = new System.Windows.Forms.Padding(4);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(142, 47);
            this.btnBS.TabIndex = 23;
            this.btnBS.Text = "←";
            this.btnBS.UseVisualStyleBackColor = false;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(655, 491);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBS;
    }
}

