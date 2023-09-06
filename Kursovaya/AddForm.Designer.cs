namespace Kursovaya
{
    partial class AddForm
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
            Tb_FN = new TextBox();
            Tb_SN = new TextBox();
            Tb_RN = new TextBox();
            Add_btn = new Button();
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
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(191, 26);
            label2.TabIndex = 1;
            label2.Text = "Фамилия студента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(165, 26);
            label3.TabIndex = 2;
            label3.Text = "Номер комнаты";
            // 
            // Tb_FN
            // 
            Tb_FN.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Tb_FN.Location = new Point(219, 6);
            Tb_FN.Name = "Tb_FN";
            Tb_FN.Size = new Size(161, 34);
            Tb_FN.TabIndex = 3;
            // 
            // Tb_SN
            // 
            Tb_SN.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Tb_SN.Location = new Point(219, 49);
            Tb_SN.Name = "Tb_SN";
            Tb_SN.Size = new Size(161, 34);
            Tb_SN.TabIndex = 4;
            // 
            // Tb_RN
            // 
            Tb_RN.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Tb_RN.Location = new Point(219, 90);
            Tb_RN.Name = "Tb_RN";
            Tb_RN.Size = new Size(161, 34);
            Tb_RN.TabIndex = 5;
            // 
            // Add_btn
            // 
            Add_btn.AutoSize = true;
            Add_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Add_btn.Location = new Point(415, 47);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(115, 36);
            Add_btn.TabIndex = 6;
            Add_btn.Text = "Добавить";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 132);
            Controls.Add(Add_btn);
            Controls.Add(Tb_RN);
            Controls.Add(Tb_SN);
            Controls.Add(Tb_FN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "Добавить студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Tb_FN;
        private TextBox Tb_SN;
        private TextBox Tb_RN;
        private Button Add_btn;
    }
}