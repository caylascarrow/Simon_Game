namespace SimonGame
{
    partial class MainScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.goGame = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goGame
            // 
            this.goGame.Location = new System.Drawing.Point(252, 297);
            this.goGame.Name = "goGame";
            this.goGame.Size = new System.Drawing.Size(87, 41);
            this.goGame.TabIndex = 0;
            this.goGame.TabStop = false;
            this.goGame.Text = "Start Game";
            this.goGame.UseVisualStyleBackColor = true;
            this.goGame.Click += new System.EventHandler(this.goGame_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(252, 369);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 41);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit Game";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Onyx", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Location = new System.Drawing.Point(204, 66);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(190, 107);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "SIMON";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.goGame);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goGame;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label titleLabel;
    }
}
