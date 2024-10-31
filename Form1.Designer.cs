namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            Equal = new Button();
            Point = new Button();
            btn0 = new Button();
            Sum = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            Sub = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            Mult = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            Div = new Button();
            Clear = new Button();
            ClearEntry = new Button();
            MainField = new TextBox();
            SmallField = new TextBox();
            SuspendLayout();
            // 
            // Equal
            // 
            Equal.BackColor = SystemColors.ControlLight;
            Equal.Cursor = Cursors.Hand;
            Equal.FlatAppearance.BorderSize = 0;
            Equal.Font = new Font("Segoe UI", 30F);
            Equal.ForeColor = SystemColors.ControlText;
            Equal.ImageAlign = ContentAlignment.TopCenter;
            Equal.Location = new Point(304, 480);
            Equal.Name = "Equal";
            Equal.Size = new Size(93, 65);
            Equal.TabIndex = 0;
            Equal.Text = "=";
            Equal.TextAlign = ContentAlignment.TopCenter;
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Point
            // 
            Point.Cursor = Cursors.Hand;
            Point.Font = new Font("Segoe UI", 30F);
            Point.Location = new Point(205, 480);
            Point.Name = "Point";
            Point.Size = new Size(93, 65);
            Point.TabIndex = 1;
            Point.Text = ".";
            Point.TextAlign = ContentAlignment.TopCenter;
            Point.UseVisualStyleBackColor = true;
            Point.Click += Point_Click;
            // 
            // btn0
            // 
            btn0.Cursor = Cursors.Hand;
            btn0.Font = new Font("Segoe UI", 30F);
            btn0.Location = new Point(7, 480);
            btn0.Name = "btn0";
            btn0.Size = new Size(192, 65);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // Sum
            // 
            Sum.Cursor = Cursors.Hand;
            Sum.Font = new Font("Segoe UI", 30F);
            Sum.ImageAlign = ContentAlignment.TopCenter;
            Sum.Location = new Point(304, 409);
            Sum.Name = "Sum";
            Sum.Size = new Size(93, 65);
            Sum.TabIndex = 3;
            Sum.Text = "+";
            Sum.TextAlign = ContentAlignment.TopCenter;
            Sum.UseVisualStyleBackColor = true;
            Sum.Click += Sum_Click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Font = new Font("Segoe UI", 30F);
            btn3.Location = new Point(205, 409);
            btn3.Name = "btn3";
            btn3.Size = new Size(93, 65);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Font = new Font("Segoe UI", 30F);
            btn2.Location = new Point(106, 409);
            btn2.Name = "btn2";
            btn2.Size = new Size(93, 65);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Segoe UI", 30F);
            btn1.Location = new Point(7, 409);
            btn1.Name = "btn1";
            btn1.Size = new Size(93, 65);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Sub
            // 
            Sub.Cursor = Cursors.Hand;
            Sub.Font = new Font("Segoe UI", 30F);
            Sub.ImageAlign = ContentAlignment.TopCenter;
            Sub.Location = new Point(304, 338);
            Sub.Name = "Sub";
            Sub.Size = new Size(93, 65);
            Sub.TabIndex = 7;
            Sub.Text = "-";
            Sub.TextAlign = ContentAlignment.TopCenter;
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Font = new Font("Segoe UI", 30F);
            btn6.Location = new Point(205, 338);
            btn6.Name = "btn6";
            btn6.Size = new Size(93, 65);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Cursor = Cursors.Hand;
            btn5.Font = new Font("Segoe UI", 30F);
            btn5.Location = new Point(106, 338);
            btn5.Name = "btn5";
            btn5.Size = new Size(93, 65);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Segoe UI", 30F);
            btn4.Location = new Point(7, 338);
            btn4.Name = "btn4";
            btn4.Size = new Size(93, 65);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // Mult
            // 
            Mult.Cursor = Cursors.Hand;
            Mult.Font = new Font("Segoe UI", 30F);
            Mult.ImageAlign = ContentAlignment.TopCenter;
            Mult.Location = new Point(304, 267);
            Mult.Name = "Mult";
            Mult.Size = new Size(93, 65);
            Mult.TabIndex = 11;
            Mult.Text = "x";
            Mult.UseVisualStyleBackColor = true;
            Mult.Click += Mult_Click;
            // 
            // btn9
            // 
            btn9.Cursor = Cursors.Hand;
            btn9.Font = new Font("Segoe UI", 30F);
            btn9.Location = new Point(205, 267);
            btn9.Name = "btn9";
            btn9.Size = new Size(93, 65);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Cursor = Cursors.Hand;
            btn8.Font = new Font("Segoe UI", 30F);
            btn8.Location = new Point(106, 267);
            btn8.Name = "btn8";
            btn8.Size = new Size(93, 65);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Cursor = Cursors.Hand;
            btn7.Font = new Font("Segoe UI", 30F);
            btn7.Location = new Point(7, 267);
            btn7.Name = "btn7";
            btn7.Size = new Size(93, 65);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // Div
            // 
            Div.Cursor = Cursors.Hand;
            Div.Font = new Font("Segoe UI", 30F);
            Div.ImageAlign = ContentAlignment.TopCenter;
            Div.Location = new Point(304, 196);
            Div.Name = "Div";
            Div.Size = new Size(93, 65);
            Div.TabIndex = 15;
            Div.Text = "÷";
            Div.UseVisualStyleBackColor = true;
            Div.Click += Div_Click;
            // 
            // Clear
            // 
            Clear.Cursor = Cursors.Hand;
            Clear.Font = new Font("Segoe UI", 30F);
            Clear.Location = new Point(205, 196);
            Clear.Name = "Clear";
            Clear.Size = new Size(93, 65);
            Clear.TabIndex = 16;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // ClearEntry
            // 
            ClearEntry.Cursor = Cursors.Hand;
            ClearEntry.Font = new Font("Segoe UI", 30F);
            ClearEntry.Location = new Point(7, 196);
            ClearEntry.Name = "ClearEntry";
            ClearEntry.Size = new Size(192, 65);
            ClearEntry.TabIndex = 17;
            ClearEntry.Text = "CE";
            ClearEntry.UseVisualStyleBackColor = true;
            ClearEntry.Click += ClearEntry_Click;
            // 
            // MainField
            // 
            MainField.BackColor = SystemColors.WindowText;
            MainField.BorderStyle = BorderStyle.None;
            MainField.Cursor = Cursors.IBeam;
            MainField.Font = new Font("Segoe UI", 52F);
            MainField.ForeColor = SystemColors.Window;
            MainField.Location = new Point(7, 90);
            MainField.Name = "MainField";
            MainField.Size = new Size(390, 93);
            MainField.TabIndex = 18;
            MainField.TextAlign = HorizontalAlignment.Right;
            // 
            // SmallField
            // 
            SmallField.BackColor = SystemColors.WindowText;
            SmallField.BorderStyle = BorderStyle.None;
            SmallField.Cursor = Cursors.IBeam;
            SmallField.Font = new Font("Segoe UI", 37F);
            SmallField.ForeColor = SystemColors.ScrollBar;
            SmallField.Location = new Point(7, 18);
            SmallField.Name = "SmallField";
            SmallField.Size = new Size(390, 66);
            SmallField.TabIndex = 19;
            SmallField.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(404, 552);
            Controls.Add(SmallField);
            Controls.Add(MainField);
            Controls.Add(ClearEntry);
            Controls.Add(Clear);
            Controls.Add(Div);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(Mult);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(Sub);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(Sum);
            Controls.Add(btn0);
            Controls.Add(Point);
            Controls.Add(Equal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Equal;
        private Button Point;
        private Button btn0;
        private Button Sum;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button Sub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button Mult;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button Div;
        private Button Clear;
        private Button ClearEntry;
        private TextBox MainField;
        private TextBox SmallField;
    }
}
