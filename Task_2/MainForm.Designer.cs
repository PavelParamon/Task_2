namespace Task_2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PhoneGroupBox = new System.Windows.Forms.GroupBox();
            this.Clean_btn = new System.Windows.Forms.Button();
            this.Info_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.PhoneGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.Controls.Add(this.PhoneGroupBox, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.InfoGroupBox, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3321F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.6679F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(897, 542);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // PhoneGroupBox
            // 
            this.PhoneGroupBox.Controls.Add(this.Clean_btn);
            this.PhoneGroupBox.Controls.Add(this.Info_btn);
            this.PhoneGroupBox.Controls.Add(this.Add_btn);
            this.PhoneGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneGroupBox.Location = new System.Drawing.Point(3, 3);
            this.PhoneGroupBox.Name = "PhoneGroupBox";
            this.PhoneGroupBox.Size = new System.Drawing.Size(891, 49);
            this.PhoneGroupBox.TabIndex = 1;
            this.PhoneGroupBox.TabStop = false;
            this.PhoneGroupBox.Text = "Телефон";
            // 
            // Clean_btn
            // 
            this.Clean_btn.Location = new System.Drawing.Point(807, 11);
            this.Clean_btn.Name = "Clean_btn";
            this.Clean_btn.Size = new System.Drawing.Size(75, 33);
            this.Clean_btn.TabIndex = 3;
            this.Clean_btn.Text = "Clean";
            this.Clean_btn.UseVisualStyleBackColor = true;
            this.Clean_btn.Click += new System.EventHandler(this.Clean_btn_Click);
            // 
            // Info_btn
            // 
            this.Info_btn.Location = new System.Drawing.Point(160, 21);
            this.Info_btn.Name = "Info_btn";
            this.Info_btn.Size = new System.Drawing.Size(185, 23);
            this.Info_btn.TabIndex = 2;
            this.Info_btn.Text = "Информация о телефонах";
            this.Info_btn.UseVisualStyleBackColor = true;
            this.Info_btn.Click += new System.EventHandler(this.Info_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(6, 21);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(126, 23);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "Добавить телефон";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.InfoTextBox);
            this.InfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGroupBox.Location = new System.Drawing.Point(3, 58);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(891, 481);
            this.InfoGroupBox.TabIndex = 0;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Информация";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTextBox.Location = new System.Drawing.Point(3, 16);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(885, 462);
            this.InfoTextBox.TabIndex = 0;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 542);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Полиморфизм";
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.PhoneGroupBox.ResumeLayout(false);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.GroupBox PhoneGroupBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Button Clean_btn;
        private System.Windows.Forms.Button Info_btn;
        private System.Windows.Forms.Button Add_btn;
    }
}

