namespace WinFormsApp2
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
            label1=new Label();
            textBox1=new TextBox();
            button1=new Button();
            label2=new Label();
            label3=new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(152, 138);
            label1.Name="label1";
            label1.Size=new Size(50, 15);
            label1.TabIndex=0;
            label1.Text="攝氏(C):";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(208, 135);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=1;
            // 
            // button1
            // 
            button1.Location=new Point(223, 185);
            button1.Name="button1";
            button1.Size=new Size(75, 23);
            button1.TabIndex=2;
            button1.Text="轉換";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(152, 220);
            label2.Name="label2";
            label2.Size=new Size(48, 15);
            label2.TabIndex=3;
            label2.Text="華氏(F):";
            label2.Click+=label2_Click;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(208, 220);
            label3.Name="label3";
            label3.Size=new Size(139, 15);
            label3.TabIndex=4;
            label3.Text="請輸入華氏後案轉換按鈕";
            // 
            // Form2
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name="Form2";
            Text="Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}