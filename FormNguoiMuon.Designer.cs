namespace Oracle_QTCSDL
{
    partial class FormNguoiMuon
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
            dataGridView1 = new DataGridView();
            txbMadg = new TextBox();
            txbMaSach = new TextBox();
            txbTendg = new TextBox();
            txbTenSach = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 258);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txbMadg
            // 
            txbMadg.Enabled = false;
            txbMadg.Location = new Point(169, 57);
            txbMadg.Name = "txbMadg";
            txbMadg.Size = new Size(201, 27);
            txbMadg.TabIndex = 1;
            // 
            // txbMaSach
            // 
            txbMaSach.Enabled = false;
            txbMaSach.Location = new Point(169, 90);
            txbMaSach.Name = "txbMaSach";
            txbMaSach.Size = new Size(201, 27);
            txbMaSach.TabIndex = 2;
            // 
            // txbTendg
            // 
            txbTendg.Location = new Point(607, 57);
            txbTendg.Name = "txbTendg";
            txbTendg.Size = new Size(200, 27);
            txbTendg.TabIndex = 2;
            // 
            // txbTenSach
            // 
            txbTenSach.Location = new Point(607, 90);
            txbTenSach.Name = "txbTenSach";
            txbTenSach.Size = new Size(200, 27);
            txbTenSach.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 60);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên độc giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 95);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 5;
            label3.Text = "Mã sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 93);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Tên sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 128);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 7;
            label5.Text = "Ngày mượn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(535, 127);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 8;
            label6.Text = "Ngày trả";
            // 
            // button1
            // 
            button1.Location = new Point(424, 162);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 9;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(169, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(607, 123);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(247, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(342, -6);
            label7.Name = "label7";
            label7.Size = new Size(247, 50);
            label7.TabIndex = 12;
            label7.Text = "Người mượn";
            // 
            // FormNguoiMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 494);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbTenSach);
            Controls.Add(txbTendg);
            Controls.Add(txbMaSach);
            Controls.Add(txbMadg);
            Controls.Add(dataGridView1);
            Name = "FormNguoiMuon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNguoiMuon";
            Load += FormNguoiMuon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txbMadg;
        private TextBox txbMaSach;
        private TextBox txbTendg;
        private TextBox txbTenSach;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label7;
    }
}