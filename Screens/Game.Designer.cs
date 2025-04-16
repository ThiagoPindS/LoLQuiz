namespace LeagueQuests.Screens
{
    partial class Game
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
            txtQuestion = new TextBox();
            txtOptionE = new TextBox();
            txtOptionD = new TextBox();
            txtOptionC = new TextBox();
            txtOptionB = new TextBox();
            txtOptionA = new TextBox();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lblD = new Label();
            lblE = new Label();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(12, 109);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ReadOnly = true;
            txtQuestion.Size = new Size(776, 184);
            txtQuestion.TabIndex = 1;
            txtQuestion.Text = "Question";
            // 
            // txtOptionE
            // 
            txtOptionE.Location = new Point(33, 415);
            txtOptionE.Multiline = true;
            txtOptionE.Name = "txtOptionE";
            txtOptionE.ReadOnly = true;
            txtOptionE.Size = new Size(755, 23);
            txtOptionE.TabIndex = 2;
            txtOptionE.Click += txt_Click;
            // 
            // txtOptionD
            // 
            txtOptionD.Location = new Point(33, 386);
            txtOptionD.Multiline = true;
            txtOptionD.Name = "txtOptionD";
            txtOptionD.ReadOnly = true;
            txtOptionD.Size = new Size(755, 23);
            txtOptionD.TabIndex = 3;
            txtOptionD.Click += txt_Click;
            // 
            // txtOptionC
            // 
            txtOptionC.Location = new Point(33, 357);
            txtOptionC.Multiline = true;
            txtOptionC.Name = "txtOptionC";
            txtOptionC.ReadOnly = true;
            txtOptionC.Size = new Size(755, 23);
            txtOptionC.TabIndex = 4;
            txtOptionC.Click += txt_Click;
            // 
            // txtOptionB
            // 
            txtOptionB.Location = new Point(33, 328);
            txtOptionB.Multiline = true;
            txtOptionB.Name = "txtOptionB";
            txtOptionB.ReadOnly = true;
            txtOptionB.Size = new Size(755, 23);
            txtOptionB.TabIndex = 5;
            txtOptionB.Click += txt_Click;
            // 
            // txtOptionA
            // 
            txtOptionA.Location = new Point(33, 299);
            txtOptionA.Multiline = true;
            txtOptionA.Name = "txtOptionA";
            txtOptionA.ReadOnly = true;
            txtOptionA.Size = new Size(755, 23);
            txtOptionA.TabIndex = 6;
            txtOptionA.Click += txt_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(12, 302);
            lblA.Name = "lblA";
            lblA.Size = new Size(15, 15);
            lblA.TabIndex = 7;
            lblA.Text = "A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(12, 331);
            lblB.Name = "lblB";
            lblB.Size = new Size(14, 15);
            lblB.TabIndex = 8;
            lblB.Text = "B";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(12, 360);
            lblC.Name = "lblC";
            lblC.Size = new Size(15, 15);
            lblC.TabIndex = 9;
            lblC.Text = "C";
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Location = new Point(12, 389);
            lblD.Name = "lblD";
            lblD.Size = new Size(15, 15);
            lblD.TabIndex = 10;
            lblD.Text = "D";
            // 
            // lblE
            // 
            lblE.AutoSize = true;
            lblE.Location = new Point(12, 418);
            lblE.Name = "lblE";
            lblE.Size = new Size(13, 15);
            lblE.TabIndex = 11;
            lblE.Text = "E";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblE);
            Controls.Add(lblD);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(txtOptionA);
            Controls.Add(txtOptionB);
            Controls.Add(txtOptionC);
            Controls.Add(txtOptionD);
            Controls.Add(txtOptionE);
            Controls.Add(txtQuestion);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtQuestion;
        private TextBox txtOptionE;
        private TextBox txtOptionD;
        private TextBox txtOptionC;
        private TextBox txtOptionB;
        private TextBox txtOptionA;
        private Label lblA;
        private Label lblB;
        private Label lblD;
        private Label lblE;
        private Label lblC;
        internal Label label2;
    }
}