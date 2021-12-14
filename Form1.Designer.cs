
namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRules = new System.Windows.Forms.Button();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRock.Location = new System.Drawing.Point(12, 84);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Kivi";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Lavender;
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaper.Location = new System.Drawing.Point(12, 137);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 0;
            this.btnPaper.Text = "Paber";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnScissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScissor.Location = new System.Drawing.Point(12, 201);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 0;
            this.btnScissor.Text = "Käärid";
            this.btnScissor.UseVisualStyleBackColor = false;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(737, 379);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Alusta uuesti";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mängija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bot";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(350, 84);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(233, 26);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Mängija: 0 - Bot: 0";
            // 
            // txtCountDown
            // 
            this.txtCountDown.AutoSize = true;
            this.txtCountDown.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountDown.Location = new System.Drawing.Point(454, 137);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(40, 26);
            this.txtCountDown.TabIndex = 2;
            this.txtCountDown.Text = "10";
            this.txtCountDown.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRounds.Location = new System.Drawing.Point(417, 240);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(106, 26);
            this.txtRounds.TabIndex = 2;
            this.txtRounds.Text = "Ümar: 3";
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimerEvent);
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(737, 408);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(75, 23);
            this.btnRules.TabIndex = 3;
            this.btnRules.Text = "Reglid";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // picCPU
            // 
            this.picCPU.Image = global::RockPaperScissors.Properties.Resources.qq;
            this.picCPU.Location = new System.Drawing.Point(649, 84);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(163, 140);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 1;
            this.picCPU.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::RockPaperScissors.Properties.Resources.qq;
            this.picPlayer.Location = new System.Drawing.Point(140, 84);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(163, 140);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 52);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Välja";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RockPaperScissors.Properties.Resources.wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(842, 446);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnClose;
    }
}

