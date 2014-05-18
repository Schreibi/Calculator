namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fold = new System.Windows.Forms.Button();
            this.deduct = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fold
            // 
            this.fold.Location = new System.Drawing.Point(22, 109);
            this.fold.Name = "fold";
            this.fold.Size = new System.Drawing.Size(48, 38);
            this.fold.TabIndex = 0;
            this.fold.Text = "+";
            this.fold.UseVisualStyleBackColor = true;
            this.fold.Click += new System.EventHandler(this.button1_Click);
            // 
            // deduct
            // 
            this.deduct.Location = new System.Drawing.Point(76, 109);
            this.deduct.Name = "deduct";
            this.deduct.Size = new System.Drawing.Size(48, 38);
            this.deduct.TabIndex = 1;
            this.deduct.Text = "-";
            this.deduct.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(22, 153);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(48, 38);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // share
            // 
            this.share.Location = new System.Drawing.Point(76, 153);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(48, 38);
            this.share.TabIndex = 3;
            this.share.Text = "/";
            this.share.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 266);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.share);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.deduct);
            this.Controls.Add(this.fold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fold;
        private System.Windows.Forms.Button deduct;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

