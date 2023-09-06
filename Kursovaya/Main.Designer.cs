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
            Btn_Add.Location = new Point(292, 674);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(120, 35);
            Btn_Add.TabIndex = 1;
            Btn_Add.Text = "Добавить";
            Btn_Add.UseVisualStyleBackColor = true;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.Location = new Point(418, 674);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(120, 35);
            Btn_Edit.TabIndex = 2;
            Btn_Edit.Text = "Изменить";
            Btn_Edit.UseVisualStyleBackColor = true;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Location = new Point(544, 674);
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
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
        }

        #endregion

        private DataGridView datagridview;
        private Button Btn_Add;
        private Button Btn_Edit;
        private Button Btn_Delete;
        private OpenFileDialog openFileDialog1;
    }
}