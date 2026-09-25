namespace ManageWorks
{
    partial class FormInsert
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
            TBname = new TextBox();
            InsertBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            fileBtn = new Button();
            fileName = new Label();
            thumbnail = new PictureBox();
            thmnailBtn = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            TagInsertBtn = new Button();
            UpdateTagBoxBtn = new Button();
            label5 = new Label();
            TBcreator = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)thumbnail).BeginInit();
            SuspendLayout();
            // 
            // TBname
            // 
            TBname.Font = new Font("Yu Gothic UI", 10F);
            TBname.Location = new Point(175, 156);
            TBname.MaxLength = 50;
            TBname.Name = "TBname";
            TBname.Size = new Size(526, 34);
            TBname.TabIndex = 0;
            // 
            // InsertBtn
            // 
            InsertBtn.Location = new Point(1216, 759);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(170, 65);
            InsertBtn.TabIndex = 2;
            InsertBtn.Text = "登録";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(83, 156);
            label1.Margin = new Padding(3, 20, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 3;
            label1.Text = "作品名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F);
            label2.Location = new Point(107, 208);
            label2.Margin = new Padding(3, 20, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 32);
            label2.TabIndex = 4;
            label2.Text = "作者";
            // 
            // fileBtn
            // 
            fileBtn.Location = new Point(12, 12);
            fileBtn.Name = "fileBtn";
            fileBtn.Size = new Size(112, 76);
            fileBtn.TabIndex = 5;
            fileBtn.Text = "ファイル";
            fileBtn.UseVisualStyleBackColor = true;
            fileBtn.Click += fileBtn_Click;
            // 
            // fileName
            // 
            fileName.AutoSize = true;
            fileName.Location = new Point(149, 30);
            fileName.Name = "fileName";
            fileName.Size = new Size(0, 25);
            fileName.TabIndex = 6;
            // 
            // thumbnail
            // 
            thumbnail.Location = new Point(718, 37);
            thumbnail.Name = "thumbnail";
            thumbnail.Size = new Size(667, 716);
            thumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            thumbnail.TabIndex = 7;
            thumbnail.TabStop = false;
            // 
            // thmnailBtn
            // 
            thmnailBtn.Location = new Point(175, 97);
            thmnailBtn.Name = "thmnailBtn";
            thmnailBtn.Size = new Size(112, 50);
            thmnailBtn.TabIndex = 8;
            thmnailBtn.Text = "選択";
            thmnailBtn.UseVisualStyleBackColor = true;
            thmnailBtn.Click += thmnailBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 9;
            label3.Text = "サムネイル画像";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(175, 265);
            checkBox1.Margin = new Padding(3, 20, 3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 10;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Yu Gothic UI", 10F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(175, 309);
            checkedListBox1.Margin = new Padding(3, 20, 3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(408, 438);
            checkedListBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F);
            label4.Location = new Point(118, 312);
            label4.Margin = new Padding(3, 20, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 32);
            label4.TabIndex = 12;
            label4.Text = "タグ";
            // 
            // TagInsertBtn
            // 
            TagInsertBtn.Location = new Point(589, 640);
            TagInsertBtn.Name = "TagInsertBtn";
            TagInsertBtn.Size = new Size(112, 107);
            TagInsertBtn.TabIndex = 13;
            TagInsertBtn.Text = "タグ追加";
            TagInsertBtn.UseVisualStyleBackColor = true;
            TagInsertBtn.Click += TagInsertBtn_Click;
            // 
            // UpdateTagBoxBtn
            // 
            UpdateTagBoxBtn.Location = new Point(589, 561);
            UpdateTagBoxBtn.Name = "UpdateTagBoxBtn";
            UpdateTagBoxBtn.Size = new Size(112, 73);
            UpdateTagBoxBtn.TabIndex = 14;
            UpdateTagBoxBtn.Text = "更新";
            UpdateTagBoxBtn.UseVisualStyleBackColor = true;
            UpdateTagBoxBtn.Click += UpdateTagBoxBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F);
            label5.Location = new Point(53, 260);
            label5.Margin = new Padding(3, 20, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 15;
            label5.Text = "お気に入り";
            // 
            // TBcreator
            // 
            TBcreator.FormattingEnabled = true;
            TBcreator.Location = new Point(175, 211);
            TBcreator.Name = "TBcreator";
            TBcreator.Size = new Size(526, 33);
            TBcreator.TabIndex = 16;
            // 
            // FormInsert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 834);
            Controls.Add(TBcreator);
            Controls.Add(label5);
            Controls.Add(UpdateTagBoxBtn);
            Controls.Add(TagInsertBtn);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(thmnailBtn);
            Controls.Add(thumbnail);
            Controls.Add(fileName);
            Controls.Add(fileBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InsertBtn);
            Controls.Add(TBname);
            Name = "FormInsert";
            Text = "登録";
            FormClosed += FormClose;
            Load += Insert_Load;
            ((System.ComponentModel.ISupportInitialize)thumbnail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBname;
        private Button InsertBtn;
        private Label label1;
        private Label label2;
        private Button fileBtn;
        private Label fileName;
        private PictureBox thumbnail;
        private Button thmnailBtn;
        private Label label3;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private Button TagInsertBtn;
        private Button UpdateTagBoxBtn;
        private Label label5;
        private ComboBox TBcreator;
    }
}