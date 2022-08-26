namespace GMS
{
    partial class EProductList
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
            this.label3 = new System.Windows.Forms.Label();
            this.NumQty = new System.Windows.Forms.NumericUpDown();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.cusPhn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.Label();
            this.txtProdCat = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.dgvProdList = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NumQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Available Poducts";
            // 
            // NumQty
            // 
            this.NumQty.Location = new System.Drawing.Point(82, 200);
            this.NumQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumQty.Name = "NumQty";
            this.NumQty.Size = new System.Drawing.Size(171, 22);
            this.NumQty.TabIndex = 29;
            // 
            // txtProdId
            // 
            this.txtProdId.Enabled = false;
            this.txtProdId.Location = new System.Drawing.Point(82, 34);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(171, 22);
            this.txtProdId.TabIndex = 15;
            // 
            // cusPhn
            // 
            this.cusPhn.AutoSize = true;
            this.cusPhn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.cusPhn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cusPhn.Location = new System.Drawing.Point(82, 179);
            this.cusPhn.Name = "cusPhn";
            this.cusPhn.Size = new System.Drawing.Size(109, 16);
            this.cusPhn.TabIndex = 25;
            this.cusPhn.Text = "Product Quantity*";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(931, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Today\'s Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(271, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Product Catagory*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(82, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product name*";
            // 
            // cusName
            // 
            this.cusName.AutoSize = true;
            this.cusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.cusName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cusName.Location = new System.Drawing.Point(82, 129);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(93, 16);
            this.cusName.TabIndex = 28;
            this.cusName.Text = "Price Per Unit*";
            // 
            // txtProdCat
            // 
            this.txtProdCat.Location = new System.Drawing.Point(271, 200);
            this.txtProdCat.Name = "txtProdCat";
            this.txtProdCat.Size = new System.Drawing.Size(200, 22);
            this.txtProdCat.TabIndex = 18;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(50)))), ((int)(((byte)(48)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(-14, -8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(187, 55);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(82, 99);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(171, 22);
            this.txtProdName.TabIndex = 16;
            // 
            // dgvProdList
            // 
            this.dgvProdList.AllowUserToAddRows = false;
            this.dgvProdList.AllowUserToDeleteRows = false;
            this.dgvProdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.ProdCat,
            this.DateAdded});
            this.dgvProdList.Location = new System.Drawing.Point(12, 302);
            this.dgvProdList.Name = "dgvProdList";
            this.dgvProdList.ReadOnly = true;
            this.dgvProdList.RowHeadersWidth = 51;
            this.dgvProdList.RowTemplate.Height = 24;
            this.dgvProdList.Size = new System.Drawing.Size(1019, 288);
            this.dgvProdList.TabIndex = 10;
            this.dgvProdList.DoubleClick += new System.EventHandler(this.dgvProductList_DoubleClick);
            // 
            // ProdId
            // 
            this.ProdId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdId.DataPropertyName = "ProdId";
            this.ProdId.HeaderText = "Id";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            this.ProdId.ReadOnly = true;
            this.ProdId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // ProdPrice
            // 
            this.ProdPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdPrice.DataPropertyName = "ProdPrice";
            this.ProdPrice.HeaderText = "Price";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.ReadOnly = true;
            // 
            // ProdQty
            // 
            this.ProdQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdQty.DataPropertyName = "ProdQty";
            this.ProdQty.HeaderText = "On Stock";
            this.ProdQty.MinimumWidth = 6;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.ReadOnly = true;
            // 
            // ProdCat
            // 
            this.ProdCat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdCat.DataPropertyName = "ProdCat";
            this.ProdCat.HeaderText = "Catagorie";
            this.ProdCat.MinimumWidth = 6;
            this.ProdCat.Name = "ProdCat";
            this.ProdCat.ReadOnly = true;
            // 
            // DateAdded
            // 
            this.DateAdded.DataPropertyName = "DateAdded";
            this.DateAdded.HeaderText = "Insertion Date";
            this.DateAdded.MinimumWidth = 6;
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            this.DateAdded.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Location = new System.Drawing.Point(874, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 39);
            this.panel3.TabIndex = 13;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(82, 151);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(171, 22);
            this.txtProdPrice.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(489, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 39);
            this.panel1.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(146)))), ((int)(((byte)(55)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(-14, -9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(489, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 39);
            this.panel2.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(81)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(-14, -8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(932, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 16);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "DD/MM/YYYY";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(3, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1044, 327);
            this.panel4.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(83, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Product ID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1043, 277);
            this.panel5.TabIndex = 36;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Location = new System.Drawing.Point(131, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(897, 4);
            this.panel6.TabIndex = 0;
            // 
            // EProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumQty);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(this.cusPhn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.txtProdCat);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.dgvProdList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "EProductList";
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumQty;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label cusPhn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cusName;
        private System.Windows.Forms.TextBox txtProdCat;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.DataGridView dgvProdList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}