namespace calculator
{
    partial class Calculator
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.PercentBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.BtComma = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.BtHistory = new System.Windows.Forms.Button();
            this.LbValue = new System.Windows.Forms.Label();
            this.LbProcces = new System.Windows.Forms.Label();
            this.BtExponentiation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PercentBtn
            // 
            this.PercentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PercentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PercentBtn.Location = new System.Drawing.Point(68, 185);
            this.PercentBtn.Name = "PercentBtn";
            this.PercentBtn.Size = new System.Drawing.Size(57, 55);
            this.PercentBtn.TabIndex = 1;
            this.PercentBtn.Text = "%";
            this.PercentBtn.UseVisualStyleBackColor = true;
            this.PercentBtn.Click += new System.EventHandler(this.PercentBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlusBtn.Location = new System.Drawing.Point(147, 185);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(57, 55);
            this.PlusBtn.TabIndex = 2;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // SevenBtn
            // 
            this.SevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SevenBtn.Location = new System.Drawing.Point(68, 257);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(57, 55);
            this.SevenBtn.TabIndex = 4;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = true;
            this.SevenBtn.Click += new System.EventHandler(this.SevenBtn_Click);
            // 
            // EightBtn
            // 
            this.EightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EightBtn.Location = new System.Drawing.Point(147, 257);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(57, 55);
            this.EightBtn.TabIndex = 5;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = true;
            this.EightBtn.Click += new System.EventHandler(this.EightBtn_Click);
            // 
            // NineBtn
            // 
            this.NineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NineBtn.Location = new System.Drawing.Point(227, 257);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(57, 55);
            this.NineBtn.TabIndex = 6;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = true;
            this.NineBtn.Click += new System.EventHandler(this.NineBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinusBtn.Location = new System.Drawing.Point(297, 185);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(57, 55);
            this.MinusBtn.TabIndex = 7;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // FourBtn
            // 
            this.FourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FourBtn.Location = new System.Drawing.Point(68, 330);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(57, 55);
            this.FourBtn.TabIndex = 8;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FiveBtn.Location = new System.Drawing.Point(147, 330);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(57, 55);
            this.FiveBtn.TabIndex = 9;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click);
            // 
            // SixBtn
            // 
            this.SixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SixBtn.Location = new System.Drawing.Point(227, 330);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(57, 55);
            this.SixBtn.TabIndex = 10;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = true;
            this.SixBtn.Click += new System.EventHandler(this.SixBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MultiplyBtn.Location = new System.Drawing.Point(297, 257);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(57, 55);
            this.MultiplyBtn.TabIndex = 11;
            this.MultiplyBtn.Text = "X";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // OneBtn
            // 
            this.OneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OneBtn.Location = new System.Drawing.Point(68, 401);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(57, 55);
            this.OneBtn.TabIndex = 12;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TwoBtn.Location = new System.Drawing.Point(147, 401);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(57, 55);
            this.TwoBtn.TabIndex = 13;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ThreeBtn.Location = new System.Drawing.Point(227, 401);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(57, 55);
            this.ThreeBtn.TabIndex = 14;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DivideBtn.Location = new System.Drawing.Point(297, 330);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(57, 55);
            this.DivideBtn.TabIndex = 15;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearBtn.Location = new System.Drawing.Point(227, 185);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(57, 55);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.Text = "C";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // BtComma
            // 
            this.BtComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtComma.Location = new System.Drawing.Point(297, 401);
            this.BtComma.Name = "BtComma";
            this.BtComma.Size = new System.Drawing.Size(57, 55);
            this.BtComma.TabIndex = 17;
            this.BtComma.Text = ",";
            this.BtComma.UseVisualStyleBackColor = true;
            this.BtComma.Click += new System.EventHandler(this.BtComma_Click_1);
            // 
            // EqualBtn
            // 
            this.EqualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EqualBtn.Location = new System.Drawing.Point(147, 462);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(136, 55);
            this.EqualBtn.TabIndex = 18;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = true;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZeroBtn.Location = new System.Drawing.Point(68, 462);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(57, 55);
            this.ZeroBtn.TabIndex = 19;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // BtHistory
            // 
            this.BtHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtHistory.Location = new System.Drawing.Point(147, 529);
            this.BtHistory.Name = "BtHistory";
            this.BtHistory.Size = new System.Drawing.Size(137, 31);
            this.BtHistory.TabIndex = 20;
            this.BtHistory.Text = "History";
            this.BtHistory.UseVisualStyleBackColor = true;
            this.BtHistory.Click += new System.EventHandler(this.BtHistory_Click);
            // 
            // LbValue
            // 
            this.LbValue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LbValue.ForeColor = System.Drawing.Color.Black;
            this.LbValue.Location = new System.Drawing.Point(51, 22);
            this.LbValue.Name = "LbValue";
            this.LbValue.Size = new System.Drawing.Size(334, 42);
            this.LbValue.TabIndex = 22;
            this.LbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbProcces
            // 
            this.LbProcces.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LbProcces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbProcces.ForeColor = System.Drawing.Color.Aqua;
            this.LbProcces.Location = new System.Drawing.Point(87, 125);
            this.LbProcces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbProcces.Name = "LbProcces";
            this.LbProcces.Size = new System.Drawing.Size(242, 28);
            this.LbProcces.TabIndex = 113;
            this.LbProcces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtExponentiation
            // 
            this.BtExponentiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtExponentiation.Location = new System.Drawing.Point(297, 462);
            this.BtExponentiation.Name = "BtExponentiation";
            this.BtExponentiation.Size = new System.Drawing.Size(57, 55);
            this.BtExponentiation.TabIndex = 114;
            this.BtExponentiation.Text = "xʸ";
            this.BtExponentiation.UseVisualStyleBackColor = true;
            this.BtExponentiation.Click += new System.EventHandler(this.BtExponentiation_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 648);
            this.Controls.Add(this.BtExponentiation);
            this.Controls.Add(this.LbProcces);
            this.Controls.Add(this.LbValue);
            this.Controls.Add(this.BtHistory);
            this.Controls.Add(this.ZeroBtn);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.BtComma);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.ThreeBtn);
            this.Controls.Add(this.TwoBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SixBtn);
            this.Controls.Add(this.FiveBtn);
            this.Controls.Add(this.FourBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.NineBtn);
            this.Controls.Add(this.EightBtn);
            this.Controls.Add(this.SevenBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.PercentBtn);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PercentBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button BtComma;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button BtHistory;
        private System.Windows.Forms.Label LbValue;
        private System.Windows.Forms.Label LbProcces;
        private System.Windows.Forms.Button BtExponentiation;
    }
}

