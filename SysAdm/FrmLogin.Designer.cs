namespace SysAdm
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.IMG_RED = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.imgShowPwd = new System.Windows.Forms.PictureBox();
            this.imgHidePwd = new System.Windows.Forms.PictureBox();
            this.txtLogin = new ns1.BunifuMetroTextbox();
            this.txtPwd = new ns1.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_RED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidePwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IMG_RED
            // 
            this.IMG_RED.Image = ((System.Drawing.Image)(resources.GetObject("IMG_RED.Image")));
            this.IMG_RED.Location = new System.Drawing.Point(700, 25);
            this.IMG_RED.Margin = new System.Windows.Forms.Padding(2);
            this.IMG_RED.Name = "IMG_RED";
            this.IMG_RED.Size = new System.Drawing.Size(33, 33);
            this.IMG_RED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_RED.TabIndex = 109;
            this.IMG_RED.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(425, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 108;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownFrm);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveFrm);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(21, 19);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 33);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInfo.TabIndex = 107;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGo.BackgroundImage")));
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.Location = new System.Drawing.Point(450, 270);
            this.btnGo.Margin = new System.Windows.Forms.Padding(0);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(50, 44);
            this.btnGo.TabIndex = 96;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // imgShowPwd
            // 
            this.imgShowPwd.BackColor = System.Drawing.Color.Silver;
            this.imgShowPwd.Image = ((System.Drawing.Image)(resources.GetObject("imgShowPwd.Image")));
            this.imgShowPwd.Location = new System.Drawing.Point(399, 342);
            this.imgShowPwd.Name = "imgShowPwd";
            this.imgShowPwd.Size = new System.Drawing.Size(43, 35);
            this.imgShowPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShowPwd.TabIndex = 106;
            this.imgShowPwd.TabStop = false;
            this.imgShowPwd.Click += new System.EventHandler(this.ImgShowPwd_Click);
            // 
            // imgHidePwd
            // 
            this.imgHidePwd.BackColor = System.Drawing.Color.Silver;
            this.imgHidePwd.Image = ((System.Drawing.Image)(resources.GetObject("imgHidePwd.Image")));
            this.imgHidePwd.Location = new System.Drawing.Point(399, 342);
            this.imgHidePwd.Name = "imgHidePwd";
            this.imgHidePwd.Size = new System.Drawing.Size(43, 35);
            this.imgHidePwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHidePwd.TabIndex = 105;
            this.imgHidePwd.TabStop = false;
            this.imgHidePwd.Visible = false;
            this.imgHidePwd.Click += new System.EventHandler(this.ImgHidePwd_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Silver;
            this.txtLogin.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLogin.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtLogin.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.txtLogin.BorderThickness = 3;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtLogin.isPassword = false;
            this.txtLogin.Location = new System.Drawing.Point(160, 270);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(286, 44);
            this.txtLogin.TabIndex = 94;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Silver;
            this.txtPwd.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPwd.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtPwd.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.txtPwd.BorderThickness = 3;
            this.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtPwd.isPassword = true;
            this.txtPwd.Location = new System.Drawing.Point(160, 337);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(286, 44);
            this.txtPwd.TabIndex = 95;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(67, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 104;
            this.label3.Text = "Senha :";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(-7, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(640, 18);
            this.lblTop.TabIndex = 103;
            this.lblTop.Text = "                                                                                 " +
    "                                                                             ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Location = new System.Drawing.Point(615, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 442);
            this.panel3.TabIndex = 102;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(581, 17);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 101;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMessage.Location = new System.Drawing.Point(162, 231);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(179, 20);
            this.lblMessage.TabIndex = 100;
            this.lblMessage.Text = "Menssagem Ao Usuario";
            this.lblMessage.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(-4, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 19);
            this.panel2.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 429);
            this.panel1.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(76, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Login :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(115, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 163);
            this.panel4.TabIndex = 110;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownFrm);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveFrm);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(153, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "Logo Wallpaper";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 441);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.IMG_RED);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.imgShowPwd);
            this.Controls.Add(this.imgHidePwd);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_RED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHidePwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG_RED;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox imgShowPwd;
        private System.Windows.Forms.PictureBox imgHidePwd;
        private ns1.BunifuMetroTextbox txtLogin;
        private ns1.BunifuMetroTextbox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}