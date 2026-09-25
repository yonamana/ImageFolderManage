namespace ManageWorks
{
    partial class FormTagInsert
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
            tagBox = new TextBox();
            InsertBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tagBox
            // 
            tagBox.Font = new Font("Yu Gothic UI", 10F);
            tagBox.Location = new Point(106, 30);
            tagBox.Name = "tagBox";
            tagBox.Size = new Size(434, 34);
            tagBox.TabIndex = 1;
            // 
            // InsertBtn
            // 
            InsertBtn.Location = new Point(586, 212);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(180, 120);
            InsertBtn.TabIndex = 2;
            InsertBtn.Text = "登録";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 3;
            label1.Text = "タグ名";
            // 
            // FormTagInsert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 344);
            Controls.Add(label1);
            Controls.Add(InsertBtn);
            Controls.Add(tagBox);
            Name = "FormTagInsert";
            Text = "タグ：登録";
            FormClosed += FormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tagBox;
        private Button InsertBtn;
        private Label label1;
    }
}