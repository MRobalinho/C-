﻿/* Testes Manuel Robalinho
 */
namespace SimpleCalculator
{
    partial class frmCalculator
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulitply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqrRoot = new System.Windows.Forms.Button();
            this.btnByTwo = new System.Windows.Forms.Button();
            this.btnByFour = new System.Windows.Forms.Button();
            this.textTot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textParc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(28, 63);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(193, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(27, 89);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(34, 23);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(67, 89);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(34, 23);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(107, 89);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(34, 23);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(27, 118);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(34, 23);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(67, 118);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(34, 23);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(107, 118);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(34, 23);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(28, 147);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(34, 23);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(68, 147);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(34, 23);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(108, 147);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(34, 23);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(28, 176);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(34, 23);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(67, 176);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(34, 23);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(108, 176);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(34, 23);
            this.btnEqual.TabIndex = 12;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.Leave += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(147, 89);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(34, 23);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(147, 118);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(34, 23);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulitply
            // 
            this.btnMulitply.Location = new System.Drawing.Point(147, 147);
            this.btnMulitply.Name = "btnMulitply";
            this.btnMulitply.Size = new System.Drawing.Size(34, 23);
            this.btnMulitply.TabIndex = 15;
            this.btnMulitply.Text = "*";
            this.btnMulitply.UseVisualStyleBackColor = true;
            this.btnMulitply.Click += new System.EventHandler(this.btnMulitply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(147, 176);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(34, 23);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(34, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSqrRoot
            // 
            this.btnSqrRoot.Location = new System.Drawing.Point(187, 118);
            this.btnSqrRoot.Name = "btnSqrRoot";
            this.btnSqrRoot.Size = new System.Drawing.Size(34, 23);
            this.btnSqrRoot.TabIndex = 18;
            this.btnSqrRoot.Text = "√";
            this.btnSqrRoot.UseVisualStyleBackColor = true;
            this.btnSqrRoot.Click += new System.EventHandler(this.btnSqrRoot_Click);
            // 
            // btnByTwo
            // 
            this.btnByTwo.Location = new System.Drawing.Point(187, 147);
            this.btnByTwo.Name = "btnByTwo";
            this.btnByTwo.Size = new System.Drawing.Size(34, 23);
            this.btnByTwo.TabIndex = 19;
            this.btnByTwo.Text = "½";
            this.btnByTwo.UseVisualStyleBackColor = true;
            this.btnByTwo.Click += new System.EventHandler(this.btnByTwo_Click);
            // 
            // btnByFour
            // 
            this.btnByFour.Location = new System.Drawing.Point(187, 176);
            this.btnByFour.Name = "btnByFour";
            this.btnByFour.Size = new System.Drawing.Size(34, 23);
            this.btnByFour.TabIndex = 20;
            this.btnByFour.Text = "¼";
            this.btnByFour.UseVisualStyleBackColor = true;
            this.btnByFour.Click += new System.EventHandler(this.btnByFour_Click);
            // 
            // textTot
            // 
            this.textTot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTot.Location = new System.Drawing.Point(28, 22);
            this.textTot.Name = "textTot";
            this.textTot.Size = new System.Drawing.Size(193, 22);
            this.textTot.TabIndex = 21;
            this.textTot.TextChanged += new System.EventHandler(this.textTot_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Memória do cálculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textParc
            // 
            this.textParc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textParc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textParc.Location = new System.Drawing.Point(227, 22);
            this.textParc.Name = "textParc";
            this.textParc.Size = new System.Drawing.Size(51, 22);
            this.textParc.TabIndex = 23;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 219);
            this.Controls.Add(this.textParc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTot);
            this.Controls.Add(this.btnByFour);
            this.Controls.Add(this.btnByTwo);
            this.Controls.Add(this.btnSqrRoot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMulitply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.Text = "Simple Calculator - MRobalinho";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulitply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSqrRoot;
        private System.Windows.Forms.Button btnByTwo;
        private System.Windows.Forms.Button btnByFour;
        private System.Windows.Forms.TextBox textTot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textParc;
    }
}

