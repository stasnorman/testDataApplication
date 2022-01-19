namespace Session2
{
    partial class FormCadVehicle
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
            this.vin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mark = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.enginenumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.enginemodel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.typedrive = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.driver = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.horsepower = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.enginepower = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.enginetype = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.weightinkg = new System.Windows.Forms.NumericUpDown();
            this.engineyear = new System.Windows.Forms.NumericUpDown();
            this.maximumload = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightinkg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumload)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vin
            // 
            this.vin.Location = new System.Drawing.Point(18, 88);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(310, 21);
            this.vin.TabIndex = 0;
            this.vin.TextChanged += new System.EventHandler(this.vin_TextChanged);
            this.vin.Leave += new System.EventHandler(this.vin_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "VIN number of car*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mark*";
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(18, 134);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(310, 21);
            this.mark.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.Location = new System.Drawing.Point(15, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2.Location = new System.Drawing.Point(118, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(18, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Model*";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(18, 180);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(310, 21);
            this.model.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(18, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vehicle Type*";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(18, 230);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(310, 21);
            this.type.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(18, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vehicle Category*";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(18, 276);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(310, 21);
            this.category.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(18, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Year of Issue*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(18, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "Engine Number";
            // 
            // enginenumber
            // 
            this.enginenumber.Location = new System.Drawing.Point(18, 368);
            this.enginenumber.Name = "enginenumber";
            this.enginenumber.Size = new System.Drawing.Size(310, 21);
            this.enginenumber.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label15.Location = new System.Drawing.Point(18, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 19);
            this.label15.TabIndex = 28;
            this.label15.Text = "Engine Model";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label16.Location = new System.Drawing.Point(18, 438);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 19);
            this.label16.TabIndex = 30;
            this.label16.Text = "Engine Year";
            // 
            // enginemodel
            // 
            this.enginemodel.Location = new System.Drawing.Point(18, 414);
            this.enginemodel.Name = "enginemodel";
            this.enginemodel.Size = new System.Drawing.Size(310, 21);
            this.enginemodel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(361, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Driver";
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(361, 414);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(310, 21);
            this.comments.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(361, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Comments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(361, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Type of Drive*";
            // 
            // typedrive
            // 
            this.typedrive.Location = new System.Drawing.Point(361, 368);
            this.typedrive.Name = "typedrive";
            this.typedrive.Size = new System.Drawing.Size(310, 21);
            this.typedrive.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(361, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "Vehicle Weight (in Kg)*";
            // 
            // driver
            // 
            this.driver.Location = new System.Drawing.Point(361, 460);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(310, 21);
            this.driver.TabIndex = 17;
            this.driver.TextChanged += new System.EventHandler(this.driver_TextChanged);
            this.driver.Leave += new System.EventHandler(this.driver_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(361, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "Engine\'s Type*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label14.Location = new System.Drawing.Point(361, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 19);
            this.label14.TabIndex = 43;
            this.label14.Text = "Vehicle weight*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label17.Location = new System.Drawing.Point(361, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 19);
            this.label17.TabIndex = 42;
            this.label17.Text = "Maximum Load (in kg)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label18.Location = new System.Drawing.Point(361, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 19);
            this.label18.TabIndex = 37;
            this.label18.Text = "Horsepower";
            // 
            // horsepower
            // 
            this.horsepower.Location = new System.Drawing.Point(361, 134);
            this.horsepower.Name = "horsepower";
            this.horsepower.Size = new System.Drawing.Size(310, 21);
            this.horsepower.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label19.Location = new System.Drawing.Point(361, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 19);
            this.label19.TabIndex = 34;
            this.label19.Text = "Engine Power in kW";
            // 
            // enginepower
            // 
            this.enginepower.Location = new System.Drawing.Point(361, 88);
            this.enginepower.Name = "enginepower";
            this.enginepower.Size = new System.Drawing.Size(310, 21);
            this.enginepower.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label20.Location = new System.Drawing.Point(721, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 19);
            this.label20.TabIndex = 49;
            this.label20.Text = "Color*";
            // 
            // enginetype
            // 
            this.enginetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enginetype.FormattingEnabled = true;
            this.enginetype.Location = new System.Drawing.Point(361, 276);
            this.enginetype.Name = "enginetype";
            this.enginetype.Size = new System.Drawing.Size(310, 21);
            this.enginetype.TabIndex = 13;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(18, 322);
            this.year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(310, 21);
            this.year.TabIndex = 5;
            this.year.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(361, 231);
            this.weight.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(310, 21);
            this.weight.TabIndex = 12;
            // 
            // weightinkg
            // 
            this.weightinkg.Location = new System.Drawing.Point(361, 322);
            this.weightinkg.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.weightinkg.Name = "weightinkg";
            this.weightinkg.Size = new System.Drawing.Size(310, 21);
            this.weightinkg.TabIndex = 14;
            // 
            // engineyear
            // 
            this.engineyear.Location = new System.Drawing.Point(18, 461);
            this.engineyear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.engineyear.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.engineyear.Name = "engineyear";
            this.engineyear.Size = new System.Drawing.Size(310, 21);
            this.engineyear.TabIndex = 8;
            this.engineyear.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // maximumload
            // 
            this.maximumload.Location = new System.Drawing.Point(361, 184);
            this.maximumload.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.maximumload.Name = "maximumload";
            this.maximumload.Size = new System.Drawing.Size(310, 21);
            this.maximumload.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(725, 104);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pallete Tiles";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(725, 127);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Color Code";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(725, 150);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.Text = "Color Name";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-5, -23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 197);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(274, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(89, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 66);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(65, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "Select a Color";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(274, 171);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(274, 171);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(824, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 161);
            this.panel1.TabIndex = 60;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label21.Location = new System.Drawing.Point(85, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 19);
            this.label21.TabIndex = 61;
            this.label21.Text = "Color Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 21);
            this.textBox1.TabIndex = 61;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(89, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 66);
            this.panel3.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(96, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 66);
            this.panel4.TabIndex = 65;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label22.Location = new System.Drawing.Point(89, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 19);
            this.label22.TabIndex = 64;
            this.label22.Text = "Color Name";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormCadVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.maximumload);
            this.Controls.Add(this.engineyear);
            this.Controls.Add(this.weightinkg);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.year);
            this.Controls.Add(this.enginetype);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.typedrive);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.horsepower);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.enginepower);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.enginemodel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.enginenumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.model);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vin);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCadVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakta";
            this.Load += new System.EventHandler(this.FormCadVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightinkg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumload)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox enginenumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox enginemodel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox typedrive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox driver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox horsepower;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox enginepower;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox enginetype;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.NumericUpDown weightinkg;
        private System.Windows.Forms.NumericUpDown engineyear;
        private System.Windows.Forms.NumericUpDown maximumload;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label22;
    }
}

