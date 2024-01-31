namespace CrashTester
{
    partial class MainCrasthesterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            currentProcessInfoLb = new Label();
            divByZeroBtn = new Button();
            increaseMemoryBtn = new Button();
            increaseMemoryInMB_ValueTB = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            workingMemoryValueToIncrease = new TextBox();
            SuspendLayout();
            // 
            // currentProcessInfoLb
            // 
            currentProcessInfoLb.AutoSize = true;
            currentProcessInfoLb.Location = new Point(27, 34);
            currentProcessInfoLb.Name = "currentProcessInfoLb";
            currentProcessInfoLb.Size = new Size(90, 20);
            currentProcessInfoLb.TabIndex = 0;
            currentProcessInfoLb.Text = "Current info:";
            // 
            // divByZeroBtn
            // 
            divByZeroBtn.Location = new Point(323, 34);
            divByZeroBtn.Name = "divByZeroBtn";
            divByZeroBtn.Size = new Size(170, 61);
            divByZeroBtn.TabIndex = 1;
            divByZeroBtn.Text = "Divide by zero";
            divByZeroBtn.UseVisualStyleBackColor = true;
            divByZeroBtn.Click += divByZeroBtn_Click;
            // 
            // increaseMemoryBtn
            // 
            increaseMemoryBtn.Location = new Point(323, 112);
            increaseMemoryBtn.Name = "increaseMemoryBtn";
            increaseMemoryBtn.Size = new Size(170, 51);
            increaseMemoryBtn.TabIndex = 2;
            increaseMemoryBtn.Text = "Increase private virtual memory usage to:";
            increaseMemoryBtn.UseVisualStyleBackColor = true;
            increaseMemoryBtn.Click += increaseMemoryBtn_Click;
            // 
            // increaseMemoryInMB_ValueTB
            // 
            increaseMemoryInMB_ValueTB.Location = new Point(510, 124);
            increaseMemoryInMB_ValueTB.Name = "increaseMemoryInMB_ValueTB";
            increaseMemoryInMB_ValueTB.Size = new Size(147, 39);
            increaseMemoryInMB_ValueTB.TabIndex = 3;
            increaseMemoryInMB_ValueTB.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 101);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 4;
            label1.Text = "value of memory to increase:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(663, 127);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 5;
            label2.Text = "MB";
            // 
            // button1
            // 
            button1.Location = new Point(323, 187);
            button1.Name = "button1";
            button1.Size = new Size(170, 50);
            button1.TabIndex = 6;
            button1.Text = "Increase working memory to:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // workingMemoryValueToIncrease
            // 
            workingMemoryValueToIncrease.Location = new Point(510, 199);
            workingMemoryValueToIncrease.Name = "workingMemoryValueToIncrease";
            workingMemoryValueToIncrease.Size = new Size(125, 27);
            workingMemoryValueToIncrease.TabIndex = 7;
            // 
            // MainCrasthesterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(workingMemoryValueToIncrease);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(increaseMemoryInMB_ValueTB);
            Controls.Add(increaseMemoryBtn);
            Controls.Add(divByZeroBtn);
            Controls.Add(currentProcessInfoLb);
            Name = "MainCrasthesterForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentProcessInfoLb;
        private Button divByZeroBtn;
        private Button increaseMemoryBtn;
        private RichTextBox increaseMemoryInMB_ValueTB;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox workingMemoryValueToIncrease;
    }
}