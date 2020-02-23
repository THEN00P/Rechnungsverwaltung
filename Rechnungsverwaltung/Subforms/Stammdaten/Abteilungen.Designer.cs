namespace Rechnungsverwaltung.Subforms.Stammdaten
{
    partial class Abteilungen
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
            this.nameBox = new ZusatzComponents.TextBoxPlus();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.nameBox.Location = new System.Drawing.Point(29, 29);
            this.nameBox.Margin = new System.Windows.Forms.Padding(20);
            this.nameBox.Name = "nameBox";
            this.nameBox.PaddingLeftRight = new System.Drawing.Point(12, 12);
            this.nameBox.PasswordChar = '\0';
            this.nameBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nameBox.PlaceHolderText = "Name";
            this.nameBox.Size = new System.Drawing.Size(141, 36);
            this.nameBox.TabIndex = 2;
            // 
            // Abteilungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 415);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Abteilungen";
            this.Text = "Abteilung";
            this.ResumeLayout(false);

        }

        #endregion

        private ZusatzComponents.TextBoxPlus nameBox;
    }
}