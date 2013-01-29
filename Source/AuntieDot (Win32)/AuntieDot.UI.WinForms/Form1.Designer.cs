namespace AuntieDot.UI.WinForms
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
            this.btnRequestToken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOAuthToken = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSkipSTGeneration = new System.Windows.Forms.CheckBox();
            this.txtSpartanToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGetMatch = new System.Windows.Forms.Button();
            this.txtMatchID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetMatches = new System.Windows.Forms.Button();
            this.txtMatchesStartAt = new System.Windows.Forms.TextBox();
            this.txtMatchesCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetMetadata = new System.Windows.Forms.Button();
            this.btnGetPlayerCard = new System.Windows.Forms.Button();
            this.btnGetPlaylists = new System.Windows.Forms.Button();
            this.btnGetWargames = new System.Windows.Forms.Button();
            this.btnGetCustoms = new System.Windows.Forms.Button();
            this.btnGetSpartanOps = new System.Windows.Forms.Button();
            this.btnGetChallenges = new System.Windows.Forms.Button();
            this.btnGetCampaign = new System.Windows.Forms.Button();
            this.GetCommendations = new System.Windows.Forms.Button();
            this.btnGetServiceRecord = new System.Windows.Forms.Button();
            this.btnGetPersonalChallenges = new System.Windows.Forms.Button();
            this.txtGamertag = new System.Windows.Forms.TextBox();
            this.btnGetServicesList = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbServices = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtHeaders = new System.Windows.Forms.TextBox();
            this.txtSelectedService = new System.Windows.Forms.TextBox();
            this.btnCallSelectedService = new System.Windows.Forms.Button();
            this.txtServiceOutput = new System.Windows.Forms.TextBox();
            this.btnRapeThemServers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDoAuth = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequestToken
            // 
            this.btnRequestToken.Location = new System.Drawing.Point(234, 102);
            this.btnRequestToken.Name = "btnRequestToken";
            this.btnRequestToken.Size = new System.Drawing.Size(259, 23);
            this.btnRequestToken.TabIndex = 0;
            this.btnRequestToken.Text = "Request Spartan Token";
            this.btnRequestToken.UseVisualStyleBackColor = true;
            this.btnRequestToken.Click += new System.EventHandler(this.btnRequestToken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OAuth Access Token:";
            // 
            // txtOAuthToken
            // 
            this.txtOAuthToken.Location = new System.Drawing.Point(124, 76);
            this.txtOAuthToken.Name = "txtOAuthToken";
            this.txtOAuthToken.Size = new System.Drawing.Size(369, 20);
            this.txtOAuthToken.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoAuth);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.cbSkipSTGeneration);
            this.groupBox1.Controls.Add(this.txtSpartanToken);
            this.groupBox1.Controls.Add(this.btnRequestToken);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOAuthToken);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 157);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // cbSkipSTGeneration
            // 
            this.cbSkipSTGeneration.AutoSize = true;
            this.cbSkipSTGeneration.Location = new System.Drawing.Point(9, 106);
            this.cbSkipSTGeneration.Name = "cbSkipSTGeneration";
            this.cbSkipSTGeneration.Size = new System.Drawing.Size(173, 17);
            this.cbSkipSTGeneration.TabIndex = 5;
            this.cbSkipSTGeneration.Text = "Skip SpartanToken Generation";
            this.cbSkipSTGeneration.UseVisualStyleBackColor = true;
            // 
            // txtSpartanToken
            // 
            this.txtSpartanToken.Location = new System.Drawing.Point(93, 131);
            this.txtSpartanToken.Name = "txtSpartanToken";
            this.txtSpartanToken.Size = new System.Drawing.Size(400, 20);
            this.txtSpartanToken.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spartan Token:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.btnGetMetadata);
            this.groupBox2.Controls.Add(this.btnGetPlayerCard);
            this.groupBox2.Controls.Add(this.btnGetPlaylists);
            this.groupBox2.Controls.Add(this.btnGetWargames);
            this.groupBox2.Controls.Add(this.btnGetCustoms);
            this.groupBox2.Controls.Add(this.btnGetSpartanOps);
            this.groupBox2.Controls.Add(this.btnGetChallenges);
            this.groupBox2.Controls.Add(this.btnGetCampaign);
            this.groupBox2.Controls.Add(this.GetCommendations);
            this.groupBox2.Controls.Add(this.btnGetServiceRecord);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 240);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Global Functions;";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGetMatch);
            this.groupBox6.Controls.Add(this.txtMatchID);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(9, 195);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(484, 39);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Match:";
            // 
            // btnGetMatch
            // 
            this.btnGetMatch.Location = new System.Drawing.Point(345, 11);
            this.btnGetMatch.Name = "btnGetMatch";
            this.btnGetMatch.Size = new System.Drawing.Size(133, 23);
            this.btnGetMatch.TabIndex = 11;
            this.btnGetMatch.Text = "Get Match";
            this.btnGetMatch.UseVisualStyleBackColor = true;
            this.btnGetMatch.Click += new System.EventHandler(this.btnGetMatch_Click);
            // 
            // txtMatchID
            // 
            this.txtMatchID.Location = new System.Drawing.Point(64, 13);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.Size = new System.Drawing.Size(251, 20);
            this.txtMatchID.TabIndex = 6;
            this.txtMatchID.Text = "569724820e5fa1e4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Match Id:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGetMatches);
            this.groupBox5.Controls.Add(this.txtMatchesStartAt);
            this.groupBox5.Controls.Add(this.txtMatchesCount);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(9, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(484, 39);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Matches;";
            // 
            // btnGetMatches
            // 
            this.btnGetMatches.Location = new System.Drawing.Point(345, 11);
            this.btnGetMatches.Name = "btnGetMatches";
            this.btnGetMatches.Size = new System.Drawing.Size(133, 23);
            this.btnGetMatches.TabIndex = 11;
            this.btnGetMatches.Text = "Get Matches";
            this.btnGetMatches.UseVisualStyleBackColor = true;
            this.btnGetMatches.Click += new System.EventHandler(this.btnGetMatches_Click);
            // 
            // txtMatchesStartAt
            // 
            this.txtMatchesStartAt.Location = new System.Drawing.Point(217, 13);
            this.txtMatchesStartAt.Name = "txtMatchesStartAt";
            this.txtMatchesStartAt.Size = new System.Drawing.Size(98, 20);
            this.txtMatchesStartAt.TabIndex = 7;
            this.txtMatchesStartAt.Text = "0";
            // 
            // txtMatchesCount
            // 
            this.txtMatchesCount.Location = new System.Drawing.Point(50, 13);
            this.txtMatchesCount.Name = "txtMatchesCount";
            this.txtMatchesCount.Size = new System.Drawing.Size(98, 20);
            this.txtMatchesCount.TabIndex = 6;
            this.txtMatchesCount.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start At:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count:";
            // 
            // btnGetMetadata
            // 
            this.btnGetMetadata.Location = new System.Drawing.Point(9, 106);
            this.btnGetMetadata.Name = "btnGetMetadata";
            this.btnGetMetadata.Size = new System.Drawing.Size(141, 23);
            this.btnGetMetadata.TabIndex = 10;
            this.btnGetMetadata.Text = "Get Metadata";
            this.btnGetMetadata.UseVisualStyleBackColor = true;
            this.btnGetMetadata.Click += new System.EventHandler(this.btnGetMetadata_Click);
            // 
            // btnGetPlayerCard
            // 
            this.btnGetPlayerCard.Location = new System.Drawing.Point(303, 77);
            this.btnGetPlayerCard.Name = "btnGetPlayerCard";
            this.btnGetPlayerCard.Size = new System.Drawing.Size(141, 23);
            this.btnGetPlayerCard.TabIndex = 9;
            this.btnGetPlayerCard.Text = "Get Player Card";
            this.btnGetPlayerCard.UseVisualStyleBackColor = true;
            this.btnGetPlayerCard.Click += new System.EventHandler(this.btnGetPlayerCard_Click);
            // 
            // btnGetPlaylists
            // 
            this.btnGetPlaylists.Location = new System.Drawing.Point(156, 77);
            this.btnGetPlaylists.Name = "btnGetPlaylists";
            this.btnGetPlaylists.Size = new System.Drawing.Size(141, 23);
            this.btnGetPlaylists.TabIndex = 8;
            this.btnGetPlaylists.Text = "Get Playlists";
            this.btnGetPlaylists.UseVisualStyleBackColor = true;
            this.btnGetPlaylists.Click += new System.EventHandler(this.btnGetPlaylists_Click);
            // 
            // btnGetWargames
            // 
            this.btnGetWargames.Location = new System.Drawing.Point(9, 77);
            this.btnGetWargames.Name = "btnGetWargames";
            this.btnGetWargames.Size = new System.Drawing.Size(141, 23);
            this.btnGetWargames.TabIndex = 7;
            this.btnGetWargames.Text = "Get Wargames";
            this.btnGetWargames.UseVisualStyleBackColor = true;
            this.btnGetWargames.Click += new System.EventHandler(this.btnGetWargames_Click);
            // 
            // btnGetCustoms
            // 
            this.btnGetCustoms.Location = new System.Drawing.Point(303, 48);
            this.btnGetCustoms.Name = "btnGetCustoms";
            this.btnGetCustoms.Size = new System.Drawing.Size(141, 23);
            this.btnGetCustoms.TabIndex = 6;
            this.btnGetCustoms.Text = "Get Customs";
            this.btnGetCustoms.UseVisualStyleBackColor = true;
            this.btnGetCustoms.Click += new System.EventHandler(this.btnGetCustoms_Click);
            // 
            // btnGetSpartanOps
            // 
            this.btnGetSpartanOps.Location = new System.Drawing.Point(156, 48);
            this.btnGetSpartanOps.Name = "btnGetSpartanOps";
            this.btnGetSpartanOps.Size = new System.Drawing.Size(141, 23);
            this.btnGetSpartanOps.TabIndex = 5;
            this.btnGetSpartanOps.Text = "Get Spartan Ops";
            this.btnGetSpartanOps.UseVisualStyleBackColor = true;
            this.btnGetSpartanOps.Click += new System.EventHandler(this.btnGetSpartanOps_Click);
            // 
            // btnGetChallenges
            // 
            this.btnGetChallenges.Location = new System.Drawing.Point(303, 19);
            this.btnGetChallenges.Name = "btnGetChallenges";
            this.btnGetChallenges.Size = new System.Drawing.Size(141, 23);
            this.btnGetChallenges.TabIndex = 4;
            this.btnGetChallenges.Text = "Get Challenges";
            this.btnGetChallenges.UseVisualStyleBackColor = true;
            this.btnGetChallenges.Click += new System.EventHandler(this.btnGetChallenges_Click);
            // 
            // btnGetCampaign
            // 
            this.btnGetCampaign.Location = new System.Drawing.Point(9, 48);
            this.btnGetCampaign.Name = "btnGetCampaign";
            this.btnGetCampaign.Size = new System.Drawing.Size(141, 23);
            this.btnGetCampaign.TabIndex = 3;
            this.btnGetCampaign.Text = "Get Campaign";
            this.btnGetCampaign.UseVisualStyleBackColor = true;
            this.btnGetCampaign.Click += new System.EventHandler(this.btnGetCampaign_Click);
            // 
            // GetCommendations
            // 
            this.GetCommendations.Location = new System.Drawing.Point(156, 19);
            this.GetCommendations.Name = "GetCommendations";
            this.GetCommendations.Size = new System.Drawing.Size(141, 23);
            this.GetCommendations.TabIndex = 2;
            this.GetCommendations.Text = "Get Commendations";
            this.GetCommendations.UseVisualStyleBackColor = true;
            this.GetCommendations.Click += new System.EventHandler(this.btnGetCommendations_Click);
            // 
            // btnGetServiceRecord
            // 
            this.btnGetServiceRecord.Location = new System.Drawing.Point(9, 19);
            this.btnGetServiceRecord.Name = "btnGetServiceRecord";
            this.btnGetServiceRecord.Size = new System.Drawing.Size(141, 23);
            this.btnGetServiceRecord.TabIndex = 0;
            this.btnGetServiceRecord.Text = "Get Service Record";
            this.btnGetServiceRecord.UseVisualStyleBackColor = true;
            this.btnGetServiceRecord.Click += new System.EventHandler(this.btnGetServiceRecord_Click);
            // 
            // btnGetPersonalChallenges
            // 
            this.btnGetPersonalChallenges.Location = new System.Drawing.Point(9, 19);
            this.btnGetPersonalChallenges.Name = "btnGetPersonalChallenges";
            this.btnGetPersonalChallenges.Size = new System.Drawing.Size(141, 23);
            this.btnGetPersonalChallenges.TabIndex = 1;
            this.btnGetPersonalChallenges.Text = "Get Personal Challenges";
            this.btnGetPersonalChallenges.UseVisualStyleBackColor = true;
            this.btnGetPersonalChallenges.Click += new System.EventHandler(this.btnGetPeronalChallenges_Click);
            // 
            // txtGamertag
            // 
            this.txtGamertag.Location = new System.Drawing.Point(12, 174);
            this.txtGamertag.Name = "txtGamertag";
            this.txtGamertag.Size = new System.Drawing.Size(213, 20);
            this.txtGamertag.TabIndex = 5;
            this.txtGamertag.Text = "PhoenixBanTrain";
            // 
            // btnGetServicesList
            // 
            this.btnGetServicesList.Location = new System.Drawing.Point(246, 172);
            this.btnGetServicesList.Name = "btnGetServicesList";
            this.btnGetServicesList.Size = new System.Drawing.Size(265, 23);
            this.btnGetServicesList.TabIndex = 6;
            this.btnGetServicesList.Text = "Get Services List";
            this.btnGetServicesList.UseVisualStyleBackColor = true;
            this.btnGetServicesList.Click += new System.EventHandler(this.btnGetServicesList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 17);
            this.lblStatus.Text = "Status: Waiting...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetPersonalChallenges);
            this.groupBox3.Location = new System.Drawing.Point(526, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Functions;";
            // 
            // lbServices
            // 
            this.lbServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbServices.FormattingEnabled = true;
            this.lbServices.Location = new System.Drawing.Point(3, 3);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(473, 96);
            this.lbServices.TabIndex = 9;
            this.lbServices.SelectedIndexChanged += new System.EventHandler(this.lbServices_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Controls.Add(this.txtSelectedService);
            this.groupBox4.Controls.Add(this.btnCallSelectedService);
            this.groupBox4.Controls.Add(this.txtServiceOutput);
            this.groupBox4.Location = new System.Drawing.Point(526, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 341);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Services";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 128);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbServices);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 102);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Services";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtHeaders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 102);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Headers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtHeaders
            // 
            this.txtHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHeaders.Location = new System.Drawing.Point(3, 3);
            this.txtHeaders.Multiline = true;
            this.txtHeaders.Name = "txtHeaders";
            this.txtHeaders.Size = new System.Drawing.Size(473, 96);
            this.txtHeaders.TabIndex = 5;
            // 
            // txtSelectedService
            // 
            this.txtSelectedService.Location = new System.Drawing.Point(6, 146);
            this.txtSelectedService.Name = "txtSelectedService";
            this.txtSelectedService.Size = new System.Drawing.Size(487, 20);
            this.txtSelectedService.TabIndex = 12;
            // 
            // btnCallSelectedService
            // 
            this.btnCallSelectedService.Location = new System.Drawing.Point(6, 172);
            this.btnCallSelectedService.Name = "btnCallSelectedService";
            this.btnCallSelectedService.Size = new System.Drawing.Size(487, 23);
            this.btnCallSelectedService.TabIndex = 11;
            this.btnCallSelectedService.Text = "Call Selected Service";
            this.btnCallSelectedService.UseVisualStyleBackColor = true;
            this.btnCallSelectedService.Click += new System.EventHandler(this.btnCallSelectedService_Click);
            // 
            // txtServiceOutput
            // 
            this.txtServiceOutput.Location = new System.Drawing.Point(6, 201);
            this.txtServiceOutput.Multiline = true;
            this.txtServiceOutput.Name = "txtServiceOutput";
            this.txtServiceOutput.Size = new System.Drawing.Size(487, 134);
            this.txtServiceOutput.TabIndex = 10;
            // 
            // btnRapeThemServers
            // 
            this.btnRapeThemServers.Location = new System.Drawing.Point(526, 415);
            this.btnRapeThemServers.Name = "btnRapeThemServers";
            this.btnRapeThemServers.Size = new System.Drawing.Size(499, 23);
            this.btnRapeThemServers.TabIndex = 11;
            this.btnRapeThemServers.Text = "Rape 343";
            this.btnRapeThemServers.UseVisualStyleBackColor = true;
            this.btnRapeThemServers.Click += new System.EventHandler(this.btnRapeThemServers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(73, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '$';
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnDoAuth
            // 
            this.btnDoAuth.Location = new System.Drawing.Point(249, 11);
            this.btnDoAuth.Name = "btnDoAuth";
            this.btnDoAuth.Size = new System.Drawing.Size(244, 48);
            this.btnDoAuth.TabIndex = 10;
            this.btnDoAuth.Text = "Do Authorization";
            this.btnDoAuth.UseVisualStyleBackColor = true;
            this.btnDoAuth.Click += new System.EventHandler(this.btnDoAuth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 469);
            this.Controls.Add(this.btnRapeThemServers);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGetServicesList);
            this.Controls.Add(this.txtGamertag);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Auntie Dot Test Software";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequestToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOAuthToken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSpartanToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetServiceRecord;
        private System.Windows.Forms.TextBox txtGamertag;
        private System.Windows.Forms.Button btnGetServicesList;
        private System.Windows.Forms.Button GetCommendations;
        private System.Windows.Forms.Button btnGetPersonalChallenges;
        private System.Windows.Forms.Button btnGetCampaign;
        private System.Windows.Forms.CheckBox cbSkipSTGeneration;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetChallenges;
        private System.Windows.Forms.ListBox lbServices;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCallSelectedService;
        private System.Windows.Forms.TextBox txtServiceOutput;
        private System.Windows.Forms.Button btnGetSpartanOps;
        private System.Windows.Forms.Button btnGetCustoms;
        private System.Windows.Forms.Button btnGetWargames;
        private System.Windows.Forms.Button btnGetPlaylists;
        private System.Windows.Forms.Button btnGetPlayerCard;
        private System.Windows.Forms.Button btnGetMetadata;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMatchesCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatchesStartAt;
        private System.Windows.Forms.Button btnGetMatches;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGetMatch;
        private System.Windows.Forms.TextBox txtMatchID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSelectedService;
        private System.Windows.Forms.Button btnRapeThemServers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtHeaders;
        private System.Windows.Forms.Button btnDoAuth;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
    }
}