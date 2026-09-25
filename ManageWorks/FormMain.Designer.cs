namespace ManageWorks
{
    partial class FormMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            InsertBtn = new Button();
            pictureBox1 = new PictureBox();
            tagInsertBtn = new Button();
            tagUpdateBtn = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            creator = new DataGridViewTextBoxColumn();
            favorite = new DataGridViewTextBoxColumn();
            thumbnail = new DataGridViewTextBoxColumn();
            Tag = new DataGridViewTextBoxColumn();
            ConditionsBtn = new Button();
            UpdateBtn = new Button();
            label1 = new Label();
            TagBox = new TextBox();
            FoluderBtn = new Button();
            tagDeleteBtn = new Button();
            DeleteBtn = new Button();
            VersionText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(1694, 830);
            button1.Name = "button1";
            button1.Size = new Size(192, 182);
            button1.TabIndex = 0;
            button1.Text = "表示";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Enter += FocusMoveList;
            // 
            // InsertBtn
            // 
            InsertBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InsertBtn.Location = new Point(1436, 832);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(112, 114);
            InsertBtn.TabIndex = 2;
            InsertBtn.Text = "登録";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            InsertBtn.Enter += FocusMoveList;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(1178, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(708, 772);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tagInsertBtn
            // 
            tagInsertBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tagInsertBtn.Location = new Point(1178, 830);
            tagInsertBtn.Name = "tagInsertBtn";
            tagInsertBtn.Size = new Size(112, 114);
            tagInsertBtn.TabIndex = 7;
            tagInsertBtn.Text = "タグ登録";
            tagInsertBtn.UseVisualStyleBackColor = true;
            tagInsertBtn.Click += tagInsertBtn_Click;
            tagInsertBtn.Enter += FocusMoveList;
            // 
            // tagUpdateBtn
            // 
            tagUpdateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tagUpdateBtn.Location = new Point(1296, 832);
            tagUpdateBtn.Name = "tagUpdateBtn";
            tagUpdateBtn.Size = new Size(112, 114);
            tagUpdateBtn.TabIndex = 8;
            tagUpdateBtn.Text = "タグ更新";
            tagUpdateBtn.UseVisualStyleBackColor = true;
            tagUpdateBtn.Click += tagUpdateBtn_Click;
            tagUpdateBtn.Enter += FocusMoveList;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, creator, favorite, thumbnail, Tag });
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1119, 960);
            dataGridView1.TabIndex = 9;
            dataGridView1.SelectionChanged += SelectChanged;
            dataGridView1.Click += listBox1_Click;
            dataGridView1.KeyUp += dataGridView1_KeyUp;
            // 
            // id
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 150;
            // 
            // name
            // 
            name.HeaderText = "作品名";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 500;
            // 
            // creator
            // 
            creator.HeaderText = "作者";
            creator.MinimumWidth = 8;
            creator.Name = "creator";
            creator.ReadOnly = true;
            creator.Width = 280;
            // 
            // favorite
            // 
            favorite.HeaderText = "お気に入り";
            favorite.MinimumWidth = 8;
            favorite.Name = "favorite";
            favorite.ReadOnly = true;
            favorite.Width = 130;
            // 
            // thumbnail
            // 
            thumbnail.HeaderText = "thumbnail";
            thumbnail.MinimumWidth = 8;
            thumbnail.Name = "thumbnail";
            thumbnail.ReadOnly = true;
            thumbnail.Visible = false;
            thumbnail.Width = 150;
            // 
            // Tag
            // 
            Tag.HeaderText = "タグ";
            Tag.MinimumWidth = 8;
            Tag.Name = "Tag";
            Tag.ReadOnly = true;
            Tag.Visible = false;
            Tag.Width = 150;
            // 
            // ConditionsBtn
            // 
            ConditionsBtn.Location = new Point(1019, 12);
            ConditionsBtn.Name = "ConditionsBtn";
            ConditionsBtn.Size = new Size(112, 34);
            ConditionsBtn.TabIndex = 10;
            ConditionsBtn.Text = "条件";
            ConditionsBtn.UseVisualStyleBackColor = true;
            ConditionsBtn.Click += ConditionsBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UpdateBtn.Location = new Point(1554, 832);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(112, 114);
            UpdateBtn.TabIndex = 11;
            UpdateBtn.Text = "更新";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            UpdateBtn.Enter += FocusMoveList;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(1178, 790);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 12;
            label1.Text = "タグ：";
            // 
            // TagBox
            // 
            TagBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TagBox.Font = new Font("Yu Gothic UI", 10F);
            TagBox.Location = new Point(1259, 790);
            TagBox.Name = "TagBox";
            TagBox.ReadOnly = true;
            TagBox.Size = new Size(627, 34);
            TagBox.TabIndex = 13;
            TagBox.Enter += FocusMoveList;
            // 
            // FoluderBtn
            // 
            FoluderBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FoluderBtn.BackColor = Color.Orange;
            FoluderBtn.Location = new Point(1178, 950);
            FoluderBtn.Name = "FoluderBtn";
            FoluderBtn.Size = new Size(112, 62);
            FoluderBtn.TabIndex = 14;
            FoluderBtn.Text = "フォルダ";
            FoluderBtn.UseVisualStyleBackColor = false;
            FoluderBtn.Click += FoluderBtn_Click;
            FoluderBtn.Enter += FocusMoveList;
            // 
            // tagDeleteBtn
            // 
            tagDeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tagDeleteBtn.BackColor = Color.LightCoral;
            tagDeleteBtn.ForeColor = SystemColors.ControlText;
            tagDeleteBtn.Location = new Point(1296, 951);
            tagDeleteBtn.Name = "tagDeleteBtn";
            tagDeleteBtn.Size = new Size(112, 60);
            tagDeleteBtn.TabIndex = 15;
            tagDeleteBtn.Text = "タグ削除";
            tagDeleteBtn.UseVisualStyleBackColor = false;
            tagDeleteBtn.Click += tagDeleteBtn_Click;
            tagDeleteBtn.Enter += FocusMoveList;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteBtn.BackColor = Color.LightCoral;
            DeleteBtn.Location = new Point(1436, 950);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(112, 62);
            DeleteBtn.TabIndex = 16;
            DeleteBtn.Text = "削除";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            DeleteBtn.Enter += FocusMoveList;
            // 
            // VersionText
            // 
            VersionText.AutoSize = true;
            VersionText.Location = new Point(12, 9);
            VersionText.Name = "VersionText";
            VersionText.Size = new Size(78, 25);
            VersionText.TabIndex = 17;
            VersionText.Text = "Ver.0.6.3";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(VersionText);
            Controls.Add(DeleteBtn);
            Controls.Add(tagDeleteBtn);
            Controls.Add(FoluderBtn);
            Controls.Add(TagBox);
            Controls.Add(label1);
            Controls.Add(UpdateBtn);
            Controls.Add(ConditionsBtn);
            Controls.Add(dataGridView1);
            Controls.Add(tagUpdateBtn);
            Controls.Add(tagInsertBtn);
            Controls.Add(pictureBox1);
            Controls.Add(InsertBtn);
            Controls.Add(button1);
            Name = "FormMain";
            Text = "メイン";
            Activated += FormFocusActive;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button InsertBtn;
        private PictureBox pictureBox1;
        private Button tagInsertBtn;
        private Button tagUpdateBtn;
        private DataGridView dataGridView1;
        private Button ConditionsBtn;
        private Button UpdateBtn;
        private Label label1;
        private TextBox TagBox;
        private Button FoluderBtn;
        private Button tagDeleteBtn;
        private Button DeleteBtn;
        private Label VersionText;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn creator;
        private DataGridViewTextBoxColumn favorite;
        private DataGridViewTextBoxColumn thumbnail;
        private DataGridViewTextBoxColumn Tag;
    }
}