
namespace MarvelSnapTracker
{
    partial class MainMenu
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
            this.btnAddNewDeck = new System.Windows.Forms.Button();
            this.btnAddNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewDeck
            // 
            this.btnAddNewDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.btnAddNewDeck.Location = new System.Drawing.Point(12, 12);
            this.btnAddNewDeck.Name = "btnAddNewDeck";
            this.btnAddNewDeck.Size = new System.Drawing.Size(372, 426);
            this.btnAddNewDeck.TabIndex = 0;
            this.btnAddNewDeck.Text = "Add\r\nNew\r\nDeck";
            this.btnAddNewDeck.UseVisualStyleBackColor = true;
            this.btnAddNewDeck.Click += new System.EventHandler(this.btnAddNewDeck_Click);
            // 
            // btnAddNewGame
            // 
            this.btnAddNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.btnAddNewGame.Location = new System.Drawing.Point(390, 12);
            this.btnAddNewGame.Name = "btnAddNewGame";
            this.btnAddNewGame.Size = new System.Drawing.Size(372, 426);
            this.btnAddNewGame.TabIndex = 1;
            this.btnAddNewGame.Text = "Add\r\nNew\r\nGame";
            this.btnAddNewGame.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.btnAddNewGame);
            this.Controls.Add(this.btnAddNewDeck);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewDeck;
        private System.Windows.Forms.Button btnAddNewGame;
    }
}

