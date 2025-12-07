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
            this.RunBtn1 = new Guna.UI2.WinForms.Guna2Button();
            this.EncodInputText = new Guna.UI2.WinForms.Guna2TextBox();
            this.EncodResultText = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasteBtn1 = new Guna.UI2.WinForms.Guna2Button();
            this.CopyBtn1 = new Guna.UI2.WinForms.Guna2Button();
            this.EncodeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DecodeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.MenuPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            this.BtnBase64.Location = new System.Drawing.Point(5, 3);
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
            this.BtnUrl.Location = new System.Drawing.Point(5, 64);
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
            this.BtnHtml.Location = new System.Drawing.Point(5, 125);
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
            this.BtnUnescape.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnescape.ForeColor = System.Drawing.Color.White;
            this.BtnUnescape.Location = new System.Drawing.Point(5, 186);
            this.BtnUnescape.Name = "BtnUnescape";
            this.BtnUnescape.ShadowDecoration.Enabled = true;
            this.BtnUnescape.Size = new System.Drawing.Size(96, 55);
            this.BtnUnescape.TabIndex = 4;
            this.BtnUnescape.Text = "Unescape";
            // 
            // RunBtn1
            // 
            this.RunBtn1.Animated = true;
            this.RunBtn1.BackColor = System.Drawing.Color.Transparent;
            this.RunBtn1.BorderRadius = 6;
            this.RunBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RunBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RunBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RunBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RunBtn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RunBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn1.ForeColor = System.Drawing.Color.White;
            this.RunBtn1.Location = new System.Drawing.Point(52, 530);
            this.RunBtn1.Name = "RunBtn1";
            this.RunBtn1.ShadowDecoration.Enabled = true;
            this.RunBtn1.Size = new System.Drawing.Size(134, 55);
            this.RunBtn1.TabIndex = 7;
            this.RunBtn1.Text = "Run";
            // 
            // EncodInputText
            // 
            this.EncodInputText.BackColor = System.Drawing.Color.Transparent;
            this.EncodInputText.BorderColor = System.Drawing.Color.Black;
            this.EncodInputText.BorderRadius = 6;
            this.EncodInputText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EncodInputText.DefaultText = "";
            this.EncodInputText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EncodInputText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EncodInputText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EncodInputText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EncodInputText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EncodInputText.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.EncodInputText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodInputText.HoverState.BorderColor = System.Drawing.Color.Black;
            this.EncodInputText.Location = new System.Drawing.Point(307, 86);
            this.EncodInputText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EncodInputText.Multiline = true;
            this.EncodInputText.Name = "EncodInputText";
            this.EncodInputText.PlaceholderForeColor = System.Drawing.Color.White;
            this.EncodInputText.PlaceholderText = "";
            this.EncodInputText.SelectedText = "";
            this.EncodInputText.ShadowDecoration.Enabled = true;
            this.EncodInputText.Size = new System.Drawing.Size(659, 260);
            this.EncodInputText.TabIndex = 8;
            // 
            // EncodResultText
            // 
            this.EncodResultText.BackColor = System.Drawing.Color.Transparent;
            this.EncodResultText.BorderColor = System.Drawing.Color.Black;
            this.EncodResultText.BorderRadius = 6;
            this.EncodResultText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EncodResultText.DefaultText = "";
            this.EncodResultText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EncodResultText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EncodResultText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EncodResultText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EncodResultText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EncodResultText.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.EncodResultText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodResultText.HoverState.BorderColor = System.Drawing.Color.Black;
            this.EncodResultText.Location = new System.Drawing.Point(307, 362);
            this.EncodResultText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncodResultText.Multiline = true;
            this.EncodResultText.Name = "EncodResultText";
            this.EncodResultText.PlaceholderForeColor = System.Drawing.Color.White;
            this.EncodResultText.PlaceholderText = "";
            this.EncodResultText.ReadOnly = true;
            this.EncodResultText.SelectedText = "";
            this.EncodResultText.ShadowDecoration.Enabled = true;
            this.EncodResultText.Size = new System.Drawing.Size(659, 260);
            this.EncodResultText.TabIndex = 9;
            // 
            // PasteBtn1
            // 
            this.PasteBtn1.Animated = true;
            this.PasteBtn1.BackColor = System.Drawing.Color.Transparent;
            this.PasteBtn1.BorderRadius = 6;
            this.PasteBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PasteBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PasteBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PasteBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PasteBtn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PasteBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.PasteBtn1.ForeColor = System.Drawing.Color.White;
            this.PasteBtn1.Location = new System.Drawing.Point(205, 86);
            this.PasteBtn1.Name = "PasteBtn1";
            this.PasteBtn1.ShadowDecoration.Enabled = true;
            this.PasteBtn1.Size = new System.Drawing.Size(96, 55);
            this.PasteBtn1.TabIndex = 10;
            this.PasteBtn1.Text = "Paste";
            // 
            // CopyBtn1
            // 
            this.CopyBtn1.Animated = true;
            this.CopyBtn1.BackColor = System.Drawing.Color.Transparent;
            this.CopyBtn1.BorderRadius = 6;
            this.CopyBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CopyBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CopyBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CopyBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CopyBtn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CopyBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CopyBtn1.ForeColor = System.Drawing.Color.White;
            this.CopyBtn1.Location = new System.Drawing.Point(205, 362);
            this.CopyBtn1.Name = "CopyBtn1";
            this.CopyBtn1.ShadowDecoration.Enabled = true;
            this.CopyBtn1.Size = new System.Drawing.Size(96, 55);
            this.CopyBtn1.TabIndex = 11;
            this.CopyBtn1.Text = "Copy";
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
            this.EncodeBtn.Location = new System.Drawing.Point(52, 362);
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
            this.DecodeBtn.Location = new System.Drawing.Point(52, 423);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.ShadowDecoration.Enabled = true;
            this.DecodeBtn.Size = new System.Drawing.Size(96, 55);
            this.DecodeBtn.TabIndex = 13;
            this.DecodeBtn.Text = "Decode";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BtnBase64);
            this.guna2Panel1.Controls.Add(this.BtnUrl);
            this.guna2Panel1.Controls.Add(this.BtnHtml);
            this.guna2Panel1.Controls.Add(this.BtnUnescape);
            this.guna2Panel1.Location = new System.Drawing.Point(46, 83);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(104, 244);
            this.guna2Panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(992, 646);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DecodeBtn);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.CopyBtn1);
            this.Controls.Add(this.PasteBtn1);
            this.Controls.Add(this.EncodResultText);
            this.Controls.Add(this.EncodInputText);
            this.Controls.Add(this.RunBtn1);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash\'n\'Code";
            this.MenuPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button RunBtn1;
        private Guna.UI2.WinForms.Guna2Button BtnUnescape;
        private Guna.UI2.WinForms.Guna2Button BtnHtml;
        private Guna.UI2.WinForms.Guna2Button BtnUrl;
        private Guna.UI2.WinForms.Guna2Button BtnBase64;
        private Guna.UI2.WinForms.Guna2TextBox EncodResultText;
        private Guna.UI2.WinForms.Guna2TextBox EncodInputText;
        private Guna.UI2.WinForms.Guna2Button CopyBtn1;
        private Guna.UI2.WinForms.Guna2Button PasteBtn1;
        private Guna.UI2.WinForms.Guna2Button DecodeBtn;
        private Guna.UI2.WinForms.Guna2Button EncodeBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

