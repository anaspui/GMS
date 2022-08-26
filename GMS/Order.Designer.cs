namespace GMS
{
    partial class Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProdList = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.cusName = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusPhn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cusPhn = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.Label();
            this.txtNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvSelProd = new System.Windows.Forms.DataGridView();
            this.SelProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdList
            // 
            this.dgvProdList.AllowUserToAddRows = false;
            this.dgvProdList.AllowUserToDeleteRows = false;
            this.dgvProdList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdList.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.ProdCat});
            this.dgvProdList.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvProdList.Location = new System.Drawing.Point(-110, 295);
            this.dgvProdList.Name = "dgvProdList";
            this.dgvProdList.ReadOnly = true;
            this.dgvProdList.RowHeadersWidth = 51;
            this.dgvProdList.RowTemplate.Height = 24;
            this.dgvProdList.Size = new System.Drawing.Size(503, 288);
            this.dgvProdList.TabIndex = 0;
            this.dgvProdList.DoubleClick += new System.EventHandler(this.dgvProductList_DoubleClick);
            // 
            // ProdId
            // 
            this.ProdId.DataPropertyName = "ProdId";
            this.ProdId.HeaderText = "Id";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            this.ProdId.ReadOnly = true;
            this.ProdId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdId.Width = 90;
            // 
            // ProdName
            // 
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Width = 90;
            // 
            // ProdPrice
            // 
            this.ProdPrice.DataPropertyName = "ProdPrice";
            this.ProdPrice.HeaderText = "Price";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.ReadOnly = true;
            this.ProdPrice.Width = 90;
            // 
            // ProdQty
            // 
            this.ProdQty.DataPropertyName = "ProdQty";
            this.ProdQty.HeaderText = "On Stock";
            this.ProdQty.MinimumWidth = 6;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.ReadOnly = true;
            this.ProdQty.Width = 90;
            // 
            // ProdCat
            // 
            this.ProdCat.DataPropertyName = "ProdCat";
            this.ProdCat.HeaderText = "Catagorie";
            this.ProdCat.MinimumWidth = 6;
            this.ProdCat.Name = "ProdCat";
            this.ProdCat.ReadOnly = true;
            this.ProdCat.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Location = new System.Drawing.Point(549, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(199)))), ((int)(((byte)(81)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckOut.Location = new System.Drawing.Point(-16, -7);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(210, 55);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtCusId
            // 
            this.txtCusId.Enabled = false;
            this.txtCusId.Location = new System.Drawing.Point(194, 32);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(247, 22);
            this.txtCusId.TabIndex = 3;
            // 
            // cusName
            // 
            this.cusName.AutoSize = true;
            this.cusName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.cusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cusName.Location = new System.Drawing.Point(194, 10);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(80, 16);
            this.cusName.TabIndex = 4;
            this.cusName.Text = "Customer ID";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(16, 32);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(147, 22);
            this.txtOrderId.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(16, 10);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 16);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Order ID";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(16, 103);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(247, 22);
            this.txtCusName.TabIndex = 3;
            // 
            // txtCusPhn
            // 
            this.txtCusPhn.Location = new System.Drawing.Point(16, 159);
            this.txtCusPhn.Name = "txtCusPhn";
            this.txtCusPhn.Size = new System.Drawing.Size(247, 22);
            this.txtCusPhn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer name*";
            // 
            // cusPhn
            // 
            this.cusPhn.AutoSize = true;
            this.cusPhn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.cusPhn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cusPhn.Location = new System.Drawing.Point(16, 137);
            this.cusPhn.Name = "cusPhn";
            this.cusPhn.Size = new System.Drawing.Size(51, 16);
            this.cusPhn.TabIndex = 4;
            this.cusPhn.Text = "Phone*";
            // 
            // numQuantity
            // 
            this.numQuantity.AutoSize = true;
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numQuantity.Location = new System.Drawing.Point(256, 52);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(55, 16);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.Text = "Quantity";
            // 
            // txtNumUpDown
            // 
            this.txtNumUpDown.Location = new System.Drawing.Point(259, 71);
            this.txtNumUpDown.Name = "txtNumUpDown";
            this.txtNumUpDown.Size = new System.Drawing.Size(135, 22);
            this.txtNumUpDown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(4, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available Poducts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(400, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selected Products";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Location = new System.Drawing.Point(738, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 39);
            this.panel3.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(50)))), ((int)(((byte)(48)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(-20, -8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(210, 55);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Location = new System.Drawing.Point(19, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 39);
            this.panel5.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(146)))), ((int)(((byte)(55)))));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(-16, -8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(210, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(807, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Purchase Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPurchaseDate.Location = new System.Drawing.Point(807, 32);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(81, 16);
            this.lblPurchaseDate.TabIndex = 4;
            this.lblPurchaseDate.Text = "dd/MM/yyyy";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgvSelProd);
            this.panel2.Controls.Add(this.numQuantity);
            this.panel2.Controls.Add(this.txtNumUpDown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 405);
            this.panel2.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(795, 335);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 16);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0.00";
            // 
            // dgvSelProd
            // 
            this.dgvSelProd.AllowUserToAddRows = false;
            this.dgvSelProd.AllowUserToDeleteRows = false;
            this.dgvSelProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelProdId,
            this.SelProdName,
            this.SelProdQty,
            this.SelProdPrice});
            this.dgvSelProd.Location = new System.Drawing.Point(399, 97);
            this.dgvSelProd.Name = "dgvSelProd";
            this.dgvSelProd.ReadOnly = true;
            this.dgvSelProd.RowHeadersWidth = 51;
            this.dgvSelProd.RowTemplate.Height = 24;
            this.dgvSelProd.Size = new System.Drawing.Size(504, 228);
            this.dgvSelProd.TabIndex = 10;
            // 
            // SelProdId
            // 
            this.SelProdId.DataPropertyName = "SelProdId";
            this.SelProdId.HeaderText = "ID";
            this.SelProdId.MinimumWidth = 6;
            this.SelProdId.Name = "SelProdId";
            this.SelProdId.ReadOnly = true;
            this.SelProdId.Width = 113;
            // 
            // SelProdName
            // 
            this.SelProdName.DataPropertyName = "SelProdName";
            this.SelProdName.HeaderText = "Name";
            this.SelProdName.MinimumWidth = 6;
            this.SelProdName.Name = "SelProdName";
            this.SelProdName.ReadOnly = true;
            this.SelProdName.Width = 113;
            // 
            // SelProdQty
            // 
            this.SelProdQty.DataPropertyName = "SelProdQty";
            this.SelProdQty.HeaderText = "Quantity";
            this.SelProdQty.MinimumWidth = 6;
            this.SelProdQty.Name = "SelProdQty";
            this.SelProdQty.ReadOnly = true;
            this.SelProdQty.Width = 112;
            // 
            // SelProdPrice
            // 
            this.SelProdPrice.DataPropertyName = "SelProdPrice";
            this.SelProdPrice.HeaderText = "Total Price";
            this.SelProdPrice.MinimumWidth = 6;
            this.SelProdPrice.Name = "SelProdPrice";
            this.SelProdPrice.ReadOnly = true;
            this.SelProdPrice.Width = 113;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(906, 201);
            this.panel4.TabIndex = 10;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.cusPhn);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.txtCusPhn);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusId);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProdList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Order";
            this.Size = new System.Drawing.Size(906, 603);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.Label cusName;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusPhn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cusPhn;
        private System.Windows.Forms.Label numQuantity;
        private System.Windows.Forms.NumericUpDown txtNumUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSelProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelProdPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel4;
    }
}
