namespace ProyektoCSharp.Forms
{
    partial class FormRSVP
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEventinfo = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblErrorAdding = new System.Windows.Forms.Label();
            this.btnRsvpAdd = new FontAwesome.Sharp.IconButton();
            this.txtBoxRsvpEvtId = new System.Windows.Forms.TextBox();
            this.txtBoxRsvpCustId = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRSVPList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblEventinfo);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(353, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 233);
            this.panel3.TabIndex = 26;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(26, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "ID         Event Name             Venue";
            // 
            // lblEventinfo
            // 
            this.lblEventinfo.AutoSize = true;
            this.lblEventinfo.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Bold);
            this.lblEventinfo.Location = new System.Drawing.Point(30, 65);
            this.lblEventinfo.Name = "lblEventinfo";
            this.lblEventinfo.Size = new System.Drawing.Size(0, 19);
            this.lblEventinfo.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(120, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Event\'s List";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyektoCSharp.Properties.Resources.icons8_calendar_48;
            this.pictureBox5.Location = new System.Drawing.Point(69, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 50);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel10.Controls.Add(this.lblErrorAdding);
            this.panel10.Controls.Add(this.btnRsvpAdd);
            this.panel10.Controls.Add(this.txtBoxRsvpEvtId);
            this.panel10.Controls.Add(this.txtBoxRsvpCustId);
            this.panel10.Controls.Add(this.label24);
            this.panel10.Controls.Add(this.label25);
            this.panel10.Controls.Add(this.label26);
            this.panel10.Controls.Add(this.pictureBox6);
            this.panel10.Location = new System.Drawing.Point(12, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(240, 233);
            this.panel10.TabIndex = 25;
            this.panel10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblErrorAdding
            // 
            this.lblErrorAdding.AutoSize = true;
            this.lblErrorAdding.ForeColor = System.Drawing.Color.Green;
            this.lblErrorAdding.Location = new System.Drawing.Point(91, 151);
            this.lblErrorAdding.Name = "lblErrorAdding";
            this.lblErrorAdding.Size = new System.Drawing.Size(0, 13);
            this.lblErrorAdding.TabIndex = 22;
            // 
            // btnRsvpAdd
            // 
            this.btnRsvpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnRsvpAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRsvpAdd.FlatAppearance.BorderSize = 0;
            this.btnRsvpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRsvpAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsvpAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRsvpAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnRsvpAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRsvpAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRsvpAdd.IconSize = 14;
            this.btnRsvpAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRsvpAdd.Location = new System.Drawing.Point(91, 174);
            this.btnRsvpAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnRsvpAdd.Name = "btnRsvpAdd";
            this.btnRsvpAdd.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnRsvpAdd.Size = new System.Drawing.Size(102, 34);
            this.btnRsvpAdd.TabIndex = 21;
            this.btnRsvpAdd.Text = "Add";
            this.btnRsvpAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRsvpAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRsvpAdd.UseVisualStyleBackColor = false;
            this.btnRsvpAdd.Click += new System.EventHandler(this.btnRsvpAdd_Click);
            // 
            // txtBoxRsvpEvtId
            // 
            this.txtBoxRsvpEvtId.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRsvpEvtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxRsvpEvtId.Location = new System.Drawing.Point(93, 123);
            this.txtBoxRsvpEvtId.MaxLength = 4;
            this.txtBoxRsvpEvtId.Name = "txtBoxRsvpEvtId";
            this.txtBoxRsvpEvtId.Size = new System.Drawing.Size(100, 22);
            this.txtBoxRsvpEvtId.TabIndex = 6;
            this.txtBoxRsvpEvtId.Text = "0000";
            this.txtBoxRsvpEvtId.Enter += new System.EventHandler(this.txtBoxRsvpEvtId_Enter);
            this.txtBoxRsvpEvtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRsvpCustId_KeyPress);
            this.txtBoxRsvpEvtId.Leave += new System.EventHandler(this.txtBoxRsvpEvtId_Leave);
            // 
            // txtBoxRsvpCustId
            // 
            this.txtBoxRsvpCustId.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRsvpCustId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxRsvpCustId.Location = new System.Drawing.Point(93, 92);
            this.txtBoxRsvpCustId.MaxLength = 4;
            this.txtBoxRsvpCustId.Name = "txtBoxRsvpCustId";
            this.txtBoxRsvpCustId.Size = new System.Drawing.Size(100, 22);
            this.txtBoxRsvpCustId.TabIndex = 5;
            this.txtBoxRsvpCustId.Text = "0000";
            this.txtBoxRsvpCustId.Enter += new System.EventHandler(this.txtBoxRsvpCustId_Enter);
            this.txtBoxRsvpCustId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRsvpCustId_KeyPress);
            this.txtBoxRsvpCustId.Leave += new System.EventHandler(this.txtBoxRsvpCustId_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label24.Location = new System.Drawing.Point(35, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 17);
            this.label24.TabIndex = 4;
            this.label24.Text = "Event Id";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label25.Location = new System.Drawing.Point(11, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 17);
            this.label25.TabIndex = 3;
            this.label25.Text = "Customer Id";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(70, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(152, 25);
            this.label26.TabIndex = 1;
            this.label26.Text = "Register to Event";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyektoCSharp.Properties.Resources.add_to_event1;
            this.pictureBox6.Location = new System.Drawing.Point(18, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(68, 50);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblCustInfo);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(12, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 233);
            this.panel4.TabIndex = 27;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID           Name                    Phone";
            // 
            // lblCustInfo
            // 
            this.lblCustInfo.AutoSize = true;
            this.lblCustInfo.Font = new System.Drawing.Font("Book Antiqua", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCustInfo.Location = new System.Drawing.Point(12, 62);
            this.lblCustInfo.Name = "lblCustInfo";
            this.lblCustInfo.Size = new System.Drawing.Size(0, 18);
            this.lblCustInfo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(118, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Customer\'s List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyektoCSharp.Properties.Resources.customers;
            this.pictureBox1.Location = new System.Drawing.Point(69, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblRSVPList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(258, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 233);
            this.panel1.TabIndex = 28;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblRSVPList
            // 
            this.lblRSVPList.AutoSize = true;
            this.lblRSVPList.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold);
            this.lblRSVPList.Location = new System.Drawing.Point(8, 66);
            this.lblRSVPList.Name = "lblRSVPList";
            this.lblRSVPList.Size = new System.Drawing.Size(0, 17);
            this.lblRSVPList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "RSVP\'s List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyektoCSharp.Properties.Resources.event_accepted;
            this.pictureBox2.Location = new System.Drawing.Point(92, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 68);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FormRSVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(688, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRSVP";
            this.Text = "RSVP";
            this.Load += new System.EventHandler(this.FormRSVP_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton btnRsvpAdd;
        private System.Windows.Forms.TextBox txtBoxRsvpEvtId;
        private System.Windows.Forms.TextBox txtBoxRsvpCustId;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEventinfo;
        private System.Windows.Forms.Label lblCustInfo;
        private System.Windows.Forms.Label lblRSVPList;
        private System.Windows.Forms.Label lblErrorAdding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}