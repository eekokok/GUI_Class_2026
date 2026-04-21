namespace GUI_Class_2026
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Calculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Calculator
            // 
            this.btn_Calculator.Location = new System.Drawing.Point(256, 124);
            this.btn_Calculator.Name = "btn_Calculator";
            this.btn_Calculator.Size = new System.Drawing.Size(140, 67);
            this.btn_Calculator.TabIndex = 0;
            this.btn_Calculator.Text = "計算機";
            this.btn_Calculator.UseVisualStyleBackColor = true;
            this.btn_Calculator.Click += new System.EventHandler(this.btn_Calculator_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(852, 625);
            this.Controls.Add(this.btn_Calculator);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Label lab_ChangeLabel;
        private System.Windows.Forms.Button btn_ChangeLabel;
        private System.Windows.Forms.Button btn_Num1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button btn_Counter;
        private System.Windows.Forms.Button btnBigger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Calculator;
    }
}

