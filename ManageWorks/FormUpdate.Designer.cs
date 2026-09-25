namespace ManageWorks
{
    partial class FormUpdate
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
            thumbnail = new PictureBox();
            UpdateBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            thmnailBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            TBname = new TextBox();
            TBcreator = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)thumbnail).BeginInit();
            SuspendLayout();
            // 
            // thumbnail
            // 
            thumbnail.Location = new Point(727, 12);
            thumbnail.Name = "thumbnail";
            thumbnail.Size = new Size(667, 739);
            thumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            thumbnail.TabIndex = 18;
            thumbnail.TabStop = false;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(1216, 757);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(170, 65);
            UpdateBtn.TabIndex = 15;
            UpdateBtn.Text = "更新";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F);
            label5.Location = new Point(53, 181);
            label5.Margin = new Padding(3, 20, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 30;
            label5.Text = "お気に入り";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F);
            label4.Location = new Point(118, 233);
            label4.Margin = new Padding(3, 20, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 32);
            label4.TabIndex = 29;
            label4.Text = "タグ";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Yu Gothic UI", 10F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(175, 230);
            checkedListBox1.Margin = new Padding(3, 20, 3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(393, 500);
            checkedListBox1.TabIndex = 28;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(175, 186);
            checkBox1.Margin = new Padding(3, 20, 3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 27;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F);
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 26;
            label3.Text = "サムネイル画像";
            // 
            // thmnailBtn
            // 
            thmnailBtn.Location = new Point(175, 18);
            thmnailBtn.Name = "thmnailBtn";
            thmnailBtn.Size = new Size(112, 50);
            thmnailBtn.TabIndex = 25;
            thmnailBtn.Text = "選択";
            thmnailBtn.UseVisualStyleBackColor = true;
            thmnailBtn.Click += thmnailBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F);
            label2.Location = new Point(107, 125);
            label2.Margin = new Padding(3, 20, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 32);
            label2.TabIndex = 22;
            label2.Text = "作者";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(83, 79);
            label1.Margin = new Padding(3, 20, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 21;
            label1.Text = "作品名";
            // 
            // TBname
            // 
            TBname.Font = new Font("Yu Gothic UI", 10F);
            TBname.Location = new Point(175, 77);
            TBname.MaxLength = 50;
            TBname.Name = "TBname";
            TBname.Size = new Size(526, 34);
            TBname.TabIndex = 19;
            // 
            // TBcreator
            // 
            TBcreator.FormattingEnabled = true;
            TBcreator.Location = new Point(175, 128);
            TBcreator.Name = "TBcreator";
            TBcreator.Size = new Size(526, 33);
            TBcreator.TabIndex = 31;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 834);
            Controls.Add(TBcreator);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(thmnailBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBname);
            Controls.Add(thumbnail);
            Controls.Add(UpdateBtn);
            Name = "FormUpdate";
            Text = "更新";
            FormClosed += FormClose;
            ((System.ComponentModel.ISupportInitialize)thumbnail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox thumbnail;
        private Button UpdateBtn;
        private Label label5;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox1;
        private Label label3;
        private Button thmnailBtn;
        private Label label2;
        private Label label1;
        private TextBox TBname;
        private ComboBox TBcreator;
    }
}