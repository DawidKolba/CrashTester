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
            memoryToIncreaseLbl = new Label();
            MB_Label = new Label();
            increaseWorkingMemoryToBtn = new Button();
            workingMemoryValueToIncrease = new TextBox();
            setProcessHandlesBtn = new Button();
            exceedMaxArrayLengthBtn = new Button();
            noRespondingBtn = new Button();
            handlesCountTB = new TextBox();
            closeMainWindowRemainProcess = new Button();
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
            memoryToIncreaseLbl.AutoSize = true;
            memoryToIncreaseLbl.Location = new Point(510, 101);
            memoryToIncreaseLbl.Name = "memoryToIncreaseLbl";
            memoryToIncreaseLbl.Size = new Size(200, 20);
            memoryToIncreaseLbl.TabIndex = 4;
            memoryToIncreaseLbl.Text = "value of memory to increase:";
            // 
            // MB_Label
            // 
            MB_Label.AutoSize = true;
            MB_Label.Location = new Point(663, 127);
            MB_Label.Name = "MB_Label";
            MB_Label.Size = new Size(31, 20);
            MB_Label.TabIndex = 5;
            MB_Label.Text = "MB";
            // 
            // increaseWorkingMemoryToBtn
            // 
            increaseWorkingMemoryToBtn.Location = new Point(323, 187);
            increaseWorkingMemoryToBtn.Name = "increaseWorkingMemoryToBtn";
            increaseWorkingMemoryToBtn.Size = new Size(170, 50);
            increaseWorkingMemoryToBtn.TabIndex = 6;
            increaseWorkingMemoryToBtn.Text = "Increase working memory to:";
            increaseWorkingMemoryToBtn.UseVisualStyleBackColor = true;
            increaseWorkingMemoryToBtn.Click += increaseWorkingMemoryToBtn_Click;
            // 
            // workingMemoryValueToIncrease
            // 
            workingMemoryValueToIncrease.Location = new Point(510, 199);
            workingMemoryValueToIncrease.Name = "workingMemoryValueToIncrease";
            workingMemoryValueToIncrease.Size = new Size(125, 27);
            workingMemoryValueToIncrease.TabIndex = 7;
            // 
            // setProcessHandlesBtn
            // 
            setProcessHandlesBtn.Location = new Point(323, 253);
            setProcessHandlesBtn.Name = "setProcessHandlesBtn";
            setProcessHandlesBtn.Size = new Size(170, 48);
            setProcessHandlesBtn.TabIndex = 8;
            setProcessHandlesBtn.Text = "Set process handles to:";
            setProcessHandlesBtn.UseVisualStyleBackColor = true;
            setProcessHandlesBtn.Click += button2_ClickAsync;
            // 
            // button3
            // 
            exceedMaxArrayLengthBtn.Location = new Point(323, 310);
            exceedMaxArrayLengthBtn.Name = "button3";
            exceedMaxArrayLengthBtn.Size = new Size(127, 61);
            exceedMaxArrayLengthBtn.TabIndex = 9;
            exceedMaxArrayLengthBtn.Text = "Exceed max array length";
            exceedMaxArrayLengthBtn.UseVisualStyleBackColor = true;
            exceedMaxArrayLengthBtn.Click += ExceedMaxArrayLengthBtn_Click;
            // 
            // noRespondingBtn
            // 
            noRespondingBtn.Location = new Point(492, 314);
            noRespondingBtn.Name = "noRespondingBtn";
            noRespondingBtn.Size = new Size(127, 53);
            noRespondingBtn.TabIndex = 10;
            noRespondingBtn.Text = "No responding test";
            noRespondingBtn.UseVisualStyleBackColor = true;
            noRespondingBtn.Click += noRespondingBtn_Click;
            // 
            // handlesCountTB
            // 
            handlesCountTB.Location = new Point(510, 264);
            handlesCountTB.Name = "handlesCountTB";
            handlesCountTB.Size = new Size(94, 27);
            handlesCountTB.TabIndex = 11;
            // 
            // button2
            // 
            closeMainWindowRemainProcess.Location = new Point(635, 313);
            closeMainWindowRemainProcess.Name = "button2";
            closeMainWindowRemainProcess.Size = new Size(153, 55);
            closeMainWindowRemainProcess.TabIndex = 12;
            closeMainWindowRemainProcess.Text = "Close main window, remain process";
            closeMainWindowRemainProcess.UseVisualStyleBackColor = true;
            closeMainWindowRemainProcess.Click += closeMainWindowRemainProcess_Click;
            // 
            // MainCrasthesterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeMainWindowRemainProcess);
            Controls.Add(handlesCountTB);
            Controls.Add(noRespondingBtn);
            Controls.Add(exceedMaxArrayLengthBtn);
            Controls.Add(setProcessHandlesBtn);
            Controls.Add(workingMemoryValueToIncrease);
            Controls.Add(increaseWorkingMemoryToBtn);
            Controls.Add(MB_Label);
            Controls.Add(memoryToIncreaseLbl);
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
        private Label memoryToIncreaseLbl;
        private Label MB_Label;
        private Button increaseWorkingMemoryToBtn;
        private TextBox workingMemoryValueToIncrease;
        private Button setProcessHandlesBtn;
        private Button exceedMaxArrayLengthBtn;
        private Button noRespondingBtn;
        private TextBox handlesCountTB;
        private Button closeMainWindowRemainProcess;
    }
}