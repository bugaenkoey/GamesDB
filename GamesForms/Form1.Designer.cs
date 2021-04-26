
namespace GamesForms
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
            this.GamesDataGridView = new System.Windows.Forms.DataGridView();
            this.RequestesComboBox = new System.Windows.Forms.ComboBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonAfterDate = new System.Windows.Forms.Button();
            this.buttonStyle = new System.Windows.Forms.Button();
            this.buttonCompany = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GamesDataGridView
            // 
            this.GamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamesDataGridView.Location = new System.Drawing.Point(12, 195);
            this.GamesDataGridView.Name = "GamesDataGridView";
            this.GamesDataGridView.RowHeadersWidth = 51;
            this.GamesDataGridView.RowTemplate.Height = 29;
            this.GamesDataGridView.Size = new System.Drawing.Size(745, 243);
            this.GamesDataGridView.TabIndex = 0;
            // 
            // RequestesComboBox
            // 
            this.RequestesComboBox.FormattingEnabled = true;
            this.RequestesComboBox.Location = new System.Drawing.Point(12, 12);
            this.RequestesComboBox.Name = "RequestesComboBox";
            this.RequestesComboBox.Size = new System.Drawing.Size(394, 28);
            this.RequestesComboBox.TabIndex = 1;
            this.RequestesComboBox.SelectedIndexChanged += new System.EventHandler(this.RequestesComboBox_SelectedIndexChanged);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(12, 46);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(394, 24);
            this.buttonAll.TabIndex = 2;
            this.buttonAll.Text = "Информации о всех играх";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonAfterDate
            // 
            this.buttonAfterDate.Location = new System.Drawing.Point(12, 76);
            this.buttonAfterDate.Name = "buttonAfterDate";
            this.buttonAfterDate.Size = new System.Drawing.Size(394, 24);
            this.buttonAfterDate.TabIndex = 3;
            this.buttonAfterDate.Text = "Информации о играх позже определенной даты";
            this.buttonAfterDate.UseVisualStyleBackColor = true;
            this.buttonAfterDate.Click += new System.EventHandler(this.buttonAfterDate_Click);
            // 
            // buttonStyle
            // 
            this.buttonStyle.Location = new System.Drawing.Point(12, 106);
            this.buttonStyle.Name = "buttonStyle";
            this.buttonStyle.Size = new System.Drawing.Size(394, 24);
            this.buttonStyle.TabIndex = 4;
            this.buttonStyle.Text = "Информации об ихрах определенного стиля";
            this.buttonStyle.UseVisualStyleBackColor = true;
            this.buttonStyle.Click += new System.EventHandler(this.buttonStyle_Click);
            // 
            // buttonCompany
            // 
            this.buttonCompany.Location = new System.Drawing.Point(12, 136);
            this.buttonCompany.Name = "buttonCompany";
            this.buttonCompany.Size = new System.Drawing.Size(394, 24);
            this.buttonCompany.TabIndex = 5;
            this.buttonCompany.Text = "Информации об ихрах определенной студии";
            this.buttonCompany.UseVisualStyleBackColor = true;
            this.buttonCompany.Click += new System.EventHandler(this.buttonCompany_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCompany);
            this.Controls.Add(this.buttonStyle);
            this.Controls.Add(this.buttonAfterDate);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.RequestesComboBox);
            this.Controls.Add(this.GamesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GamesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GamesDataGridView;
        private System.Windows.Forms.ComboBox RequestesComboBox;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonAfterDate;
        private System.Windows.Forms.Button buttonStyle;
        private System.Windows.Forms.Button buttonCompany;
        private System.Windows.Forms.Button button;
    }
}

