namespace Scriptura
{
    partial class Save
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Save));
            this.popupSaveButton = new System.Windows.Forms.Button();
            this.popupNoSaveButton = new System.Windows.Forms.Button();
            this.popupCancelButton = new System.Windows.Forms.Button();
            this.popupText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // popupSaveButton
            // 
            this.popupSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.popupSaveButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.popupSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.popupSaveButton.FlatAppearance.BorderSize = 0;
            this.popupSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.popupSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.popupSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popupSaveButton.ForeColor = System.Drawing.Color.White;
            this.popupSaveButton.Location = new System.Drawing.Point(42, 90);
            this.popupSaveButton.Name = "popupSaveButton";
            this.popupSaveButton.Size = new System.Drawing.Size(103, 38);
            this.popupSaveButton.TabIndex = 1;
            this.popupSaveButton.Text = "Save";
            this.popupSaveButton.UseVisualStyleBackColor = false;
            this.popupSaveButton.Click += new System.EventHandler(this.popupSaveButton_Click);
            // 
            // popupNoSaveButton
            // 
            this.popupNoSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.popupNoSaveButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.popupNoSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.popupNoSaveButton.FlatAppearance.BorderSize = 0;
            this.popupNoSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.popupNoSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.popupNoSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popupNoSaveButton.ForeColor = System.Drawing.Color.White;
            this.popupNoSaveButton.Location = new System.Drawing.Point(161, 90);
            this.popupNoSaveButton.Name = "popupNoSaveButton";
            this.popupNoSaveButton.Size = new System.Drawing.Size(103, 38);
            this.popupNoSaveButton.TabIndex = 2;
            this.popupNoSaveButton.Text = "Don\'t save";
            this.popupNoSaveButton.UseVisualStyleBackColor = false;
            this.popupNoSaveButton.Click += new System.EventHandler(this.popupNoSaveButton_Click);
            // 
            // popupCancelButton
            // 
            this.popupCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.popupCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.popupCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.popupCancelButton.FlatAppearance.BorderSize = 0;
            this.popupCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.popupCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.popupCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popupCancelButton.ForeColor = System.Drawing.Color.White;
            this.popupCancelButton.Location = new System.Drawing.Point(280, 90);
            this.popupCancelButton.Name = "popupCancelButton";
            this.popupCancelButton.Size = new System.Drawing.Size(103, 38);
            this.popupCancelButton.TabIndex = 3;
            this.popupCancelButton.Text = "Cancel";
            this.popupCancelButton.UseVisualStyleBackColor = false;
            this.popupCancelButton.Click += new System.EventHandler(this.popupCancelButton_Click);
            // 
            // popupText
            // 
            this.popupText.AutoSize = true;
            this.popupText.Font = new System.Drawing.Font("Borda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.popupText.ForeColor = System.Drawing.Color.White;
            this.popupText.Location = new System.Drawing.Point(86, 37);
            this.popupText.Name = "popupText";
            this.popupText.Size = new System.Drawing.Size(248, 20);
            this.popupText.TabIndex = 4;
            this.popupText.Text = "Do you want to save your changes?";
            this.popupText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(429, 159);
            this.Controls.Add(this.popupText);
            this.Controls.Add(this.popupCancelButton);
            this.Controls.Add(this.popupNoSaveButton);
            this.Controls.Add(this.popupSaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Save";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.Save_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button popupSaveButton;
        private Button popupNoSaveButton;
        private Button popupCancelButton;
        private Label popupText;
    }
}