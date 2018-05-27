namespace Winter_homework08
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Salesman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liwhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Salesman,
            this.Pen,
            this.Pencil,
            this.Eraser,
            this.Ruler,
            this.Liwhite,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(30, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(650, 142);
            this.dataGridView1.TabIndex = 0;
            // 
            // Salesman
            // 
            this.Salesman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Salesman.DataPropertyName = "Salesman";
            this.Salesman.HeaderText = "業務員";
            this.Salesman.Name = "Salesman";
            this.Salesman.ReadOnly = true;
            this.Salesman.Width = 81;
            // 
            // Pen
            // 
            this.Pen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pen.DataPropertyName = "Pen";
            this.Pen.HeaderText = "原子筆";
            this.Pen.Name = "Pen";
            this.Pen.ReadOnly = true;
            this.Pen.Width = 81;
            // 
            // Pencil
            // 
            this.Pencil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pencil.DataPropertyName = "Pencil";
            this.Pencil.HeaderText = "鉛筆";
            this.Pencil.Name = "Pencil";
            this.Pencil.ReadOnly = true;
            this.Pencil.Width = 66;
            // 
            // Eraser
            // 
            this.Eraser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eraser.DataPropertyName = "Eraser";
            this.Eraser.HeaderText = "橡皮擦";
            this.Eraser.Name = "Eraser";
            this.Eraser.ReadOnly = true;
            this.Eraser.Width = 81;
            // 
            // Ruler
            // 
            this.Ruler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ruler.DataPropertyName = "Ruler";
            this.Ruler.HeaderText = "直尺";
            this.Ruler.Name = "Ruler";
            this.Ruler.ReadOnly = true;
            this.Ruler.Width = 66;
            // 
            // Liwhite
            // 
            this.Liwhite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Liwhite.DataPropertyName = "Liwhite";
            this.Liwhite.HeaderText = "立可白";
            this.Liwhite.Name = "Liwhite";
            this.Liwhite.ReadOnly = true;
            this.Liwhite.Width = 81;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "銷售總額";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "業務業績";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "各產品的銷售總額";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Price,
            this.Totals,
            this.Sum});
            this.dataGridView2.Location = new System.Drawing.Point(29, 280);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(428, 223);
            this.dataGridView2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(498, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "最佳銷售員";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(498, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "最佳產品";
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "產品";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 66;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "單價";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 66;
            // 
            // Totals
            // 
            this.Totals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Totals.DataPropertyName = "Totals";
            this.Totals.HeaderText = "總銷售數量";
            this.Totals.Name = "Totals";
            this.Totals.ReadOnly = true;
            this.Totals.Width = 111;
            // 
            // Sum
            // 
            this.Sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "總銷售金額";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 111;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 560);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salesman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liwhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}

