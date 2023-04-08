namespace RG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pn_log = new Guna.UI2.WinForms.Guna2Panel();
            this.Button_log_crtacc = new Guna.UI2.WinForms.Guna2Button();
            this.GradientButton_log_log = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label_frgt_pass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToggleSwitch_rmmbr_me = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.TextBox_log_paswd = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_log_usr = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_reg = new Guna.UI2.WinForms.Guna2Panel();
            this.GradientButton_reg_reg = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label_reg_log = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ToggleSwitch_shw_paswd = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.TextBox_reg_mail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_reg_paswd = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_reg_usr = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pn_log.SuspendLayout();
            this.pn_reg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(126, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "SING IN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pn_log
            // 
            this.pn_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.pn_log.Controls.Add(this.Button_log_crtacc);
            this.pn_log.Controls.Add(this.GradientButton_log_log);
            this.pn_log.Controls.Add(this.label_frgt_pass);
            this.pn_log.Controls.Add(this.label2);
            this.pn_log.Controls.Add(this.ToggleSwitch_rmmbr_me);
            this.pn_log.Controls.Add(this.TextBox_log_paswd);
            this.pn_log.Controls.Add(this.TextBox_log_usr);
            this.pn_log.Controls.Add(this.label1);
            this.guna2Transition1.SetDecoration(this.pn_log, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_log.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pn_log.ForeColor = System.Drawing.Color.Snow;
            this.pn_log.Location = new System.Drawing.Point(0, 0);
            this.pn_log.Name = "pn_log";
            this.pn_log.Size = new System.Drawing.Size(354, 522);
            this.pn_log.TabIndex = 1;
            this.pn_log.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_log_Paint);
            // 
            // Button_log_crtacc
            // 
            this.Button_log_crtacc.AutoRoundedCorners = true;
            this.Button_log_crtacc.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.Button_log_crtacc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Button_log_crtacc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_log_crtacc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_log_crtacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_log_crtacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_log_crtacc.FillColor = System.Drawing.Color.Transparent;
            this.Button_log_crtacc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_log_crtacc.ForeColor = System.Drawing.Color.White;
            this.Button_log_crtacc.Image = global::RG.Properties.Resources.right_arrow;
            this.Button_log_crtacc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Button_log_crtacc.Location = new System.Drawing.Point(84, 441);
            this.Button_log_crtacc.Name = "Button_log_crtacc";
            this.Button_log_crtacc.Size = new System.Drawing.Size(208, 45);
            this.Button_log_crtacc.TabIndex = 5;
            this.Button_log_crtacc.Text = "Create Account";
            this.Button_log_crtacc.TextOffset = new System.Drawing.Point(0, -1);
            this.Button_log_crtacc.Click += new System.EventHandler(this.Button_log_crtacc_Click);
            // 
            // GradientButton_log_log
            // 
            this.GradientButton_log_log.Animated = true;
            this.GradientButton_log_log.AutoRoundedCorners = true;
            this.GradientButton_log_log.BackColor = System.Drawing.Color.Transparent;
            this.GradientButton_log_log.BorderRadius = 24;
            this.guna2Transition1.SetDecoration(this.GradientButton_log_log, Guna.UI2.AnimatorNS.DecorationType.None);
            this.GradientButton_log_log.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GradientButton_log_log.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GradientButton_log_log.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GradientButton_log_log.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GradientButton_log_log.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GradientButton_log_log.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Bold);
            this.GradientButton_log_log.ForeColor = System.Drawing.Color.White;
            this.GradientButton_log_log.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.GradientButton_log_log.Location = new System.Drawing.Point(84, 341);
            this.GradientButton_log_log.Name = "GradientButton_log_log";
            this.GradientButton_log_log.Size = new System.Drawing.Size(208, 51);
            this.GradientButton_log_log.TabIndex = 4;
            this.GradientButton_log_log.Text = "LOGIN";
            this.GradientButton_log_log.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label_frgt_pass
            // 
            this.label_frgt_pass.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label_frgt_pass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_frgt_pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_frgt_pass.Location = new System.Drawing.Point(104, 395);
            this.label_frgt_pass.Name = "label_frgt_pass";
            this.label_frgt_pass.Size = new System.Drawing.Size(170, 15);
            this.label_frgt_pass.TabIndex = 3;
            this.label_frgt_pass.Text = "Forgot Username or Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remember me";
            // 
            // ToggleSwitch_rmmbr_me
            // 
            this.ToggleSwitch_rmmbr_me.Animated = true;
            this.ToggleSwitch_rmmbr_me.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToggleSwitch_rmmbr_me.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToggleSwitch_rmmbr_me.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch_rmmbr_me.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.ToggleSwitch_rmmbr_me, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ToggleSwitch_rmmbr_me.Location = new System.Drawing.Point(25, 293);
            this.ToggleSwitch_rmmbr_me.Name = "ToggleSwitch_rmmbr_me";
            this.ToggleSwitch_rmmbr_me.Size = new System.Drawing.Size(35, 20);
            this.ToggleSwitch_rmmbr_me.TabIndex = 2;
            this.ToggleSwitch_rmmbr_me.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch_rmmbr_me.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch_rmmbr_me.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch_rmmbr_me.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // TextBox_log_paswd
            // 
            this.TextBox_log_paswd.Animated = true;
            this.TextBox_log_paswd.AutoRoundedCorners = true;
            this.TextBox_log_paswd.BorderRadius = 20;
            this.TextBox_log_paswd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TextBox_log_paswd.BorderThickness = 0;
            this.TextBox_log_paswd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.TextBox_log_paswd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TextBox_log_paswd.DefaultText = "";
            this.TextBox_log_paswd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_log_paswd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_log_paswd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_log_paswd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_log_paswd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.TextBox_log_paswd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_log_paswd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox_log_paswd.ForeColor = System.Drawing.Color.Black;
            this.TextBox_log_paswd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_log_paswd.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox_log_paswd.IconLeft")));
            this.TextBox_log_paswd.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.TextBox_log_paswd.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TextBox_log_paswd.Location = new System.Drawing.Point(26, 230);
            this.TextBox_log_paswd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_log_paswd.Name = "TextBox_log_paswd";
            this.TextBox_log_paswd.PasswordChar = '•';
            this.TextBox_log_paswd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_log_paswd.PlaceholderText = "Password";
            this.TextBox_log_paswd.SelectedText = "";
            this.TextBox_log_paswd.Size = new System.Drawing.Size(300, 42);
            this.TextBox_log_paswd.TabIndex = 1;
            this.TextBox_log_paswd.TextOffset = new System.Drawing.Point(2, 0);
            this.TextBox_log_paswd.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // TextBox_log_usr
            // 
            this.TextBox_log_usr.Animated = true;
            this.TextBox_log_usr.AutoRoundedCorners = true;
            this.TextBox_log_usr.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_log_usr.BorderRadius = 20;
            this.TextBox_log_usr.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TextBox_log_usr.BorderThickness = 0;
            this.TextBox_log_usr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.TextBox_log_usr, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TextBox_log_usr.DefaultText = "";
            this.TextBox_log_usr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_log_usr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_log_usr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_log_usr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_log_usr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.TextBox_log_usr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_log_usr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox_log_usr.ForeColor = System.Drawing.Color.Black;
            this.TextBox_log_usr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_log_usr.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox_log_usr.IconLeft")));
            this.TextBox_log_usr.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.TextBox_log_usr.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TextBox_log_usr.Location = new System.Drawing.Point(26, 169);
            this.TextBox_log_usr.Margin = new System.Windows.Forms.Padding(310);
            this.TextBox_log_usr.Name = "TextBox_log_usr";
            this.TextBox_log_usr.PasswordChar = '\0';
            this.TextBox_log_usr.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_log_usr.PlaceholderText = "Username";
            this.TextBox_log_usr.SelectedText = "";
            this.TextBox_log_usr.Size = new System.Drawing.Size(300, 42);
            this.TextBox_log_usr.TabIndex = 1;
            this.TextBox_log_usr.TextOffset = new System.Drawing.Point(2, 0);
            this.TextBox_log_usr.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // pn_reg
            // 
            this.pn_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.pn_reg.Controls.Add(this.pn_log);
            this.pn_reg.Controls.Add(this.GradientButton_reg_reg);
            this.pn_reg.Controls.Add(this.label_reg_log);
            this.pn_reg.Controls.Add(this.label5);
            this.pn_reg.Controls.Add(this.ToggleSwitch_shw_paswd);
            this.pn_reg.Controls.Add(this.TextBox_reg_mail);
            this.pn_reg.Controls.Add(this.TextBox_reg_paswd);
            this.pn_reg.Controls.Add(this.TextBox_reg_usr);
            this.pn_reg.Controls.Add(this.label6);
            this.guna2Transition1.SetDecoration(this.pn_reg, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_reg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pn_reg.ForeColor = System.Drawing.Color.Snow;
            this.pn_reg.Location = new System.Drawing.Point(328, 0);
            this.pn_reg.Name = "pn_reg";
            this.pn_reg.Size = new System.Drawing.Size(354, 522);
            this.pn_reg.TabIndex = 1;
            // 
            // GradientButton_reg_reg
            // 
            this.GradientButton_reg_reg.Animated = true;
            this.GradientButton_reg_reg.AutoRoundedCorners = true;
            this.GradientButton_reg_reg.BackColor = System.Drawing.Color.Transparent;
            this.GradientButton_reg_reg.BorderRadius = 24;
            this.guna2Transition1.SetDecoration(this.GradientButton_reg_reg, Guna.UI2.AnimatorNS.DecorationType.None);
            this.GradientButton_reg_reg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GradientButton_reg_reg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GradientButton_reg_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GradientButton_reg_reg.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GradientButton_reg_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GradientButton_reg_reg.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Bold);
            this.GradientButton_reg_reg.ForeColor = System.Drawing.Color.White;
            this.GradientButton_reg_reg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.GradientButton_reg_reg.Location = new System.Drawing.Point(85, 392);
            this.GradientButton_reg_reg.Name = "GradientButton_reg_reg";
            this.GradientButton_reg_reg.Size = new System.Drawing.Size(208, 51);
            this.GradientButton_reg_reg.TabIndex = 4;
            this.GradientButton_reg_reg.Text = "REGISTER";
            this.GradientButton_reg_reg.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label_reg_log
            // 
            this.label_reg_log.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label_reg_log, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_reg_log.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_reg_log.Location = new System.Drawing.Point(280, 475);
            this.label_reg_log.Name = "label_reg_log";
            this.label_reg_log.Size = new System.Drawing.Size(46, 20);
            this.label_reg_log.TabIndex = 3;
            this.label_reg_log.Text = "Login";
            this.label_reg_log.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(67, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Show password";
            // 
            // ToggleSwitch_shw_paswd
            // 
            this.ToggleSwitch_shw_paswd.Animated = true;
            this.ToggleSwitch_shw_paswd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToggleSwitch_shw_paswd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToggleSwitch_shw_paswd.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch_shw_paswd.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.ToggleSwitch_shw_paswd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ToggleSwitch_shw_paswd.Location = new System.Drawing.Point(26, 349);
            this.ToggleSwitch_shw_paswd.Name = "ToggleSwitch_shw_paswd";
            this.ToggleSwitch_shw_paswd.Size = new System.Drawing.Size(35, 20);
            this.ToggleSwitch_shw_paswd.TabIndex = 2;
            this.ToggleSwitch_shw_paswd.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch_shw_paswd.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch_shw_paswd.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch_shw_paswd.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch_shw_paswd.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // TextBox_reg_mail
            // 
            this.TextBox_reg_mail.Animated = true;
            this.TextBox_reg_mail.AutoRoundedCorners = true;
            this.TextBox_reg_mail.BorderRadius = 20;
            this.TextBox_reg_mail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TextBox_reg_mail.BorderThickness = 0;
            this.TextBox_reg_mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.TextBox_reg_mail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TextBox_reg_mail.DefaultText = "";
            this.TextBox_reg_mail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_reg_mail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_reg_mail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_reg_mail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_reg_mail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.TextBox_reg_mail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_reg_mail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox_reg_mail.ForeColor = System.Drawing.Color.Black;
            this.TextBox_reg_mail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_reg_mail.IconLeft = global::RG.Properties.Resources.email;
            this.TextBox_reg_mail.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.TextBox_reg_mail.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TextBox_reg_mail.Location = new System.Drawing.Point(26, 224);
            this.TextBox_reg_mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_reg_mail.Name = "TextBox_reg_mail";
            this.TextBox_reg_mail.PasswordChar = '\0';
            this.TextBox_reg_mail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_reg_mail.PlaceholderText = "E-Mail";
            this.TextBox_reg_mail.SelectedText = "";
            this.TextBox_reg_mail.Size = new System.Drawing.Size(300, 42);
            this.TextBox_reg_mail.TabIndex = 1;
            this.TextBox_reg_mail.TextOffset = new System.Drawing.Point(2, 0);
            this.TextBox_reg_mail.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // TextBox_reg_paswd
            // 
            this.TextBox_reg_paswd.Animated = true;
            this.TextBox_reg_paswd.AutoRoundedCorners = true;
            this.TextBox_reg_paswd.BorderRadius = 20;
            this.TextBox_reg_paswd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TextBox_reg_paswd.BorderThickness = 0;
            this.TextBox_reg_paswd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.TextBox_reg_paswd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TextBox_reg_paswd.DefaultText = "";
            this.TextBox_reg_paswd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_reg_paswd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_reg_paswd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_reg_paswd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_reg_paswd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.TextBox_reg_paswd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_reg_paswd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox_reg_paswd.ForeColor = System.Drawing.Color.Black;
            this.TextBox_reg_paswd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_reg_paswd.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox_reg_paswd.IconLeft")));
            this.TextBox_reg_paswd.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.TextBox_reg_paswd.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TextBox_reg_paswd.Location = new System.Drawing.Point(26, 284);
            this.TextBox_reg_paswd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_reg_paswd.Name = "TextBox_reg_paswd";
            this.TextBox_reg_paswd.PasswordChar = '•';
            this.TextBox_reg_paswd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_reg_paswd.PlaceholderText = "Password";
            this.TextBox_reg_paswd.SelectedText = "";
            this.TextBox_reg_paswd.Size = new System.Drawing.Size(300, 42);
            this.TextBox_reg_paswd.TabIndex = 1;
            this.TextBox_reg_paswd.TextOffset = new System.Drawing.Point(2, 0);
            this.TextBox_reg_paswd.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // TextBox_reg_usr
            // 
            this.TextBox_reg_usr.Animated = true;
            this.TextBox_reg_usr.AutoRoundedCorners = true;
            this.TextBox_reg_usr.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_reg_usr.BorderRadius = 20;
            this.TextBox_reg_usr.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TextBox_reg_usr.BorderThickness = 0;
            this.TextBox_reg_usr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.TextBox_reg_usr, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TextBox_reg_usr.DefaultText = "";
            this.TextBox_reg_usr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_reg_usr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_reg_usr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_reg_usr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_reg_usr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.TextBox_reg_usr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_reg_usr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox_reg_usr.ForeColor = System.Drawing.Color.Black;
            this.TextBox_reg_usr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_reg_usr.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox_reg_usr.IconLeft")));
            this.TextBox_reg_usr.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.TextBox_reg_usr.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TextBox_reg_usr.Location = new System.Drawing.Point(26, 163);
            this.TextBox_reg_usr.Margin = new System.Windows.Forms.Padding(310);
            this.TextBox_reg_usr.Name = "TextBox_reg_usr";
            this.TextBox_reg_usr.PasswordChar = '\0';
            this.TextBox_reg_usr.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_reg_usr.PlaceholderText = "Username";
            this.TextBox_reg_usr.SelectedText = "";
            this.TextBox_reg_usr.Size = new System.Drawing.Size(300, 42);
            this.TextBox_reg_usr.TabIndex = 1;
            this.TextBox_reg_usr.TextOffset = new System.Drawing.Point(2, 0);
            this.TextBox_reg_usr.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(126, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "SING UP";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::RG.Properties.Resources.bg_1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(331, 522);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(682, 28);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(654, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(28, 28);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.9D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 522);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pn_reg);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pn_log.ResumeLayout(false);
            this.pn_log.PerformLayout();
            this.pn_reg.ResumeLayout(false);
            this.pn_reg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pn_log;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_log_usr;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch_rmmbr_me;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_log_paswd;
        private Guna.UI2.WinForms.Guna2GradientButton GradientButton_log_log;
        private Guna.UI2.WinForms.Guna2Panel pn_reg;
        private Guna.UI2.WinForms.Guna2GradientButton GradientButton_reg_reg;
        private System.Windows.Forms.Label label_reg_log;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch_shw_paswd;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_reg_mail;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_reg_paswd;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_reg_usr;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Button_log_crtacc;
        private System.Windows.Forms.Label label_frgt_pass;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

