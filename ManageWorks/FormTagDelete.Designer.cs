namespace ManageWorks
{
    partial class FormTagDelete
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
            comboBox1 = new ComboBox();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(46, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(389, 33);
            comboBox1.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(584, 335);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(204, 103);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "削除";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // FormTagDelete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteBtn);
            Controls.Add(comboBox1);
            Name = "FormTagDelete";
            Text = "タグ：削除";
            FormClosed += FormClose;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button DeleteBtn;
    }
}