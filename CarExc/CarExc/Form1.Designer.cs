namespace CarExc
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
            label1 = new Label();
            label2 = new Label();
            pbSpeed = new ProgressBar();
            groupBox1 = new GroupBox();
            rbSaab = new RadioButton();
            rbFerrari = new RadioButton();
            rbFiat = new RadioButton();
            lblCurrentSpeed = new Label();
            btnAccelerate = new Button();
            btnBrake = new Button();
            lblTopSpeed = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 48);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Current speed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 106);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Top speed: ";
            // 
            // pbSpeed
            // 
            pbSpeed.Location = new Point(360, 56);
            pbSpeed.Name = "pbSpeed";
            pbSpeed.Size = new Size(366, 27);
            pbSpeed.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSaab);
            groupBox1.Controls.Add(rbFerrari);
            groupBox1.Controls.Add(rbFiat);
            groupBox1.Location = new Point(29, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(124, 105);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Brand:";
            // 
            // rbSaab
            // 
            rbSaab.AutoSize = true;
            rbSaab.Location = new Point(6, 73);
            rbSaab.Name = "rbSaab";
            rbSaab.Size = new Size(50, 19);
            rbSaab.TabIndex = 6;
            rbSaab.TabStop = true;
            rbSaab.Text = "Saab";
            rbSaab.UseVisualStyleBackColor = true;
            rbSaab.CheckedChanged += rbSaab_CheckedChanged;
            // 
            // rbFerrari
            // 
            rbFerrari.AutoSize = true;
            rbFerrari.Location = new Point(6, 23);
            rbFerrari.Name = "rbFerrari";
            rbFerrari.Size = new Size(58, 19);
            rbFerrari.TabIndex = 4;
            rbFerrari.TabStop = true;
            rbFerrari.Text = "Ferrari";
            rbFerrari.UseVisualStyleBackColor = true;
            rbFerrari.CheckedChanged += rbFerrari_CheckedChanged;
            // 
            // rbFiat
            // 
            rbFiat.AutoSize = true;
            rbFiat.Location = new Point(6, 48);
            rbFiat.Name = "rbFiat";
            rbFiat.Size = new Size(44, 19);
            rbFiat.TabIndex = 5;
            rbFiat.TabStop = true;
            rbFiat.Text = "Fiat";
            rbFiat.UseVisualStyleBackColor = true;
            rbFiat.CheckedChanged += rbFiat_CheckedChanged;
            // 
            // lblCurrentSpeed
            // 
            lblCurrentSpeed.AutoSize = true;
            lblCurrentSpeed.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentSpeed.Location = new Point(493, 33);
            lblCurrentSpeed.Name = "lblCurrentSpeed";
            lblCurrentSpeed.Size = new Size(83, 17);
            lblCurrentSpeed.TabIndex = 4;
            lblCurrentSpeed.Text = "Current speed";
            // 
            // btnAccelerate
            // 
            btnAccelerate.Location = new Point(360, 161);
            btnAccelerate.Name = "btnAccelerate";
            btnAccelerate.Size = new Size(135, 47);
            btnAccelerate.TabIndex = 5;
            btnAccelerate.Text = "Pedal to the metal";
            btnAccelerate.UseVisualStyleBackColor = true;
            btnAccelerate.Click += btnAccelerate_Click;
            // 
            // btnBrake
            // 
            btnBrake.Location = new Point(591, 161);
            btnBrake.Name = "btnBrake";
            btnBrake.Size = new Size(135, 47);
            btnBrake.TabIndex = 6;
            btnBrake.Text = "Hit the brakes";
            btnBrake.UseVisualStyleBackColor = true;
            // 
            // lblTopSpeed
            // 
            lblTopSpeed.AutoSize = true;
            lblTopSpeed.BorderStyle = BorderStyle.FixedSingle;
            lblTopSpeed.Location = new Point(493, 106);
            lblTopSpeed.Name = "lblTopSpeed";
            lblTopSpeed.Size = new Size(60, 17);
            lblTopSpeed.TabIndex = 7;
            lblTopSpeed.Text = "TopSpeed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 234);
            Controls.Add(lblTopSpeed);
            Controls.Add(btnBrake);
            Controls.Add(btnAccelerate);
            Controls.Add(lblCurrentSpeed);
            Controls.Add(groupBox1);
            Controls.Add(pbSpeed);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar pbSpeed;
        private GroupBox groupBox1;
        private RadioButton rbSaab;
        private RadioButton rbFerrari;
        private RadioButton rbFiat;
        private Label lblCurrentSpeed;
        private Button btnAccelerate;
        private Button btnBrake;
        private Label lblTopSpeed;
    }
}