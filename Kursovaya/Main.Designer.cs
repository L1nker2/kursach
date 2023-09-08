namespace Kursovaya
{
    partial class Main
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
            datagridview = new DataGridView();
            Btn_Add = new Button();
            Btn_Edit = new Button();
            Btn_Delete = new Button();
            openFileDialog1 = new OpenFileDialog();
            about_btn = new Button();
            floor_one_btn = new Button();
            floor_two_btn = new Button();
            floor_three_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            SuspendLayout();
            // 
            // datagridview
            // 
            datagridview.AllowUserToAddRows = false;
            datagridview.AllowUserToDeleteRows = false;
            datagridview.AllowUserToResizeColumns = false;
            datagridview.AllowUserToResizeRows = false;
            datagridview.BackgroundColor = Color.Bisque;
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview.Location = new Point(12, 12);
            datagridview.Name = "datagridview";
            datagridview.RowHeadersWidth = 51;
            datagridview.RowTemplate.Height = 29;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview.Size = new Size(982, 606);
            datagridview.TabIndex = 0;
            // 
            // Btn_Add
            // 
            Btn_Add.Location = new Point(192, 674);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(120, 35);
            Btn_Add.TabIndex = 1;
            Btn_Add.Text = "Добавить";
            Btn_Add.UseVisualStyleBackColor = true;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.Location = new Point(318, 674);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(120, 35);
            Btn_Edit.TabIndex = 2;
            Btn_Edit.Text = "Изменить";
            Btn_Edit.UseVisualStyleBackColor = true;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Location = new Point(444, 674);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(120, 35);
            Btn_Delete.TabIndex = 3;
            Btn_Delete.Text = "Удалить";
            Btn_Delete.UseVisualStyleBackColor = true;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // about_btn
            // 
            about_btn.AutoSize = true;
            about_btn.Location = new Point(12, 674);
            about_btn.Name = "about_btn";
            about_btn.Size = new Size(152, 36);
            about_btn.TabIndex = 4;
            about_btn.Text = "О программе";
            about_btn.UseVisualStyleBackColor = true;
            about_btn.Click += about_btn_Click;
            // 
            // floor_one_btn
            // 
            floor_one_btn.Location = new Point(588, 674);
            floor_one_btn.Name = "floor_one_btn";
            floor_one_btn.Size = new Size(120, 35);
            floor_one_btn.TabIndex = 5;
            floor_one_btn.Text = "1 этаж";
            floor_one_btn.UseVisualStyleBackColor = true;
            floor_one_btn.Click += floor_one_btn_Click;
            // 
            // floor_two_btn
            // 
            floor_two_btn.Location = new Point(714, 675);
            floor_two_btn.Name = "floor_two_btn";
            floor_two_btn.Size = new Size(120, 35);
            floor_two_btn.TabIndex = 6;
            floor_two_btn.Text = "2 этаж";
            floor_two_btn.UseVisualStyleBackColor = true;
            floor_two_btn.Click += floor_two_btn_Click;
            // 
            // floor_three_btn
            // 
            floor_three_btn.Location = new Point(840, 674);
            floor_three_btn.Name = "floor_three_btn";
            floor_three_btn.Size = new Size(120, 35);
            floor_three_btn.TabIndex = 7;
            floor_three_btn.Text = "3 этаж";
            floor_three_btn.UseVisualStyleBackColor = true;
            floor_three_btn.Click += floor_three_btn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(floor_three_btn);
            Controls.Add(floor_two_btn);
            Controls.Add(floor_one_btn);
            Controls.Add(about_btn);
            Controls.Add(Btn_Delete);
            Controls.Add(Btn_Edit);
            Controls.Add(Btn_Add);
            Controls.Add(datagridview);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kursovaya";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridview;
        private Button Btn_Add;
        private Button Btn_Edit;
        private Button Btn_Delete;
        private OpenFileDialog openFileDialog1;
        private Button about_btn;
        private Button floor_one_btn;
        private Button floor_two_btn;
        private Button floor_three_btn;
    }
}