namespace TablaBingo
{
    partial class FmTblBingo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TblBingo = new System.Windows.Forms.DataGridView();
            this.BtnNewTbl = new System.Windows.Forms.Button();
            this.BtnEmpezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TblBingo)).BeginInit();
            this.SuspendLayout();
            // 
            // TblBingo
            // 
            this.TblBingo.AllowDrop = true;
            this.TblBingo.AllowUserToAddRows = false;
            this.TblBingo.AllowUserToDeleteRows = false;
            this.TblBingo.AllowUserToResizeColumns = false;
            this.TblBingo.AllowUserToResizeRows = false;
            this.TblBingo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TblBingo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblBingo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TblBingo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblBingo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TblBingo.ColumnHeadersHeight = 80;
            this.TblBingo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TblBingo.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TblBingo.DefaultCellStyle = dataGridViewCellStyle2;
            this.TblBingo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblBingo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TblBingo.Location = new System.Drawing.Point(0, 0);
            this.TblBingo.MultiSelect = false;
            this.TblBingo.Name = "TblBingo";
            this.TblBingo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TblBingo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TblBingo.RowHeadersVisible = false;
            this.TblBingo.RowTemplate.Height = 3;
            this.TblBingo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TblBingo.Size = new System.Drawing.Size(555, 491);
            this.TblBingo.TabIndex = 0;
            this.TblBingo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblBingo_CellContentDoubleClick);
            // 
            // BtnNewTbl
            // 
            this.BtnNewTbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewTbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewTbl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNewTbl.FlatAppearance.BorderSize = 3;
            this.BtnNewTbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNewTbl.Location = new System.Drawing.Point(81, 456);
            this.BtnNewTbl.Name = "BtnNewTbl";
            this.BtnNewTbl.Size = new System.Drawing.Size(132, 23);
            this.BtnNewTbl.TabIndex = 1;
            this.BtnNewTbl.Text = "Nueva Tabla";
            this.BtnNewTbl.UseVisualStyleBackColor = false;
            this.BtnNewTbl.Click += new System.EventHandler(this.BtnNewTbl_Click);
            // 
            // BtnEmpezar
            // 
            this.BtnEmpezar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEmpezar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEmpezar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEmpezar.FlatAppearance.BorderSize = 3;
            this.BtnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEmpezar.Location = new System.Drawing.Point(345, 456);
            this.BtnEmpezar.Name = "BtnEmpezar";
            this.BtnEmpezar.Size = new System.Drawing.Size(132, 23);
            this.BtnEmpezar.TabIndex = 2;
            this.BtnEmpezar.Text = "Empezar";
            this.BtnEmpezar.UseVisualStyleBackColor = false;
            this.BtnEmpezar.Click += new System.EventHandler(this.BtnEmpezar_Click);
            // 
            // FmTblBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 491);
            this.Controls.Add(this.BtnEmpezar);
            this.Controls.Add(this.BtnNewTbl);
            this.Controls.Add(this.TblBingo);
            this.MaximizeBox = false;
            this.Name = "FmTblBingo";
            this.Text = "Tabla Bingo";
            ((System.ComponentModel.ISupportInitialize)(this.TblBingo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TblBingo;
        private System.Windows.Forms.Button BtnNewTbl;
        private System.Windows.Forms.Button BtnEmpezar;
    }
}

