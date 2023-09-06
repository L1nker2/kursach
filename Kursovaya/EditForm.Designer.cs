namespace Kursovaya
{
    partial class EditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Fn_Tb = new TextBox();
            Sn_Tb = new TextBox();
            Rn_Tb = new TextBox();
            save_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 26);
            label1.TabIndex = 0;
            label1.Text = "Имя студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(191, 26);
            label2.TabIndex = 1;
            label2.Text = "Фамилия студента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(165, 26);
            label3.TabIndex = 2;
            label3.Text = "Номер комнаты";
            // 
            // Fn_Tb
            // 
            Fn_Tb.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Fn_Tb.Location = new Point(215, 6);
            Fn_Tb.Name = "Fn_Tb";
            Fn_Tb.Size = new Size(159, 34);
            Fn_Tb.TabIndex = 3;
            // 
            // Sn_Tb
            // 
            Sn_Tb.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Sn_Tb.Location = new Point(215, 52);
            Sn_Tb.Name = "Sn_Tb";
            Sn_Tb.Size = new Size(159, 34);
            Sn_Tb.TabIndex = 4;
            // 
            // Rn_Tb
            // 
            Rn_Tb.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Rn_Tb.Location = new Point(215, 99);
            Rn_Tb.Name = "Rn_Tb";
            Rn_Tb.Size = new Size(159, 34);
            Rn_Tb.TabIndex = 5;
            // 
            // save_btn
            // 
            save_btn.AutoSize = true;
            save_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Location = new Point(394, 52);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(125, 36);
            save_btn.TabIndex = 6;
            save_btn.Text = "Сохранить";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 152);
            Controls.Add(save_btn);
            Controls.Add(Rn_Tb);
            Controls.Add(Sn_Tb);
            Controls.Add(Fn_Tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Fn_Tb;
        private TextBox Sn_Tb;
        private TextBox Rn_Tb;
        private Button save_btn;
    }
}