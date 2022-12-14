namespace Lab1
{
    partial class Form5
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.c_in = new System.Windows.Forms.TextBox();
            this.b_in = new System.Windows.Forms.TextBox();
            this.a_in = new System.Windows.Forms.TextBox();
            this.res_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(206, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "x:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_in
            // 
            this.c_in.Location = new System.Drawing.Point(187, 48);
            this.c_in.Name = "c_in";
            this.c_in.Size = new System.Drawing.Size(66, 22);
            this.c_in.TabIndex = 9;
            // 
            // b_in
            // 
            this.b_in.Location = new System.Drawing.Point(99, 48);
            this.b_in.Name = "b_in";
            this.b_in.Size = new System.Drawing.Size(66, 22);
            this.b_in.TabIndex = 8;
            // 
            // a_in
            // 
            this.a_in.Location = new System.Drawing.Point(19, 48);
            this.a_in.Name = "a_in";
            this.a_in.Size = new System.Drawing.Size(66, 22);
            this.a_in.TabIndex = 7;
            // 
            // res_textBox
            // 
            this.res_textBox.Location = new System.Drawing.Point(71, 150);
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.ReadOnly = true;
            this.res_textBox.Size = new System.Drawing.Size(124, 22);
            this.res_textBox.TabIndex = 14;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 191);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_in);
            this.Controls.Add(this.b_in);
            this.Controls.Add(this.a_in);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox c_in;
        private System.Windows.Forms.TextBox b_in;
        private System.Windows.Forms.TextBox a_in;
        private System.Windows.Forms.TextBox res_textBox;
    }
}