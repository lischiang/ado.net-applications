namespace DisplayBooks
{
    partial class DisplayBooksForm
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
            this.components = new System.ComponentModel.Container();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQueryResult = new System.Windows.Forms.TextBox();
            this.comboBoxQuery = new System.Windows.Forms.ComboBox();
            this.lblSelectQuery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataSource = typeof(BookClassLibrary.Title);
            // 
            // txtQueryResult
            // 
            this.txtQueryResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQueryResult.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueryResult.Location = new System.Drawing.Point(0, 0);
            this.txtQueryResult.Multiline = true;
            this.txtQueryResult.Name = "txtQueryResult";
            this.txtQueryResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQueryResult.Size = new System.Drawing.Size(828, 375);
            this.txtQueryResult.TabIndex = 0;
            // 
            // comboBoxQuery
            // 
            this.comboBoxQuery.FormattingEnabled = true;
            this.comboBoxQuery.Items.AddRange(new object[] {
            "TItles and the corresponding authors",
            "Titles and the corresponding authors - sorted by title, author\'s last name, autho" +
                "r\'s first name",
            "List of authors grouped by title - sorted by title, author\'s last name, author\'s " +
                "first name"});
            this.comboBoxQuery.Location = new System.Drawing.Point(15, 411);
            this.comboBoxQuery.Name = "comboBoxQuery";
            this.comboBoxQuery.Size = new System.Drawing.Size(801, 21);
            this.comboBoxQuery.TabIndex = 1;
            this.comboBoxQuery.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuery_SelectedIndexChanged);
            // 
            // lblSelectQuery
            // 
            this.lblSelectQuery.AutoSize = true;
            this.lblSelectQuery.Location = new System.Drawing.Point(12, 395);
            this.lblSelectQuery.Name = "lblSelectQuery";
            this.lblSelectQuery.Size = new System.Drawing.Size(143, 13);
            this.lblSelectQuery.TabIndex = 2;
            this.lblSelectQuery.Text = "Select which books to show:";
            // 
            // DisplayBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 454);
            this.Controls.Add(this.lblSelectQuery);
            this.Controls.Add(this.comboBoxQuery);
            this.Controls.Add(this.txtQueryResult);
            this.Name = "DisplayBooksForm";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.DisplayBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource titleBindingSource;
        private System.Windows.Forms.TextBox txtQueryResult;
        private System.Windows.Forms.ComboBox comboBoxQuery;
        private System.Windows.Forms.Label lblSelectQuery;
    }
}

