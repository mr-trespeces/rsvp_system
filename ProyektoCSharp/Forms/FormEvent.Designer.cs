namespace ProyektoCSharp.Forms
{
    partial class FormEvent
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblAttendeeError = new System.Windows.Forms.Label();
            this.lblDateError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvtAdd = new FontAwesome.Sharp.IconButton();
            this.txtBoxEvtAttendees = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBoxEvtMin = new System.Windows.Forms.TextBox();
            this.txtBoxEvtHour = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBoxEvtYear = new System.Windows.Forms.TextBox();
            this.txtBoxEvtMonth = new System.Windows.Forms.TextBox();
            this.txtBoxEvtDay = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBoxEvtVenue = new System.Windows.Forms.TextBox();
            this.txtBoxEvtName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGetIdError = new System.Windows.Forms.Label();
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.lblGetEventID = new System.Windows.Forms.Label();
            this.txtBoxgetEventId = new System.Windows.Forms.TextBox();
            this.btnEvtDetails = new FontAwesome.Sharp.IconButton();
            this.lblEventList = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel10.Controls.Add(this.lblAttendeeError);
            this.panel10.Controls.Add(this.lblDateError);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.btnEvtAdd);
            this.panel10.Controls.Add(this.txtBoxEvtAttendees);
            this.panel10.Controls.Add(this.label18);
            this.panel10.Controls.Add(this.label19);
            this.panel10.Controls.Add(this.txtBoxEvtMin);
            this.panel10.Controls.Add(this.txtBoxEvtHour);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.label21);
            this.panel10.Controls.Add(this.label22);
            this.panel10.Controls.Add(this.txtBoxEvtYear);
            this.panel10.Controls.Add(this.txtBoxEvtMonth);
            this.panel10.Controls.Add(this.txtBoxEvtDay);
            this.panel10.Controls.Add(this.label23);
            this.panel10.Controls.Add(this.txtBoxEvtVenue);
            this.panel10.Controls.Add(this.txtBoxEvtName);
            this.panel10.Controls.Add(this.label24);
            this.panel10.Controls.Add(this.label25);
            this.panel10.Controls.Add(this.label26);
            this.panel10.Controls.Add(this.pictureBox6);
            this.panel10.Location = new System.Drawing.Point(13, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(314, 252);
            this.panel10.TabIndex = 23;
            this.panel10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblAttendeeError
            // 
            this.lblAttendeeError.AutoSize = true;
            this.lblAttendeeError.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendeeError.ForeColor = System.Drawing.Color.Red;
            this.lblAttendeeError.Location = new System.Drawing.Point(74, 220);
            this.lblAttendeeError.Name = "lblAttendeeError";
            this.lblAttendeeError.Size = new System.Drawing.Size(0, 13);
            this.lblAttendeeError.TabIndex = 28;
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDateError.Location = new System.Drawing.Point(74, 165);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(0, 13);
            this.lblDateError.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(243, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(209, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "hr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(162, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(115, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(76, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "dd";
            // 
            // btnEvtAdd
            // 
            this.btnEvtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnEvtAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvtAdd.FlatAppearance.BorderSize = 0;
            this.btnEvtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvtAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Bold);
            this.btnEvtAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEvtAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnEvtAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEvtAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvtAdd.IconSize = 20;
            this.btnEvtAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvtAdd.Location = new System.Drawing.Point(206, 195);
            this.btnEvtAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnEvtAdd.Name = "btnEvtAdd";
            this.btnEvtAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEvtAdd.Size = new System.Drawing.Size(74, 27);
            this.btnEvtAdd.TabIndex = 21;
            this.btnEvtAdd.Text = "Add";
            this.btnEvtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvtAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvtAdd.UseVisualStyleBackColor = false;
            this.btnEvtAdd.Click += new System.EventHandler(this.iconButton3_Click_1);
            // 
            // txtBoxEvtAttendees
            // 
            this.txtBoxEvtAttendees.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEvtAttendees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxEvtAttendees.Location = new System.Drawing.Point(77, 195);
            this.txtBoxEvtAttendees.MaxLength = 4;
            this.txtBoxEvtAttendees.Name = "txtBoxEvtAttendees";
            this.txtBoxEvtAttendees.Size = new System.Drawing.Size(53, 22);
            this.txtBoxEvtAttendees.TabIndex = 19;
            this.txtBoxEvtAttendees.Text = "0000";
            this.txtBoxEvtAttendees.Enter += new System.EventHandler(this.txtBoxEvtAttendees_Enter);
            this.txtBoxEvtAttendees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEvtAttendees_KeyPress);
            this.txtBoxEvtAttendees.Leave += new System.EventHandler(this.txtBoxEvtAttendees_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label18.Location = new System.Drawing.Point(5, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "Attendees";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label19.Location = new System.Drawing.Point(233, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 17);
            this.label19.TabIndex = 17;
            this.label19.Text = ":";
            // 
            // txtBoxEvtMin
            // 
            this.txtBoxEvtMin.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEvtMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxEvtMin.Location = new System.Drawing.Point(244, 123);
            this.txtBoxEvtMin.MaxLength = 2;
            this.txtBoxEvtMin.Name = "txtBoxEvtMin";
            this.txtBoxEvtMin.Size = new System.Drawing.Size(26, 22);
            this.txtBoxEvtMin.TabIndex = 16;
            this.txtBoxEvtMin.Text = "00";
            this.txtBoxEvtMin.Enter += new System.EventHandler(this.txtBoxEvtMin_Enter);
            this.txtBoxEvtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEvtDay_KeyPress);
            this.txtBoxEvtMin.Leave += new System.EventHandler(this.txtBoxEvtMin_Leave);
            // 
            // txtBoxEvtHour
            // 
            this.txtBoxEvtHour.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEvtHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxEvtHour.Location = new System.Drawing.Point(206, 123);
            this.txtBoxEvtHour.MaxLength = 2;
            this.txtBoxEvtHour.Name = "txtBoxEvtHour";
            this.txtBoxEvtHour.Size = new System.Drawing.Size(26, 22);
            this.txtBoxEvtHour.TabIndex = 15;
            this.txtBoxEvtHour.Text = "00";
            this.txtBoxEvtHour.Enter += new System.EventHandler(this.txtBoxEvtHour_Enter);
            this.txtBoxEvtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEvtDay_KeyPress);
            this.txtBoxEvtHour.Leave += new System.EventHandler(this.txtBoxEvtHour_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label20.Location = new System.Drawing.Point(197, 124);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 17);
            this.label20.TabIndex = 14;
            this.label20.Text = "|";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label21.Location = new System.Drawing.Point(144, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "/";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label22.Location = new System.Drawing.Point(101, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 17);
            this.label22.TabIndex = 12;
            this.label22.Text = "/";
            // 
            // txtBoxEvtYear
            // 
            this.txtBoxEvtYear.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEvtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxEvtYear.Location = new System.Drawing.Point(158, 123);
            this.txtBoxEvtYear.MaxLength = 4;
            this.txtBoxEvtYear.Name = "txtBoxEvtYear";
            this.txtBoxEvtYear.Size = new System.Drawing.Size(38, 22);
            this.txtBoxEvtYear.TabIndex = 11;
            this.txtBoxEvtYear.Text = "0000";
            this.txtBoxEvtYear.Enter += new System.EventHandler(this.txtBoxEvtYear_Enter);
            this.txtBoxEvtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEvtDay_KeyPress);
            this.txtBoxEvtYear.Leave += new System.EventHandler(this.txtBoxEvtYear_Leave);
            // 
            // txtBoxEvtMonth
            // 
            this.txtBoxEvtMonth.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEvtMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxEvtMonth.Location = new System.Drawing.Point(114, 123);
            this.txtBoxEvtMonth.MaxLength = 2;
            this.txtBoxEvtMonth.Name = "txtBoxEvtMonth";
            this.txtBoxEvtMonth.Size = new System.Drawing.Size(28, 22);
            this.txtBoxEvtMonth.TabIndex = 10;
            this.txtBoxEvtMonth.Text = "00";
            this.txtBoxEvtMonth.Enter += new System.EventHandler(this.txtBoxEvtMonth_Enter);
            this.txtBoxEvtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEvtDay_KeyPress);
            this.txtBoxEvtMonth.Leave += new System.EventHandler(this.txtBoxEvtMonth_Leave);
            // 
            // txtBoxEvtDay
            // 
            this.txtBoxEvtDay.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEvtDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxEvtDay.Location = new System.Drawing.Point(74, 122);
            this.txtBoxEvtDay.MaxLength = 2;
            this.txtBoxEvtDay.Name = "txtBoxEvtDay";
            this.txtBoxEvtDay.Size = new System.Drawing.Size(26, 22);
            this.txtBoxEvtDay.TabIndex = 8;
            this.txtBoxEvtDay.Text = "00";
            this.txtBoxEvtDay.Enter += new System.EventHandler(this.txtBoxEvtDay_Enter);
            this.txtBoxEvtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEvtDay_KeyPress);
            this.txtBoxEvtDay.Leave += new System.EventHandler(this.txtBoxEvtDay_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label23.Location = new System.Drawing.Point(33, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 17);
            this.label23.TabIndex = 7;
            this.label23.Text = "Date";
            // 
            // txtBoxEvtVenue
            // 
            this.txtBoxEvtVenue.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEvtVenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxEvtVenue.Location = new System.Drawing.Point(74, 91);
            this.txtBoxEvtVenue.Name = "txtBoxEvtVenue";
            this.txtBoxEvtVenue.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEvtVenue.TabIndex = 6;
            this.txtBoxEvtVenue.Text = "e.g. Place";
            this.txtBoxEvtVenue.Enter += new System.EventHandler(this.txtBoxEvtVenue_Enter);
            this.txtBoxEvtVenue.Leave += new System.EventHandler(this.txtBoxEvtVenue_Leave);
            // 
            // txtBoxEvtName
            // 
            this.txtBoxEvtName.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEvtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxEvtName.Location = new System.Drawing.Point(74, 60);
            this.txtBoxEvtName.Name = "txtBoxEvtName";
            this.txtBoxEvtName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEvtName.TabIndex = 5;
            this.txtBoxEvtName.Text = "e.g. Title";
            this.txtBoxEvtName.Enter += new System.EventHandler(this.txtBoxEvtName_Enter);
            this.txtBoxEvtName.Leave += new System.EventHandler(this.txtBoxEvtName_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label24.Location = new System.Drawing.Point(25, 96);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 17);
            this.label24.TabIndex = 4;
            this.label24.Text = "Venue";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label25.Location = new System.Drawing.Point(29, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 17);
            this.label25.TabIndex = 3;
            this.label25.Text = "Event";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(122, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 25);
            this.label26.TabIndex = 1;
            this.label26.Text = "Add Event";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyektoCSharp.Properties.Resources.icons8_add_property_40;
            this.pictureBox6.Location = new System.Drawing.Point(74, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(68, 50);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblGetIdError);
            this.panel3.Controls.Add(this.lblEventInfo);
            this.panel3.Controls.Add(this.lblGetEventID);
            this.panel3.Controls.Add(this.txtBoxgetEventId);
            this.panel3.Controls.Add(this.btnEvtDetails);
            this.panel3.Location = new System.Drawing.Point(346, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 452);
            this.panel3.TabIndex = 24;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblGetIdError
            // 
            this.lblGetIdError.AutoSize = true;
            this.lblGetIdError.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetIdError.ForeColor = System.Drawing.Color.Red;
            this.lblGetIdError.Location = new System.Drawing.Point(123, 433);
            this.lblGetIdError.Name = "lblGetIdError";
            this.lblGetIdError.Size = new System.Drawing.Size(0, 15);
            this.lblGetIdError.TabIndex = 30;
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.AutoSize = true;
            this.lblEventInfo.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEventInfo.Location = new System.Drawing.Point(27, 28);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(0, 19);
            this.lblEventInfo.TabIndex = 27;
            // 
            // lblGetEventID
            // 
            this.lblGetEventID.AutoSize = true;
            this.lblGetEventID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetEventID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblGetEventID.Location = new System.Drawing.Point(45, 390);
            this.lblGetEventID.Name = "lblGetEventID";
            this.lblGetEventID.Size = new System.Drawing.Size(144, 17);
            this.lblGetEventID.TabIndex = 29;
            this.lblGetEventID.Text = "Enter ID to view details:";
            // 
            // txtBoxgetEventId
            // 
            this.txtBoxgetEventId.Location = new System.Drawing.Point(123, 410);
            this.txtBoxgetEventId.Name = "txtBoxgetEventId";
            this.txtBoxgetEventId.Size = new System.Drawing.Size(66, 20);
            this.txtBoxgetEventId.TabIndex = 27;
            // 
            // btnEvtDetails
            // 
            this.btnEvtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnEvtDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvtDetails.FlatAppearance.BorderSize = 0;
            this.btnEvtDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvtDetails.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnEvtDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(179)))));
            this.btnEvtDetails.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnEvtDetails.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(179)))));
            this.btnEvtDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvtDetails.IconSize = 20;
            this.btnEvtDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvtDetails.Location = new System.Drawing.Point(210, 406);
            this.btnEvtDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnEvtDetails.Name = "btnEvtDetails";
            this.btnEvtDetails.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEvtDetails.Size = new System.Drawing.Size(99, 24);
            this.btnEvtDetails.TabIndex = 25;
            this.btnEvtDetails.Text = "Details";
            this.btnEvtDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvtDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvtDetails.UseVisualStyleBackColor = false;
            this.btnEvtDetails.Click += new System.EventHandler(this.btnEvtDetails_Click);
            // 
            // lblEventList
            // 
            this.lblEventList.AutoSize = true;
            this.lblEventList.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEventList.Location = new System.Drawing.Point(13, 64);
            this.lblEventList.Name = "lblEventList";
            this.lblEventList.Size = new System.Drawing.Size(0, 19);
            this.lblEventList.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(87, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Event\'s List";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyektoCSharp.Properties.Resources.icons8_calendar_48;
            this.pictureBox5.Location = new System.Drawing.Point(37, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 50);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.lblEventList);
            this.panel1.Location = new System.Drawing.Point(13, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 194);
            this.panel1.TabIndex = 25;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(13, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "ID         Event Name             Venue";
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(691, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEvent";
            this.Text = "Event";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtBoxEvtAttendees;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBoxEvtMin;
        private System.Windows.Forms.TextBox txtBoxEvtHour;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBoxEvtYear;
        private System.Windows.Forms.TextBox txtBoxEvtMonth;
        private System.Windows.Forms.TextBox txtBoxEvtDay;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBoxEvtVenue;
        private System.Windows.Forms.TextBox txtBoxEvtName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox5;
        private FontAwesome.Sharp.IconButton btnEvtAdd;
        private FontAwesome.Sharp.IconButton btnEvtDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEventList;
        private System.Windows.Forms.TextBox txtBoxgetEventId;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.Label lblAttendeeError;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Label lblGetEventID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGetIdError;
    }
}