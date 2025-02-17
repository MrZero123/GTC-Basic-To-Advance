namespace BasicToAdvance_01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.error = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.info = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.warn = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 1000;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.DimGray;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(26, -15);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 274);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2TextBox1.BorderRadius = 4;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.guna2TextBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.guna2TextBox1.Location = new System.Drawing.Point(49, 232);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Enter Your Username";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2TextBox1.ShadowDecoration.Enabled = true;
            this.guna2TextBox1.Size = new System.Drawing.Size(253, 43);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 3;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2TextBox2.BorderRadius = 4;
            this.guna2TextBox2.BorderThickness = 2;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.guna2TextBox2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.guna2TextBox2.Location = new System.Drawing.Point(49, 310);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '*';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox2.PlaceholderText = "Enter Your Password";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2TextBox2.ShadowDecoration.Enabled = true;
            this.guna2TextBox2.Size = new System.Drawing.Size(253, 43);
            this.guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox2.TabIndex = 3;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Location = new System.Drawing.Point(80, 385);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Login";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // error
            // 
            this.error.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.error.Caption = "GTC CHE3TS";
            this.error.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.error.Parent = this;
            this.error.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.error.Text = null;
            // 
            // info
            // 
            this.info.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.info.Caption = "GTC CHE3TS";
            this.info.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.info.Parent = this;
            this.info.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.info.Text = null;
            // 
            // warn
            // 
            this.warn.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.warn.Caption = "GTC CHE3TS";
            this.warn.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.warn.Parent = this;
            this.warn.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.warn.Text = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(346, 491);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2MessageDialog error;
        private Guna.UI2.WinForms.Guna2MessageDialog info;
        private Guna.UI2.WinForms.Guna2MessageDialog warn;
    }
}

