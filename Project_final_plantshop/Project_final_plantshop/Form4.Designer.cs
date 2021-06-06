
namespace Project_final_plantshop
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataEquiment = new System.Windows.Forms.DataGridView();
            this.submitBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NumText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquiment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEquiment
            // 
            this.dataEquiment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataEquiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEquiment.Location = new System.Drawing.Point(387, 12);
            this.dataEquiment.Name = "dataEquiment";
            this.dataEquiment.RowHeadersWidth = 51;
            this.dataEquiment.RowTemplate.Height = 24;
            this.dataEquiment.Size = new System.Drawing.Size(595, 683);
            this.dataEquiment.TabIndex = 0;
            this.dataEquiment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquiment_CellClick);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(26, 365);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(172, 55);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "เพิ่มข้อมูล";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(26, 441);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(172, 55);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "แก้ไขข้อมูล";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(26, 132);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(324, 41);
            this.NameText.TabIndex = 3;
            // 
            // NumText
            // 
            this.NumText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumText.Location = new System.Drawing.Point(26, 214);
            this.NumText.Name = "NumText";
            this.NumText.Size = new System.Drawing.Size(324, 41);
            this.NumText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "ชื่อต้นไม้";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "จำนวน";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(26, 515);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(172, 55);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "ลบข้อมูล";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mikado Bold DEMO", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(82, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 81);
            this.label3.TabIndex = 8;
            this.label3.Text = "STOCK";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "ราคา";
            // 
            // PriceText
            // 
            this.PriceText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.Location = new System.Drawing.Point(26, 299);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(324, 41);
            this.PriceText.TabIndex = 10;
            // 
            // close_button
            // 
            this.close_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(108, 620);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(172, 55);
            this.close_button.TabIndex = 12;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(994, 708);
            this.ControlBox = false;
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.dataEquiment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plant Stock";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEquiment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEquiment;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox NumText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Button close_button;
    }
}