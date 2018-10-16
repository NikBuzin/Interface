namespace Interface
{
    partial class Interface
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
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Count = new System.Windows.Forms.TextBox();
            this.TB_Power = new System.Windows.Forms.TextBox();
            this.But_Printer = new System.Windows.Forms.Button();
            this.But_Add_Queue = new System.Windows.Forms.Button();
            this.But_Cancel_Queue = new System.Windows.Forms.Button();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.But_Remove_printer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(13, 13);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Name.TabIndex = 0;
            // 
            // TB_Count
            // 
            this.TB_Count.Location = new System.Drawing.Point(13, 65);
            this.TB_Count.Name = "TB_Count";
            this.TB_Count.Size = new System.Drawing.Size(100, 20);
            this.TB_Count.TabIndex = 1;
            // 
            // TB_Power
            // 
            this.TB_Power.Location = new System.Drawing.Point(13, 39);
            this.TB_Power.Name = "TB_Power";
            this.TB_Power.Size = new System.Drawing.Size(100, 20);
            this.TB_Power.TabIndex = 2;
            // 
            // But_Printer
            // 
            this.But_Printer.Location = new System.Drawing.Point(13, 91);
            this.But_Printer.Name = "But_Printer";
            this.But_Printer.Size = new System.Drawing.Size(100, 23);
            this.But_Printer.TabIndex = 3;
            this.But_Printer.Text = "Add printer";
            this.But_Printer.UseVisualStyleBackColor = true;
            this.But_Printer.Click += new System.EventHandler(this.But_Printer_Click);
            // 
            // But_Add_Queue
            // 
            this.But_Add_Queue.Location = new System.Drawing.Point(13, 149);
            this.But_Add_Queue.Name = "But_Add_Queue";
            this.But_Add_Queue.Size = new System.Drawing.Size(100, 23);
            this.But_Add_Queue.TabIndex = 4;
            this.But_Add_Queue.Text = "Add in queue";
            this.But_Add_Queue.UseVisualStyleBackColor = true;
            this.But_Add_Queue.Click += new System.EventHandler(this.But_Add_Queue_Click);
            // 
            // But_Cancel_Queue
            // 
            this.But_Cancel_Queue.Location = new System.Drawing.Point(13, 178);
            this.But_Cancel_Queue.Name = "But_Cancel_Queue";
            this.But_Cancel_Queue.Size = new System.Drawing.Size(100, 23);
            this.But_Cancel_Queue.TabIndex = 5;
            this.But_Cancel_Queue.Text = "Cancel queue";
            this.But_Cancel_Queue.UseVisualStyleBackColor = true;
            this.But_Cancel_Queue.Click += new System.EventHandler(this.But_Cancel_Queue_Click);
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(119, 13);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.Size = new System.Drawing.Size(206, 188);
            this.TB_Result.TabIndex = 6;
            // 
            // But_Remove_printer
            // 
            this.But_Remove_printer.Location = new System.Drawing.Point(13, 120);
            this.But_Remove_printer.Name = "But_Remove_printer";
            this.But_Remove_printer.Size = new System.Drawing.Size(100, 23);
            this.But_Remove_printer.TabIndex = 7;
            this.But_Remove_printer.Text = "Remove printer";
            this.But_Remove_printer.UseVisualStyleBackColor = true;
            this.But_Remove_printer.Click += new System.EventHandler(this.But_Remove_printer_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 217);
            this.Controls.Add(this.But_Remove_printer);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.But_Cancel_Queue);
            this.Controls.Add(this.But_Add_Queue);
            this.Controls.Add(this.But_Printer);
            this.Controls.Add(this.TB_Power);
            this.Controls.Add(this.TB_Count);
            this.Controls.Add(this.TB_Name);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Count;
        private System.Windows.Forms.TextBox TB_Power;
        private System.Windows.Forms.Button But_Printer;
        private System.Windows.Forms.Button But_Add_Queue;
        private System.Windows.Forms.Button But_Cancel_Queue;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Button But_Remove_printer;
    }
}

