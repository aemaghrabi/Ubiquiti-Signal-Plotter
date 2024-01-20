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
            db_formsPlot = new ScottPlot.FormsPlot();
            rawdata_richTextBox = new RichTextBox();
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
            SuspendLayout();
            // 
            // db_formsPlot
            // 
            db_formsPlot.Location = new Point(8, 318);
            db_formsPlot.Margin = new Padding(4, 3, 4, 3);
            db_formsPlot.Name = "db_formsPlot";
            db_formsPlot.Size = new Size(607, 423);
            db_formsPlot.TabIndex = 0;
            // 
            // rawdata_richTextBox
            // 
            rawdata_richTextBox.Location = new Point(8, 99);
            rawdata_richTextBox.Name = "rawdata_richTextBox";
            rawdata_richTextBox.ReadOnly = true;
            rawdata_richTextBox.Size = new Size(607, 213);
            rawdata_richTextBox.TabIndex = 2;
            rawdata_richTextBox.Text = "";
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(203, 12);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(131, 23);
            username_textbox.TabIndex = 5;
            username_textbox.Text = "ubnt";
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(403, 12);
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.Size = new Size(131, 23);
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
            username_label.Location = new Point(137, 15);
            username_label.Name = "username_label";
            username_label.Size = new Size(60, 15);
            username_label.TabIndex = 9;
            username_label.Text = "Username";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(340, 15);
            password_label.Name = "password_label";
            password_label.Size = new Size(57, 15);
            password_label.TabIndex = 10;
            password_label.Text = "Password";
            // 
            // connect_button
            // 
            connect_button.Location = new Point(540, 12);
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
            start_button.Size = new Size(603, 23);
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
            rxPower_textbox.Size = new Size(100, 23);
            rxPower_textbox.TabIndex = 14;
            // 
            // rssi_textbox
            // 
            rssi_textbox.Location = new Point(243, 70);
            rssi_textbox.Name = "rssi_textbox";
            rssi_textbox.ReadOnly = true;
            rssi_textbox.Size = new Size(100, 23);
            rssi_textbox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 73);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 15;
            label2.Text = "RSSI";
            // 
            // txPower_textbox
            // 
            txPower_textbox.Location = new Point(411, 70);
            txPower_textbox.Name = "txPower_textbox";
            txPower_textbox.ReadOnly = true;
            txPower_textbox.Size = new Size(100, 23);
            txPower_textbox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 73);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 17;
            label3.Text = "TX Power";
            // 
            // ip_textbox
            // 
            ip_textbox.Location = new Point(31, 12);
            ip_textbox.Name = "ip_textbox";
            ip_textbox.Size = new Size(100, 23);
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
            exportData_button.Location = new Point(399, 747);
            exportData_button.Name = "exportData_button";
            exportData_button.Size = new Size(141, 43);
            exportData_button.TabIndex = 21;
            exportData_button.Text = "Export Data";
            exportData_button.UseVisualStyleBackColor = true;
            exportData_button.Click += exportData_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 802);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ScottPlot.FormsPlot db_formsPlot;
        private RichTextBox rawdata_richTextBox;
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
    }
}