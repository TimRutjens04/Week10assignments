namespace WinFormsApp1
{
    partial class Form1
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
            button1 = new Button();
            progressBar1 = new ProgressBar();
            trackBar1 = new TrackBar();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btBGSwitch = new Button();
            tbWeight = new TextBox();
            tbHeight = new TextBox();
            label2 = new Label();
            lKG = new Label();
            lM = new Label();
            bBMI = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.Aantekening_2020_09_01_193517;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(323, 140);
            button1.TabIndex = 0;
            button1.Text = "Wubba lubba dub dub\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(354, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(434, 39);
            progressBar1.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.GrayText;
            trackBar1.Cursor = Cursors.NoMoveHoriz;
            trackBar1.Location = new Point(354, 107);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(434, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 20;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(544, 62);
            label1.Name = "label1";
            label1.Size = new Size(244, 37);
            label1.TabIndex = 3;
            label1.Text = "Follow the trackbar";
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 202);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(164, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Make background go brrrr";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 227);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Uno reverse";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btBGSwitch
            // 
            btBGSwitch.Location = new Point(12, 252);
            btBGSwitch.Name = "btBGSwitch";
            btBGSwitch.Size = new Size(164, 40);
            btBGSwitch.TabIndex = 6;
            btBGSwitch.Text = "Background switcher";
            btBGSwitch.UseVisualStyleBackColor = true;
            btBGSwitch.Click += btBGSwitch_Click;
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(636, 202);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(99, 23);
            tbWeight.TabIndex = 7;
            tbWeight.TextChanged += textBox1_TextChanged;
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(636, 252);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(99, 23);
            tbHeight.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // lKG
            // 
            lKG.AutoSize = true;
            lKG.Location = new Point(544, 205);
            lKG.Name = "lKG";
            lKG.Size = new Size(75, 15);
            lKG.TabIndex = 10;
            lKG.Text = "Weight in KG";
            lKG.Click += label3_Click;
            // 
            // lM
            // 
            lM.AutoSize = true;
            lM.Location = new Point(544, 255);
            lM.Name = "lM";
            lM.Size = new Size(70, 15);
            lM.TabIndex = 11;
            lM.Text = "Height in M";
            // 
            // bBMI
            // 
            bBMI.Location = new Point(544, 294);
            bBMI.Name = "bBMI";
            bBMI.Size = new Size(191, 51);
            bBMI.TabIndex = 12;
            bBMI.Text = "Calculate BMI";
            bBMI.UseVisualStyleBackColor = true;
            bBMI.Click += bBMI_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bBMI);
            Controls.Add(lM);
            Controls.Add(lKG);
            Controls.Add(label2);
            Controls.Add(tbHeight);
            Controls.Add(tbWeight);
            Controls.Add(btBGSwitch);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btBGSwitch;
        private TextBox tbWeight;
        private TextBox tbHeight;
        private Label label2;
        private Label lKG;
        private Label lM;
        private Button bBMI;
    }
}