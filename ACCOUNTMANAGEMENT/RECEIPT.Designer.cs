﻿namespace ACCOUNTMANAGEMENT
{
    partial class RECEIPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RECEIPT));
            this.label11 = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtChequeno = new System.Windows.Forms.TextBox();
            this.cmbpaymentmode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_extra1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpChequeDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcustid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.lblpath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbInstallmentNo = new System.Windows.Forms.ComboBox();
            this.txtinstallmentamount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPlotNo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSurveyNo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPlotSellId = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAd = new System.Windows.Forms.Button();
            this.dtpinstallmentdate = new System.Windows.Forms.DateTimePicker();
            this.txtRemainingamount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(55, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Date";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiptDate.Location = new System.Drawing.Point(168, 39);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(120, 20);
            this.dtpReceiptDate.TabIndex = 0;
            // 
            // txttotalamount
            // 
            this.txttotalamount.Location = new System.Drawing.Point(168, 240);
            this.txttotalamount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.Size = new System.Drawing.Size(151, 20);
            this.txttotalamount.TabIndex = 5;
            this.txttotalamount.TextChanged += new System.EventHandler(this.txttotalamount_TextChanged);
            this.txttotalamount.Leave += new System.EventHandler(this.txttotalamount_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(58, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 223;
            this.label5.Text = " Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(56, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 222;
            this.label2.Text = "Paymetnt Mode";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(57, 79);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 221;
            this.lblCompanyName.Text = "Customer Name";
            // 
            // txtChequeno
            // 
            this.txtChequeno.Location = new System.Drawing.Point(766, 197);
            this.txtChequeno.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtChequeno.Name = "txtChequeno";
            this.txtChequeno.Size = new System.Drawing.Size(151, 20);
            this.txtChequeno.TabIndex = 4;
            this.txtChequeno.Visible = false;
       //   this.txtChequeno.TextChanged += new System.EventHandler(this.txtChequeno_TextChanged);
            // 
            // cmbpaymentmode
            // 
            this.cmbpaymentmode.FormattingEnabled = true;
            this.cmbpaymentmode.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmbpaymentmode.Location = new System.Drawing.Point(171, 196);
            this.cmbpaymentmode.Name = "cmbpaymentmode";
            this.cmbpaymentmode.Size = new System.Drawing.Size(121, 21);
            this.cmbpaymentmode.TabIndex = 2;
            this.cmbpaymentmode.Leave += new System.EventHandler(this.cmbpaymentmode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(625, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 225;
            this.label1.Text = "Cheque No";
            this.label1.Visible = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btn_new);
            this.GroupBox2.Controls.Add(this.btn_delete);
            this.GroupBox2.Controls.Add(this.btn_save);
            this.GroupBox2.Controls.Add(this.btn_close);
            this.GroupBox2.Controls.Add(this.btn_update);
            this.GroupBox2.Location = new System.Drawing.Point(168, 307);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(468, 59);
            this.GroupBox2.TabIndex = 226;
            this.GroupBox2.TabStop = false;
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(12, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(83, 36);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "&New";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(275, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(97, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(83, 36);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "&Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(364, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 36);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "&Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(186, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(83, 36);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "&Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_extra1
            // 
            this.txt_extra1.Location = new System.Drawing.Point(168, 280);
            this.txt_extra1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txt_extra1.MaxLength = 25;
            this.txt_extra1.Name = "txt_extra1";
            this.txt_extra1.Size = new System.Drawing.Size(388, 20);
            this.txt_extra1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(54, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 228;
            this.label3.Text = "EXTRA DETAIL";
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "dd/MM/yyyy";
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChequeDate.Location = new System.Drawing.Point(457, 193);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(120, 20);
            this.dtpChequeDate.TabIndex = 3;
            this.dtpChequeDate.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(331, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 229;
            this.label4.Text = "Cheque Date";
            this.label4.Visible = false;
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcustid.Location = new System.Drawing.Point(37, 79);
            this.lblcustid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(13, 13);
            this.lblcustid.TabIndex = 230;
            this.lblcustid.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(56, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 232;
            this.label6.Text = "Recipt No";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(168, 6);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.ReadOnly = true;
            this.txtReceiptNo.Size = new System.Drawing.Size(100, 20);
            this.txtReceiptNo.TabIndex = 233;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(817, 9);
            this.lblpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 13);
            this.lblpath.TabIndex = 241;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(55, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 242;
            this.label7.Text = "Against Installment No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(331, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 243;
            this.label8.Text = "Against Installment Date";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(168, 76);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(414, 21);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyUp);
            this.cmbCustomer.Leave += new System.EventHandler(this.cmbCustomer_Leave);
            // 
            // cmbInstallmentNo
            // 
            this.cmbInstallmentNo.FormattingEnabled = true;
            this.cmbInstallmentNo.Location = new System.Drawing.Point(171, 156);
            this.cmbInstallmentNo.Name = "cmbInstallmentNo";
            this.cmbInstallmentNo.Size = new System.Drawing.Size(121, 21);
            this.cmbInstallmentNo.TabIndex = 6;
            this.cmbInstallmentNo.Leave += new System.EventHandler(this.cmbInstallmentNo_Leave);
            // 
            // txtinstallmentamount
            // 
            this.txtinstallmentamount.Location = new System.Drawing.Point(766, 154);
            this.txtinstallmentamount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtinstallmentamount.Name = "txtinstallmentamount";
            this.txtinstallmentamount.ReadOnly = true;
            this.txtinstallmentamount.Size = new System.Drawing.Size(151, 20);
            this.txtinstallmentamount.TabIndex = 249;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(625, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 248;
            this.label9.Text = "Installment Amount to Paid";
            // 
            // cmbPlotNo
            // 
            this.cmbPlotNo.FormattingEnabled = true;
            this.cmbPlotNo.Location = new System.Drawing.Point(168, 109);
            this.cmbPlotNo.Name = "cmbPlotNo";
            this.cmbPlotNo.Size = new System.Drawing.Size(124, 21);
            this.cmbPlotNo.TabIndex = 250;
            this.cmbPlotNo.Leave += new System.EventHandler(this.cmbPlotNo_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(58, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 251;
            this.label10.Text = "Against Plot No";
            // 
            // cmbSurveyNo
            // 
            this.cmbSurveyNo.FormattingEnabled = true;
            this.cmbSurveyNo.Location = new System.Drawing.Point(458, 112);
            this.cmbSurveyNo.Name = "cmbSurveyNo";
            this.cmbSurveyNo.Size = new System.Drawing.Size(124, 21);
            this.cmbSurveyNo.TabIndex = 253;
            this.cmbSurveyNo.Leave += new System.EventHandler(this.cmbSurveyNo_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(331, 113);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 254;
            this.label12.Text = "Against Survey No";
            // 
            // cmbPlotSellId
            // 
            this.cmbPlotSellId.FormattingEnabled = true;
            this.cmbPlotSellId.Location = new System.Drawing.Point(763, 112);
            this.cmbPlotSellId.Name = "cmbPlotSellId";
            this.cmbPlotSellId.Size = new System.Drawing.Size(124, 21);
            this.cmbPlotSellId.TabIndex = 255;
            this.cmbPlotSellId.Leave += new System.EventHandler(this.cmbPlotSellId_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(625, 120);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 256;
            this.label13.Text = "Against Plot Sell Id";
            // 
            // btnAd
            // 
            this.btnAd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAd.ForeColor = System.Drawing.Color.Green;
            this.btnAd.Location = new System.Drawing.Point(599, 76);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(27, 27);
            this.btnAd.TabIndex = 257;
            this.btnAd.Text = "+";
            this.btnAd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // dtpinstallmentdate
            // 
            this.dtpinstallmentdate.CustomFormat = "dd/MM/yyyy";
            this.dtpinstallmentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpinstallmentdate.Location = new System.Drawing.Point(457, 153);
            this.dtpinstallmentdate.Name = "dtpinstallmentdate";
            this.dtpinstallmentdate.Size = new System.Drawing.Size(120, 20);
            this.dtpinstallmentdate.TabIndex = 258;
            // 
            // txtRemainingamount
            // 
            this.txtRemainingamount.ForeColor = System.Drawing.Color.Red;
            this.txtRemainingamount.Location = new System.Drawing.Point(443, 240);
            this.txtRemainingamount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtRemainingamount.Name = "txtRemainingamount";
            this.txtRemainingamount.ReadOnly = true;
            this.txtRemainingamount.Size = new System.Drawing.Size(151, 20);
            this.txtRemainingamount.TabIndex = 259;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(333, 243);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 260;
            this.label14.Text = "Remaining Amount";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblx.Location = new System.Drawing.Point(695, 243);
            this.lblx.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(13, 13);
            this.lblx.TabIndex = 261;
            this.lblx.Text = "0";
            // 
            // RECEIPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 378);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.txtRemainingamount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpinstallmentdate);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.cmbPlotSellId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSurveyNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbPlotNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtinstallmentamount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbInstallmentNo);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.txtReceiptNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcustid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_extra1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbpaymentmode);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChequeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpChequeDate);
            this.Controls.Add(this.dtpReceiptDate);
            this.Name = "RECEIPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECEIPT";
            this.Load += new System.EventHandler(this.RECEIPT_Load);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtChequeno;
        private System.Windows.Forms.ComboBox cmbpaymentmode;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_extra1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker dtpChequeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReceiptNo;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbInstallmentNo;
        private System.Windows.Forms.TextBox txtinstallmentamount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPlotNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSurveyNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbPlotSellId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAd;
        internal System.Windows.Forms.DateTimePicker dtpinstallmentdate;
        private System.Windows.Forms.TextBox txtRemainingamount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblx;
    }
}