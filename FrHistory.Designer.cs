namespace calculator
{
    partial class FrHistory
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
            this.DtCalculatorView = new System.Windows.Forms.DataGridView();
            this.BtDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtCalculatorView)).BeginInit();
            this.SuspendLayout();
            // 
            // DtCalculatorView
            // 
            this.DtCalculatorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtCalculatorView.Location = new System.Drawing.Point(32, 12);
            this.DtCalculatorView.Name = "DtCalculatorView";
            this.DtCalculatorView.RowHeadersWidth = 51;
            this.DtCalculatorView.RowTemplate.Height = 24;
            this.DtCalculatorView.Size = new System.Drawing.Size(1103, 157);
            this.DtCalculatorView.TabIndex = 0;
            this.DtCalculatorView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtCalculatorView_CellContentClick_1);
            // 
            // BtDelete
            // 
            this.BtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDelete.Location = new System.Drawing.Point(679, 238);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(169, 35);
            this.BtDelete.TabIndex = 1;
            this.BtDelete.Text = "Delete";
            this.BtDelete.UseVisualStyleBackColor = true;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click_1);
            // 
            // FrHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 403);
            this.Controls.Add(this.BtDelete);
            this.Controls.Add(this.DtCalculatorView);
            this.Name = "FrHistory";
            this.Text = "FrHistory";
            this.Load += new System.EventHandler(this.FrHistory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DtCalculatorView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtCalculatorView;
        private System.Windows.Forms.Button BtDelete;
    }
}