namespace SignMeSample
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlFooter = new Panel();
            flpFooter = new FlowLayoutPanel();
            lblSupportEn = new Label();
            lnkSupportEn = new LinkLabel();
            lblSupportAr = new Label();
            tlpBody = new TableLayoutPanel();
            tlpApiKey = new TableLayoutPanel();
            lblApiKeyCaption = new Label();
            txtApiKey = new TextBox();
            flpHint = new FlowLayoutPanel();
            lblNoKey = new Label();
            lnkRegister = new LinkLabel();
            tlpImage = new TableLayoutPanel();
            lblImageCaption = new Label();
            txtImage = new TextBox();
            btnBrowse = new Button();
            tlpIdType = new TableLayoutPanel();
            lblIdTypeCaption = new Label();
            cmbIdType = new ComboBox();
            btnScan = new Button();
            lblStatus = new Label();
            grpResults = new GroupBox();
            tlpResults = new TableLayoutPanel();
            lblKFirstName = new Label();
            valFirstName = new Label();
            lblKLastName = new Label();
            valLastName = new Label();
            lblKNationalId = new Label();
            valNationalId = new Label();
            lblKBirthday = new Label();
            valBirthday = new Label();
            lblKGender = new Label();
            valGender = new Label();
            lblKCity = new Label();
            valCity = new Label();
            lblKAddress = new Label();
            valAddress = new Label();
            lblKReligion = new Label();
            valReligion = new Label();
            lblKJob = new Label();
            valJob = new Label();
            lblKIssueDate = new Label();
            valIssueDate = new Label();
            lblKExpiry = new Label();
            valExpiry = new Label();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            flpFooter.SuspendLayout();
            tlpBody.SuspendLayout();
            tlpApiKey.SuspendLayout();
            flpHint.SuspendLayout();
            tlpImage.SuspendLayout();
            tlpIdType.SuspendLayout();
            grpResults.SuspendLayout();
            tlpResults.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 64, 175);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(776, 85);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(776, 85);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SignMe  ·  Egyptian National ID Scanner";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(243, 244, 246);
            pnlFooter.Controls.Add(flpFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 863);
            pnlFooter.Margin = new Padding(3, 4, 3, 4);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(776, 48);
            pnlFooter.TabIndex = 1;
            // 
            // flpFooter
            // 
            flpFooter.Controls.Add(lblSupportEn);
            flpFooter.Controls.Add(lnkSupportEn);
            flpFooter.Controls.Add(lblSupportAr);
            flpFooter.Dock = DockStyle.Fill;
            flpFooter.Location = new Point(0, 0);
            flpFooter.Margin = new Padding(3, 4, 3, 4);
            flpFooter.Name = "flpFooter";
            flpFooter.Padding = new Padding(9, 0, 9, 0);
            flpFooter.Size = new Size(776, 48);
            flpFooter.TabIndex = 0;
            flpFooter.WrapContents = false;
            // 
            // lblSupportEn
            // 
            lblSupportEn.AutoSize = true;
            lblSupportEn.Font = new Font("Segoe UI", 8F);
            lblSupportEn.ForeColor = Color.FromArgb(107, 114, 128);
            lblSupportEn.Location = new Point(9, 12);
            lblSupportEn.Margin = new Padding(0, 12, 5, 0);
            lblSupportEn.Name = "lblSupportEn";
            lblSupportEn.Size = new Size(176, 19);
            lblSupportEn.TabIndex = 0;
            lblSupportEn.Text = "Technical issue? Contact us:";
            // 
            // lnkSupportEn
            // 
            lnkSupportEn.AutoSize = true;
            lnkSupportEn.Font = new Font("Segoe UI", 8F);
            lnkSupportEn.Location = new Point(190, 12);
            lnkSupportEn.Margin = new Padding(0, 12, 9, 0);
            lnkSupportEn.Name = "lnkSupportEn";
            lnkSupportEn.Size = new Size(138, 19);
            lnkSupportEn.TabIndex = 1;
            lnkSupportEn.TabStop = true;
            lnkSupportEn.Text = "api.signme.it/support";
            lnkSupportEn.Click += LnkSupport_Click;
            // 
            // lblSupportAr
            // 
            lblSupportAr.AutoSize = true;
            lblSupportAr.Font = new Font("Segoe UI", 8F);
            lblSupportAr.ForeColor = Color.FromArgb(107, 114, 128);
            lblSupportAr.Location = new Point(337, 12);
            lblSupportAr.Margin = new Padding(0, 12, 5, 0);
            lblSupportAr.Name = "lblSupportAr";
            lblSupportAr.RightToLeft = RightToLeft.Yes;
            lblSupportAr.Size = new Size(218, 19);
            lblSupportAr.TabIndex = 3;
            lblSupportAr.Text = "هل لديك مشكلة تقنية؟ تواصل معنا:";
            // 
            // tlpBody
            // 
            tlpBody.ColumnCount = 1;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBody.Controls.Add(tlpApiKey, 0, 0);
            tlpBody.Controls.Add(flpHint, 0, 1);
            tlpBody.Controls.Add(tlpImage, 0, 2);
            tlpBody.Controls.Add(tlpIdType, 0, 3);
            tlpBody.Controls.Add(btnScan, 0, 4);
            tlpBody.Controls.Add(lblStatus, 0, 5);
            tlpBody.Controls.Add(grpResults, 0, 6);
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.Location = new Point(0, 85);
            tlpBody.Margin = new Padding(3, 4, 3, 4);
            tlpBody.Name = "tlpBody";
            tlpBody.Padding = new Padding(23, 21, 23, 21);
            tlpBody.RowCount = 7;
            tlpBody.RowStyles.Add(new RowStyle());
            tlpBody.RowStyles.Add(new RowStyle());
            tlpBody.RowStyles.Add(new RowStyle());
            tlpBody.RowStyles.Add(new RowStyle());
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBody.Size = new Size(776, 778);
            tlpBody.TabIndex = 0;
            // 
            // tlpApiKey
            // 
            tlpApiKey.AutoSize = true;
            tlpApiKey.ColumnCount = 2;
            tlpApiKey.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tlpApiKey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpApiKey.Controls.Add(lblApiKeyCaption, 0, 0);
            tlpApiKey.Controls.Add(txtApiKey, 1, 0);
            tlpApiKey.Dock = DockStyle.Fill;
            tlpApiKey.Location = new Point(23, 21);
            tlpApiKey.Margin = new Padding(0, 0, 0, 5);
            tlpApiKey.Name = "tlpApiKey";
            tlpApiKey.RowCount = 1;
            tlpApiKey.RowStyles.Add(new RowStyle());
            tlpApiKey.Size = new Size(730, 41);
            tlpApiKey.TabIndex = 0;
            // 
            // lblApiKeyCaption
            // 
            lblApiKeyCaption.Dock = DockStyle.Fill;
            lblApiKeyCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblApiKeyCaption.Location = new Point(3, 0);
            lblApiKeyCaption.Name = "lblApiKeyCaption";
            lblApiKeyCaption.Padding = new Padding(0, 0, 9, 0);
            lblApiKeyCaption.Size = new Size(85, 41);
            lblApiKeyCaption.TabIndex = 0;
            lblApiKeyCaption.Text = "API Key:";
            lblApiKeyCaption.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtApiKey
            // 
            txtApiKey.Dock = DockStyle.Fill;
            txtApiKey.Font = new Font("Consolas", 9F);
            txtApiKey.Location = new Point(94, 4);
            txtApiKey.Margin = new Padding(3, 4, 3, 4);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.PlaceholderText = "Paste your API key here…";
            txtApiKey.Size = new Size(633, 25);
            txtApiKey.TabIndex = 1;
            // 
            // flpHint
            // 
            flpHint.AutoSize = true;
            flpHint.Controls.Add(lblNoKey);
            flpHint.Controls.Add(lnkRegister);
            flpHint.Dock = DockStyle.Fill;
            flpHint.Location = new Point(114, 67);
            flpHint.Margin = new Padding(91, 0, 0, 16);
            flpHint.Name = "flpHint";
            flpHint.Size = new Size(639, 20);
            flpHint.TabIndex = 1;
            // 
            // lblNoKey
            // 
            lblNoKey.AutoSize = true;
            lblNoKey.ForeColor = Color.FromArgb(107, 114, 128);
            lblNoKey.Location = new Point(3, 0);
            lblNoKey.Name = "lblNoKey";
            lblNoKey.Size = new Size(88, 20);
            lblNoKey.TabIndex = 0;
            lblNoKey.Text = "No API key?";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(97, 0);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(198, 20);
            lnkRegister.TabIndex = 1;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Register free at api.signme.it";
            lnkRegister.Click += LnkRegister_Click;
            // 
            // tlpImage
            // 
            tlpImage.AutoSize = true;
            tlpImage.ColumnCount = 3;
            tlpImage.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tlpImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpImage.ColumnStyles.Add(new ColumnStyle());
            tlpImage.Controls.Add(lblImageCaption, 0, 0);
            tlpImage.Controls.Add(txtImage, 1, 0);
            tlpImage.Controls.Add(btnBrowse, 2, 0);
            tlpImage.Dock = DockStyle.Fill;
            tlpImage.Location = new Point(23, 103);
            tlpImage.Margin = new Padding(0, 0, 0, 11);
            tlpImage.Name = "tlpImage";
            tlpImage.RowCount = 1;
            tlpImage.RowStyles.Add(new RowStyle());
            tlpImage.Size = new Size(730, 44);
            tlpImage.TabIndex = 2;
            // 
            // lblImageCaption
            // 
            lblImageCaption.Dock = DockStyle.Fill;
            lblImageCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblImageCaption.Location = new Point(3, 0);
            lblImageCaption.Name = "lblImageCaption";
            lblImageCaption.Padding = new Padding(0, 0, 9, 0);
            lblImageCaption.Size = new Size(85, 44);
            lblImageCaption.TabIndex = 0;
            lblImageCaption.Text = "ID Image:";
            lblImageCaption.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtImage
            // 
            txtImage.BackColor = Color.White;
            txtImage.Dock = DockStyle.Fill;
            txtImage.Location = new Point(94, 4);
            txtImage.Margin = new Padding(3, 4, 3, 4);
            txtImage.Name = "txtImage";
            txtImage.PlaceholderText = "Click Browse to select an image…";
            txtImage.ReadOnly = true;
            txtImage.Size = new Size(535, 27);
            txtImage.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.AutoSize = true;
            btnBrowse.BackColor = Color.FromArgb(243, 244, 246);
            btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(639, 0);
            btnBrowse.Margin = new Padding(7, 0, 0, 0);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(91, 43);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse…";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += BtnBrowse_Click;
            // 
            // tlpIdType
            // 
            tlpIdType.AutoSize = true;
            tlpIdType.ColumnCount = 2;
            tlpIdType.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tlpIdType.ColumnStyles.Add(new ColumnStyle());
            tlpIdType.Controls.Add(lblIdTypeCaption, 0, 0);
            tlpIdType.Controls.Add(cmbIdType, 1, 0);
            tlpIdType.Dock = DockStyle.Fill;
            tlpIdType.Location = new Point(23, 158);
            tlpIdType.Margin = new Padding(0, 0, 0, 8);
            tlpIdType.Name = "tlpIdType";
            tlpIdType.RowCount = 1;
            tlpIdType.RowStyles.Add(new RowStyle());
            tlpIdType.Size = new Size(730, 36);
            tlpIdType.TabIndex = 6;
            // 
            // lblIdTypeCaption
            // 
            lblIdTypeCaption.Dock = DockStyle.Fill;
            lblIdTypeCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblIdTypeCaption.Location = new Point(3, 0);
            lblIdTypeCaption.Name = "lblIdTypeCaption";
            lblIdTypeCaption.Padding = new Padding(0, 0, 9, 0);
            lblIdTypeCaption.Size = new Size(85, 36);
            lblIdTypeCaption.TabIndex = 0;
            lblIdTypeCaption.Text = "ID Type:";
            lblIdTypeCaption.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbIdType
            // 
            cmbIdType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdType.Items.AddRange(new object[] { "0 – National ID Face / Driver / Car License", "1 – National ID Back Side", "2 – Passport" });
            cmbIdType.Location = new Point(94, 4);
            cmbIdType.Margin = new Padding(3, 4, 3, 4);
            cmbIdType.Name = "cmbIdType";
            cmbIdType.Size = new Size(375, 28);
            cmbIdType.TabIndex = 1;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.FromArgb(30, 64, 175);
            btnScan.Cursor = Cursors.Hand;
            btnScan.Dock = DockStyle.Fill;
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnScan.ForeColor = Color.White;
            btnScan.Location = new Point(23, 207);
            btnScan.Margin = new Padding(0, 5, 0, 5);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(730, 57);
            btnScan.TabIndex = 3;
            btnScan.Text = "Scan ID";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += BtnScan_Click;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.ForeColor = Color.FromArgb(75, 85, 99);
            lblStatus.Location = new Point(26, 269);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(724, 37);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Ready. Enter your API key and select an image.";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(tlpResults);
            grpResults.Dock = DockStyle.Fill;
            grpResults.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpResults.Location = new Point(26, 310);
            grpResults.Margin = new Padding(3, 4, 3, 4);
            grpResults.Name = "grpResults";
            grpResults.Padding = new Padding(9, 11, 9, 11);
            grpResults.Size = new Size(724, 443);
            grpResults.TabIndex = 5;
            grpResults.TabStop = false;
            grpResults.Text = "Extracted Data";
            // 
            // tlpResults
            // 
            tlpResults.AutoScroll = true;
            tlpResults.ColumnCount = 2;
            tlpResults.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tlpResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpResults.Controls.Add(lblKFirstName, 0, 0);
            tlpResults.Controls.Add(valFirstName, 1, 0);
            tlpResults.Controls.Add(lblKLastName, 0, 1);
            tlpResults.Controls.Add(valLastName, 1, 1);
            tlpResults.Controls.Add(lblKNationalId, 0, 2);
            tlpResults.Controls.Add(valNationalId, 1, 2);
            tlpResults.Controls.Add(lblKBirthday, 0, 3);
            tlpResults.Controls.Add(valBirthday, 1, 3);
            tlpResults.Controls.Add(lblKGender, 0, 4);
            tlpResults.Controls.Add(valGender, 1, 4);
            tlpResults.Controls.Add(lblKCity, 0, 5);
            tlpResults.Controls.Add(valCity, 1, 5);
            tlpResults.Controls.Add(lblKAddress, 0, 6);
            tlpResults.Controls.Add(valAddress, 1, 6);
            tlpResults.Controls.Add(lblKReligion, 0, 7);
            tlpResults.Controls.Add(valReligion, 1, 7);
            tlpResults.Controls.Add(lblKJob, 0, 8);
            tlpResults.Controls.Add(valJob, 1, 8);
            tlpResults.Controls.Add(lblKIssueDate, 0, 9);
            tlpResults.Controls.Add(valIssueDate, 1, 9);
            tlpResults.Controls.Add(lblKExpiry, 0, 10);
            tlpResults.Controls.Add(valExpiry, 1, 10);
            tlpResults.Dock = DockStyle.Fill;
            tlpResults.Font = new Font("Segoe UI", 9F);
            tlpResults.Location = new Point(9, 31);
            tlpResults.Margin = new Padding(3, 4, 3, 4);
            tlpResults.Name = "tlpResults";
            tlpResults.RowCount = 11;
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.RowStyles.Add(new RowStyle());
            tlpResults.Size = new Size(706, 401);
            tlpResults.TabIndex = 0;
            // 
            // lblKFirstName
            // 
            lblKFirstName.Dock = DockStyle.Fill;
            lblKFirstName.ForeColor = Color.FromArgb(107, 114, 128);
            lblKFirstName.Location = new Point(3, 0);
            lblKFirstName.Name = "lblKFirstName";
            lblKFirstName.Padding = new Padding(0, 0, 8, 0);
            lblKFirstName.Size = new Size(120, 23);
            lblKFirstName.TabIndex = 0;
            lblKFirstName.Text = "First Name:";
            lblKFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valFirstName
            // 
            valFirstName.Dock = DockStyle.Fill;
            valFirstName.Location = new Point(129, 0);
            valFirstName.Name = "valFirstName";
            valFirstName.Padding = new Padding(4, 2, 0, 2);
            valFirstName.Size = new Size(574, 23);
            valFirstName.TabIndex = 1;
            valFirstName.Text = "—";
            // 
            // lblKLastName
            // 
            lblKLastName.Dock = DockStyle.Fill;
            lblKLastName.ForeColor = Color.FromArgb(107, 114, 128);
            lblKLastName.Location = new Point(3, 23);
            lblKLastName.Name = "lblKLastName";
            lblKLastName.Padding = new Padding(0, 0, 8, 0);
            lblKLastName.Size = new Size(120, 23);
            lblKLastName.TabIndex = 2;
            lblKLastName.Text = "Last Name:";
            lblKLastName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valLastName
            // 
            valLastName.Dock = DockStyle.Fill;
            valLastName.Location = new Point(129, 23);
            valLastName.Name = "valLastName";
            valLastName.Padding = new Padding(4, 2, 0, 2);
            valLastName.Size = new Size(574, 23);
            valLastName.TabIndex = 3;
            valLastName.Text = "—";
            // 
            // lblKNationalId
            // 
            lblKNationalId.Dock = DockStyle.Fill;
            lblKNationalId.ForeColor = Color.FromArgb(107, 114, 128);
            lblKNationalId.Location = new Point(3, 46);
            lblKNationalId.Name = "lblKNationalId";
            lblKNationalId.Padding = new Padding(0, 0, 8, 0);
            lblKNationalId.Size = new Size(120, 23);
            lblKNationalId.TabIndex = 4;
            lblKNationalId.Text = "National ID:";
            lblKNationalId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valNationalId
            // 
            valNationalId.Dock = DockStyle.Fill;
            valNationalId.Location = new Point(129, 46);
            valNationalId.Name = "valNationalId";
            valNationalId.Padding = new Padding(4, 2, 0, 2);
            valNationalId.Size = new Size(574, 23);
            valNationalId.TabIndex = 5;
            valNationalId.Text = "—";
            // 
            // lblKBirthday
            // 
            lblKBirthday.Dock = DockStyle.Fill;
            lblKBirthday.ForeColor = Color.FromArgb(107, 114, 128);
            lblKBirthday.Location = new Point(3, 69);
            lblKBirthday.Name = "lblKBirthday";
            lblKBirthday.Padding = new Padding(0, 0, 8, 0);
            lblKBirthday.Size = new Size(120, 23);
            lblKBirthday.TabIndex = 6;
            lblKBirthday.Text = "Birthday:";
            lblKBirthday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valBirthday
            // 
            valBirthday.Dock = DockStyle.Fill;
            valBirthday.Location = new Point(129, 69);
            valBirthday.Name = "valBirthday";
            valBirthday.Padding = new Padding(4, 2, 0, 2);
            valBirthday.Size = new Size(574, 23);
            valBirthday.TabIndex = 7;
            valBirthday.Text = "—";
            // 
            // lblKGender
            // 
            lblKGender.Dock = DockStyle.Fill;
            lblKGender.ForeColor = Color.FromArgb(107, 114, 128);
            lblKGender.Location = new Point(3, 92);
            lblKGender.Name = "lblKGender";
            lblKGender.Padding = new Padding(0, 0, 8, 0);
            lblKGender.Size = new Size(120, 23);
            lblKGender.TabIndex = 8;
            lblKGender.Text = "Gender:";
            lblKGender.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valGender
            // 
            valGender.Dock = DockStyle.Fill;
            valGender.Location = new Point(129, 92);
            valGender.Name = "valGender";
            valGender.Padding = new Padding(4, 2, 0, 2);
            valGender.Size = new Size(574, 23);
            valGender.TabIndex = 9;
            valGender.Text = "—";
            // 
            // lblKCity
            // 
            lblKCity.Dock = DockStyle.Fill;
            lblKCity.ForeColor = Color.FromArgb(107, 114, 128);
            lblKCity.Location = new Point(3, 115);
            lblKCity.Name = "lblKCity";
            lblKCity.Padding = new Padding(0, 0, 8, 0);
            lblKCity.Size = new Size(120, 23);
            lblKCity.TabIndex = 10;
            lblKCity.Text = "City:";
            lblKCity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valCity
            // 
            valCity.Dock = DockStyle.Fill;
            valCity.Location = new Point(129, 115);
            valCity.Name = "valCity";
            valCity.Padding = new Padding(4, 2, 0, 2);
            valCity.Size = new Size(574, 23);
            valCity.TabIndex = 11;
            valCity.Text = "—";
            // 
            // lblKAddress
            // 
            lblKAddress.Dock = DockStyle.Fill;
            lblKAddress.ForeColor = Color.FromArgb(107, 114, 128);
            lblKAddress.Location = new Point(3, 138);
            lblKAddress.Name = "lblKAddress";
            lblKAddress.Padding = new Padding(0, 0, 8, 0);
            lblKAddress.Size = new Size(120, 23);
            lblKAddress.TabIndex = 12;
            lblKAddress.Text = "Address:";
            lblKAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valAddress
            // 
            valAddress.Dock = DockStyle.Fill;
            valAddress.Location = new Point(129, 138);
            valAddress.Name = "valAddress";
            valAddress.Padding = new Padding(4, 2, 0, 2);
            valAddress.Size = new Size(574, 23);
            valAddress.TabIndex = 13;
            valAddress.Text = "—";
            // 
            // lblKReligion
            // 
            lblKReligion.Dock = DockStyle.Fill;
            lblKReligion.ForeColor = Color.FromArgb(107, 114, 128);
            lblKReligion.Location = new Point(3, 161);
            lblKReligion.Name = "lblKReligion";
            lblKReligion.Padding = new Padding(0, 0, 8, 0);
            lblKReligion.Size = new Size(120, 23);
            lblKReligion.TabIndex = 14;
            lblKReligion.Text = "Religion:";
            lblKReligion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valReligion
            // 
            valReligion.Dock = DockStyle.Fill;
            valReligion.Location = new Point(129, 161);
            valReligion.Name = "valReligion";
            valReligion.Padding = new Padding(4, 2, 0, 2);
            valReligion.Size = new Size(574, 23);
            valReligion.TabIndex = 15;
            valReligion.Text = "—";
            // 
            // lblKJob
            // 
            lblKJob.Dock = DockStyle.Fill;
            lblKJob.ForeColor = Color.FromArgb(107, 114, 128);
            lblKJob.Location = new Point(3, 184);
            lblKJob.Name = "lblKJob";
            lblKJob.Padding = new Padding(0, 0, 8, 0);
            lblKJob.Size = new Size(120, 23);
            lblKJob.TabIndex = 16;
            lblKJob.Text = "Job:";
            lblKJob.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valJob
            // 
            valJob.Dock = DockStyle.Fill;
            valJob.Location = new Point(129, 184);
            valJob.Name = "valJob";
            valJob.Padding = new Padding(4, 2, 0, 2);
            valJob.Size = new Size(574, 23);
            valJob.TabIndex = 17;
            valJob.Text = "—";
            // 
            // lblKIssueDate
            // 
            lblKIssueDate.Dock = DockStyle.Fill;
            lblKIssueDate.ForeColor = Color.FromArgb(107, 114, 128);
            lblKIssueDate.Location = new Point(3, 207);
            lblKIssueDate.Name = "lblKIssueDate";
            lblKIssueDate.Padding = new Padding(0, 0, 8, 0);
            lblKIssueDate.Size = new Size(120, 23);
            lblKIssueDate.TabIndex = 18;
            lblKIssueDate.Text = "Issue Date:";
            lblKIssueDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valIssueDate
            // 
            valIssueDate.Dock = DockStyle.Fill;
            valIssueDate.Location = new Point(129, 207);
            valIssueDate.Name = "valIssueDate";
            valIssueDate.Padding = new Padding(4, 2, 0, 2);
            valIssueDate.Size = new Size(574, 23);
            valIssueDate.TabIndex = 19;
            valIssueDate.Text = "—";
            // 
            // lblKExpiry
            // 
            lblKExpiry.Dock = DockStyle.Fill;
            lblKExpiry.ForeColor = Color.FromArgb(107, 114, 128);
            lblKExpiry.Location = new Point(3, 230);
            lblKExpiry.Name = "lblKExpiry";
            lblKExpiry.Padding = new Padding(0, 0, 8, 0);
            lblKExpiry.Size = new Size(120, 225);
            lblKExpiry.TabIndex = 20;
            lblKExpiry.Text = "Expiry:";
            lblKExpiry.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valExpiry
            // 
            valExpiry.Dock = DockStyle.Fill;
            valExpiry.Location = new Point(129, 230);
            valExpiry.Name = "valExpiry";
            valExpiry.Padding = new Padding(4, 2, 0, 2);
            valExpiry.Size = new Size(574, 225);
            valExpiry.TabIndex = 21;
            valExpiry.Text = "—";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 911);
            Controls.Add(tlpBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(615, 784);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignMe – National ID Scanner";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            flpFooter.ResumeLayout(false);
            flpFooter.PerformLayout();
            tlpBody.ResumeLayout(false);
            tlpBody.PerformLayout();
            tlpApiKey.ResumeLayout(false);
            tlpApiKey.PerformLayout();
            flpHint.ResumeLayout(false);
            flpHint.PerformLayout();
            tlpImage.ResumeLayout(false);
            tlpImage.PerformLayout();
            tlpIdType.ResumeLayout(false);
            grpResults.ResumeLayout(false);
            tlpResults.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ── Field declarations ───────────────────────────────────────────────────
        private Panel            pnlHeader;
        private Label            lblTitle;
        private Panel            pnlFooter;
        private FlowLayoutPanel  flpFooter;
        private Label            lblSupportEn;
        private LinkLabel        lnkSupportEn;
        private Label            lblSupportAr;
        private TableLayoutPanel tlpBody;
        private TableLayoutPanel tlpApiKey;
        private Label            lblApiKeyCaption;
        private TextBox          txtApiKey;
        private FlowLayoutPanel  flpHint;
        private Label            lblNoKey;
        private LinkLabel        lnkRegister;
        private TableLayoutPanel tlpImage;
        private Label            lblImageCaption;
        private TextBox          txtImage;
        private Button           btnBrowse;
        private TableLayoutPanel tlpIdType;
        private Label            lblIdTypeCaption;
        private ComboBox         cmbIdType;
        private Button           btnScan;
        private Label            lblStatus;
        private GroupBox         grpResults;
        private TableLayoutPanel tlpResults;
        private Label            lblKFirstName,  valFirstName;
        private Label            lblKLastName,   valLastName;
        private Label            lblKNationalId, valNationalId;
        private Label            lblKBirthday,   valBirthday;
        private Label            lblKGender,     valGender;
        private Label            lblKCity,       valCity;
        private Label            lblKAddress,    valAddress;
        private Label            lblKReligion,   valReligion;
        private Label            lblKJob,        valJob;
        private Label            lblKIssueDate,  valIssueDate;
        private Label            lblKExpiry,     valExpiry;
    }
}
