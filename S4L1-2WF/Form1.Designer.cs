namespace S4L1_2WF
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
            label_fn = new Label();
            label_sn = new Label();
            textBox_fn = new TextBox();
            textBox_sn = new TextBox();
            sum_btn = new Button();
            encrypt_btn = new Button();
            textBox_shift = new TextBox();
            label1 = new Label();
            rand_btn = new Button();
            SuspendLayout();
            // 
            // label_fn
            // 
            label_fn.AutoSize = true;
            label_fn.Location = new Point(140, 103);
            label_fn.Name = "label_fn";
            label_fn.Size = new Size(68, 15);
            label_fn.TabIndex = 0;
            label_fn.Text = "First name: ";
            // 
            // label_sn
            // 
            label_sn.AutoSize = true;
            label_sn.Location = new Point(140, 141);
            label_sn.Name = "label_sn";
            label_sn.Size = new Size(60, 15);
            label_sn.TabIndex = 4;
            label_sn.Text = "Surname: ";
            // 
            // textBox_fn
            // 
            textBox_fn.Location = new Point(218, 100);
            textBox_fn.Name = "textBox_fn";
            textBox_fn.Size = new Size(191, 23);
            textBox_fn.TabIndex = 2;
            textBox_fn.Text = "Anton";
            // 
            // textBox_sn
            // 
            textBox_sn.Location = new Point(218, 138);
            textBox_sn.Name = "textBox_sn";
            textBox_sn.Size = new Size(191, 23);
            textBox_sn.TabIndex = 3;
            textBox_sn.Text = "Ivanov";
            // 
            // sum_btn
            // 
            sum_btn.Location = new Point(218, 180);
            sum_btn.Margin = new Padding(3, 2, 3, 2);
            sum_btn.Name = "sum_btn";
            sum_btn.Size = new Size(117, 24);
            sum_btn.TabIndex = 1;
            sum_btn.Text = "Sum them";
            sum_btn.UseVisualStyleBackColor = true;
            sum_btn.Click += sum_btn_Click;
            // 
            // encrypt_btn
            // 
            encrypt_btn.Location = new Point(437, 138);
            encrypt_btn.Margin = new Padding(3, 2, 3, 2);
            encrypt_btn.Name = "encrypt_btn";
            encrypt_btn.Size = new Size(81, 24);
            encrypt_btn.TabIndex = 5;
            encrypt_btn.Text = "Encrypt";
            encrypt_btn.UseVisualStyleBackColor = true;
            encrypt_btn.Click += encrypt_btn_Click;
            // 
            // textBox_shift
            // 
            textBox_shift.Location = new Point(477, 100);
            textBox_shift.Name = "textBox_shift";
            textBox_shift.Size = new Size(41, 23);
            textBox_shift.TabIndex = 6;
            textBox_shift.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 103);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 7;
            label1.Text = "Shift:";
            // 
            // rand_btn
            // 
            rand_btn.Location = new Point(401, 180);
            rand_btn.Name = "rand_btn";
            rand_btn.Size = new Size(117, 24);
            rand_btn.TabIndex = 8;
            rand_btn.Text = "Randomize";
            rand_btn.UseVisualStyleBackColor = true;
            rand_btn.Click += rand_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(rand_btn);
            Controls.Add(label1);
            Controls.Add(textBox_shift);
            Controls.Add(encrypt_btn);
            Controls.Add(label_sn);
            Controls.Add(textBox_sn);
            Controls.Add(textBox_fn);
            Controls.Add(sum_btn);
            Controls.Add(label_fn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "S4L1-2WF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_fn;
        private Label label_sn;
        private TextBox textBox_fn;
        private TextBox textBox_sn;
        private Button sum_btn;
        private Button encrypt_btn;
        private TextBox textBox_shift;
        private Label label1;
        private Button rand_btn;
    }
}