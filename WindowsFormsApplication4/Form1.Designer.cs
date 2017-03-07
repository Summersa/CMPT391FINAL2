namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchRoomsComboBox = new System.Windows.Forms.ComboBox();
            this.bookRoomButton = new System.Windows.Forms.Button();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.roomData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateMonthText = new System.Windows.Forms.TextBox();
            this.dateQuarterText = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.clientCountryText = new System.Windows.Forms.TextBox();
            this.clientProvinceText = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.hotelCountryText = new System.Windows.Forms.TextBox();
            this.hotelProvinceText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateYearText = new System.Windows.Forms.TextBox();
            this.clientCityText = new System.Windows.Forms.TextBox();
            this.hotelCityText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 489);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.loginButton);
            this.tabPage1.Controls.Add(this.mainTitleLabel);
            this.tabPage1.Controls.Add(this.passwordTextbox);
            this.tabPage1.Controls.Add(this.passwordLabel);
            this.tabPage1.Controls.Add(this.usernameTextbox);
            this.tabPage1.Controls.Add(this.usernameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "includes booking and reservations, inventory, energy managment ";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(252, 316);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(116, 45);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.Location = new System.Drawing.Point(213, 85);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(188, 23);
            this.mainTitleLabel.TabIndex = 5;
            this.mainTitleLabel.Text = "Hotel Managment";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(301, 246);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(205, 246);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(52, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(301, 201);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(205, 208);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(53, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataButton);
            this.tabPage2.Controls.Add(this.searchRoomsComboBox);
            this.tabPage2.Controls.Add(this.bookRoomButton);
            this.tabPage2.Controls.Add(this.deleteRoomButton);
            this.tabPage2.Controls.Add(this.roomsLabel);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchRoomsComboBox
            // 
            this.searchRoomsComboBox.FormattingEnabled = true;
            this.searchRoomsComboBox.Items.AddRange(new object[] {
            "All Rooms",
            "Empty Rooms",
            "Booked",
            "History"});
            this.searchRoomsComboBox.Location = new System.Drawing.Point(9, 38);
            this.searchRoomsComboBox.Name = "searchRoomsComboBox";
            this.searchRoomsComboBox.Size = new System.Drawing.Size(166, 21);
            this.searchRoomsComboBox.TabIndex = 5;
            this.searchRoomsComboBox.SelectedIndexChanged += new System.EventHandler(this.searchRoomsComboBox_SelectedIndexChanged);
            // 
            // bookRoomButton
            // 
            this.bookRoomButton.Location = new System.Drawing.Point(52, 9);
            this.bookRoomButton.Name = "bookRoomButton";
            this.bookRoomButton.Size = new System.Drawing.Size(52, 23);
            this.bookRoomButton.TabIndex = 4;
            this.bookRoomButton.Text = "Book Room";
            this.bookRoomButton.UseVisualStyleBackColor = true;
            this.bookRoomButton.Click += new System.EventHandler(this.bookRoomButton_Click);
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(110, 9);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(65, 23);
            this.deleteRoomButton.TabIndex = 3;
            this.deleteRoomButton.Text = "Checkout";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Location = new System.Drawing.Point(6, 14);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(40, 13);
            this.roomsLabel.TabIndex = 1;
            this.roomsLabel.Text = "Rooms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataButton
            // 
            this.dataButton.Location = new System.Drawing.Point(492, 9);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(114, 35);
            this.dataButton.TabIndex = 6;
            this.dataButton.Text = "Data Warehouse";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.hotelCityText);
            this.tabPage3.Controls.Add(this.clientCityText);
            this.tabPage3.Controls.Add(this.dateYearText);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.hotelProvinceText);
            this.tabPage3.Controls.Add(this.hotelCountryText);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.clientProvinceText);
            this.tabPage3.Controls.Add(this.clientCountryText);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.dateQuarterText);
            this.tabPage3.Controls.Add(this.dateMonthText);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.roomData);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(613, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // roomData
            // 
            this.roomData.AutoSize = true;
            this.roomData.Location = new System.Drawing.Point(126, 350);
            this.roomData.Name = "roomData";
            this.roomData.Size = new System.Drawing.Size(125, 13);
            this.roomData.TabIndex = 0;
            this.roomData.Text = "Total Number of Rooms: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Warehouse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Client:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hotels:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dateMonthText
            // 
            this.dateMonthText.Location = new System.Drawing.Point(235, 94);
            this.dateMonthText.Name = "dateMonthText";
            this.dateMonthText.Size = new System.Drawing.Size(100, 20);
            this.dateMonthText.TabIndex = 6;
            // 
            // dateQuarterText
            // 
            this.dateQuarterText.Location = new System.Drawing.Point(341, 94);
            this.dateQuarterText.Name = "dateQuarterText";
            this.dateQuarterText.Size = new System.Drawing.Size(100, 20);
            this.dateQuarterText.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // clientCountryText
            // 
            this.clientCountryText.Location = new System.Drawing.Point(235, 151);
            this.clientCountryText.Name = "clientCountryText";
            this.clientCountryText.Size = new System.Drawing.Size(100, 20);
            this.clientCountryText.TabIndex = 9;
            // 
            // clientProvinceText
            // 
            this.clientProvinceText.Location = new System.Drawing.Point(341, 151);
            this.clientProvinceText.Name = "clientProvinceText";
            this.clientProvinceText.Size = new System.Drawing.Size(100, 20);
            this.clientProvinceText.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(129, 212);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 11;
            // 
            // hotelCountryText
            // 
            this.hotelCountryText.Location = new System.Drawing.Point(235, 212);
            this.hotelCountryText.Name = "hotelCountryText";
            this.hotelCountryText.Size = new System.Drawing.Size(100, 20);
            this.hotelCountryText.TabIndex = 12;
            // 
            // hotelProvinceText
            // 
            this.hotelProvinceText.Location = new System.Drawing.Point(341, 212);
            this.hotelProvinceText.Name = "hotelProvinceText";
            this.hotelProvinceText.Size = new System.Drawing.Size(100, 20);
            this.hotelProvinceText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // dateYearText
            // 
            this.dateYearText.Location = new System.Drawing.Point(447, 94);
            this.dateYearText.Name = "dateYearText";
            this.dateYearText.Size = new System.Drawing.Size(100, 20);
            this.dateYearText.TabIndex = 15;
            // 
            // clientCityText
            // 
            this.clientCityText.Location = new System.Drawing.Point(447, 151);
            this.clientCityText.Name = "clientCityText";
            this.clientCityText.Size = new System.Drawing.Size(100, 20);
            this.clientCityText.TabIndex = 16;
            // 
            // hotelCityText
            // 
            this.hotelCityText.Location = new System.Drawing.Point(447, 212);
            this.hotelCityText.Name = "hotelCityText";
            this.hotelCityText.Size = new System.Drawing.Size(100, 20);
            this.hotelCityText.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Month";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Quarter";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Country";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(268, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Country";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Province";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(369, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Province";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(480, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "City";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(480, 196);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "City";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 541);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchRoomsComboBox;
        private System.Windows.Forms.Button bookRoomButton;
        private System.Windows.Forms.Button dataButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hotelCityText;
        private System.Windows.Forms.TextBox clientCityText;
        private System.Windows.Forms.TextBox dateYearText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hotelProvinceText;
        private System.Windows.Forms.TextBox hotelCountryText;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox clientProvinceText;
        private System.Windows.Forms.TextBox clientCountryText;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox dateQuarterText;
        private System.Windows.Forms.TextBox dateMonthText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label roomData;
    }
}

