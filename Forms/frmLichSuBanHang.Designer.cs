﻿
namespace management_store
{
    partial class frmLichSuaBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuaBanHang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachHoaDon = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnDong = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(318, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "LỊCH SỬ BÁN HÀNG";
            // 
            // dgvDanhSachHoaDon
            // 
            this.dgvDanhSachHoaDon.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHoaDon.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvDanhSachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachHoaDon.ColumnHeadersHeight = 40;
            this.dgvDanhSachHoaDon.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDanhSachHoaDon.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDanhSachHoaDon.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachHoaDon.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDanhSachHoaDon.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachHoaDon.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachHoaDon.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDanhSachHoaDon.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDanhSachHoaDon.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDanhSachHoaDon.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachHoaDon.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvDanhSachHoaDon.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDanhSachHoaDon.CurrentTheme.Name = null;
            this.dgvDanhSachHoaDon.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachHoaDon.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDanhSachHoaDon.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachHoaDon.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDanhSachHoaDon.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachHoaDon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDanhSachHoaDon.EnableHeadersVisualStyles = false;
            this.dgvDanhSachHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDanhSachHoaDon.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDanhSachHoaDon.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDanhSachHoaDon.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDanhSachHoaDon.Location = new System.Drawing.Point(12, 82);
            this.dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            this.dgvDanhSachHoaDon.RowHeadersVisible = false;
            this.dgvDanhSachHoaDon.RowTemplate.Height = 40;
            this.dgvDanhSachHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachHoaDon.Size = new System.Drawing.Size(841, 515);
            this.dgvDanhSachHoaDon.TabIndex = 1;
            this.dgvDanhSachHoaDon.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvDanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoaDon_CellClick);
            this.dgvDanhSachHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoaDon_CellDoubleClick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnDong
            // 
            this.btnDong.AllowAnimations = true;
            this.btnDong.AllowMouseEffects = true;
            this.btnDong.AllowToggling = false;
            this.btnDong.AnimationSpeed = 200;
            this.btnDong.AutoGenerateColors = false;
            this.btnDong.AutoRoundBorders = false;
            this.btnDong.AutoSizeLeftIcon = true;
            this.btnDong.AutoSizeRightIcon = true;
            this.btnDong.BackColor = System.Drawing.Color.Transparent;
            this.btnDong.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDong.BackgroundImage")));
            this.btnDong.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDong.ButtonText = "Đóng";
            this.btnDong.ButtonTextMarginLeft = 0;
            this.btnDong.ColorContrastOnClick = 45;
            this.btnDong.ColorContrastOnHover = 45;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDong.CustomizableEdges = borderEdges1;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDong.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDong.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDong.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDong.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDong.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.IconLeft = null;
            this.btnDong.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDong.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDong.IconMarginLeft = 11;
            this.btnDong.IconPadding = 10;
            this.btnDong.IconRight = null;
            this.btnDong.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDong.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDong.IconSize = 25;
            this.btnDong.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDong.IdleBorderRadius = 0;
            this.btnDong.IdleBorderThickness = 0;
            this.btnDong.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDong.IdleIconLeftImage = null;
            this.btnDong.IdleIconRightImage = null;
            this.btnDong.IndicateFocus = false;
            this.btnDong.Location = new System.Drawing.Point(12, 604);
            this.btnDong.Name = "btnDong";
            this.btnDong.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDong.OnDisabledState.BorderRadius = 1;
            this.btnDong.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDong.OnDisabledState.BorderThickness = 1;
            this.btnDong.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDong.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDong.OnDisabledState.IconLeftImage = null;
            this.btnDong.OnDisabledState.IconRightImage = null;
            this.btnDong.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDong.onHoverState.BorderRadius = 1;
            this.btnDong.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDong.onHoverState.BorderThickness = 1;
            this.btnDong.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDong.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDong.onHoverState.IconLeftImage = null;
            this.btnDong.onHoverState.IconRightImage = null;
            this.btnDong.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDong.OnIdleState.BorderRadius = 1;
            this.btnDong.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDong.OnIdleState.BorderThickness = 1;
            this.btnDong.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDong.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDong.OnIdleState.IconLeftImage = null;
            this.btnDong.OnIdleState.IconRightImage = null;
            this.btnDong.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDong.OnPressedState.BorderRadius = 1;
            this.btnDong.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDong.OnPressedState.BorderThickness = 1;
            this.btnDong.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDong.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDong.OnPressedState.IconLeftImage = null;
            this.btnDong.OnPressedState.IconRightImage = null;
            this.btnDong.Size = new System.Drawing.Size(899, 45);
            this.btnDong.TabIndex = 2;
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDong.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDong.TextMarginLeft = 0;
            this.btnDong.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDong.UseDefaultRadiusAndThickness = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AllowAnimations = true;
            this.btnXoa.AllowMouseEffects = true;
            this.btnXoa.AllowToggling = false;
            this.btnXoa.AnimationSpeed = 200;
            this.btnXoa.AutoGenerateColors = false;
            this.btnXoa.AutoRoundBorders = false;
            this.btnXoa.AutoSizeLeftIcon = true;
            this.btnXoa.AutoSizeRightIcon = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.ButtonTextMarginLeft = 0;
            this.btnXoa.ColorContrastOnClick = 45;
            this.btnXoa.ColorContrastOnHover = 45;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnXoa.CustomizableEdges = borderEdges2;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnXoa.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnXoa.Enabled = false;
            this.btnXoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXoa.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconLeft = null;
            this.btnXoa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXoa.IconMarginLeft = 11;
            this.btnXoa.IconPadding = 10;
            this.btnXoa.IconRight = null;
            this.btnXoa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXoa.IconSize = 25;
            this.btnXoa.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnXoa.IdleBorderRadius = 0;
            this.btnXoa.IdleBorderThickness = 0;
            this.btnXoa.IdleFillColor = System.Drawing.Color.Empty;
            this.btnXoa.IdleIconLeftImage = null;
            this.btnXoa.IdleIconRightImage = null;
            this.btnXoa.IndicateFocus = false;
            this.btnXoa.Location = new System.Drawing.Point(859, 82);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXoa.OnDisabledState.BorderRadius = 1;
            this.btnXoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnDisabledState.BorderThickness = 1;
            this.btnXoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoa.OnDisabledState.IconLeftImage = null;
            this.btnXoa.OnDisabledState.IconRightImage = null;
            this.btnXoa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnXoa.onHoverState.BorderRadius = 1;
            this.btnXoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.onHoverState.BorderThickness = 1;
            this.btnXoa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnXoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.onHoverState.IconLeftImage = null;
            this.btnXoa.onHoverState.IconRightImage = null;
            this.btnXoa.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OnIdleState.BorderRadius = 1;
            this.btnXoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnIdleState.BorderThickness = 1;
            this.btnXoa.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnIdleState.IconLeftImage = null;
            this.btnXoa.OnIdleState.IconRightImage = null;
            this.btnXoa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.BorderRadius = 1;
            this.btnXoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoa.OnPressedState.BorderThickness = 1;
            this.btnXoa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXoa.OnPressedState.IconLeftImage = null;
            this.btnXoa.OnPressedState.IconRightImage = null;
            this.btnXoa.Size = new System.Drawing.Size(52, 515);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.TextMarginLeft = 0;
            this.btnXoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXoa.UseDefaultRadiusAndThickness = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmLichSuaBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(923, 656);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDanhSachHoaDon);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLichSuaBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLichSuaBanHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDanhSachHoaDon;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDong;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXoa;
    }
}