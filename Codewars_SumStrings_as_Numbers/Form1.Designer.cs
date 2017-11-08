namespace Codewars_SumStrings_as_Numbers
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(61, 39);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(351, 20);
            this.textBox_A.TabIndex = 0;
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(61, 89);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(351, 20);
            this.textBox_B.TabIndex = 0;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(61, 144);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(351, 20);
            this.textBox_Result.TabIndex = 0;
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.Location = new System.Drawing.Point(480, 39);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(75, 23);
            this.button_Evaluate.TabIndex = 1;
            this.button_Evaluate.Text = "Evaluate";
            this.button_Evaluate.UseVisualStyleBackColor = true;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 249);
            this.Controls.Add(this.button_Evaluate);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_Evaluate;
    }
}

