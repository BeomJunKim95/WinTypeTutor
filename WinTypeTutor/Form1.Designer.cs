namespace WinTypeTutor
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblChance = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblSentence = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.시작ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblScore);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox1.Location = new System.Drawing.Point(50, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(300, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "점수";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("굴림체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(54, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "점수";
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblScore.Location = new System.Drawing.Point(154, 40);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(81, 19);
			this.lblScore.TabIndex = 1;
			this.lblScore.Text = "lblScore";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.lblChance);
			this.groupBox2.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox2.Location = new System.Drawing.Point(428, 44);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(300, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "남은기회";
			// 
			// lblChance
			// 
			this.lblChance.AutoSize = true;
			this.lblChance.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblChance.Location = new System.Drawing.Point(72, 40);
			this.lblChance.Name = "lblChance";
			this.lblChance.Size = new System.Drawing.Size(96, 19);
			this.lblChance.TabIndex = 0;
			this.lblChance.Text = "lblChance";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(174, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 19);
			this.label4.TabIndex = 1;
			this.label4.Text = "회";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(46, 184);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(682, 35);
			this.progressBar1.TabIndex = 2;
			// 
			// lblSentence
			// 
			this.lblSentence.AutoSize = true;
			this.lblSentence.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblSentence.Location = new System.Drawing.Point(46, 253);
			this.lblSentence.Name = "lblSentence";
			this.lblSentence.Size = new System.Drawing.Size(141, 24);
			this.lblSentence.TabIndex = 3;
			this.lblSentence.Text = "lblSentence";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtAnswer.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txtAnswer.Location = new System.Drawing.Point(46, 292);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(682, 35);
			this.txtAnswer.TabIndex = 0;
			this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
			this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 시작ToolStripMenuItem
			// 
			this.시작ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem1});
			this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
			this.시작ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.시작ToolStripMenuItem.Text = "시작";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// 시작ToolStripMenuItem1
			// 
			this.시작ToolStripMenuItem1.Name = "시작ToolStripMenuItem1";
			this.시작ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.시작ToolStripMenuItem1.Text = "시작";
			this.시작ToolStripMenuItem1.Click += new System.EventHandler(this.시작ToolStripMenuItem1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 389);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.lblSentence);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblChance;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lblSentence;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem1;
	}
}

