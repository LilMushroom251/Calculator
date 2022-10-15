namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.Label();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // txtA
            // 
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtA.Location = new System.Drawing.Point(144, 31);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(214, 30);
            this.txtA.TabIndex = 3;
            // 
            // txtKQ
            // 
            this.txtKQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKQ.Location = new System.Drawing.Point(144, 112);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(214, 30);
            this.txtKQ.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Location = new System.Drawing.Point(144, 73);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(214, 30);
            this.txtB.TabIndex = 5;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(274, 159);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(84, 31);
            this.btCong.TabIndex = 6;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 210);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.Label txtKQ;
        private System.Windows.Forms.Label txtB;
        private System.Windows.Forms.Button btCong;
    }
}

