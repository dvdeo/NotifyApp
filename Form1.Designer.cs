namespace NotifyApp
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
            components = new System.ComponentModel.Container();
            lb_hour = new Label();
            lb_min = new Label();
            lb_sec = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            comb_hour = new ComboBox();
            label2 = new Label();
            comb_min = new ComboBox();
            label3 = new Label();
            comb_sec = new ComboBox();
            btn_start = new Button();
            btn_cancel = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            lb_hourNotify = new Label();
            lb_minNotify = new Label();
            lb_secNotify = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lb_hour
            // 
            lb_hour.AutoSize = true;
            lb_hour.BackColor = SystemColors.Control;
            lb_hour.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lb_hour.Location = new Point(223, 106);
            lb_hour.Name = "lb_hour";
            lb_hour.Size = new Size(58, 45);
            lb_hour.TabIndex = 0;
            lb_hour.Text = "00";
            // 
            // lb_min
            // 
            lb_min.AutoSize = true;
            lb_min.BackColor = SystemColors.Control;
            lb_min.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lb_min.Location = new Point(283, 106);
            lb_min.Name = "lb_min";
            lb_min.Size = new Size(58, 45);
            lb_min.TabIndex = 0;
            lb_min.Text = "00";
            // 
            // lb_sec
            // 
            lb_sec.AutoSize = true;
            lb_sec.BackColor = SystemColors.Control;
            lb_sec.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lb_sec.Location = new Point(343, 106);
            lb_sec.Name = "lb_sec";
            lb_sec.Size = new Size(58, 45);
            lb_sec.TabIndex = 0;
            lb_sec.Text = "00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 207);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 1;
            label1.Text = "hour";
            // 
            // comb_hour
            // 
            comb_hour.FormattingEnabled = true;
            comb_hour.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comb_hour.Location = new Point(89, 207);
            comb_hour.Name = "comb_hour";
            comb_hour.Size = new Size(76, 33);
            comb_hour.TabIndex = 2;
            comb_hour.Text = "0";
            comb_hour.SelectionChangeCommitted += comb_hour_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 207);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 1;
            label2.Text = "min";
            // 
            // comb_min
            // 
            comb_min.FormattingEnabled = true;
            comb_min.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comb_min.Location = new Point(261, 204);
            comb_min.Name = "comb_min";
            comb_min.Size = new Size(76, 33);
            comb_min.TabIndex = 2;
            comb_min.Text = "0";
            comb_min.SelectionChangeCommitted += comb_min_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 207);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 1;
            label3.Text = "sec";
            // 
            // comb_sec
            // 
            comb_sec.FormattingEnabled = true;
            comb_sec.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comb_sec.Location = new Point(431, 204);
            comb_sec.Name = "comb_sec";
            comb_sec.Size = new Size(76, 33);
            comb_sec.TabIndex = 2;
            comb_sec.Text = "0";
            comb_sec.SelectionChangeCommitted += comb_sec_SelectionChangeCommitted;
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.FromArgb(255, 192, 192);
            btn_start.BackgroundImageLayout = ImageLayout.None;
            btn_start.FlatStyle = FlatStyle.Flat;
            btn_start.Location = new Point(403, 391);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(119, 65);
            btn_start.TabIndex = 3;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(121, 391);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(120, 65);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            btn_cancel.Paint += btn_cancel_Paint;
            // 
            // timer2
            // 
            timer2.Interval = 900;
            timer2.Tick += timer2_Tick;
            // 
            // lb_hourNotify
            // 
            lb_hourNotify.AutoSize = true;
            lb_hourNotify.BackColor = SystemColors.Control;
            lb_hourNotify.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lb_hourNotify.ForeColor = Color.Red;
            lb_hourNotify.Location = new Point(223, 290);
            lb_hourNotify.Name = "lb_hourNotify";
            lb_hourNotify.Size = new Size(58, 45);
            lb_hourNotify.TabIndex = 0;
            lb_hourNotify.Text = "00";
            // 
            // lb_minNotify
            // 
            lb_minNotify.AutoSize = true;
            lb_minNotify.BackColor = SystemColors.Control;
            lb_minNotify.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lb_minNotify.ForeColor = Color.Red;
            lb_minNotify.Location = new Point(283, 290);
            lb_minNotify.Name = "lb_minNotify";
            lb_minNotify.Size = new Size(58, 45);
            lb_minNotify.TabIndex = 0;
            lb_minNotify.Text = "00";
            // 
            // lb_secNotify
            // 
            lb_secNotify.AutoSize = true;
            lb_secNotify.BackColor = SystemColors.Control;
            lb_secNotify.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lb_secNotify.ForeColor = Color.Red;
            lb_secNotify.Location = new Point(343, 290);
            lb_secNotify.Name = "lb_secNotify";
            lb_secNotify.Size = new Size(58, 45);
            lb_secNotify.TabIndex = 0;
            lb_secNotify.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 62);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 4;
            label4.Text = "Current Time";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(673, 536);
            Controls.Add(label4);
            Controls.Add(btn_cancel);
            Controls.Add(btn_start);
            Controls.Add(comb_sec);
            Controls.Add(label3);
            Controls.Add(comb_min);
            Controls.Add(label2);
            Controls.Add(comb_hour);
            Controls.Add(label1);
            Controls.Add(lb_secNotify);
            Controls.Add(lb_minNotify);
            Controls.Add(lb_sec);
            Controls.Add(lb_hourNotify);
            Controls.Add(lb_min);
            Controls.Add(lb_hour);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notify App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_hour;
        private Label lb_min;
        private Label lb_sec;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private ComboBox comb_hour;
        private Label label2;
        private ComboBox comb_min;
        private Label label3;
        private ComboBox comb_sec;
        private Button btn_start;
        private Button btn_cancel;
        private System.Windows.Forms.Timer timer2;
        private Label lb_hourNotify;
        private Label lb_minNotify;
        private Label lb_secNotify;
        private Label label4;
    }
}
