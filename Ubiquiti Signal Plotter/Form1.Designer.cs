namespace Ubiquiti_Signal_Plotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            db_formsPlot = new ScottPlot.FormsPlot();
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            ip_label = new Label();
            username_label = new Label();
            password_label = new Label();
            connect_button = new Button();
            label1 = new Label();
            start_button = new Button();
            rxPower_textbox = new TextBox();
            rssi_textbox = new TextBox();
            label2 = new Label();
            txPower_textbox = new TextBox();
            label3 = new Label();
            ip_textbox = new TextBox();
            saveFigure_button = new Button();
            exportData_button = new Button();
            rx_power_dbm_7seg = new DmitryBrant.CustomControls.SevenSegmentArray();
            label4 = new Label();
            label5 = new Label();
            tx_power_dbm_7seg = new DmitryBrant.CustomControls.SevenSegmentArray();
            label6 = new Label();
            label7 = new Label();
            rawdata_richTextBox = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label8 = new Label();
            tx_power_mw_7seg = new DmitryBrant.CustomControls.SevenSegmentArray();
            label9 = new Label();
            rx_power_mw_7seg = new DmitryBrant.CustomControls.SevenSegmentArray();
            ledBulb1 = new Bulb.LedBulb();
            label10 = new Label();
            label11 = new Label();
            upper_level_numericUpDown = new NumericUpDown();
            lower_level_numericUpDown = new NumericUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)upper_level_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lower_level_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // db_formsPlot
            // 
            db_formsPlot.Location = new Point(8, 368);
            db_formsPlot.Margin = new Padding(4, 3, 4, 3);
            db_formsPlot.Name = "db_formsPlot";
            db_formsPlot.Size = new Size(772, 317);
            db_formsPlot.TabIndex = 0;
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(283, 12);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(211, 23);
            username_textbox.TabIndex = 5;
            username_textbox.Text = "ubnt";
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(558, 11);
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.Size = new Size(211, 23);
            password_textbox.TabIndex = 6;
            password_textbox.Text = "ubnt1234";
            // 
            // ip_label
            // 
            ip_label.AutoSize = true;
            ip_label.Location = new Point(8, 15);
            ip_label.Name = "ip_label";
            ip_label.Size = new Size(17, 15);
            ip_label.TabIndex = 7;
            ip_label.Text = "IP";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Location = new Point(217, 15);
            username_label.Name = "username_label";
            username_label.Size = new Size(60, 15);
            username_label.TabIndex = 9;
            username_label.Text = "Username";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(500, 14);
            password_label.Name = "password_label";
            password_label.Size = new Size(57, 15);
            password_label.TabIndex = 10;
            password_label.Text = "Password";
            // 
            // connect_button
            // 
            connect_button.Location = new Point(775, 11);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(75, 23);
            connect_button.TabIndex = 11;
            connect_button.Text = "Connect";
            connect_button.UseVisualStyleBackColor = true;
            connect_button.Click += connect_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 12;
            label1.Text = "Recived Power";
            // 
            // start_button
            // 
            start_button.Enabled = false;
            start_button.Location = new Point(12, 41);
            start_button.Name = "start_button";
            start_button.Size = new Size(838, 23);
            start_button.TabIndex = 13;
            start_button.Text = "Start";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // rxPower_textbox
            // 
            rxPower_textbox.Location = new Point(102, 70);
            rxPower_textbox.Name = "rxPower_textbox";
            rxPower_textbox.ReadOnly = true;
            rxPower_textbox.Size = new Size(232, 23);
            rxPower_textbox.TabIndex = 14;
            // 
            // rssi_textbox
            // 
            rssi_textbox.Location = new Point(375, 70);
            rssi_textbox.Name = "rssi_textbox";
            rssi_textbox.ReadOnly = true;
            rssi_textbox.Size = new Size(232, 23);
            rssi_textbox.TabIndex = 16;
            rssi_textbox.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 73);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 15;
            label2.Text = "RSSI";
            label2.Visible = false;
            // 
            // txPower_textbox
            // 
            txPower_textbox.Location = new Point(675, 70);
            txPower_textbox.Name = "txPower_textbox";
            txPower_textbox.ReadOnly = true;
            txPower_textbox.Size = new Size(175, 23);
            txPower_textbox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(613, 73);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 17;
            label3.Text = "TX Power";
            // 
            // ip_textbox
            // 
            ip_textbox.Location = new Point(31, 11);
            ip_textbox.Name = "ip_textbox";
            ip_textbox.Size = new Size(180, 23);
            ip_textbox.TabIndex = 19;
            ip_textbox.Text = "192.168.1.21";
            // 
            // saveFigure_button
            // 
            saveFigure_button.Location = new Point(102, 747);
            saveFigure_button.Name = "saveFigure_button";
            saveFigure_button.Size = new Size(141, 43);
            saveFigure_button.TabIndex = 20;
            saveFigure_button.Text = "Save Figure";
            saveFigure_button.UseVisualStyleBackColor = true;
            saveFigure_button.Click += saveFigure_button_Click;
            // 
            // exportData_button
            // 
            exportData_button.Location = new Point(624, 747);
            exportData_button.Name = "exportData_button";
            exportData_button.Size = new Size(141, 43);
            exportData_button.TabIndex = 21;
            exportData_button.Text = "Export Data";
            exportData_button.UseVisualStyleBackColor = true;
            exportData_button.Click += exportData_button_Click;
            // 
            // rx_power_dbm_7seg
            // 
            rx_power_dbm_7seg.ArrayCount = 5;
            rx_power_dbm_7seg.ColorBackground = SystemColors.Control;
            rx_power_dbm_7seg.ColorDark = Color.Gainsboro;
            rx_power_dbm_7seg.ColorLight = Color.DarkRed;
            rx_power_dbm_7seg.DecimalShow = true;
            rx_power_dbm_7seg.ElementPadding = new Padding(10);
            rx_power_dbm_7seg.ElementWidth = 10;
            rx_power_dbm_7seg.ForeColor = SystemColors.ControlText;
            rx_power_dbm_7seg.ItalicFactor = 0F;
            rx_power_dbm_7seg.Location = new Point(12, 153);
            rx_power_dbm_7seg.Name = "rx_power_dbm_7seg";
            rx_power_dbm_7seg.Size = new Size(290, 103);
            rx_power_dbm_7seg.TabIndex = 22;
            rx_power_dbm_7seg.TabStop = false;
            rx_power_dbm_7seg.Value = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(730, 191);
            label4.Name = "label4";
            label4.Size = new Size(133, 65);
            label4.TabIndex = 23;
            label4.Text = "dBm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(308, 191);
            label5.Name = "label5";
            label5.Size = new Size(133, 65);
            label5.TabIndex = 25;
            label5.Text = "dBm";
            // 
            // tx_power_dbm_7seg
            // 
            tx_power_dbm_7seg.ArrayCount = 5;
            tx_power_dbm_7seg.ColorBackground = SystemColors.Control;
            tx_power_dbm_7seg.ColorDark = Color.Gainsboro;
            tx_power_dbm_7seg.ColorLight = Color.DarkRed;
            tx_power_dbm_7seg.DecimalShow = true;
            tx_power_dbm_7seg.ElementPadding = new Padding(10);
            tx_power_dbm_7seg.ElementWidth = 10;
            tx_power_dbm_7seg.ForeColor = SystemColors.ControlText;
            tx_power_dbm_7seg.ItalicFactor = 0F;
            tx_power_dbm_7seg.Location = new Point(434, 153);
            tx_power_dbm_7seg.Name = "tx_power_dbm_7seg";
            tx_power_dbm_7seg.Size = new Size(290, 103);
            tx_power_dbm_7seg.TabIndex = 24;
            tx_power_dbm_7seg.TabStop = false;
            tx_power_dbm_7seg.Value = null;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 105);
            label6.Name = "label6";
            label6.Size = new Size(154, 45);
            label6.TabIndex = 26;
            label6.Text = "RX Power";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(434, 105);
            label7.Name = "label7";
            label7.Size = new Size(152, 45);
            label7.TabIndex = 27;
            label7.Text = "TX Power";
            // 
            // rawdata_richTextBox
            // 
            rawdata_richTextBox.Location = new Point(12, 681);
            rawdata_richTextBox.Name = "rawdata_richTextBox";
            rawdata_richTextBox.ReadOnly = true;
            rawdata_richTextBox.Size = new Size(835, 50);
            rawdata_richTextBox.TabIndex = 2;
            rawdata_richTextBox.Text = "";
            rawdata_richTextBox.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(308, 300);
            label8.Name = "label8";
            label8.Size = new Size(120, 65);
            label8.TabIndex = 31;
            label8.Text = "mW";
            // 
            // tx_power_mw_7seg
            // 
            tx_power_mw_7seg.ArrayCount = 5;
            tx_power_mw_7seg.ColorBackground = SystemColors.Control;
            tx_power_mw_7seg.ColorDark = Color.Gainsboro;
            tx_power_mw_7seg.ColorLight = Color.DarkRed;
            tx_power_mw_7seg.DecimalShow = true;
            tx_power_mw_7seg.ElementPadding = new Padding(10);
            tx_power_mw_7seg.ElementWidth = 10;
            tx_power_mw_7seg.ForeColor = SystemColors.ControlText;
            tx_power_mw_7seg.ItalicFactor = 0F;
            tx_power_mw_7seg.Location = new Point(434, 262);
            tx_power_mw_7seg.Name = "tx_power_mw_7seg";
            tx_power_mw_7seg.Size = new Size(290, 103);
            tx_power_mw_7seg.TabIndex = 30;
            tx_power_mw_7seg.TabStop = false;
            tx_power_mw_7seg.Value = null;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(730, 300);
            label9.Name = "label9";
            label9.Size = new Size(120, 65);
            label9.TabIndex = 29;
            label9.Text = "mW";
            // 
            // rx_power_mw_7seg
            // 
            rx_power_mw_7seg.ArrayCount = 5;
            rx_power_mw_7seg.ColorBackground = SystemColors.Control;
            rx_power_mw_7seg.ColorDark = Color.Gainsboro;
            rx_power_mw_7seg.ColorLight = Color.DarkRed;
            rx_power_mw_7seg.DecimalShow = true;
            rx_power_mw_7seg.ElementPadding = new Padding(10);
            rx_power_mw_7seg.ElementWidth = 10;
            rx_power_mw_7seg.ForeColor = SystemColors.ControlText;
            rx_power_mw_7seg.ItalicFactor = 0F;
            rx_power_mw_7seg.Location = new Point(12, 262);
            rx_power_mw_7seg.Name = "rx_power_mw_7seg";
            rx_power_mw_7seg.Size = new Size(290, 103);
            rx_power_mw_7seg.TabIndex = 28;
            rx_power_mw_7seg.TabStop = false;
            rx_power_mw_7seg.Value = null;
            // 
            // ledBulb1
            // 
            ledBulb1.Color = Color.PaleVioletRed;
            ledBulb1.Location = new Point(772, 388);
            ledBulb1.Name = "ledBulb1";
            ledBulb1.On = true;
            ledBulb1.Size = new Size(75, 68);
            ledBulb1.TabIndex = 32;
            ledBulb1.Text = "ledBulb1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(778, 472);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 34;
            label10.Text = "Upper Level";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(778, 516);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 36;
            label11.Text = "Lower Level";
            // 
            // upper_level_numericUpDown
            // 
            upper_level_numericUpDown.Location = new Point(780, 490);
            upper_level_numericUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            upper_level_numericUpDown.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            upper_level_numericUpDown.Name = "upper_level_numericUpDown";
            upper_level_numericUpDown.Size = new Size(70, 23);
            upper_level_numericUpDown.TabIndex = 37;
            // 
            // lower_level_numericUpDown
            // 
            lower_level_numericUpDown.Location = new Point(780, 534);
            lower_level_numericUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            lower_level_numericUpDown.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            lower_level_numericUpDown.Name = "lower_level_numericUpDown";
            lower_level_numericUpDown.Size = new Size(70, 23);
            lower_level_numericUpDown.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(249, 691);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 802);
            Controls.Add(pictureBox1);
            Controls.Add(lower_level_numericUpDown);
            Controls.Add(upper_level_numericUpDown);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(ledBulb1);
            Controls.Add(label8);
            Controls.Add(tx_power_mw_7seg);
            Controls.Add(label9);
            Controls.Add(rx_power_mw_7seg);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tx_power_dbm_7seg);
            Controls.Add(label4);
            Controls.Add(rx_power_dbm_7seg);
            Controls.Add(exportData_button);
            Controls.Add(saveFigure_button);
            Controls.Add(ip_textbox);
            Controls.Add(txPower_textbox);
            Controls.Add(label3);
            Controls.Add(rssi_textbox);
            Controls.Add(label2);
            Controls.Add(rxPower_textbox);
            Controls.Add(start_button);
            Controls.Add(label1);
            Controls.Add(connect_button);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(ip_label);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(rawdata_richTextBox);
            Controls.Add(db_formsPlot);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Power Logger";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)upper_level_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lower_level_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ScottPlot.FormsPlot db_formsPlot;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private Label ip_label;
        private Label username_label;
        private Label password_label;
        private Button connect_button;
        private Label label1;
        private Button start_button;
        private TextBox rxPower_textbox;
        private TextBox rssi_textbox;
        private Label label2;
        private TextBox txPower_textbox;
        private Label label3;
        private TextBox ip_textbox;
        private Button saveFigure_button;
        private Button exportData_button;
        private DmitryBrant.CustomControls.SevenSegmentArray rx_power_dbm_7seg;
        private Label label4;
        private Label label5;
        private DmitryBrant.CustomControls.SevenSegmentArray tx_power_dbm_7seg;
        private Label label6;
        private Label label7;
        private RichTextBox rawdata_richTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label8;
        private DmitryBrant.CustomControls.SevenSegmentArray tx_power_mw_7seg;
        private Label label9;
        private DmitryBrant.CustomControls.SevenSegmentArray rx_power_mw_7seg;
        private Bulb.LedBulb ledBulb1;
        private Label label10;
        private Label label11;
        private NumericUpDown upper_level_numericUpDown;
        private NumericUpDown lower_level_numericUpDown;
        private PictureBox pictureBox1;
    }
}