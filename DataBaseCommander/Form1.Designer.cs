
namespace DataBaseCommander
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTagUrlSlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTagDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostShortDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(437, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вивести вміст";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTagName,
            this.ColTagUrlSlug,
            this.ColTagDescription,
            this.ColPostName,
            this.ColPostShortDescription,
            this.ColCategoryName,
            this.ColCategoryDescription});
            this.dataGridView1.Location = new System.Drawing.Point(30, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColTagName
            // 
            this.ColTagName.HeaderText = "Назва тегу";
            this.ColTagName.MinimumWidth = 6;
            this.ColTagName.Name = "ColTagName";
            this.ColTagName.Width = 125;
            // 
            // ColTagUrlSlug
            // 
            this.ColTagUrlSlug.HeaderText = "Силка на тег";
            this.ColTagUrlSlug.MinimumWidth = 6;
            this.ColTagUrlSlug.Name = "ColTagUrlSlug";
            this.ColTagUrlSlug.Width = 125;
            // 
            // ColTagDescription
            // 
            this.ColTagDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTagDescription.HeaderText = "Опис тегу";
            this.ColTagDescription.MinimumWidth = 6;
            this.ColTagDescription.Name = "ColTagDescription";
            // 
            // ColPostName
            // 
            this.ColPostName.HeaderText = "Назва публікації";
            this.ColPostName.MinimumWidth = 6;
            this.ColPostName.Name = "ColPostName";
            this.ColPostName.Width = 125;
            // 
            // ColPostShortDescription
            // 
            this.ColPostShortDescription.HeaderText = "Короткий опис";
            this.ColPostShortDescription.MinimumWidth = 6;
            this.ColPostShortDescription.Name = "ColPostShortDescription";
            this.ColPostShortDescription.Width = 125;
            // 
            // ColCategoryName
            // 
            this.ColCategoryName.HeaderText = "Назва категорії";
            this.ColCategoryName.MinimumWidth = 6;
            this.ColCategoryName.Name = "ColCategoryName";
            this.ColCategoryName.Width = 125;
            // 
            // ColCategoryDescription
            // 
            this.ColCategoryDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCategoryDescription.HeaderText = "Опис категорії";
            this.ColCategoryDescription.MinimumWidth = 6;
            this.ColCategoryDescription.Name = "ColCategoryDescription";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTagUrlSlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTagDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostShortDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoryDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

