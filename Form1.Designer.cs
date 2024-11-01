namespace Oracle_QTCSDL
{
    partial class Form1
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbMaSach = new Label();
            lbTenSach = new Label();
            lbNXB = new Label();
            lbTacGia = new Label();
            lbGia = new Label();
            button4 = new Button();
            button5 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(512, 12);
            button1.Name = "button1";
            button1.Size = new Size(204, 42);
            button1.TabIndex = 0;
            button1.Text = "Tổng giá sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(730, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 42);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(730, 68);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 42);
            textBox2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(839, 278);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(512, 68);
            button2.Name = "button2";
            button2.Size = new Size(204, 42);
            button2.TabIndex = 5;
            button2.Text = "Giá trung bình 1 cuốn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(512, 122);
            button3.Name = "button3";
            button3.Size = new Size(204, 42);
            button3.TabIndex = 6;
            button3.Text = "Giá sách của NXB Kim Đồng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(730, 122);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 42);
            textBox3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 71);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 107);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 10;
            label3.Text = "NXB:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 139);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 11;
            label4.Text = "Tác giả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 172);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 12;
            label5.Text = "Giá:";
            // 
            // lbMaSach
            // 
            lbMaSach.AutoSize = true;
            lbMaSach.Location = new Point(140, 40);
            lbMaSach.Name = "lbMaSach";
            lbMaSach.Size = new Size(0, 20);
            lbMaSach.TabIndex = 13;
            // 
            // lbTenSach
            // 
            lbTenSach.AutoSize = true;
            lbTenSach.Location = new Point(140, 71);
            lbTenSach.Name = "lbTenSach";
            lbTenSach.Size = new Size(0, 20);
            lbTenSach.TabIndex = 14;
            // 
            // lbNXB
            // 
            lbNXB.AutoSize = true;
            lbNXB.Location = new Point(140, 107);
            lbNXB.Name = "lbNXB";
            lbNXB.Size = new Size(0, 20);
            lbNXB.TabIndex = 15;
            // 
            // lbTacGia
            // 
            lbTacGia.AutoSize = true;
            lbTacGia.Location = new Point(140, 139);
            lbTacGia.Name = "lbTacGia";
            lbTacGia.Size = new Size(0, 20);
            lbTacGia.TabIndex = 16;
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.Location = new Point(140, 172);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(0, 20);
            lbGia.TabIndex = 17;
            // 
            // button4
            // 
            button4.Location = new Point(601, 178);
            button4.Name = "button4";
            button4.Size = new Size(115, 35);
            button4.TabIndex = 18;
            button4.Text = "Cập nhật";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(730, 178);
            button5.Name = "button5";
            button5.Size = new Size(115, 35);
            button5.TabIndex = 19;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(158, 1);
            label6.Name = "label6";
            label6.Size = new Size(210, 38);
            label6.TabIndex = 20;
            label6.Text = "Thông tin sách";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 518);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(lbGia);
            Controls.Add(lbTacGia);
            Controls.Add(lbNXB);
            Controls.Add(lbTenSach);
            Controls.Add(lbMaSach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbMaSach;
        private Label lbTenSach;
        private Label lbNXB;
        private Label lbTacGia;
        private Label lbGia;
        private Button button4;
        private Button button5;
        private Label label6;
    }
}
