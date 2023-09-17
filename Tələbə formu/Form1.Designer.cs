namespace Tələbə_formu
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxgroupUpdate = new System.Windows.Forms.TextBox();
            this.tbxsurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxgroup = new System.Windows.Forms.TextBox();
            this.tbxsurname = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(610, 19);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxgroupUpdate);
            this.gbxUpdate.Controls.Add(this.tbxsurnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(482, 297);
            this.gbxUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUpdate.Size = new System.Drawing.Size(307, 183);
            this.gbxUpdate.TabIndex = 13;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Tələbə məlumatlarını yenilə";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 139);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Yenilə";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxgroupUpdate
            // 
            this.tbxgroupUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbxgroupUpdate.Location = new System.Drawing.Point(113, 106);
            this.tbxgroupUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxgroupUpdate.Name = "tbxgroupUpdate";
            this.tbxgroupUpdate.Size = new System.Drawing.Size(132, 24);
            this.tbxgroupUpdate.TabIndex = 7;
            // 
            // tbxsurnameUpdate
            // 
            this.tbxsurnameUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbxsurnameUpdate.Location = new System.Drawing.Point(112, 63);
            this.tbxsurnameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxsurnameUpdate.Name = "tbxsurnameUpdate";
            this.tbxsurnameUpdate.Size = new System.Drawing.Size(132, 24);
            this.tbxsurnameUpdate.TabIndex = 6;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.BackColor = System.Drawing.Color.Blue;
            this.tbxNameUpdate.Location = new System.Drawing.Point(112, 17);
            this.tbxNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(132, 24);
            this.tbxNameUpdate.TabIndex = 5;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(8, 21);
            this.lblNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(24, 17);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Ad";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(8, 63);
            this.lblUnitPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(47, 17);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Soyad";
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(8, 110);
            this.lblStockAmountUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(39, 17);
            this.lblStockAmountUpdate.TabIndex = 3;
            this.lblStockAmountUpdate.Text = "Qrup";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxgroup);
            this.gbxAdd.Controls.Add(this.tbxsurname);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.unitPrice);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(122, 297);
            this.gbxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAdd.Size = new System.Drawing.Size(307, 183);
            this.gbxAdd.TabIndex = 12;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Tələbə əlavə et";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 139);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Əlavə et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxgroup
            // 
            this.tbxgroup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbxgroup.Location = new System.Drawing.Point(113, 106);
            this.tbxgroup.Margin = new System.Windows.Forms.Padding(4);
            this.tbxgroup.Name = "tbxgroup";
            this.tbxgroup.Size = new System.Drawing.Size(132, 24);
            this.tbxgroup.TabIndex = 7;
            // 
            // tbxsurname
            // 
            this.tbxsurname.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbxsurname.Location = new System.Drawing.Point(112, 63);
            this.tbxsurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbxsurname.Name = "tbxsurname";
            this.tbxsurname.Size = new System.Drawing.Size(132, 24);
            this.tbxsurname.TabIndex = 6;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbxName.Location = new System.Drawing.Point(112, 17);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(132, 24);
            this.tbxName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 21);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ad";
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.Location = new System.Drawing.Point(8, 63);
            this.unitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(47, 17);
            this.unitPrice.TabIndex = 2;
            this.unitPrice.Text = "Soyad";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(8, 110);
            this.lblStockAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(39, 17);
            this.lblStockAmount.TabIndex = 3;
            this.lblStockAmount.Text = "Qrup";
            // 
            // dgwProducts
            // 
            this.dgwProducts.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(163, 63);
            this.dgwProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.Size = new System.Drawing.Size(579, 175);
            this.dgwProducts.TabIndex = 11;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 528);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Tələbə formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxgroupUpdate;
        private System.Windows.Forms.TextBox tbxsurnameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxgroup;
        private System.Windows.Forms.TextBox tbxsurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

