
namespace management_store
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnPower = new System.Windows.Forms.Button();
            this.pnlRoles = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.rdbAdmin = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rdbNhanVien = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.loaderDangNhap = new Bunifu.UI.WinForms.BunifuLoader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtTenTaiKhoan = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnDangNhap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.picBoxLogin = new System.Windows.Forms.PictureBox();
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            this.picBoxUsername = new System.Windows.Forms.PictureBox();
            this.pnlRoles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.Color.White;
            this.btnPower.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPower.Location = new System.Drawing.Point(992, 0);
            this.btnPower.Name = "btnPower";
            this.btnPower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPower.Size = new System.Drawing.Size(44, 45);
            this.btnPower.TabIndex = 0;
            this.btnPower.Text = "X";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // pnlRoles
            // 
            this.pnlRoles.Controls.Add(this.lblAdmin);
            this.pnlRoles.Controls.Add(this.lblNhanVien);
            this.pnlRoles.Controls.Add(this.rdbAdmin);
            this.pnlRoles.Controls.Add(this.rdbNhanVien);
            this.pnlRoles.Location = new System.Drawing.Point(621, 303);
            this.pnlRoles.Name = "pnlRoles";
            this.pnlRoles.Size = new System.Drawing.Size(367, 38);
            this.pnlRoles.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(246, 8);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(62, 22);
            this.lblAdmin.TabIndex = 12;
            this.lblAdmin.Text = "ADMIN";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblNhanVien.Location = new System.Drawing.Point(89, 8);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(94, 22);
            this.lblNhanVien.TabIndex = 12;
            this.lblNhanVien.Text = "NHÂN VIÊN";
            this.lblNhanVien.Click += new System.EventHandler(this.lblNhanVien_Click);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AllowBindingControlLocation = false;
            this.rdbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdbAdmin.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rdbAdmin.BorderThickness = 1;
            this.rdbAdmin.Checked = false;
            this.rdbAdmin.Location = new System.Drawing.Point(219, 8);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.OutlineColor = System.Drawing.Color.White;
            this.rdbAdmin.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdbAdmin.OutlineColorUnchecked = System.Drawing.Color.White;
            this.rdbAdmin.RadioColor = System.Drawing.Color.White;
            this.rdbAdmin.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdbAdmin.Size = new System.Drawing.Size(21, 21);
            this.rdbAdmin.TabIndex = 11;
            this.rdbAdmin.Text = null;
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AllowBindingControlLocation = false;
            this.rdbNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.rdbNhanVien.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rdbNhanVien.BorderThickness = 1;
            this.rdbNhanVien.Checked = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(62, 9);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.OutlineColor = System.Drawing.Color.White;
            this.rdbNhanVien.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdbNhanVien.OutlineColorUnchecked = System.Drawing.Color.White;
            this.rdbNhanVien.RadioColor = System.Drawing.Color.White;
            this.rdbNhanVien.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdbNhanVien.Size = new System.Drawing.Size(21, 21);
            this.rdbNhanVien.TabIndex = 11;
            this.rdbNhanVien.Text = null;
            // 
            // loaderDangNhap
            // 
            this.loaderDangNhap.AllowStylePresets = true;
            this.loaderDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.loaderDangNhap.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.loaderDangNhap.Color = System.Drawing.Color.AliceBlue;
            this.loaderDangNhap.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.loaderDangNhap.Customization = "";
            this.loaderDangNhap.DashWidth = 0.5F;
            this.loaderDangNhap.Enabled = false;
            this.loaderDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loaderDangNhap.Image = null;
            this.loaderDangNhap.Location = new System.Drawing.Point(786, 416);
            this.loaderDangNhap.Name = "loaderDangNhap";
            this.loaderDangNhap.NoRounding = false;
            this.loaderDangNhap.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loaderDangNhap.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loaderDangNhap.ShowText = false;
            this.loaderDangNhap.Size = new System.Drawing.Size(40, 40);
            this.loaderDangNhap.Speed = 7;
            this.loaderDangNhap.TabIndex = 7;
            this.loaderDangNhap.Text = "bunifuLoader1";
            this.loaderDangNhap.TextPadding = new System.Windows.Forms.Padding(0);
            this.loaderDangNhap.Thickness = 6;
            this.loaderDangNhap.Transparent = true;
            this.loaderDangNhap.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 476);
            this.panel1.TabIndex = 10;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(36, 25);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(485, 35);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "QUẢN LÝ CỬA HÀNG VĂN PHÒNG PHẨM";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::management_store.Properties.Resources._7df8b5dfcc84f1180a6261fdbf648b17;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AcceptsReturn = false;
            this.txtMatKhau.AcceptsTab = false;
            this.txtMatKhau.AnimationSpeed = 200;
            this.txtMatKhau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatKhau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatKhau.AutoSizeHeight = true;
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMatKhau.BackgroundImage")));
            this.txtMatKhau.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMatKhau.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMatKhau.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMatKhau.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMatKhau.BorderRadius = 1;
            this.txtMatKhau.BorderThickness = 1;
            this.txtMatKhau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultFont = new System.Drawing.Font("Open Sans ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.FillColor = System.Drawing.Color.White;
            this.txtMatKhau.HideSelection = true;
            this.txtMatKhau.IconLeft = null;
            this.txtMatKhau.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.IconPadding = 10;
            this.txtMatKhau.IconRight = null;
            this.txtMatKhau.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(668, 242);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMatKhau.Modified = false;
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.OnIdleState = stateProperties12;
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(3);
            this.txtMatKhau.PasswordChar = '•';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(320, 39);
            this.txtMatKhau.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtMatKhau.TabIndex = 9;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.TextMarginBottom = 0;
            this.txtMatKhau.TextMarginLeft = 3;
            this.txtMatKhau.TextMarginTop = 1;
            this.txtMatKhau.TextPlaceholder = "Mật khẩu";
            this.txtMatKhau.UseSystemPasswordChar = false;
            this.txtMatKhau.WordWrap = true;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.AcceptsReturn = false;
            this.txtTenTaiKhoan.AcceptsTab = false;
            this.txtTenTaiKhoan.AnimationSpeed = 200;
            this.txtTenTaiKhoan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenTaiKhoan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenTaiKhoan.AutoSizeHeight = true;
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTenTaiKhoan.BackgroundImage")));
            this.txtTenTaiKhoan.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTenTaiKhoan.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTenTaiKhoan.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTenTaiKhoan.BorderRadius = 1;
            this.txtTenTaiKhoan.BorderThickness = 1;
            this.txtTenTaiKhoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTenTaiKhoan.DefaultText = "";
            this.txtTenTaiKhoan.FillColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.HideSelection = true;
            this.txtTenTaiKhoan.IconLeft = null;
            this.txtTenTaiKhoan.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.IconPadding = 10;
            this.txtTenTaiKhoan.IconRight = null;
            this.txtTenTaiKhoan.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.Lines = new string[0];
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(668, 173);
            this.txtTenTaiKhoan.MaxLength = 32767;
            this.txtTenTaiKhoan.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTenTaiKhoan.Modified = false;
            this.txtTenTaiKhoan.Multiline = false;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenTaiKhoan.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenTaiKhoan.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenTaiKhoan.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenTaiKhoan.OnIdleState = stateProperties16;
            this.txtTenTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenTaiKhoan.PlaceholderText = "Tên tài khoản";
            this.txtTenTaiKhoan.ReadOnly = false;
            this.txtTenTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.SelectionLength = 0;
            this.txtTenTaiKhoan.SelectionStart = 0;
            this.txtTenTaiKhoan.ShortcutsEnabled = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(320, 39);
            this.txtTenTaiKhoan.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTenTaiKhoan.TabIndex = 9;
            this.txtTenTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenTaiKhoan.TextMarginBottom = 0;
            this.txtTenTaiKhoan.TextMarginLeft = 3;
            this.txtTenTaiKhoan.TextMarginTop = 1;
            this.txtTenTaiKhoan.TextPlaceholder = "Tên tài khoản";
            this.txtTenTaiKhoan.UseSystemPasswordChar = false;
            this.txtTenTaiKhoan.WordWrap = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AllowAnimations = true;
            this.btnDangNhap.AllowMouseEffects = true;
            this.btnDangNhap.AllowToggling = false;
            this.btnDangNhap.AnimationSpeed = 200;
            this.btnDangNhap.AutoGenerateColors = false;
            this.btnDangNhap.AutoRoundBorders = false;
            this.btnDangNhap.AutoSizeLeftIcon = true;
            this.btnDangNhap.AutoSizeRightIcon = true;
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.BackgroundImage")));
            this.btnDangNhap.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDangNhap.ButtonText = "ĐĂNG NHẬP";
            this.btnDangNhap.ButtonTextMarginLeft = 0;
            this.btnDangNhap.ColorContrastOnClick = 45;
            this.btnDangNhap.ColorContrastOnHover = 45;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDangNhap.CustomizableEdges = borderEdges2;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangNhap.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDangNhap.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDangNhap.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDangNhap.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDangNhap.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDangNhap.IconLeft = null;
            this.btnDangNhap.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDangNhap.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDangNhap.IconMarginLeft = 11;
            this.btnDangNhap.IconPadding = 10;
            this.btnDangNhap.IconRight = null;
            this.btnDangNhap.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDangNhap.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDangNhap.IconSize = 25;
            this.btnDangNhap.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDangNhap.IdleBorderRadius = 0;
            this.btnDangNhap.IdleBorderThickness = 0;
            this.btnDangNhap.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDangNhap.IdleIconLeftImage = null;
            this.btnDangNhap.IdleIconRightImage = null;
            this.btnDangNhap.IndicateFocus = false;
            this.btnDangNhap.Location = new System.Drawing.Point(621, 359);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDangNhap.OnDisabledState.BorderRadius = 1;
            this.btnDangNhap.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDangNhap.OnDisabledState.BorderThickness = 1;
            this.btnDangNhap.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDangNhap.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDangNhap.OnDisabledState.IconLeftImage = null;
            this.btnDangNhap.OnDisabledState.IconRightImage = null;
            this.btnDangNhap.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnDangNhap.onHoverState.BorderRadius = 1;
            this.btnDangNhap.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDangNhap.onHoverState.BorderThickness = 1;
            this.btnDangNhap.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnDangNhap.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDangNhap.onHoverState.IconLeftImage = null;
            this.btnDangNhap.onHoverState.IconRightImage = null;
            this.btnDangNhap.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnDangNhap.OnIdleState.BorderRadius = 1;
            this.btnDangNhap.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDangNhap.OnIdleState.BorderThickness = 1;
            this.btnDangNhap.OnIdleState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnDangNhap.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDangNhap.OnIdleState.IconLeftImage = null;
            this.btnDangNhap.OnIdleState.IconRightImage = null;
            this.btnDangNhap.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnDangNhap.OnPressedState.BorderRadius = 1;
            this.btnDangNhap.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDangNhap.OnPressedState.BorderThickness = 1;
            this.btnDangNhap.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnDangNhap.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.OnPressedState.IconLeftImage = null;
            this.btnDangNhap.OnPressedState.IconRightImage = null;
            this.btnDangNhap.Size = new System.Drawing.Size(367, 39);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangNhap.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangNhap.TextMarginLeft = 0;
            this.btnDangNhap.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDangNhap.UseDefaultRadiusAndThickness = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // picBoxLogin
            // 
            this.picBoxLogin.Image = global::management_store.Properties.Resources.img_337531;
            this.picBoxLogin.Location = new System.Drawing.Point(729, 30);
            this.picBoxLogin.Name = "picBoxLogin";
            this.picBoxLogin.Size = new System.Drawing.Size(174, 93);
            this.picBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogin.TabIndex = 6;
            this.picBoxLogin.TabStop = false;
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.Image = global::management_store.Properties.Resources.key__1_;
            this.picBoxPassword.Location = new System.Drawing.Point(621, 242);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(42, 39);
            this.picBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPassword.TabIndex = 5;
            this.picBoxPassword.TabStop = false;
            // 
            // picBoxUsername
            // 
            this.picBoxUsername.Image = global::management_store.Properties.Resources.user__1_;
            this.picBoxUsername.Location = new System.Drawing.Point(621, 173);
            this.picBoxUsername.Name = "picBoxUsername";
            this.picBoxUsername.Size = new System.Drawing.Size(42, 39);
            this.picBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsername.TabIndex = 5;
            this.picBoxUsername.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1038, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.loaderDangNhap);
            this.Controls.Add(this.pnlRoles);
            this.Controls.Add(this.picBoxLogin);
            this.Controls.Add(this.picBoxPassword);
            this.Controls.Add(this.picBoxUsername);
            this.Controls.Add(this.btnPower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDangNhap_MouseDown);
            this.pnlRoles.ResumeLayout(false);
            this.pnlRoles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.PictureBox picBoxUsername;
        private System.Windows.Forms.PictureBox picBoxPassword;
        private System.Windows.Forms.PictureBox picBoxLogin;
        private System.Windows.Forms.Panel pnlRoles;
        private Bunifu.UI.WinForms.BunifuLoader loaderDangNhap;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDangNhap;
        private Bunifu.UI.WinForms.BunifuTextBox txtTenTaiKhoan;
        private Bunifu.UI.WinForms.BunifuTextBox txtMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblNhanVien;
        private Bunifu.UI.WinForms.BunifuRadioButton rdbAdmin;
        private Bunifu.UI.WinForms.BunifuRadioButton rdbNhanVien;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}

