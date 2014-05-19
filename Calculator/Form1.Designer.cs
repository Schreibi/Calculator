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
            this.fnumber = new System.Windows.Forms.TextBox();
            this.snumber = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
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
            this.deduct.Click += new System.EventHandler(this.deduct_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(22, 153);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(48, 38);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // share
            // 
            this.share.Location = new System.Drawing.Point(76, 153);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(48, 38);
            this.share.TabIndex = 3;
            this.share.Text = "/";
            this.share.UseVisualStyleBackColor = true;
            this.share.Click += new System.EventHandler(this.share_Click);
            // 
            // fnumber
            // 
            this.fnumber.Location = new System.Drawing.Point(42, 25);
            this.fnumber.Name = "fnumber";
            this.fnumber.Size = new System.Drawing.Size(94, 20);
            this.fnumber.TabIndex = 4;
            // 
            // snumber
            // 
            this.snumber.Location = new System.Drawing.Point(151, 25);
            this.snumber.Name = "snumber";
            this.snumber.Size = new System.Drawing.Size(94, 20);
            this.snumber.TabIndex = 5;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(96, 67);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(94, 20);
            this.result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 266);
            this.Controls.Add(this.result);
            this.Controls.Add(this.snumber);
            this.Controls.Add(this.fnumber);
            this.Controls.Add(this.share);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.deduct);
            this.Controls.Add(this.fold);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fold;
        private System.Windows.Forms.Button deduct;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.TextBox fnumber;
        private System.Windows.Forms.TextBox snumber;
        private System.Windows.Forms.TextBox result;
    }
}

