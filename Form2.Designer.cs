namespace Lab1
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
            this.a_in = new System.Windows.Forms.TextBox();
            this.b_in = new System.Windows.Forms.TextBox();
            this.c_in = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c_out = new System.Windows.Forms.TextBox();
            this.b_out = new System.Windows.Forms.TextBox();
            this.a_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // a_in
            // 
            this.a_in.Location = new System.Drawing.Point(47, 29);
            this.a_in.Name = "a_in";
            this.a_in.Size = new System.Drawing.Size(66, 22);
            this.a_in.TabIndex = 0;
            // 
            // b_in
            // 
            this.b_in.Location = new System.Drawing.Point(47, 69);
            this.b_in.Name = "b_in";
            this.b_in.Size = new System.Drawing.Size(66, 22);
            this.b_in.TabIndex = 1;
            // 
            // c_in
            // 
            this.c_in.Location = new System.Drawing.Point(47, 109);
            this.c_in.Name = "c_in";
            this.c_in.Size = new System.Drawing.Size(66, 22);
            this.c_in.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "c:";
            // 
            // c_out
            // 
            this.c_out.Location = new System.Drawing.Point(235, 108);
            this.c_out.Name = "c_out";
            this.c_out.ReadOnly = true;
            this.c_out.Size = new System.Drawing.Size(66, 22);
            this.c_out.TabIndex = 7;
            // 
            // b_out
            // 
            this.b_out.Location = new System.Drawing.Point(235, 68);
            this.b_out.Name = "b_out";
            this.b_out.ReadOnly = true;
            this.b_out.Size = new System.Drawing.Size(66, 22);
            this.b_out.TabIndex = 8;
            // 
            // a_out
            // 
            this.a_out.Location = new System.Drawing.Point(235, 28);
            this.a_out.Name = "a_out";
            this.a_out.ReadOnly = true;
            this.a_out.Size = new System.Drawing.Size(66, 22);
            this.a_out.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 176);
            this.Controls.Add(this.a_out);
            this.Controls.Add(this.b_out);
            this.Controls.Add(this.c_out);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_in);
            this.Controls.Add(this.b_in);
            this.Controls.Add(this.a_in);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a_in;
        private System.Windows.Forms.TextBox b_in;
        private System.Windows.Forms.TextBox c_in;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox c_out;
        private System.Windows.Forms.TextBox b_out;
        private System.Windows.Forms.TextBox a_out;
    }
}