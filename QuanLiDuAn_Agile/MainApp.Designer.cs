namespace QuanLiDuAn_Agile
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grb_Find = new GroupBox();
            btn_Find = new Button();
            cbo_Find = new ComboBox();
            txt_Find = new TextBox();
            grb_ChiTiet = new GroupBox();
            lb_SoLuongNhap = new Label();
            lb_GiaNhap = new Label();
            lb_Name = new Label();
            lb_Id = new Label();
            txt_SoLuongNhap = new TextBox();
            txt_GiaNhap = new TextBox();
            txt_Name = new TextBox();
            txt_Id = new TextBox();
            btn_Add = new Button();
            btn_Update = new Button();
            btn_Del = new Button();
            btn_Show = new Button();
            btn_reset = new Button();
            groupBox2 = new GroupBox();
            dgv_SanPham = new DataGridView();
            SortByPriceBtn = new Button();
            grb_Find.SuspendLayout();
            grb_ChiTiet.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).BeginInit();
            SuspendLayout();
            // 
            // grb_Find
            // 
            grb_Find.Controls.Add(btn_Find);
            grb_Find.Controls.Add(cbo_Find);
            grb_Find.Controls.Add(txt_Find);
            grb_Find.Location = new Point(21, 7);
            grb_Find.Margin = new Padding(3, 4, 3, 4);
            grb_Find.Name = "grb_Find";
            grb_Find.Padding = new Padding(3, 4, 3, 4);
            grb_Find.Size = new Size(979, 99);
            grb_Find.TabIndex = 0;
            grb_Find.TabStop = false;
            grb_Find.Text = "Tìm kiếm ";
            // 
            // btn_Find
            // 
            btn_Find.Location = new Point(858, 29);
            btn_Find.Margin = new Padding(3, 4, 3, 4);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(102, 40);
            btn_Find.TabIndex = 2;
            btn_Find.Text = "Tìm kiếm";
            btn_Find.UseVisualStyleBackColor = true;
            btn_Find.Click += btn_Find_Click;
            // 
            // cbo_Find
            // 
            cbo_Find.FormattingEnabled = true;
            cbo_Find.Items.AddRange(new object[] { "ID", "Tên sản phẩm", "Giá nhập", "Số lượng nhập" });
            cbo_Find.Location = new Point(711, 35);
            cbo_Find.Margin = new Padding(3, 4, 3, 4);
            cbo_Find.Name = "cbo_Find";
            cbo_Find.Size = new Size(126, 28);
            cbo_Find.TabIndex = 1;
            // 
            // txt_Find
            // 
            txt_Find.Location = new Point(29, 35);
            txt_Find.Margin = new Padding(3, 4, 3, 4);
            txt_Find.Name = "txt_Find";
            txt_Find.Size = new Size(675, 27);
            txt_Find.TabIndex = 0;
            // 
            // grb_ChiTiet
            // 
            grb_ChiTiet.Controls.Add(lb_SoLuongNhap);
            grb_ChiTiet.Controls.Add(lb_GiaNhap);
            grb_ChiTiet.Controls.Add(lb_Name);
            grb_ChiTiet.Controls.Add(lb_Id);
            grb_ChiTiet.Controls.Add(txt_SoLuongNhap);
            grb_ChiTiet.Controls.Add(txt_GiaNhap);
            grb_ChiTiet.Controls.Add(txt_Name);
            grb_ChiTiet.Controls.Add(txt_Id);
            grb_ChiTiet.Location = new Point(19, 120);
            grb_ChiTiet.Margin = new Padding(3, 4, 3, 4);
            grb_ChiTiet.Name = "grb_ChiTiet";
            grb_ChiTiet.Padding = new Padding(3, 4, 3, 4);
            grb_ChiTiet.Size = new Size(754, 421);
            grb_ChiTiet.TabIndex = 1;
            grb_ChiTiet.TabStop = false;
            grb_ChiTiet.Text = "   ";
            // 
            // lb_SoLuongNhap
            // 
            lb_SoLuongNhap.AutoSize = true;
            lb_SoLuongNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_SoLuongNhap.Location = new Point(30, 313);
            lb_SoLuongNhap.Name = "lb_SoLuongNhap";
            lb_SoLuongNhap.Size = new Size(124, 22);
            lb_SoLuongNhap.TabIndex = 7;
            lb_SoLuongNhap.Text = "Số lượng nhập";
            // 
            // lb_GiaNhap
            // 
            lb_GiaNhap.AutoSize = true;
            lb_GiaNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_GiaNhap.Location = new Point(30, 223);
            lb_GiaNhap.Name = "lb_GiaNhap";
            lb_GiaNhap.Size = new Size(81, 22);
            lb_GiaNhap.TabIndex = 6;
            lb_GiaNhap.Text = "Giá nhập";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Name.Location = new Point(30, 141);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(123, 22);
            lb_Name.TabIndex = 5;
            lb_Name.Text = "Tên sản phẩm ";
            // 
            // lb_Id
            // 
            lb_Id.AutoSize = true;
            lb_Id.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Id.Location = new Point(30, 61);
            lb_Id.Name = "lb_Id";
            lb_Id.Size = new Size(30, 22);
            lb_Id.TabIndex = 4;
            lb_Id.Text = "ID";
            // 
            // txt_SoLuongNhap
            // 
            txt_SoLuongNhap.Location = new Point(159, 313);
            txt_SoLuongNhap.Margin = new Padding(3, 4, 3, 4);
            txt_SoLuongNhap.Name = "txt_SoLuongNhap";
            txt_SoLuongNhap.Size = new Size(579, 27);
            txt_SoLuongNhap.TabIndex = 3;
            // 
            // txt_GiaNhap
            // 
            txt_GiaNhap.Location = new Point(159, 223);
            txt_GiaNhap.Margin = new Padding(3, 4, 3, 4);
            txt_GiaNhap.Name = "txt_GiaNhap";
            txt_GiaNhap.Size = new Size(579, 27);
            txt_GiaNhap.TabIndex = 2;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(159, 141);
            txt_Name.Margin = new Padding(3, 4, 3, 4);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(579, 27);
            txt_Name.TabIndex = 1;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(159, 61);
            txt_Id.Margin = new Padding(3, 4, 3, 4);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(579, 27);
            txt_Id.TabIndex = 0;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(807, 135);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(171, 47);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(807, 207);
            btn_Update.Margin = new Padding(3, 4, 3, 4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(171, 47);
            btn_Update.TabIndex = 3;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(807, 283);
            btn_Del.Margin = new Padding(3, 4, 3, 4);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(171, 47);
            btn_Del.TabIndex = 4;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(807, 354);
            btn_Show.Margin = new Padding(3, 4, 3, 4);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(171, 47);
            btn_Show.TabIndex = 5;
            btn_Show.Text = "Hiển thị";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(807, 494);
            btn_reset.Margin = new Padding(3, 4, 3, 4);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(171, 47);
            btn_reset.TabIndex = 6;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_SanPham);
            groupBox2.Location = new Point(19, 552);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(974, 431);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mặt hàng bán chạy";
            // 
            // dgv_SanPham
            // 
            dgv_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham.Location = new Point(7, 29);
            dgv_SanPham.Margin = new Padding(3, 4, 3, 4);
            dgv_SanPham.Name = "dgv_SanPham";
            dgv_SanPham.RowHeadersWidth = 51;
            dgv_SanPham.RowTemplate.Height = 25;
            dgv_SanPham.Size = new Size(960, 393);
            dgv_SanPham.TabIndex = 0;
            dgv_SanPham.CellClick += dgv_SanPham_CellClick;
            // 
            // SortByPriceBtn
            // 
            SortByPriceBtn.Location = new Point(807, 421);
            SortByPriceBtn.Margin = new Padding(3, 4, 3, 4);
            SortByPriceBtn.Name = "SortByPriceBtn";
            SortByPriceBtn.Size = new Size(171, 47);
            SortByPriceBtn.TabIndex = 8;
            SortByPriceBtn.Text = "Sắp xếp theo giá";
            SortByPriceBtn.UseVisualStyleBackColor = true;
            SortByPriceBtn.Click += SortByPriceBtn_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1010, 999);
            Controls.Add(SortByPriceBtn);
            Controls.Add(groupBox2);
            Controls.Add(btn_reset);
            Controls.Add(btn_Show);
            Controls.Add(btn_Del);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(grb_ChiTiet);
            Controls.Add(grb_Find);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainApp";
            Text = "Form1";
            Load += MainApp_Load;
            grb_Find.ResumeLayout(false);
            grb_Find.PerformLayout();
            grb_ChiTiet.ResumeLayout(false);
            grb_ChiTiet.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_Find;
        private Button btn_Find;
        private ComboBox cbo_Find;
        private TextBox txt_Find;
        private GroupBox grb_ChiTiet;
        private TextBox txt_SoLuongNhap;
        private TextBox txt_GiaNhap;
        private TextBox txt_Name;
        private TextBox txt_Id;
        private Label lb_SoLuongNhap;
        private Label lb_GiaNhap;
        private Label lb_Name;
        private Label lb_Id;
        private Button btn_Add;
        private Button btn_Update;
        private Button btn_Del;
        private Button btn_Show;
        private Button btn_reset;
        private GroupBox groupBox2;
        private DataGridView dgv_SanPham;
        private Button SortByPriceBtn;
    }
}