
namespace ParentForm
{
    partial class ParentForm
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
            this.btEdit = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.LbSurname = new System.Windows.Forms.Label();
            this.lbSunameText = new System.Windows.Forms.Label();
            this.btPhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Red;
            this.btEdit.Location = new System.Drawing.Point(107, 292);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 31);
            this.btEdit.TabIndex = 0;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(39, 44);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(42, 80);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // LbSurname
            // 
            this.LbSurname.AutoSize = true;
            this.LbSurname.Location = new System.Drawing.Point(39, 134);
            this.LbSurname.Name = "LbSurname";
            this.LbSurname.Size = new System.Drawing.Size(49, 13);
            this.LbSurname.TabIndex = 3;
            this.LbSurname.Text = "Surname";
            // 
            // lbSunameText
            // 
            this.lbSunameText.AutoSize = true;
            this.lbSunameText.Location = new System.Drawing.Point(39, 171);
            this.lbSunameText.Name = "lbSunameText";
            this.lbSunameText.Size = new System.Drawing.Size(53, 13);
            this.lbSunameText.TabIndex = 4;
            this.lbSunameText.Text = "Unknown";
            // 
            // btPhone
            // 
            this.btPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btPhone.Location = new System.Drawing.Point(107, 235);
            this.btPhone.Name = "btPhone";
            this.btPhone.Size = new System.Drawing.Size(75, 36);
            this.btPhone.TabIndex = 5;
            this.btPhone.Text = "Show phone";
            this.btPhone.UseVisualStyleBackColor = false;
            this.btPhone.Click += new System.EventHandler(this.btPhone_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 436);
            this.Controls.Add(this.btPhone);
            this.Controls.Add(this.lbSunameText);
            this.Controls.Add(this.LbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btEdit);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "ParentForm";
            this.Text = "Parent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label LbSurname;
        private System.Windows.Forms.Label lbSunameText;
        private System.Windows.Forms.Button btPhone;
    }
}

