namespace ProyektoCSharp.Forms
{
    partial class FormCustomer
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDelConfirm = new System.Windows.Forms.Label();
            this.lblGetID = new System.Windows.Forms.Label();
            this.txtBoxGetCustId = new System.Windows.Forms.TextBox();
            this.lblCustList = new System.Windows.Forms.Label();
            this.btnCustDel = new FontAwesome.Sharp.IconButton();
            this.btnCustDetails = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAddingConfirm = new System.Windows.Forms.Label();
            this.btnCustAdd = new FontAwesome.Sharp.IconButton();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLname = new System.Windows.Forms.TextBox();
            this.txtBoxFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustInfoById = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblDelConfirm);
            this.panel4.Controls.Add(this.lblGetID);
            this.panel4.Controls.Add(this.txtBoxGetCustId);
            this.panel4.Controls.Add(this.lblCustList);
            this.panel4.Controls.Add(this.btnCustDel);
            this.panel4.Controls.Add(this.btnCustDetails);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(329, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 452);
            this.panel4.TabIndex = 16;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID                    Name                    Phone";
            // 
            // lblDelConfirm
            // 
            this.lblDelConfirm.AutoSize = true;
            this.lblDelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblDelConfirm.Location = new System.Drawing.Point(130, 386);
            this.lblDelConfirm.Name = "lblDelConfirm";
            this.lblDelConfirm.Size = new System.Drawing.Size(0, 15);
            this.lblDelConfirm.TabIndex = 31;
            // 
            // lblGetID
            // 
            this.lblGetID.AutoSize = true;
            this.lblGetID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblGetID.Location = new System.Drawing.Point(30, 367);
            this.lblGetID.Name = "lblGetID";
            this.lblGetID.Size = new System.Drawing.Size(193, 17);
            this.lblGetID.TabIndex = 30;
            this.lblGetID.Text = "Enter ID to view details / delete:";
            // 
            // txtBoxGetCustId
            // 
            this.txtBoxGetCustId.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxGetCustId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGetCustId.Location = new System.Drawing.Point(229, 364);
            this.txtBoxGetCustId.Name = "txtBoxGetCustId";
            this.txtBoxGetCustId.Size = new System.Drawing.Size(70, 20);
            this.txtBoxGetCustId.TabIndex = 29;
            // 
            // lblCustList
            // 
            this.lblCustList.AutoSize = true;
            this.lblCustList.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustList.Location = new System.Drawing.Point(29, 90);
            this.lblCustList.Name = "lblCustList";
            this.lblCustList.Size = new System.Drawing.Size(0, 19);
            this.lblCustList.TabIndex = 28;
            // 
            // btnCustDel
            // 
            this.btnCustDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnCustDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustDel.FlatAppearance.BorderSize = 0;
            this.btnCustDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Bold);
            this.btnCustDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnCustDel.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnCustDel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnCustDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustDel.IconSize = 20;
            this.btnCustDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDel.Location = new System.Drawing.Point(186, 412);
            this.btnCustDel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustDel.Name = "btnCustDel";
            this.btnCustDel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCustDel.Size = new System.Drawing.Size(92, 24);
            this.btnCustDel.TabIndex = 27;
            this.btnCustDel.Text = "Delete";
            this.btnCustDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustDel.UseVisualStyleBackColor = false;
            this.btnCustDel.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnCustDetails
            // 
            this.btnCustDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnCustDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustDetails.FlatAppearance.BorderSize = 0;
            this.btnCustDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustDetails.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Bold);
            this.btnCustDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(179)))));
            this.btnCustDetails.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnCustDetails.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(179)))));
            this.btnCustDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustDetails.IconSize = 20;
            this.btnCustDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDetails.Location = new System.Drawing.Point(83, 412);
            this.btnCustDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustDetails.Name = "btnCustDetails";
            this.btnCustDetails.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCustDetails.Size = new System.Drawing.Size(92, 24);
            this.btnCustDetails.TabIndex = 26;
            this.btnCustDetails.Text = "Details";
            this.btnCustDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustDetails.UseVisualStyleBackColor = false;
            this.btnCustDetails.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(120, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Customer\'s List";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyektoCSharp.Properties.Resources.user_list1;
            this.pictureBox5.Location = new System.Drawing.Point(69, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 50);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblAddingConfirm);
            this.panel3.Controls.Add(this.btnCustAdd);
            this.panel3.Controls.Add(this.txtBoxPhone);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBoxLname);
            this.panel3.Controls.Add(this.txtBoxFname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 225);
            this.panel3.TabIndex = 15;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblAddingConfirm
            // 
            this.lblAddingConfirm.AutoSize = true;
            this.lblAddingConfirm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblAddingConfirm.Location = new System.Drawing.Point(82, 138);
            this.lblAddingConfirm.Name = "lblAddingConfirm";
            this.lblAddingConfirm.Size = new System.Drawing.Size(0, 17);
            this.lblAddingConfirm.TabIndex = 23;
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnCustAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustAdd.FlatAppearance.BorderSize = 0;
            this.btnCustAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.btnCustAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCustAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustAdd.IconSize = 15;
            this.btnCustAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustAdd.Location = new System.Drawing.Point(174, 181);
            this.btnCustAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnCustAdd.Size = new System.Drawing.Size(105, 29);
            this.btnCustAdd.TabIndex = 22;
            this.btnCustAdd.Text = "Add";
            this.btnCustAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustAdd.UseVisualStyleBackColor = false;
            this.btnCustAdd.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxPhone.Location = new System.Drawing.Point(85, 113);
            this.txtBoxPhone.MaxLength = 12;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPhone.TabIndex = 8;
            this.txtBoxPhone.Text = "XXX-XXX-XXXX";
            this.toolTip1.SetToolTip(this.txtBoxPhone, "Hint! XXX-XXX-XXXX");
            this.txtBoxPhone.Enter += new System.EventHandler(this.txtBoxPhone_Enter);
            this.txtBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPhone_KeyPress);
            this.txtBoxPhone.Leave += new System.EventHandler(this.txtBoxPhone_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone no.";
            // 
            // txtBoxLname
            // 
            this.txtBoxLname.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxLname.Location = new System.Drawing.Point(85, 82);
            this.txtBoxLname.MaxLength = 60;
            this.txtBoxLname.Name = "txtBoxLname";
            this.txtBoxLname.Size = new System.Drawing.Size(100, 22);
            this.txtBoxLname.TabIndex = 6;
            this.txtBoxLname.Text = "e.g. Doe";
            this.txtBoxLname.Enter += new System.EventHandler(this.txtBoxLname_Enter);
            this.txtBoxLname.Leave += new System.EventHandler(this.txtBoxLname_Leave);
            // 
            // txtBoxFname
            // 
            this.txtBoxFname.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtBoxFname.Location = new System.Drawing.Point(85, 51);
            this.txtBoxFname.MaxLength = 60;
            this.txtBoxFname.Name = "txtBoxFname";
            this.txtBoxFname.Size = new System.Drawing.Size(100, 22);
            this.txtBoxFname.TabIndex = 5;
            this.txtBoxFname.Text = "e.g John";
            this.txtBoxFname.Enter += new System.EventHandler(this.txtBoxFname_Enter);
            this.txtBoxFname.Leave += new System.EventHandler(this.txtBoxFname_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(122, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Add Customer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyektoCSharp.Properties.Resources.add_cust;
            this.pictureBox2.Location = new System.Drawing.Point(74, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCustInfoById);
            this.panel1.Location = new System.Drawing.Point(13, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 221);
            this.panel1.TabIndex = 26;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // lblCustInfoById
            // 
            this.lblCustInfoById.AutoSize = true;
            this.lblCustInfoById.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCustInfoById.Location = new System.Drawing.Point(28, 33);
            this.lblCustInfoById.Name = "lblCustInfoById";
            this.lblCustInfoById.Size = new System.Drawing.Size(0, 19);
            this.lblCustInfoById.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Put with dashes";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(691, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomer";
            this.Text = "Customer";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxLname;
        private System.Windows.Forms.TextBox txtBoxFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnCustDel;
        private FontAwesome.Sharp.IconButton btnCustDetails;
        private FontAwesome.Sharp.IconButton btnCustAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCustList;
        private System.Windows.Forms.Label lblCustInfoById;
        private System.Windows.Forms.TextBox txtBoxGetCustId;
        private System.Windows.Forms.Label lblAddingConfirm;
        private System.Windows.Forms.Label lblGetID;
        private System.Windows.Forms.Label lblDelConfirm;
        private System.Windows.Forms.Label label1;
    }
}