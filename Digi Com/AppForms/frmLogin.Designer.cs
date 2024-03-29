﻿namespace Digi_Com.AppForms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.HomeElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblAuthRequired = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelFIngreImage = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbcomPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTransPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAuthRequiredHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeElipse
            // 
            this.HomeElipse.ElipseRadius = 20;
            this.HomeElipse.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblAuthRequired
            // 
            this.lblAuthRequired.AutoSize = true;
            this.lblAuthRequired.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthRequired.ForeColor = System.Drawing.Color.DimGray;
            this.lblAuthRequired.Location = new System.Drawing.Point(213, 144);
            this.lblAuthRequired.Name = "lblAuthRequired";
            this.lblAuthRequired.Size = new System.Drawing.Size(180, 17);
            this.lblAuthRequired.TabIndex = 3;
            this.lblAuthRequired.Text = "Please scan your fingre";
            // 
            // btnClose
            // 
            this.btnClose.Active = false;
            this.btnClose.Activecolor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = false;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 20D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(475, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelFIngreImage
            // 
            this.panelFIngreImage.BackColor = System.Drawing.SystemColors.Control;
            this.panelFIngreImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFIngreImage.BackgroundImage")));
            this.panelFIngreImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFIngreImage.Location = new System.Drawing.Point(238, 168);
            this.panelFIngreImage.Name = "panelFIngreImage";
            this.panelFIngreImage.Size = new System.Drawing.Size(93, 62);
            this.panelFIngreImage.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(188, 272);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(160, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Searching for Fingre Scanner.....";
            // 
            // cmbcomPort
            // 
            this.cmbcomPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcomPort.FormattingEnabled = true;
            this.cmbcomPort.Location = new System.Drawing.Point(151, 75);
            this.cmbcomPort.Name = "cmbcomPort";
            this.cmbcomPort.Size = new System.Drawing.Size(135, 21);
            this.cmbcomPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Scanner Port";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(186, 236);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(289, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Transmitter Port";
            // 
            // cmbTransPort
            // 
            this.cmbTransPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransPort.FormattingEnabled = true;
            this.cmbTransPort.Location = new System.Drawing.Point(292, 75);
            this.cmbTransPort.Name = "cmbTransPort";
            this.cmbTransPort.Size = new System.Drawing.Size(124, 21);
            this.cmbTransPort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(148, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Your Station";
            // 
            // cmbStation
            // 
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(151, 118);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(124, 21);
            this.cmbStation.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(108, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = " Authentication Required";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthRequiredHeader
            // 
            this.lblAuthRequiredHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthRequiredHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAuthRequiredHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblAuthRequiredHeader.Location = new System.Drawing.Point(6, -1);
            this.lblAuthRequiredHeader.Name = "lblAuthRequiredHeader";
            this.lblAuthRequiredHeader.Size = new System.Drawing.Size(520, 29);
            this.lblAuthRequiredHeader.TabIndex = 13;
            this.lblAuthRequiredHeader.Text = "Wireless Communication with PFS";
            this.lblAuthRequiredHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAuthRequiredHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbcomPort);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbTransPort);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAuthRequired);
            this.Controls.Add(this.panelFIngreImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse HomeElipse;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelFIngreImage;
        private System.Windows.Forms.Label lblAuthRequired;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbcomPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTransPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAuthRequiredHeader;
    }
}

