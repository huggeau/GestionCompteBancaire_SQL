namespace GUICompteBancaire
{
    partial class FentreBdd
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proprietaireDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compteBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, proprietaireDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, transactionsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = compteBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(395, 426);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // proprietaireDataGridViewTextBoxColumn
            // 
            proprietaireDataGridViewTextBoxColumn.DataPropertyName = "Proprietaire";
            proprietaireDataGridViewTextBoxColumn.HeaderText = "Proprietaire";
            proprietaireDataGridViewTextBoxColumn.Name = "proprietaireDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // transactionsDataGridViewTextBoxColumn
            // 
            transactionsDataGridViewTextBoxColumn.DataPropertyName = "Transactions";
            transactionsDataGridViewTextBoxColumn.HeaderText = "Transactions";
            transactionsDataGridViewTextBoxColumn.Name = "transactionsDataGridViewTextBoxColumn";
            transactionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // compteBindingSource
            // 
            compteBindingSource.DataSource = typeof(CompteBancaireEF.Compte);
            // 
            // FentreBdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "FentreBdd";
            Text = "FentreBdd";
            FormClosing += FentreBdd_FormClosing;
            Load += FentreBdd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)compteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proprietaireDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionsDataGridViewTextBoxColumn;
        private BindingSource compteBindingSource;
    }
}