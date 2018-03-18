namespace Maze_Game
{
    partial class Intermediar12
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
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(142, 177);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(120, 30);
            this.next.TabIndex = 0;
            this.next.Text = "NEXT LEVEL";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.button1_Click);
            // 
            // Intermediar12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maze_Game.Properties.Resources.intermediar12;
            this.ClientSize = new System.Drawing.Size(404, 212);
            this.Controls.Add(this.next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intermediar12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intermediar12";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button next;
    }
}