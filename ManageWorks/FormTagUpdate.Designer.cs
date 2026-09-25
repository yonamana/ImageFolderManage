namespace ManageWorks
{
    partial class FormTagUpdate
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
            updateBtn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Yu Gothic UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(412, 36);
            comboBox1.TabIndex = 1;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(586, 212);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(180, 120);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "更新";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 10F);
            textBox1.Location = new Point(170, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 34);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 4;
            label1.Text = "変更するタグ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F);
            label2.Location = new Point(65, 75);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 5;
            label2.Text = "新タグ名";
            // 
            // FormTagUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 344);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(updateBtn);
            Controls.Add(comboBox1);
            Name = "FormTagUpdate";
            Text = "タグ：更新";
            FormClosed += FormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button updateBtn;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}