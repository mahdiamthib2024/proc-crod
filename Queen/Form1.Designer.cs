namespace Queen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_order_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_customer_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_order_status = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_store_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_staff_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.order_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.required_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.shipped_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(55, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order_Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(55, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order_Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.label5.Location = new System.Drawing.Point(55, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Required_Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.label6.Location = new System.Drawing.Point(55, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shipped_Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.label7.Location = new System.Drawing.Point(55, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Store_ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.label8.Location = new System.Drawing.Point(55, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Staff_ID";
            // 
            // text_order_id
            // 
            this.text_order_id.AutoRoundedCorners = true;
            this.text_order_id.BorderRadius = 13;
            this.text_order_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_order_id.DefaultText = "";
            this.text_order_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_order_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_order_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_order_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_order_id.Enabled = false;
            this.text_order_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_order_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_order_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_order_id.Location = new System.Drawing.Point(208, 43);
            this.text_order_id.Name = "text_order_id";
            this.text_order_id.PasswordChar = '\0';
            this.text_order_id.PlaceholderText = "";
            this.text_order_id.SelectedText = "";
            this.text_order_id.Size = new System.Drawing.Size(337, 29);
            this.text_order_id.TabIndex = 8;
            this.text_order_id.TextChanged += new System.EventHandler(this.text_order_id_TextChanged);
            // 
            // text_customer_id
            // 
            this.text_customer_id.AutoRoundedCorners = true;
            this.text_customer_id.BorderRadius = 13;
            this.text_customer_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_customer_id.DefaultText = "";
            this.text_customer_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_customer_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_customer_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_customer_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_customer_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_customer_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_customer_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_customer_id.Location = new System.Drawing.Point(208, 104);
            this.text_customer_id.Name = "text_customer_id";
            this.text_customer_id.PasswordChar = '\0';
            this.text_customer_id.PlaceholderText = "";
            this.text_customer_id.SelectedText = "";
            this.text_customer_id.Size = new System.Drawing.Size(337, 29);
            this.text_customer_id.TabIndex = 9;
            // 
            // text_order_status
            // 
            this.text_order_status.AutoRoundedCorners = true;
            this.text_order_status.BorderRadius = 13;
            this.text_order_status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_order_status.DefaultText = "";
            this.text_order_status.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_order_status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_order_status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_order_status.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_order_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_order_status.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_order_status.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_order_status.Location = new System.Drawing.Point(208, 163);
            this.text_order_status.Name = "text_order_status";
            this.text_order_status.PasswordChar = '\0';
            this.text_order_status.PlaceholderText = "";
            this.text_order_status.SelectedText = "";
            this.text_order_status.Size = new System.Drawing.Size(337, 29);
            this.text_order_status.TabIndex = 10;
            // 
            // text_store_id
            // 
            this.text_store_id.AutoRoundedCorners = true;
            this.text_store_id.BorderRadius = 13;
            this.text_store_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_store_id.DefaultText = "";
            this.text_store_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_store_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_store_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_store_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_store_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_store_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_store_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_store_id.Location = new System.Drawing.Point(208, 404);
            this.text_store_id.Name = "text_store_id";
            this.text_store_id.PasswordChar = '\0';
            this.text_store_id.PlaceholderText = "";
            this.text_store_id.SelectedText = "";
            this.text_store_id.Size = new System.Drawing.Size(337, 29);
            this.text_store_id.TabIndex = 14;
            // 
            // text_staff_id
            // 
            this.text_staff_id.Animated = true;
            this.text_staff_id.AutoRoundedCorners = true;
            this.text_staff_id.BorderRadius = 13;
            this.text_staff_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_staff_id.DefaultText = "";
            this.text_staff_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_staff_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_staff_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_staff_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_staff_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_staff_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_staff_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_staff_id.Location = new System.Drawing.Point(208, 464);
            this.text_staff_id.Name = "text_staff_id";
            this.text_staff_id.PasswordChar = '\0';
            this.text_staff_id.PlaceholderText = "";
            this.text_staff_id.SelectedText = "";
            this.text_staff_id.Size = new System.Drawing.Size(337, 29);
            this.text_staff_id.TabIndex = 15;
            // 
            // dgv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.ColumnHeadersHeight = 4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(570, 23);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(706, 484);
            this.dgv.TabIndex = 16;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 22;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btn_save
            // 
            this.btn_save.Animated = true;
            this.btn_save.AutoRoundedCorners = true;
            this.btn_save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.btn_save.BorderRadius = 21;
            this.btn_save.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_save.BorderThickness = 2;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_save.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.btn_save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(157)))), ((int)(((byte)(4)))));
            this.btn_save.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(150, 551);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(152, 45);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.shipped_date);
            this.guna2Panel1.Controls.Add(this.required_date);
            this.guna2Panel1.Controls.Add(this.order_date);
            this.guna2Panel1.Location = new System.Drawing.Point(28, 23);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(536, 484);
            this.guna2Panel1.TabIndex = 18;
            // 
            // btn_update
            // 
            this.btn_update.Animated = true;
            this.btn_update.AutoRoundedCorners = true;
            this.btn_update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(196)))), ((int)(((byte)(209)))));
            this.btn_update.BorderRadius = 21;
            this.btn_update.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_update.BorderThickness = 2;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_update.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(196)))), ((int)(((byte)(209)))));
            this.btn_update.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(196)))), ((int)(((byte)(209)))));
            this.btn_update.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(337, 551);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(152, 45);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.AutoRoundedCorners = true;
            this.btn_delete.BorderColor = System.Drawing.Color.Red;
            this.btn_delete.BorderRadius = 21;
            this.btn_delete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_delete.BorderThickness = 2;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_delete.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_delete.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_delete.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(537, 551);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(152, 45);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // order_date
            // 
            this.order_date.AutoRoundedCorners = true;
            this.order_date.BorderRadius = 17;
            this.order_date.Checked = true;
            this.order_date.FillColor = System.Drawing.Color.White;
            this.order_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.order_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.order_date.Location = new System.Drawing.Point(180, 197);
            this.order_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.order_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(337, 36);
            this.order_date.TabIndex = 0;
            this.order_date.Value = new System.DateTime(2024, 2, 29, 9, 21, 45, 833);
            // 
            // required_date
            // 
            this.required_date.AutoRoundedCorners = true;
            this.required_date.BorderRadius = 17;
            this.required_date.Checked = true;
            this.required_date.FillColor = System.Drawing.Color.White;
            this.required_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.required_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.required_date.Location = new System.Drawing.Point(180, 258);
            this.required_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.required_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.required_date.Name = "required_date";
            this.required_date.Size = new System.Drawing.Size(337, 36);
            this.required_date.TabIndex = 1;
            this.required_date.Value = new System.DateTime(2024, 2, 29, 9, 21, 45, 833);
            // 
            // shipped_date
            // 
            this.shipped_date.AutoRoundedCorners = true;
            this.shipped_date.BorderRadius = 17;
            this.shipped_date.Checked = true;
            this.shipped_date.FillColor = System.Drawing.Color.White;
            this.shipped_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shipped_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.shipped_date.Location = new System.Drawing.Point(180, 314);
            this.shipped_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.shipped_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.shipped_date.Name = "shipped_date";
            this.shipped_date.Size = new System.Drawing.Size(337, 36);
            this.shipped_date.TabIndex = 2;
            this.shipped_date.Value = new System.DateTime(2024, 2, 29, 9, 21, 45, 833);
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_clear.BorderRadius = 21;
            this.btn_clear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_clear.BorderThickness = 2;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_clear.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_clear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_clear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(748, 551);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(152, 45);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1277, 634);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.text_staff_id);
            this.Controls.Add(this.text_store_id);
            this.Controls.Add(this.text_order_status);
            this.Controls.Add(this.text_customer_id);
            this.Controls.Add(this.text_order_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.MaximumSize = new System.Drawing.Size(1293, 673);
            this.MinimumSize = new System.Drawing.Size(1293, 673);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox text_order_id;
        private Guna.UI2.WinForms.Guna2TextBox text_customer_id;
        private Guna.UI2.WinForms.Guna2TextBox text_order_status;
        private Guna.UI2.WinForms.Guna2TextBox text_store_id;
        private Guna.UI2.WinForms.Guna2TextBox text_staff_id;
        private Guna.UI2.WinForms.Guna2DataGridView dgv;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2DateTimePicker order_date;
        private Guna.UI2.WinForms.Guna2DateTimePicker shipped_date;
        private Guna.UI2.WinForms.Guna2DateTimePicker required_date;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
    }
}

