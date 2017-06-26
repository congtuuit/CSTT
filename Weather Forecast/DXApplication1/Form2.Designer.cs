namespace DXApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Questions_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.Answer_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.AnswerBox = new DevExpress.XtraEditors.MemoEdit();
            this.QuestionBox = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Questions_labelControl
            // 
            this.Questions_labelControl.Location = new System.Drawing.Point(22, 10);
            this.Questions_labelControl.Name = "Questions_labelControl";
            this.Questions_labelControl.Size = new System.Drawing.Size(48, 13);
            this.Questions_labelControl.TabIndex = 1;
            this.Questions_labelControl.Text = "Questions";
            // 
            // Answer_labelControl
            // 
            this.Answer_labelControl.Location = new System.Drawing.Point(22, 101);
            this.Answer_labelControl.Name = "Answer_labelControl";
            this.Answer_labelControl.Size = new System.Drawing.Size(36, 13);
            this.Answer_labelControl.TabIndex = 2;
            this.Answer_labelControl.Text = "Answer";
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(12, 133);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBox.Properties.Appearance.Options.UseFont = true;
            this.AnswerBox.Properties.ReadOnly = true;
            this.AnswerBox.Size = new System.Drawing.Size(637, 205);
            this.AnswerBox.TabIndex = 4;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBox.FormattingEnabled = true;
            this.QuestionBox.Location = new System.Drawing.Point(12, 29);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(637, 23);
            this.QuestionBox.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(579, 56);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(70, 32);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Tra";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 350);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.Answer_labelControl);
            this.Controls.Add(this.Questions_labelControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q&A";
            ((System.ComponentModel.ISupportInitialize)(this.AnswerBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl Questions_labelControl;
        private DevExpress.XtraEditors.LabelControl Answer_labelControl;
        private System.Windows.Forms.ComboBox QuestionBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        protected DevExpress.XtraEditors.MemoEdit AnswerBox;
    }
}