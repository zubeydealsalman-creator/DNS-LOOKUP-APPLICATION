namespace dns_lookup
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
            lookup = new Button();
            info = new ListBox();
            textBoxDomain = new TextBox();
            groupBox1 = new GroupBox();
            forward = new RadioButton();
            reverse = new RadioButton();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lookup
            // 
            lookup.BackColor = Color.FromArgb(138, 81, 77);
            lookup.ForeColor = SystemColors.Info;
            lookup.Location = new Point(750, 107);
            lookup.Name = "lookup";
            lookup.Size = new Size(150, 46);
            lookup.TabIndex = 0;
            lookup.Text = "LookUp";
            lookup.UseVisualStyleBackColor = false;
            lookup.Click += lookup_Click;
            // 
            // info
            // 
            info.BackColor = Color.FromArgb(138, 81, 77);
            info.ForeColor = SystemColors.Info;
            info.FormattingEnabled = true;
            info.Location = new Point(84, 251);
            info.Name = "info";
            info.Size = new Size(422, 164);
            info.TabIndex = 1;
            info.SelectedIndexChanged += info_SelectedIndexChanged;
            // 
            // textBoxDomain
            // 
            textBoxDomain.BackColor = Color.FromArgb(138, 81, 77);
            textBoxDomain.Location = new Point(259, 107);
            textBoxDomain.Multiline = true;
            textBoxDomain.Name = "textBoxDomain";
            textBoxDomain.Size = new Size(327, 51);
            textBoxDomain.TabIndex = 2;
            textBoxDomain.TextChanged += textBoxDomain_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(138, 81, 77);
            groupBox1.Controls.Add(forward);
            groupBox1.Controls.Add(reverse);
            groupBox1.ForeColor = SystemColors.Info;
            groupBox1.Location = new Point(652, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 164);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type :";
            // 
            // forward
            // 
            forward.AutoSize = true;
            forward.Location = new Point(41, 130);
            forward.Name = "forward";
            forward.Size = new Size(130, 36);
            forward.TabIndex = 1;
            forward.TabStop = true;
            forward.Text = "Forward";
            forward.UseVisualStyleBackColor = true;
            // 
            // reverse
            // 
            reverse.AutoSize = true;
            reverse.Location = new Point(41, 65);
            reverse.Name = "reverse";
            reverse.Size = new Size(127, 36);
            reverse.TabIndex = 0;
            reverse.TabStop = true;
            reverse.Text = "Reverse";
            reverse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(31, 110);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 4;
            label1.Text = "IP | Domain";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 147, 97);
            ClientSize = new Size(1094, 674);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBoxDomain);
            Controls.Add(info);
            Controls.Add(lookup);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lookup;
        private ListBox info;
        private TextBox textBoxDomain;
        private GroupBox groupBox1;
        private RadioButton forward;
        private RadioButton reverse;
        private Label label1;
    }
}
