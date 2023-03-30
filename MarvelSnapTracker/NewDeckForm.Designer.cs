
namespace MarvelSnapTracker
{
    partial class NewDeckForm
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
            System.Windows.Forms.Button btnMainMenu;
            btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            btnMainMenu.Location = new System.Drawing.Point(580, 12);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new System.Drawing.Size(208, 93);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // NewDeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnMainMenu);
            this.Name = "NewDeckForm";
            this.Text = "NewDeckForm";
            this.ResumeLayout(false);

        }

        #endregion
    }
}