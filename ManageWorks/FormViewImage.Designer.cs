namespace ManageWorks
{
    partial class FormViewImage
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
            pictureBox = new PictureBox();
            BackBtn = new Button();
            NextBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1874, 930);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackBtn.Location = new Point(12, 948);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(131, 64);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "←";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            BackBtn.PreviewKeyDown += AllKeyDown;
            // 
            // NextBtn
            // 
            NextBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NextBtn.Location = new Point(1755, 948);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(131, 64);
            NextBtn.TabIndex = 2;
            NextBtn.Text = "→";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            NextBtn.PreviewKeyDown += AllKeyDown;
            // 
            // FormViewImage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(NextBtn);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox);
            Name = "FormViewImage";
            Text = "画像表示";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormClose;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button BackBtn;
        private Button NextBtn;
    }
}