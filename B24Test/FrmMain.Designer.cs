namespace B24Test
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebhookURL = new System.Windows.Forms.TextBox();
            this.txtWebhookKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateApi = new System.Windows.Forms.Button();
            this.txtGetUserWithId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetUserWithId = new System.Windows.Forms.Button();
            this.btnGetUserWithEmail = new System.Windows.Forms.Button();
            this.txtGetUserWithEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetProjects = new System.Windows.Forms.Button();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.btnGetTaskWithId = new System.Windows.Forms.Button();
            this.txtGetTaskWithId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnControlTaskWithId = new System.Windows.Forms.Button();
            this.txtControlTaskWithId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStartDatePlan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtResponsibleId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.lblcreated = new System.Windows.Forms.Label();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.txtAuidtors = new System.Windows.Forms.TextBox();
            this.AUDITORS = new System.Windows.Forms.Label();
            this.btnCheckApi = new System.Windows.Forms.Button();
            this.txtAccomplices = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WebhookURL";
            // 
            // txtWebhookURL
            // 
            this.txtWebhookURL.Location = new System.Drawing.Point(94, 10);
            this.txtWebhookURL.Name = "txtWebhookURL";
            this.txtWebhookURL.Size = new System.Drawing.Size(276, 20);
            this.txtWebhookURL.TabIndex = 1;
            this.txtWebhookURL.Text = "https://mybitrix24.bitrix.com/rest";
            // 
            // txtWebhookKey
            // 
            this.txtWebhookKey.Location = new System.Drawing.Point(94, 62);
            this.txtWebhookKey.Name = "txtWebhookKey";
            this.txtWebhookKey.Size = new System.Drawing.Size(276, 20);
            this.txtWebhookKey.TabIndex = 3;
            this.txtWebhookKey.Text = "hre6plffyxtfx0qz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "WebhookKey";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(94, 36);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(38, 20);
            this.txtUserId.TabIndex = 5;
            this.txtUserId.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserId";
            // 
            // btnCreateApi
            // 
            this.btnCreateApi.Location = new System.Drawing.Point(276, 88);
            this.btnCreateApi.Name = "btnCreateApi";
            this.btnCreateApi.Size = new System.Drawing.Size(94, 23);
            this.btnCreateApi.TabIndex = 6;
            this.btnCreateApi.Text = "Create API";
            this.btnCreateApi.UseVisualStyleBackColor = true;
            this.btnCreateApi.Click += new System.EventHandler(this.btnCreateApi_Click);
            // 
            // txtGetUserWithId
            // 
            this.txtGetUserWithId.Location = new System.Drawing.Point(94, 120);
            this.txtGetUserWithId.Name = "txtGetUserWithId";
            this.txtGetUserWithId.Size = new System.Drawing.Size(38, 20);
            this.txtGetUserWithId.TabIndex = 8;
            this.txtGetUserWithId.Text = "181";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "UserId";
            // 
            // btnGetUserWithId
            // 
            this.btnGetUserWithId.Location = new System.Drawing.Point(276, 117);
            this.btnGetUserWithId.Name = "btnGetUserWithId";
            this.btnGetUserWithId.Size = new System.Drawing.Size(94, 23);
            this.btnGetUserWithId.TabIndex = 9;
            this.btnGetUserWithId.Text = "Get User ID";
            this.btnGetUserWithId.UseVisualStyleBackColor = true;
            this.btnGetUserWithId.Click += new System.EventHandler(this.btnGetUserWithId_Click);
            // 
            // btnGetUserWithEmail
            // 
            this.btnGetUserWithEmail.Location = new System.Drawing.Point(276, 146);
            this.btnGetUserWithEmail.Name = "btnGetUserWithEmail";
            this.btnGetUserWithEmail.Size = new System.Drawing.Size(94, 23);
            this.btnGetUserWithEmail.TabIndex = 12;
            this.btnGetUserWithEmail.Text = "Get User Email";
            this.btnGetUserWithEmail.UseVisualStyleBackColor = true;
            this.btnGetUserWithEmail.Click += new System.EventHandler(this.btnGetUserWithEmail_Click);
            // 
            // txtGetUserWithEmail
            // 
            this.txtGetUserWithEmail.Location = new System.Drawing.Point(94, 149);
            this.txtGetUserWithEmail.Name = "txtGetUserWithEmail";
            this.txtGetUserWithEmail.Size = new System.Drawing.Size(176, 20);
            this.txtGetUserWithEmail.TabIndex = 11;
            this.txtGetUserWithEmail.Text = "ilkaysener@windowslive.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // btnGetProjects
            // 
            this.btnGetProjects.Location = new System.Drawing.Point(276, 175);
            this.btnGetProjects.Name = "btnGetProjects";
            this.btnGetProjects.Size = new System.Drawing.Size(94, 21);
            this.btnGetProjects.TabIndex = 13;
            this.btnGetProjects.Text = "Get Projects";
            this.btnGetProjects.UseVisualStyleBackColor = true;
            this.btnGetProjects.Click += new System.EventHandler(this.btnGetProjects_Click);
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(94, 175);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(176, 21);
            this.cmbProjects.TabIndex = 14;
            // 
            // btnGetTaskWithId
            // 
            this.btnGetTaskWithId.Location = new System.Drawing.Point(276, 201);
            this.btnGetTaskWithId.Name = "btnGetTaskWithId";
            this.btnGetTaskWithId.Size = new System.Drawing.Size(94, 23);
            this.btnGetTaskWithId.TabIndex = 17;
            this.btnGetTaskWithId.Text = "Get Task ID";
            this.btnGetTaskWithId.UseVisualStyleBackColor = true;
            this.btnGetTaskWithId.Click += new System.EventHandler(this.btnGetTaskWithId_Click);
            // 
            // txtGetTaskWithId
            // 
            this.txtGetTaskWithId.Location = new System.Drawing.Point(94, 204);
            this.txtGetTaskWithId.Name = "txtGetTaskWithId";
            this.txtGetTaskWithId.Size = new System.Drawing.Size(38, 20);
            this.txtGetTaskWithId.TabIndex = 16;
            this.txtGetTaskWithId.Text = "1259";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "TaskId";
            // 
            // btnControlTaskWithId
            // 
            this.btnControlTaskWithId.Location = new System.Drawing.Point(276, 230);
            this.btnControlTaskWithId.Name = "btnControlTaskWithId";
            this.btnControlTaskWithId.Size = new System.Drawing.Size(94, 23);
            this.btnControlTaskWithId.TabIndex = 20;
            this.btnControlTaskWithId.Text = "Control Task ID";
            this.btnControlTaskWithId.UseVisualStyleBackColor = true;
            this.btnControlTaskWithId.Click += new System.EventHandler(this.btnControlTaskWithId_Click);
            // 
            // txtControlTaskWithId
            // 
            this.txtControlTaskWithId.Location = new System.Drawing.Point(94, 233);
            this.txtControlTaskWithId.Name = "txtControlTaskWithId";
            this.txtControlTaskWithId.Size = new System.Drawing.Size(38, 20);
            this.txtControlTaskWithId.TabIndex = 19;
            this.txtControlTaskWithId.Text = "1259";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "TaskId";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(494, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(197, 20);
            this.txtTitle.TabIndex = 22;
            this.txtTitle.Text = "Test Mission";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "TITLE";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(494, 36);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(197, 20);
            this.txtDescription.TabIndex = 24;
            this.txtDescription.Text = "Integration Mission";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "DESCRIPTION";
            // 
            // txtStartDatePlan
            // 
            this.txtStartDatePlan.Location = new System.Drawing.Point(494, 62);
            this.txtStartDatePlan.Name = "txtStartDatePlan";
            this.txtStartDatePlan.Size = new System.Drawing.Size(197, 20);
            this.txtStartDatePlan.TabIndex = 26;
            this.txtStartDatePlan.Text = "13.12.2020";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "START_DATE_PLAN";
            // 
            // txtDeadline
            // 
            this.txtDeadline.Location = new System.Drawing.Point(494, 88);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(197, 20);
            this.txtDeadline.TabIndex = 28;
            this.txtDeadline.Text = "15.12.2020";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(427, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "DEADLINE";
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(494, 114);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(197, 20);
            this.txtPriority.TabIndex = 30;
            this.txtPriority.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(430, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "PRIORITY";
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(494, 140);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(197, 20);
            this.txtGroupId.TabIndex = 32;
            this.txtGroupId.Text = "72";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(425, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "GROUP_ID";
            // 
            // txtResponsibleId
            // 
            this.txtResponsibleId.Location = new System.Drawing.Point(494, 192);
            this.txtResponsibleId.Name = "txtResponsibleId";
            this.txtResponsibleId.Size = new System.Drawing.Size(197, 20);
            this.txtResponsibleId.TabIndex = 34;
            this.txtResponsibleId.Text = "181";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(389, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "RESPONSIBLE_ID";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(597, 270);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(94, 23);
            this.btnAddTask.TabIndex = 35;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(494, 166);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(197, 20);
            this.txtCreatedBy.TabIndex = 37;
            this.txtCreatedBy.Text = "4";
            // 
            // lblcreated
            // 
            this.lblcreated.AutoSize = true;
            this.lblcreated.Location = new System.Drawing.Point(410, 169);
            this.lblcreated.Name = "lblcreated";
            this.lblcreated.Size = new System.Drawing.Size(78, 13);
            this.lblcreated.TabIndex = 36;
            this.lblcreated.Text = "CREATED_BY";
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Location = new System.Drawing.Point(33, 178);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(55, 17);
            this.chkIsAdmin.TabIndex = 38;
            this.chkIsAdmin.Text = "Admin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // txtAuidtors
            // 
            this.txtAuidtors.Enabled = false;
            this.txtAuidtors.Location = new System.Drawing.Point(494, 218);
            this.txtAuidtors.Name = "txtAuidtors";
            this.txtAuidtors.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAuidtors.Size = new System.Drawing.Size(197, 20);
            this.txtAuidtors.TabIndex = 40;
            this.txtAuidtors.Text = "179";
            // 
            // AUDITORS
            // 
            this.AUDITORS.AutoSize = true;
            this.AUDITORS.Location = new System.Drawing.Point(425, 221);
            this.AUDITORS.Name = "AUDITORS";
            this.AUDITORS.Size = new System.Drawing.Size(63, 13);
            this.AUDITORS.TabIndex = 39;
            this.AUDITORS.Text = "AUDITORS";
            // 
            // btnCheckApi
            // 
            this.btnCheckApi.Location = new System.Drawing.Point(176, 88);
            this.btnCheckApi.Name = "btnCheckApi";
            this.btnCheckApi.Size = new System.Drawing.Size(94, 23);
            this.btnCheckApi.TabIndex = 41;
            this.btnCheckApi.Text = "Check API";
            this.btnCheckApi.UseVisualStyleBackColor = true;
            this.btnCheckApi.Click += new System.EventHandler(this.btnCheckApi_Click);
            // 
            // txtAccomplices
            // 
            this.txtAccomplices.Location = new System.Drawing.Point(494, 244);
            this.txtAccomplices.Name = "txtAccomplices";
            this.txtAccomplices.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAccomplices.Size = new System.Drawing.Size(197, 20);
            this.txtAccomplices.TabIndex = 43;
            this.txtAccomplices.Text = "179";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(406, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "ACCOMPLICES";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 320);
            this.Controls.Add(this.txtAccomplices);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCheckApi);
            this.Controls.Add(this.txtAuidtors);
            this.Controls.Add(this.AUDITORS);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.lblcreated);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtResponsibleId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStartDatePlan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnControlTaskWithId);
            this.Controls.Add(this.txtControlTaskWithId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGetTaskWithId);
            this.Controls.Add(this.txtGetTaskWithId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.btnGetProjects);
            this.Controls.Add(this.btnGetUserWithEmail);
            this.Controls.Add(this.txtGetUserWithEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetUserWithId);
            this.Controls.Add(this.txtGetUserWithId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreateApi);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWebhookKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWebhookURL);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "B24 Api Test";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebhookURL;
        private System.Windows.Forms.TextBox txtWebhookKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateApi;
        private System.Windows.Forms.TextBox txtGetUserWithId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetUserWithId;
        private System.Windows.Forms.Button btnGetUserWithEmail;
        private System.Windows.Forms.TextBox txtGetUserWithEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetProjects;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Button btnGetTaskWithId;
        private System.Windows.Forms.TextBox txtGetTaskWithId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnControlTaskWithId;
        private System.Windows.Forms.TextBox txtControlTaskWithId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStartDatePlan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtResponsibleId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.Label lblcreated;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.TextBox txtAuidtors;
        private System.Windows.Forms.Label AUDITORS;
        private System.Windows.Forms.Button btnCheckApi;
        private System.Windows.Forms.TextBox txtAccomplices;
        private System.Windows.Forms.Label label15;
    }
}

