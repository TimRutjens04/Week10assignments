namespace TruckManagement_exc
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
            gbA = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            maxBoxA = new TextBox();
            maxPalletA = new TextBox();
            gbB = new GroupBox();
            label6 = new Label();
            label3 = new Label();
            maxBoxB = new TextBox();
            maxPalletB = new TextBox();
            gbC = new GroupBox();
            label5 = new Label();
            label2 = new Label();
            maxBoxC = new TextBox();
            maxPalletC = new TextBox();
            gbOrder = new GroupBox();
            rbC = new RadioButton();
            rbB = new RadioButton();
            rbA = new RadioButton();
            label7 = new Label();
            textBox1 = new TextBox();
            btnCalculate = new Button();
            gbA.SuspendLayout();
            gbB.SuspendLayout();
            gbC.SuspendLayout();
            gbOrder.SuspendLayout();
            SuspendLayout();
            // 
            // gbA
            // 
            gbA.Controls.Add(label4);
            gbA.Controls.Add(label1);
            gbA.Controls.Add(maxBoxA);
            gbA.Controls.Add(maxPalletA);
            gbA.Location = new Point(12, 12);
            gbA.Name = "gbA";
            gbA.Size = new Size(248, 137);
            gbA.TabIndex = 0;
            gbA.TabStop = false;
            gbA.Text = "Info about Truck A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 82);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 1;
            label4.Text = "Max. boxes per pallet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 1;
            label1.Text = "Max. pallets per truck:\r\n";
            // 
            // maxBoxA
            // 
            maxBoxA.Location = new Point(140, 74);
            maxBoxA.Name = "maxBoxA";
            maxBoxA.Size = new Size(108, 23);
            maxBoxA.TabIndex = 5;
            // 
            // maxPalletA
            // 
            maxPalletA.Location = new Point(140, 45);
            maxPalletA.Name = "maxPalletA";
            maxPalletA.Size = new Size(108, 23);
            maxPalletA.TabIndex = 4;
            maxPalletA.TextChanged += textBox2_TextChanged;
            // 
            // gbB
            // 
            gbB.Controls.Add(label6);
            gbB.Controls.Add(label3);
            gbB.Controls.Add(maxBoxB);
            gbB.Controls.Add(maxPalletB);
            gbB.Location = new Point(12, 155);
            gbB.Name = "gbB";
            gbB.Size = new Size(248, 137);
            gbB.TabIndex = 1;
            gbB.TabStop = false;
            gbB.Text = "Info about Truck B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 77);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 7;
            label6.Text = "Max. boxes per pallet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 48);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 5;
            label3.Text = "Max. pallets per truck:\r\n";
            // 
            // maxBoxB
            // 
            maxBoxB.Location = new Point(140, 74);
            maxBoxB.Name = "maxBoxB";
            maxBoxB.Size = new Size(108, 23);
            maxBoxB.TabIndex = 4;
            // 
            // maxPalletB
            // 
            maxPalletB.Location = new Point(140, 45);
            maxPalletB.Name = "maxPalletB";
            maxPalletB.Size = new Size(108, 23);
            maxPalletB.TabIndex = 5;
            // 
            // gbC
            // 
            gbC.Controls.Add(label5);
            gbC.Controls.Add(label2);
            gbC.Controls.Add(maxBoxC);
            gbC.Controls.Add(maxPalletC);
            gbC.Location = new Point(12, 301);
            gbC.Name = "gbC";
            gbC.Size = new Size(248, 137);
            gbC.TabIndex = 1;
            gbC.TabStop = false;
            gbC.Text = "Info about Truck C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 73);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 6;
            label5.Text = "Max. boxes per pallet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 4;
            label2.Text = "Max. pallets per truck:\r\n";
            // 
            // maxBoxC
            // 
            maxBoxC.Location = new Point(140, 70);
            maxBoxC.Name = "maxBoxC";
            maxBoxC.Size = new Size(108, 23);
            maxBoxC.TabIndex = 4;
            // 
            // maxPalletC
            // 
            maxPalletC.Location = new Point(140, 41);
            maxPalletC.Name = "maxPalletC";
            maxPalletC.Size = new Size(108, 23);
            maxPalletC.TabIndex = 5;
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(rbC);
            gbOrder.Controls.Add(rbB);
            gbOrder.Controls.Add(rbA);
            gbOrder.Controls.Add(label7);
            gbOrder.Controls.Add(textBox1);
            gbOrder.Location = new Point(294, 12);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(494, 155);
            gbOrder.TabIndex = 2;
            gbOrder.TabStop = false;
            gbOrder.Text = "Info about Order";
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Location = new Point(221, 119);
            rbC.Name = "rbC";
            rbC.Size = new Size(64, 19);
            rbC.TabIndex = 7;
            rbC.TabStop = true;
            rbC.Text = "Truck C";
            rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Location = new Point(221, 94);
            rbB.Name = "rbB";
            rbB.Size = new Size(63, 19);
            rbB.TabIndex = 6;
            rbB.TabStop = true;
            rbB.Text = "Truck B";
            rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Location = new Point(221, 69);
            rbA.Name = "rbA";
            rbA.Size = new Size(64, 19);
            rbA.TabIndex = 5;
            rbA.TabStop = true;
            rbA.Text = "Truck A";
            rbA.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 45);
            label7.Name = "label7";
            label7.Size = new Size(152, 15);
            label7.TabIndex = 4;
            label7.Text = "No. of boxes to be shipped:\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(294, 195);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(494, 52);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(btnCalculate);
            Controls.Add(gbOrder);
            Controls.Add(gbC);
            Controls.Add(gbB);
            Controls.Add(gbA);
            Name = "Form1";
            Text = "Form1";
            gbA.ResumeLayout(false);
            gbA.PerformLayout();
            gbB.ResumeLayout(false);
            gbB.PerformLayout();
            gbC.ResumeLayout(false);
            gbC.PerformLayout();
            gbOrder.ResumeLayout(false);
            gbOrder.PerformLayout();
            ResumeLayout(false);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private GroupBox gbA;
        private GroupBox gbB;
        private GroupBox gbC;
        private GroupBox gbOrder;
        private Button btnCalculate;
        private Label label4;
        private Label label1;
        private TextBox maxBoxA;
        private TextBox maxPalletA;
        private Label label6;
        private Label label3;
        private TextBox maxBoxB;
        private TextBox maxPalletB;
        private Label label5;
        private Label label2;
        private TextBox maxBoxC;
        private TextBox maxPalletC;
        private RadioButton rbC;
        private RadioButton rbB;
        private RadioButton rbA;
        private Label label7;
        private TextBox textBox1;
    }
}