namespace Hash_n_Coder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HashingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AESBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EncodBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BtnBase64 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUrl = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHtml = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUnescape = new Guna.UI2.WinForms.Guna2Button();
            this.RunBtn = new Guna.UI2.WinForms.Guna2Button();
            this.InputText = new Guna.UI2.WinForms.Guna2TextBox();
            this.ResultText = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CopyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EncodeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DecodeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AlgorPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CBCBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EBCBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AESComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.KeyText = new Guna.UI2.WinForms.Guna2TextBox();
            this.KeyGenerateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.KeyPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MenuPanel.SuspendLayout();
            this.AlgorPanel.SuspendLayout();
            this.KeyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MenuPanel.Controls.Add(this.HashingBtn);
            this.MenuPanel.Controls.Add(this.AESBtn);
            this.MenuPanel.Controls.Add(this.EncodBtn);
            this.MenuPanel.Controls.Add(this.guna2ControlBox2);
            this.MenuPanel.Controls.Add(this.guna2ControlBox1);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(992, 48);
            this.MenuPanel.TabIndex = 0;
            // 
            // HashingBtn
            // 
            this.HashingBtn.BorderRadius = 6;
            this.HashingBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HashingBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HashingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HashingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HashingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HashingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HashingBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HashingBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashingBtn.ForeColor = System.Drawing.Color.White;
            this.HashingBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.HashingBtn.Location = new System.Drawing.Point(307, 3);
            this.HashingBtn.Name = "HashingBtn";
            this.HashingBtn.Size = new System.Drawing.Size(150, 50);
            this.HashingBtn.TabIndex = 2;
            this.HashingBtn.Text = "Hashing";
            this.HashingBtn.Click += new System.EventHandler(this.HashingBtn_Click);
            // 
            // AESBtn
            // 
            this.AESBtn.BorderRadius = 6;
            this.AESBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AESBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AESBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AESBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AESBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AESBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AESBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AESBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AESBtn.ForeColor = System.Drawing.Color.White;
            this.AESBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AESBtn.Location = new System.Drawing.Point(155, 3);
            this.AESBtn.Name = "AESBtn";
            this.AESBtn.Size = new System.Drawing.Size(150, 50);
            this.AESBtn.TabIndex = 3;
            this.AESBtn.Text = "AES";
            this.AESBtn.Click += new System.EventHandler(this.AESBtn_Click);
            // 
            // EncodBtn
            // 
            this.EncodBtn.BorderRadius = 6;
            this.EncodBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.EncodBtn.Checked = true;
            this.EncodBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EncodBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EncodBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EncodBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EncodBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EncodBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EncodBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodBtn.ForeColor = System.Drawing.Color.White;
            this.EncodBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EncodBtn.Location = new System.Drawing.Point(3, 3);
            this.EncodBtn.Name = "EncodBtn";
            this.EncodBtn.Size = new System.Drawing.Size(150, 50);
            this.EncodBtn.TabIndex = 1;
            this.EncodBtn.Text = "Encoding";
            this.EncodBtn.Click += new System.EventHandler(this.EncodBtn_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(943, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(23, 20);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(967, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(23, 20);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.MenuPanel;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // BtnBase64
            // 
            this.BtnBase64.Animated = true;
            this.BtnBase64.BackColor = System.Drawing.Color.Transparent;
            this.BtnBase64.BorderRadius = 6;
            this.BtnBase64.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnBase64.Checked = true;
            this.BtnBase64.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBase64.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBase64.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBase64.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBase64.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnBase64.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBase64.ForeColor = System.Drawing.Color.White;
            this.BtnBase64.Location = new System.Drawing.Point(5, 103);
            this.BtnBase64.Name = "BtnBase64";
            this.BtnBase64.ShadowDecoration.Enabled = true;
            this.BtnBase64.Size = new System.Drawing.Size(96, 55);
            this.BtnBase64.TabIndex = 1;
            this.BtnBase64.Text = "Base64";
            // 
            // BtnUrl
            // 
            this.BtnUrl.Animated = true;
            this.BtnUrl.BackColor = System.Drawing.Color.Transparent;
            this.BtnUrl.BorderRadius = 6;
            this.BtnUrl.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnUrl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUrl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnUrl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUrl.ForeColor = System.Drawing.Color.White;
            this.BtnUrl.Location = new System.Drawing.Point(5, 164);
            this.BtnUrl.Name = "BtnUrl";
            this.BtnUrl.ShadowDecoration.Enabled = true;
            this.BtnUrl.Size = new System.Drawing.Size(96, 55);
            this.BtnUrl.TabIndex = 2;
            this.BtnUrl.Text = "Url";
            // 
            // BtnHtml
            // 
            this.BtnHtml.Animated = true;
            this.BtnHtml.BackColor = System.Drawing.Color.Transparent;
            this.BtnHtml.BorderRadius = 6;
            this.BtnHtml.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnHtml.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnHtml.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnHtml.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnHtml.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnHtml.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnHtml.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHtml.ForeColor = System.Drawing.Color.White;
            this.BtnHtml.Location = new System.Drawing.Point(5, 225);
            this.BtnHtml.Name = "BtnHtml";
            this.BtnHtml.ShadowDecoration.Enabled = true;
            this.BtnHtml.Size = new System.Drawing.Size(96, 55);
            this.BtnHtml.TabIndex = 3;
            this.BtnHtml.Text = "Html";
            // 
            // BtnUnescape
            // 
            this.BtnUnescape.Animated = true;
            this.BtnUnescape.BackColor = System.Drawing.Color.Transparent;
            this.BtnUnescape.BorderRadius = 6;
            this.BtnUnescape.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnUnescape.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUnescape.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUnescape.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUnescape.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUnescape.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnUnescape.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnUnescape.ForeColor = System.Drawing.Color.White;
            this.BtnUnescape.Location = new System.Drawing.Point(5, 286);
            this.BtnUnescape.Name = "BtnUnescape";
            this.BtnUnescape.ShadowDecoration.Enabled = true;
            this.BtnUnescape.Size = new System.Drawing.Size(96, 55);
            this.BtnUnescape.TabIndex = 4;
            this.BtnUnescape.Text = "Unescape";
            // 
            // RunBtn
            // 
            this.RunBtn.Animated = true;
            this.RunBtn.BackColor = System.Drawing.Color.Transparent;
            this.RunBtn.BorderRadius = 6;
            this.RunBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RunBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RunBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RunBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RunBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RunBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.ForeColor = System.Drawing.Color.White;
            this.RunBtn.Location = new System.Drawing.Point(54, 627);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.ShadowDecoration.Enabled = true;
            this.RunBtn.Size = new System.Drawing.Size(121, 55);
            this.RunBtn.TabIndex = 7;
            this.RunBtn.Text = "Run";
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // InputText
            // 
            this.InputText.AutoScroll = true;
            this.InputText.BackColor = System.Drawing.Color.Transparent;
            this.InputText.BorderColor = System.Drawing.Color.Black;
            this.InputText.BorderRadius = 6;
            this.InputText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputText.DefaultText = "";
            this.InputText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InputText.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.InputText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.HoverState.BorderColor = System.Drawing.Color.Black;
            this.InputText.Location = new System.Drawing.Point(307, 157);
            this.InputText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.PlaceholderForeColor = System.Drawing.Color.White;
            this.InputText.PlaceholderText = "";
            this.InputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputText.SelectedText = "";
            this.InputText.ShadowDecoration.Enabled = true;
            this.InputText.Size = new System.Drawing.Size(659, 260);
            this.InputText.TabIndex = 8;
            this.InputText.WordWrap = false;
            // 
            // ResultText
            // 
            this.ResultText.AutoScroll = true;
            this.ResultText.BackColor = System.Drawing.Color.Transparent;
            this.ResultText.BorderColor = System.Drawing.Color.Black;
            this.ResultText.BorderRadius = 6;
            this.ResultText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResultText.DefaultText = "";
            this.ResultText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ResultText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ResultText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ResultText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ResultText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ResultText.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.ResultText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ResultText.HoverState.BorderColor = System.Drawing.Color.Black;
            this.ResultText.Location = new System.Drawing.Point(307, 422);
            this.ResultText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.PlaceholderForeColor = System.Drawing.Color.White;
            this.ResultText.PlaceholderText = "";
            this.ResultText.ReadOnly = true;
            this.ResultText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultText.SelectedText = "";
            this.ResultText.ShadowDecoration.Enabled = true;
            this.ResultText.Size = new System.Drawing.Size(659, 260);
            this.ResultText.TabIndex = 9;
            this.ResultText.WordWrap = false;
            // 
            // PasteBtn
            // 
            this.PasteBtn.Animated = true;
            this.PasteBtn.BackColor = System.Drawing.Color.Transparent;
            this.PasteBtn.BorderRadius = 6;
            this.PasteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PasteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PasteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PasteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PasteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PasteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PasteBtn.ForeColor = System.Drawing.Color.White;
            this.PasteBtn.Location = new System.Drawing.Point(205, 157);
            this.PasteBtn.Name = "PasteBtn";
            this.PasteBtn.ShadowDecoration.Enabled = true;
            this.PasteBtn.Size = new System.Drawing.Size(96, 55);
            this.PasteBtn.TabIndex = 10;
            this.PasteBtn.Text = "Paste";
            this.PasteBtn.Click += new System.EventHandler(this.PasteBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Animated = true;
            this.CopyBtn.BackColor = System.Drawing.Color.Transparent;
            this.CopyBtn.BorderRadius = 6;
            this.CopyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CopyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CopyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CopyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CopyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CopyBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CopyBtn.ForeColor = System.Drawing.Color.White;
            this.CopyBtn.Location = new System.Drawing.Point(205, 422);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.ShadowDecoration.Enabled = true;
            this.CopyBtn.Size = new System.Drawing.Size(96, 55);
            this.CopyBtn.TabIndex = 11;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Animated = true;
            this.EncodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.EncodeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.EncodeBtn.BorderRadius = 6;
            this.EncodeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.EncodeBtn.Checked = true;
            this.EncodeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EncodeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EncodeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EncodeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EncodeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EncodeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EncodeBtn.ForeColor = System.Drawing.Color.White;
            this.EncodeBtn.Location = new System.Drawing.Point(54, 422);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.ShadowDecoration.Enabled = true;
            this.EncodeBtn.Size = new System.Drawing.Size(96, 55);
            this.EncodeBtn.TabIndex = 12;
            this.EncodeBtn.Text = "Encode";
            // 
            // DecodeBtn
            // 
            this.DecodeBtn.Animated = true;
            this.DecodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.DecodeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.DecodeBtn.BorderRadius = 6;
            this.DecodeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DecodeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DecodeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DecodeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DecodeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DecodeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DecodeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.DecodeBtn.ForeColor = System.Drawing.Color.White;
            this.DecodeBtn.Location = new System.Drawing.Point(54, 483);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.ShadowDecoration.Enabled = true;
            this.DecodeBtn.Size = new System.Drawing.Size(96, 55);
            this.DecodeBtn.TabIndex = 13;
            this.DecodeBtn.Text = "Decode";
            // 
            // AlgorPanel
            // 
            this.AlgorPanel.Controls.Add(this.CBCBtn);
            this.AlgorPanel.Controls.Add(this.BtnBase64);
            this.AlgorPanel.Controls.Add(this.EBCBtn);
            this.AlgorPanel.Controls.Add(this.BtnUrl);
            this.AlgorPanel.Controls.Add(this.AESComboBox);
            this.AlgorPanel.Controls.Add(this.BtnHtml);
            this.AlgorPanel.Controls.Add(this.BtnUnescape);
            this.AlgorPanel.Location = new System.Drawing.Point(49, 54);
            this.AlgorPanel.Name = "AlgorPanel";
            this.AlgorPanel.Size = new System.Drawing.Size(114, 344);
            this.AlgorPanel.TabIndex = 14;
            // 
            // CBCBtn
            // 
            this.CBCBtn.Animated = true;
            this.CBCBtn.BackColor = System.Drawing.Color.Transparent;
            this.CBCBtn.BorderRadius = 6;
            this.CBCBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CBCBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CBCBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CBCBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CBCBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CBCBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CBCBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CBCBtn.ForeColor = System.Drawing.Color.White;
            this.CBCBtn.Location = new System.Drawing.Point(5, 164);
            this.CBCBtn.Name = "CBCBtn";
            this.CBCBtn.ShadowDecoration.Enabled = true;
            this.CBCBtn.Size = new System.Drawing.Size(96, 55);
            this.CBCBtn.TabIndex = 21;
            this.CBCBtn.Text = "AES-CBC";
            this.CBCBtn.Visible = false;
            // 
            // EBCBtn
            // 
            this.EBCBtn.Animated = true;
            this.EBCBtn.BackColor = System.Drawing.Color.Transparent;
            this.EBCBtn.BorderRadius = 6;
            this.EBCBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.EBCBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EBCBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EBCBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EBCBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EBCBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EBCBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.EBCBtn.ForeColor = System.Drawing.Color.White;
            this.EBCBtn.Location = new System.Drawing.Point(5, 103);
            this.EBCBtn.Name = "EBCBtn";
            this.EBCBtn.ShadowDecoration.Enabled = true;
            this.EBCBtn.Size = new System.Drawing.Size(96, 55);
            this.EBCBtn.TabIndex = 5;
            this.EBCBtn.Text = "AES-EBC";
            this.EBCBtn.Visible = false;
            // 
            // AESComboBox
            // 
            this.AESComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AESComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AESComboBox.BorderRadius = 6;
            this.AESComboBox.BorderThickness = 0;
            this.AESComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AESComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AESComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AESComboBox.FocusedColor = System.Drawing.Color.Black;
            this.AESComboBox.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.AESComboBox.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.AESComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.AESComboBox.ForeColor = System.Drawing.Color.Silver;
            this.AESComboBox.ItemHeight = 30;
            this.AESComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.AESComboBox.Location = new System.Drawing.Point(5, 7);
            this.AESComboBox.Name = "AESComboBox";
            this.AESComboBox.ShadowDecoration.Enabled = true;
            this.AESComboBox.Size = new System.Drawing.Size(96, 36);
            this.AESComboBox.StartIndex = 0;
            this.AESComboBox.TabIndex = 0;
            this.AESComboBox.Visible = false;
            // 
            // KeyText
            // 
            this.KeyText.AutoScroll = true;
            this.KeyText.BackColor = System.Drawing.Color.Transparent;
            this.KeyText.BorderColor = System.Drawing.Color.Black;
            this.KeyText.BorderRadius = 6;
            this.KeyText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyText.DefaultText = "";
            this.KeyText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.KeyText.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.KeyText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyText.HoverState.BorderColor = System.Drawing.Color.Black;
            this.KeyText.Location = new System.Drawing.Point(110, 7);
            this.KeyText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.KeyText.Multiline = true;
            this.KeyText.Name = "KeyText";
            this.KeyText.PlaceholderForeColor = System.Drawing.Color.White;
            this.KeyText.PlaceholderText = "";
            this.KeyText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.KeyText.SelectedText = "";
            this.KeyText.ShadowDecoration.Enabled = true;
            this.KeyText.Size = new System.Drawing.Size(659, 86);
            this.KeyText.TabIndex = 17;
            this.KeyText.WordWrap = false;
            // 
            // KeyGenerateBtn
            // 
            this.KeyGenerateBtn.Animated = true;
            this.KeyGenerateBtn.BackColor = System.Drawing.Color.Transparent;
            this.KeyGenerateBtn.BorderRadius = 6;
            this.KeyGenerateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.KeyGenerateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.KeyGenerateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.KeyGenerateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.KeyGenerateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.KeyGenerateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.KeyGenerateBtn.ForeColor = System.Drawing.Color.White;
            this.KeyGenerateBtn.Location = new System.Drawing.Point(8, 7);
            this.KeyGenerateBtn.Name = "KeyGenerateBtn";
            this.KeyGenerateBtn.ShadowDecoration.Enabled = true;
            this.KeyGenerateBtn.Size = new System.Drawing.Size(96, 55);
            this.KeyGenerateBtn.TabIndex = 18;
            this.KeyGenerateBtn.Text = "Generate key";
            this.KeyGenerateBtn.Click += new System.EventHandler(this.KeyGenerateBtn_Click);
            // 
            // KeyPanel
            // 
            this.KeyPanel.Controls.Add(this.KeyText);
            this.KeyPanel.Controls.Add(this.KeyGenerateBtn);
            this.KeyPanel.Location = new System.Drawing.Point(197, 54);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(783, 97);
            this.KeyPanel.TabIndex = 19;
            this.KeyPanel.Visible = false;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.KeyPanel;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl4.TargetControl = this.AlgorPanel;
            this.guna2DragControl4.UseTransparentDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(992, 699);
            this.Controls.Add(this.KeyPanel);
            this.Controls.Add(this.AlgorPanel);
            this.Controls.Add(this.DecodeBtn);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.PasteBtn);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash\'n\'Code";
            this.MenuPanel.ResumeLayout(false);
            this.AlgorPanel.ResumeLayout(false);
            this.KeyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel MenuPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button HashingBtn;
        private Guna.UI2.WinForms.Guna2Button AESBtn;
        private Guna.UI2.WinForms.Guna2Button EncodBtn;
        private Guna.UI2.WinForms.Guna2Button RunBtn;
        private Guna.UI2.WinForms.Guna2Button BtnUnescape;
        private Guna.UI2.WinForms.Guna2Button BtnHtml;
        private Guna.UI2.WinForms.Guna2Button BtnUrl;
        private Guna.UI2.WinForms.Guna2Button BtnBase64;
        private Guna.UI2.WinForms.Guna2TextBox ResultText;
        private Guna.UI2.WinForms.Guna2TextBox InputText;
        private Guna.UI2.WinForms.Guna2Button CopyBtn;
        private Guna.UI2.WinForms.Guna2Button PasteBtn;
        private Guna.UI2.WinForms.Guna2Button DecodeBtn;
        private Guna.UI2.WinForms.Guna2Button EncodeBtn;
        private Guna.UI2.WinForms.Guna2Panel AlgorPanel;
        private Guna.UI2.WinForms.Guna2TextBox KeyText;
        private Guna.UI2.WinForms.Guna2Button KeyGenerateBtn;
        private Guna.UI2.WinForms.Guna2Panel KeyPanel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Button CBCBtn;
        private Guna.UI2.WinForms.Guna2Button EBCBtn;
        private Guna.UI2.WinForms.Guna2ComboBox AESComboBox;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
    }
}

