
namespace jyankenbattle
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.gameAriaPanel = new System.Windows.Forms.Panel();
            this.playerHandBox = new System.Windows.Forms.PictureBox();
            this.enemyHandBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorsButton = new System.Windows.Forms.PictureBox();
            this.paperButton = new System.Windows.Forms.PictureBox();
            this.lockButton = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.gameAriaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerHandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockButton)).BeginInit();
            this.SuspendLayout();
            // 
            // gameAriaPanel
            // 
            this.gameAriaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameAriaPanel.Controls.Add(this.playerHandBox);
            this.gameAriaPanel.Controls.Add(this.enemyHandBox);
            this.gameAriaPanel.Controls.Add(this.enemyPictureBox);
            this.gameAriaPanel.Location = new System.Drawing.Point(4, 30);
            this.gameAriaPanel.Name = "gameAriaPanel";
            this.gameAriaPanel.Size = new System.Drawing.Size(280, 410);
            this.gameAriaPanel.TabIndex = 0;
            // 
            // playerHandBox
            // 
            this.playerHandBox.Location = new System.Drawing.Point(92, 290);
            this.playerHandBox.Name = "playerHandBox";
            this.playerHandBox.Size = new System.Drawing.Size(100, 100);
            this.playerHandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerHandBox.TabIndex = 2;
            this.playerHandBox.TabStop = false;
            // 
            // enemyHandBox
            // 
            this.enemyHandBox.Location = new System.Drawing.Point(92, 184);
            this.enemyHandBox.Name = "enemyHandBox";
            this.enemyHandBox.Size = new System.Drawing.Size(100, 100);
            this.enemyHandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyHandBox.TabIndex = 1;
            this.enemyHandBox.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.Image = global::jyankenbattle.Properties.Resources.enemy;
            this.enemyPictureBox.Location = new System.Drawing.Point(40, 20);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(200, 160);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPictureBox.TabIndex = 0;
            this.enemyPictureBox.TabStop = false;
            // 
            // scissorsButton
            // 
            this.scissorsButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scissorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scissorsButton.Image = global::jyankenbattle.Properties.Resources.scissors;
            this.scissorsButton.Location = new System.Drawing.Point(104, 444);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(80, 80);
            this.scissorsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissorsButton.TabIndex = 4;
            this.scissorsButton.TabStop = false;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paperButton.Image = global::jyankenbattle.Properties.Resources.paper;
            this.paperButton.Location = new System.Drawing.Point(190, 444);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(80, 80);
            this.paperButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paperButton.TabIndex = 3;
            this.paperButton.TabStop = false;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // lockButton
            // 
            this.lockButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lockButton.Image = global::jyankenbattle.Properties.Resources.rock;
            this.lockButton.Location = new System.Drawing.Point(18, 444);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(80, 80);
            this.lockButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockButton.TabIndex = 2;
            this.lockButton.TabStop = false;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightCyan;
            this.startButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(290, 156);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(260, 40);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "スタート！";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.LightCyan;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("メイリオ", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.ForeColor = System.Drawing.Color.BlueViolet;
            this.title.Location = new System.Drawing.Point(290, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(260, 122);
            this.title.TabIndex = 6;
            this.title.Text = "じゃんけん\r\nバトル";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 547);
            this.Controls.Add(this.title);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.lockButton);
            this.Controls.Add(this.gameAriaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameAriaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerHandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameAriaPanel;
        private System.Windows.Forms.PictureBox playerHandBox;
        private System.Windows.Forms.PictureBox enemyHandBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.PictureBox lockButton;
        private System.Windows.Forms.PictureBox paperButton;
        private System.Windows.Forms.PictureBox scissorsButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label title;
    }
}

