using System.Runtime.CompilerServices;

namespace WinFormsApp4
{
    partial class Close
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Close));
            button_click = new Button();
            textResult = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            SuspendLayout();
            // 
            // button_click
            // 
            button_click.BackColor = SystemColors.Desktop;
            button_click.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_click.ForeColor = SystemColors.ButtonHighlight;
            button_click.Location = new Point(258, 9);
            button_click.Name = "button_click";
            button_click.Size = new Size(33, 29);
            button_click.TabIndex = 0;
            button_click.Text = "x";
            button_click.UseVisualStyleBackColor = false;
            button_click.Click += button_click_Click;
            // 
            // textResult
            // 
            textResult.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            textResult.ForeColor = SystemColors.ButtonFace;
            textResult.Location = new Point(12, 9);
            textResult.Name = "textResult";
            textResult.Size = new Size(240, 60);
            textResult.TabIndex = 1;
            textResult.Text = "0";
            textResult.Click += bttonResultClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 92);
            button1.Name = "button1";
            button1.Size = new Size(65, 55);
            button1.TabIndex = 2;
            button1.Text = "AC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonClear;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(84, 92);
            button2.Name = "button2";
            button2.Size = new Size(65, 55);
            button2.TabIndex = 3;
            button2.Text = "+/-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += burronNumberClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(155, 92);
            button3.Name = "button3";
            button3.Size = new Size(65, 55);
            button3.TabIndex = 4;
            button3.Text = "%";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonOperationClick;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 115, 0);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(226, 92);
            button4.Name = "button4";
            button4.Size = new Size(65, 55);
            button4.TabIndex = 5;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonOperationClick;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GrayText;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(12, 164);
            button5.Name = "button5";
            button5.Size = new Size(65, 55);
            button5.TabIndex = 6;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = false;
            button5.Click += burronNumberClick;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GrayText;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(12, 234);
            button6.Name = "button6";
            button6.Size = new Size(65, 55);
            button6.TabIndex = 7;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = false;
            button6.Click += burronNumberClick;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.GrayText;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(12, 312);
            button7.Name = "button7";
            button7.Size = new Size(65, 55);
            button7.TabIndex = 8;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = false;
            button7.Click += burronNumberClick;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.GrayText;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(12, 386);
            button8.Name = "button8";
            button8.Size = new Size(136, 55);
            button8.TabIndex = 9;
            button8.Text = "0";
            button8.UseVisualStyleBackColor = false;
            button8.Click += burronNumberClick;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.GrayText;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(84, 164);
            button9.Name = "button9";
            button9.Size = new Size(65, 55);
            button9.TabIndex = 10;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += burronNumberClick;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.GrayText;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(83, 234);
            button10.Name = "button10";
            button10.Size = new Size(65, 55);
            button10.TabIndex = 11;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += burronNumberClick;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.GrayText;
            button11.FlatStyle = FlatStyle.Popup;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(84, 312);
            button11.Name = "button11";
            button11.Size = new Size(65, 55);
            button11.TabIndex = 12;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = false;
            button11.Click += burronNumberClick;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.GrayText;
            button13.FlatStyle = FlatStyle.Popup;
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Location = new Point(155, 164);
            button13.Name = "button13";
            button13.Size = new Size(65, 55);
            button13.TabIndex = 14;
            button13.Text = "9";
            button13.UseVisualStyleBackColor = false;
            button13.Click += burronNumberClick;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.GrayText;
            button14.FlatStyle = FlatStyle.Popup;
            button14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = SystemColors.ButtonHighlight;
            button14.Location = new Point(154, 234);
            button14.Name = "button14";
            button14.Size = new Size(65, 55);
            button14.TabIndex = 15;
            button14.Text = "6";
            button14.UseVisualStyleBackColor = false;
            button14.Click += burronNumberClick;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.GrayText;
            button15.FlatStyle = FlatStyle.Popup;
            button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ButtonHighlight;
            button15.Location = new Point(155, 312);
            button15.Name = "button15";
            button15.Size = new Size(65, 55);
            button15.TabIndex = 16;
            button15.Text = "3";
            button15.UseVisualStyleBackColor = false;
            button15.Click += burronNumberClick;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.GrayText;
            button16.FlatStyle = FlatStyle.Popup;
            button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.ButtonHighlight;
            button16.Location = new Point(155, 386);
            button16.Name = "button16";
            button16.Size = new Size(65, 55);
            button16.TabIndex = 17;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = false;
            button16.Click += burronNumberClick;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(255, 115, 0);
            button17.FlatStyle = FlatStyle.Popup;
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = SystemColors.ButtonHighlight;
            button17.Location = new Point(226, 164);
            button17.Name = "button17";
            button17.Size = new Size(65, 55);
            button17.TabIndex = 18;
            button17.Text = "*";
            button17.UseVisualStyleBackColor = false;
            button17.Click += buttonOperationClick;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(255, 115, 0);
            button18.FlatStyle = FlatStyle.Popup;
            button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button18.ForeColor = SystemColors.ButtonHighlight;
            button18.Location = new Point(226, 234);
            button18.Name = "button18";
            button18.Size = new Size(65, 55);
            button18.TabIndex = 19;
            button18.Text = "-";
            button18.UseVisualStyleBackColor = false;
            button18.Click += buttonOperationClick;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(255, 115, 0);
            button19.FlatStyle = FlatStyle.Popup;
            button19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button19.ForeColor = SystemColors.ButtonHighlight;
            button19.Location = new Point(226, 312);
            button19.Name = "button19";
            button19.Size = new Size(65, 55);
            button19.TabIndex = 20;
            button19.Text = "+";
            button19.UseVisualStyleBackColor = false;
            button19.Click += buttonOperationClick;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(255, 115, 0);
            button20.FlatStyle = FlatStyle.Popup;
            button20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button20.ForeColor = SystemColors.ButtonHighlight;
            button20.Location = new Point(226, 386);
            button20.Name = "button20";
            button20.Size = new Size(65, 55);
            button20.TabIndex = 21;
            button20.Text = "=";
            button20.UseVisualStyleBackColor = false;
            button20.Click += bttonResultClick;
            // 
            // Close
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(303, 453);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textResult);
            Controls.Add(button_click);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Close";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            MouseDown += Close_MouseDown;
            MouseMove += Close_MouseMove;
            MouseUp += Close_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Button button_click;
        private Label textResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }

}