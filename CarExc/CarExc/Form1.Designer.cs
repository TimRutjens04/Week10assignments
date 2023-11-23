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
            label1.Location = new Point(386, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Current speed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Top speed: ";
            // 
            // pbSpeed
            // 
            pbSpeed.Location = new Point(514, 93);
            pbSpeed.Margin = new Padding(4, 5, 4, 5);
            pbSpeed.Name = "pbSpeed";
            pbSpeed.Size = new Size(523, 45);
            pbSpeed.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSaab);
            groupBox1.Controls.Add(rbFerrari);
            groupBox1.Controls.Add(rbFiat);
            groupBox1.Location = new Point(41, 55);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(177, 175);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Brand:";
            // 
            // rbSaab
            // 
            rbSaab.AutoSize = true;
            rbSaab.Location = new Point(9, 122);
            rbSaab.Margin = new Padding(4, 5, 4, 5);
            rbSaab.Name = "rbSaab";
            rbSaab.Size = new Size(76, 29);
            rbSaab.TabIndex = 6;
            rbSaab.TabStop = true;
            rbSaab.Text = "Saab";
            rbSaab.UseVisualStyleBackColor = true;
            rbSaab.CheckedChanged += rbSaab_CheckedChanged;
            // 
            // rbFerrari
            // 
            rbFerrari.AutoSize = true;
            rbFerrari.Location = new Point(9, 38);
            rbFerrari.Margin = new Padding(4, 5, 4, 5);
            rbFerrari.Name = "rbFerrari";
            rbFerrari.Size = new Size(86, 29);
            rbFerrari.TabIndex = 4;
            rbFerrari.TabStop = true;
            rbFerrari.Text = "Ferrari";
            rbFerrari.UseVisualStyleBackColor = true;
            rbFerrari.CheckedChanged += rbFerrari_CheckedChanged;
            // 
            // rbFiat
            // 
            rbFiat.AutoSize = true;
            rbFiat.Location = new Point(9, 80);
            rbFiat.Margin = new Padding(4, 5, 4, 5);
            rbFiat.Name = "rbFiat";
            rbFiat.Size = new Size(65, 29);
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
            lblCurrentSpeed.Location = new Point(704, 55);
            lblCurrentSpeed.Margin = new Padding(4, 0, 4, 0);
            lblCurrentSpeed.Name = "lblCurrentSpeed";
            lblCurrentSpeed.Size = new Size(125, 27);
            lblCurrentSpeed.TabIndex = 4;
            lblCurrentSpeed.Text = "Current speed";
            // 
            // btnAccelerate
            // 
            btnAccelerate.Location = new Point(514, 268);
            btnAccelerate.Margin = new Padding(4, 5, 4, 5);
            btnAccelerate.Name = "btnAccelerate";
            btnAccelerate.Size = new Size(193, 78);
            btnAccelerate.TabIndex = 5;
            btnAccelerate.Text = "Pedal to the metal";
            btnAccelerate.UseVisualStyleBackColor = true;
            btnAccelerate.Click += btnAccelerate_Click;
            // 
            // btnBrake
            // 
            btnBrake.Location = new Point(844, 268);
            btnBrake.Margin = new Padding(4, 5, 4, 5);
            btnBrake.Name = "btnBrake";
            btnBrake.Size = new Size(193, 78);
            btnBrake.TabIndex = 6;
            btnBrake.Text = "Hit the brakes";
            btnBrake.UseVisualStyleBackColor = true;
            btnBrake.Click += btnBrake_Click;
            // 
            // lblTopSpeed
            // 
            lblTopSpeed.AutoSize = true;
            lblTopSpeed.BorderStyle = BorderStyle.FixedSingle;
            lblTopSpeed.Location = new Point(704, 177);
            lblTopSpeed.Margin = new Padding(4, 0, 4, 0);
            lblTopSpeed.Name = "lblTopSpeed";
            lblTopSpeed.Size = new Size(93, 27);
            lblTopSpeed.TabIndex = 7;
            lblTopSpeed.Text = "TopSpeed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 390);
            Controls.Add(lblTopSpeed);
            Controls.Add(btnBrake);
            Controls.Add(btnAccelerate);
            Controls.Add(lblCurrentSpeed);
            Controls.Add(groupBox1);
            Controls.Add(pbSpeed);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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