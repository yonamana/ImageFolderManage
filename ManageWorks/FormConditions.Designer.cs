namespace ManageWorks
{
    partial class FormConditions
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
            CreatorBox = new ComboBox();
            label1 = new Label();
            favoriteBox = new CheckBox();
            label2 = new Label();
            TagBox = new CheckedListBox();
            SearchBtn = new Button();
            SuspendLayout();
            // 
            // CreatorBox
            // 
            CreatorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CreatorBox.FormattingEnabled = true;
            CreatorBox.Location = new Point(114, 35);
            CreatorBox.Name = "CreatorBox";
            CreatorBox.Size = new Size(367, 33);
            CreatorBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 1;
            label1.Text = "作者";
            // 
            // favoriteBox
            // 
            favoriteBox.AutoSize = true;
            favoriteBox.Location = new Point(125, 115);
            favoriteBox.Name = "favoriteBox";
            favoriteBox.Size = new Size(115, 29);
            favoriteBox.TabIndex = 2;
            favoriteBox.Text = "お気に入り";
            favoriteBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 175);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 3;
            label2.Text = "タグ";
            // 
            // TagBox
            // 
            TagBox.Font = new Font("Yu Gothic UI", 10F);
            TagBox.FormattingEnabled = true;
            TagBox.Location = new Point(114, 184);
            TagBox.Name = "TagBox";
            TagBox.Size = new Size(367, 252);
            TagBox.TabIndex = 4;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(623, 329);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(165, 111);
            SearchBtn.TabIndex = 5;
            SearchBtn.Text = "検索";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // FormConditions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBtn);
            Controls.Add(TagBox);
            Controls.Add(label2);
            Controls.Add(favoriteBox);
            Controls.Add(label1);
            Controls.Add(CreatorBox);
            Name = "FormConditions";
            Text = "検索条件";
            FormClosed += FormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox CreatorBox;
        private Label label1;
        private CheckBox favoriteBox;
        private Label label2;
        private CheckedListBox TagBox;
        private Button SearchBtn;
    }
}