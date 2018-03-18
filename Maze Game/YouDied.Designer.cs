namespace Maze_Game
{
    partial class YouDied
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
            this.again = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // again
            // 
            this.again.BackColor = System.Drawing.Color.Transparent;
            this.again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.again.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.again.Location = new System.Drawing.Point(142, 177);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(120, 30);
            this.again.TabIndex = 1;
            this.again.Text = "TRY AGAIN";
            this.again.UseVisualStyleBackColor = false;
            this.again.Click += new System.EventHandler(this.again_Click);
            // 
            // YouDied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maze_Game.Properties.Resources.youdied;
            this.ClientSize = new System.Drawing.Size(404, 212);
            this.Controls.Add(this.again);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YouDied";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouDied";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button again;
    }
}