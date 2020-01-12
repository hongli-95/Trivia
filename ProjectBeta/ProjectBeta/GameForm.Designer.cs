namespace TriviaNow
{
    partial class GameForm
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
            this.answerFourButton = new System.Windows.Forms.RadioButton();
            this.answerThreeButton = new System.Windows.Forms.RadioButton();
            this.answerTwoButton = new System.Windows.Forms.RadioButton();
            this.answerOneButton = new System.Windows.Forms.RadioButton();
            this.nextButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerFourButton
            // 
            this.answerFourButton.AutoSize = true;
            this.answerFourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerFourButton.Location = new System.Drawing.Point(12, 321);
            this.answerFourButton.Name = "answerFourButton";
            this.answerFourButton.Size = new System.Drawing.Size(80, 20);
            this.answerFourButton.TabIndex = 29;
            this.answerFourButton.TabStop = true;
            this.answerFourButton.Text = "Answer 4";
            this.answerFourButton.UseVisualStyleBackColor = true;
            // 
            // answerThreeButton
            // 
            this.answerThreeButton.AutoSize = true;
            this.answerThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerThreeButton.Location = new System.Drawing.Point(12, 277);
            this.answerThreeButton.Name = "answerThreeButton";
            this.answerThreeButton.Size = new System.Drawing.Size(77, 20);
            this.answerThreeButton.TabIndex = 28;
            this.answerThreeButton.TabStop = true;
            this.answerThreeButton.Text = "Answer3";
            this.answerThreeButton.UseVisualStyleBackColor = true;
            // 
            // answerTwoButton
            // 
            this.answerTwoButton.AutoSize = true;
            this.answerTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTwoButton.Location = new System.Drawing.Point(12, 236);
            this.answerTwoButton.Name = "answerTwoButton";
            this.answerTwoButton.Size = new System.Drawing.Size(80, 20);
            this.answerTwoButton.TabIndex = 27;
            this.answerTwoButton.TabStop = true;
            this.answerTwoButton.Text = "Answer 2";
            this.answerTwoButton.UseVisualStyleBackColor = true;
            // 
            // answerOneButton
            // 
            this.answerOneButton.AutoSize = true;
            this.answerOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerOneButton.Location = new System.Drawing.Point(12, 190);
            this.answerOneButton.Name = "answerOneButton";
            this.answerOneButton.Size = new System.Drawing.Size(80, 20);
            this.answerOneButton.TabIndex = 26;
            this.answerOneButton.TabStop = true;
            this.answerOneButton.Text = "Answer 1";
            this.answerOneButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(497, 415);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(129, 23);
            this.nextButton.TabIndex = 30;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(13, 79);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(60, 24);
            this.questionLabel.TabIndex = 31;
            this.questionLabel.Text = "label1";
            // 
            // questionCountLabel
            // 
            this.questionCountLabel.AutoSize = true;
            this.questionCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionCountLabel.Location = new System.Drawing.Point(494, 381);
            this.questionCountLabel.Name = "questionCountLabel";
            this.questionCountLabel.Size = new System.Drawing.Size(41, 13);
            this.questionCountLabel.TabIndex = 32;
            this.questionCountLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Questions Remaining";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionCountLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answerFourButton);
            this.Controls.Add(this.answerThreeButton);
            this.Controls.Add(this.answerTwoButton);
            this.Controls.Add(this.answerOneButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton answerFourButton;
        private System.Windows.Forms.RadioButton answerThreeButton;
        private System.Windows.Forms.RadioButton answerTwoButton;
        private System.Windows.Forms.RadioButton answerOneButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label questionCountLabel;
        private System.Windows.Forms.Label label2;
    }
}