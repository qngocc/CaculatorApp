namespace Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lb_input = new Label();
            btb_ac = new Button();
            btb_ce = new Button();
            btb_chiadu = new Button();
            btb_chia = new Button();
            btb_7 = new Button();
            btb_8 = new Button();
            btb_9 = new Button();
            btb_nhan = new Button();
            btb_4 = new Button();
            btb_5 = new Button();
            btb_6 = new Button();
            btb_tru = new Button();
            btb_1 = new Button();
            btb_2 = new Button();
            btb_3 = new Button();
            btb_cong = new Button();
            btb_no = new Button();
            btb_0 = new Button();
            btb_cham = new Button();
            btb_bang = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(lb_input);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 138);
            panel1.TabIndex = 0;
            // 
            // lb_input
            // 
            lb_input.Dock = DockStyle.Fill;
            lb_input.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_input.Location = new Point(0, 0);
            lb_input.Name = "lb_input";
            lb_input.Size = new Size(266, 138);
            lb_input.TabIndex = 0;
            lb_input.Text = "0";
            lb_input.TextAlign = ContentAlignment.BottomRight;
            // 
            // btb_ac
            // 
            btb_ac.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_ac.Location = new Point(12, 170);
            btb_ac.Name = "btb_ac";
            btb_ac.Size = new Size(62, 51);
            btb_ac.TabIndex = 1;
            btb_ac.Text = "AC";
            btb_ac.UseVisualStyleBackColor = true;
            btb_ac.Click += btb_ac_Click;
            // 
            // btb_ce
            // 
            btb_ce.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_ce.Location = new Point(80, 170);
            btb_ce.Name = "btb_ce";
            btb_ce.Size = new Size(62, 51);
            btb_ce.TabIndex = 2;
            btb_ce.Text = "CE";
            btb_ce.UseVisualStyleBackColor = true;
            btb_ce.Click += btb_ce_Click;
            // 
            // btb_chiadu
            // 
            btb_chiadu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_chiadu.Location = new Point(148, 170);
            btb_chiadu.Name = "btb_chiadu";
            btb_chiadu.Size = new Size(62, 51);
            btb_chiadu.TabIndex = 3;
            btb_chiadu.Text = "%";
            btb_chiadu.UseVisualStyleBackColor = true;
            btb_chiadu.Click += xulyPhepToan;
            // 
            // btb_chia
            // 
            btb_chia.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_chia.Location = new Point(216, 170);
            btb_chia.Name = "btb_chia";
            btb_chia.Size = new Size(62, 51);
            btb_chia.TabIndex = 4;
            btb_chia.Text = "÷";
            btb_chia.UseVisualStyleBackColor = true;
            btb_chia.Click += xulyPhepToan;
            // 
            // btb_7
            // 
            btb_7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_7.Location = new Point(12, 227);
            btb_7.Name = "btb_7";
            btb_7.Size = new Size(62, 51);
            btb_7.TabIndex = 5;
            btb_7.Text = "7";
            btb_7.UseVisualStyleBackColor = true;
            btb_7.Click += xuLy_Click;
            // 
            // btb_8
            // 
            btb_8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_8.Location = new Point(80, 227);
            btb_8.Name = "btb_8";
            btb_8.Size = new Size(62, 51);
            btb_8.TabIndex = 6;
            btb_8.Text = "8";
            btb_8.UseVisualStyleBackColor = true;
            btb_8.Click += xuLy_Click;
            // 
            // btb_9
            // 
            btb_9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_9.Location = new Point(148, 227);
            btb_9.Name = "btb_9";
            btb_9.Size = new Size(62, 51);
            btb_9.TabIndex = 7;
            btb_9.Text = "9";
            btb_9.UseVisualStyleBackColor = true;
            btb_9.Click += xuLy_Click;
            // 
            // btb_nhan
            // 
            btb_nhan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_nhan.Location = new Point(218, 227);
            btb_nhan.Name = "btb_nhan";
            btb_nhan.Size = new Size(62, 51);
            btb_nhan.TabIndex = 8;
            btb_nhan.Text = "x";
            btb_nhan.UseVisualStyleBackColor = true;
            btb_nhan.Click += xulyPhepToan;
            // 
            // btb_4
            // 
            btb_4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_4.Location = new Point(12, 284);
            btb_4.Name = "btb_4";
            btb_4.Size = new Size(62, 51);
            btb_4.TabIndex = 9;
            btb_4.Text = "4";
            btb_4.UseVisualStyleBackColor = true;
            btb_4.Click += xuLy_Click;
            // 
            // btb_5
            // 
            btb_5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_5.Location = new Point(80, 284);
            btb_5.Name = "btb_5";
            btb_5.Size = new Size(62, 51);
            btb_5.TabIndex = 10;
            btb_5.Text = "5";
            btb_5.UseVisualStyleBackColor = true;
            btb_5.Click += xuLy_Click;
            // 
            // btb_6
            // 
            btb_6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_6.Location = new Point(148, 284);
            btb_6.Name = "btb_6";
            btb_6.Size = new Size(62, 51);
            btb_6.TabIndex = 11;
            btb_6.Text = "6";
            btb_6.UseVisualStyleBackColor = true;
            btb_6.Click += xuLy_Click;
            // 
            // btb_tru
            // 
            btb_tru.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_tru.Location = new Point(218, 284);
            btb_tru.Name = "btb_tru";
            btb_tru.Size = new Size(62, 51);
            btb_tru.TabIndex = 12;
            btb_tru.Text = "-";
            btb_tru.UseVisualStyleBackColor = true;
            btb_tru.Click += xulyPhepToan;
            // 
            // btb_1
            // 
            btb_1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_1.Location = new Point(12, 341);
            btb_1.Name = "btb_1";
            btb_1.Size = new Size(62, 51);
            btb_1.TabIndex = 13;
            btb_1.Text = "1";
            btb_1.UseVisualStyleBackColor = true;
            btb_1.Click += xuLy_Click;
            // 
            // btb_2
            // 
            btb_2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_2.Location = new Point(80, 341);
            btb_2.Name = "btb_2";
            btb_2.Size = new Size(62, 51);
            btb_2.TabIndex = 14;
            btb_2.Text = "2";
            btb_2.UseVisualStyleBackColor = true;
            btb_2.Click += xuLy_Click;
            // 
            // btb_3
            // 
            btb_3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_3.Location = new Point(148, 341);
            btb_3.Name = "btb_3";
            btb_3.Size = new Size(62, 51);
            btb_3.TabIndex = 15;
            btb_3.Text = "3";
            btb_3.UseVisualStyleBackColor = true;
            btb_3.Click += xuLy_Click;
            // 
            // btb_cong
            // 
            btb_cong.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_cong.Location = new Point(218, 341);
            btb_cong.Name = "btb_cong";
            btb_cong.Size = new Size(62, 51);
            btb_cong.TabIndex = 16;
            btb_cong.Text = "+";
            btb_cong.UseVisualStyleBackColor = true;
            btb_cong.Click += xulyPhepToan;
            // 
            // btb_no
            // 
            btb_no.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_no.Location = new Point(12, 398);
            btb_no.Name = "btb_no";
            btb_no.Size = new Size(62, 51);
            btb_no.TabIndex = 17;
            btb_no.Text = "NO";
            btb_no.UseVisualStyleBackColor = true;
            // 
            // btb_0
            // 
            btb_0.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_0.Location = new Point(80, 398);
            btb_0.Name = "btb_0";
            btb_0.Size = new Size(62, 51);
            btb_0.TabIndex = 18;
            btb_0.Text = "0";
            btb_0.UseVisualStyleBackColor = true;
            btb_0.Click += xuLy_Click;
            // 
            // btb_cham
            // 
            btb_cham.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btb_cham.Location = new Point(148, 398);
            btb_cham.Name = "btb_cham";
            btb_cham.Size = new Size(62, 51);
            btb_cham.TabIndex = 19;
            btb_cham.Text = ".";
            btb_cham.UseVisualStyleBackColor = true;
            btb_cham.Click += xuLy_Click;
            // 
            // btb_bang
            // 
            btb_bang.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btb_bang.Location = new Point(216, 398);
            btb_bang.Name = "btb_bang";
            btb_bang.Size = new Size(62, 51);
            btb_bang.TabIndex = 20;
            btb_bang.Text = "=";
            btb_bang.UseVisualStyleBackColor = true;
            btb_bang.Click += xulyKQ_Click;
            // 
            // Form1
            // 
            AcceptButton = btb_tru;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 469);
            Controls.Add(btb_bang);
            Controls.Add(btb_cham);
            Controls.Add(btb_0);
            Controls.Add(btb_no);
            Controls.Add(btb_cong);
            Controls.Add(btb_3);
            Controls.Add(btb_2);
            Controls.Add(btb_1);
            Controls.Add(btb_tru);
            Controls.Add(btb_6);
            Controls.Add(btb_5);
            Controls.Add(btb_4);
            Controls.Add(btb_nhan);
            Controls.Add(btb_9);
            Controls.Add(btb_8);
            Controls.Add(btb_7);
            Controls.Add(btb_chia);
            Controls.Add(btb_chiadu);
            Controls.Add(btb_ce);
            Controls.Add(btb_ac);
            Controls.Add(panel1);
            ForeColor = SystemColors.Desktop;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Caculator";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lb_input;
        private Button btb_ac;
        private Button btb_ce;
        private Button btb_chiadu;
        private Button btb_chia;
        private Button btb_7;
        private Button btb_8;
        private Button btb_9;
        private Button btb_nhan;
        private Button btb_4;
        private Button btb_5;
        private Button btb_6;
        private Button btb_tru;
        private Button btb_1;
        private Button btb_2;
        private Button btb_3;
        private Button btb_cong;
        private Button btb_no;
        private Button btb_0;
        private Button btb_cham;
        private Button btb_bang;
    }
}
