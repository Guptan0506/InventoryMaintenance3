namespace InventoryMaintenance
{
    partial class frmInventoryMaint
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
            lstItems = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label1 = new Label();
            cboFilterBy = new ComboBox();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.Location = new Point(50, 117);
            lstItems.Margin = new Padding(4, 4, 4, 4);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(591, 292);
            lstItems.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(691, 117);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(691, 186);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 49);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(691, 254);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 49);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 4;
            label1.Text = "Show:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboFilterBy
            // 
            cboFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterBy.FormattingEnabled = true;
            cboFilterBy.Location = new Point(136, 34);
            cboFilterBy.Margin = new Padding(4, 4, 4, 4);
            cboFilterBy.Name = "cboFilterBy";
            cboFilterBy.Size = new Size(236, 40);
            cboFilterBy.TabIndex = 0;
            cboFilterBy.SelectedIndexChanged += cboFilterBy_SelectedIndexChanged;
            // 
            // frmInventoryMaint
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(877, 459);
            Controls.Add(cboFilterBy);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstItems);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmInventoryMaint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Navya Gupta's Inventory Maintenance";
            Load += frmInventoryMaint_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstItems;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;
        private Label label1;
        private ComboBox cboFilterBy;
    }
}