namespace Airplane_Fighter
{
    partial class airplaneFighter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(airplaneFighter));
            this.startGameButton = new System.Windows.Forms.Button();
            this.airCraft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.airCraft)).BeginInit();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startGameButton.BackColor = System.Drawing.Color.White;
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGameButton.Location = new System.Drawing.Point(193, 130);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(400, 100);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseMnemonic = false;
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // airCraft
            // 
            this.airCraft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.airCraft.BackColor = System.Drawing.Color.Transparent;
            this.airCraft.Image = ((System.Drawing.Image)(resources.GetObject("airCraft.Image")));
            this.airCraft.Location = new System.Drawing.Point(400, 390);
            this.airCraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.airCraft.Name = "airCraft";
            this.airCraft.Size = new System.Drawing.Size(50, 50);
            this.airCraft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airCraft.TabIndex = 1;
            this.airCraft.TabStop = false;
            this.airCraft.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.airCraft);
            this.Controls.Add(this.startGameButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.airCraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.PictureBox airCraft;
    }
}

