namespace Lab1
{
    partial class Course
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
            DGView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_create = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txt_name = new TextBox();
            txt_duration = new TextBox();
            cmbox_topic = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGView).BeginInit();
            SuspendLayout();
            // 
            // DGView
            // 
            DGView.BackgroundColor = SystemColors.MenuBar;
            DGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGView.Location = new Point(12, 247);
            DGView.Name = "DGView";
            DGView.RowHeadersWidth = 62;
            DGView.Size = new Size(788, 225);
            DGView.TabIndex = 0;
            DGView.RowHeaderMouseDoubleClick += DGView_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Course Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 2;
            label2.Text = "Course Duration:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 3;
            label3.Text = "Topic:";
            // 
            // btn_create
            // 
            btn_create.Location = new Point(452, 195);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(112, 34);
            btn_create.TabIndex = 4;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(570, 195);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(688, 195);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(168, 23);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(422, 31);
            txt_name.TabIndex = 7;
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(168, 75);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(422, 31);
            txt_duration.TabIndex = 8;
            // 
            // cmbox_topic
            // 
            cmbox_topic.FormattingEnabled = true;
            cmbox_topic.Location = new Point(168, 132);
            cmbox_topic.Name = "cmbox_topic";
            cmbox_topic.Size = new Size(422, 33);
            cmbox_topic.TabIndex = 9;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(812, 485);
            Controls.Add(cmbox_topic);
            Controls.Add(txt_duration);
            Controls.Add(txt_name);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_create);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DGView);
            Name = "Course";
            Text = "Course CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_create;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_name;
        private TextBox txt_duration;
        private ComboBox cmbox_topic;
    }
}
