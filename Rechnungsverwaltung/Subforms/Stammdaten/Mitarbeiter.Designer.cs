namespace Rechnungsverwaltung
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
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnHinzu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nameBox = new ZusatzComponents.TextBoxPlus();
            this.adresseBox = new ZusatzComponents.TextBoxPlus();
            this.plzBox = new ZusatzComponents.TextBoxPlus();
            this.logNameBox = new ZusatzComponents.TextBoxPlus();
            this.logPwBox = new ZusatzComponents.TextBoxPlus();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBea = new System.Windows.Forms.Button();
            this.btnDeak = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, -3);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Abteilung";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnHinzu
            // 
            this.btnHinzu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHinzu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnHinzu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHinzu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinzu.ForeColor = System.Drawing.Color.White;
            this.btnHinzu.Location = new System.Drawing.Point(20, 20);
            this.btnHinzu.Margin = new System.Windows.Forms.Padding(20);
            this.btnHinzu.Name = "btnHinzu";
            this.btnHinzu.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnHinzu.Size = new System.Drawing.Size(131, 47);
            this.btnHinzu.TabIndex = 7;
            this.btnHinzu.Text = "Hinzufügen";
            this.btnHinzu.UseVisualStyleBackColor = false;
            this.btnHinzu.Visible = false;
            this.btnHinzu.Click += new System.EventHandler(this.btnHinzu_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.nameBox);
            this.flowLayoutPanel1.Controls.Add(this.adresseBox);
            this.flowLayoutPanel1.Controls.Add(this.plzBox);
            this.flowLayoutPanel1.Controls.Add(this.logNameBox);
            this.flowLayoutPanel1.Controls.Add(this.logPwBox);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(85, 145);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(543, 9999);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(543, 152);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.nameBox.Location = new System.Drawing.Point(20, 20);
            this.nameBox.Margin = new System.Windows.Forms.Padding(20);
            this.nameBox.Name = "nameBox";
            this.nameBox.PaddingLeftRight = new System.Drawing.Point(12, 12);
            this.nameBox.PasswordChar = '\0';
            this.nameBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.nameBox.PlaceHolderText = "Name";
            this.nameBox.Size = new System.Drawing.Size(141, 36);
            this.nameBox.TabIndex = 1;
            // 
            // adresseBox
            // 
            this.adresseBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adresseBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adresseBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.adresseBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresseBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.adresseBox.Location = new System.Drawing.Point(201, 20);
            this.adresseBox.Margin = new System.Windows.Forms.Padding(20);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.PaddingLeftRight = new System.Drawing.Point(12, 12);
            this.adresseBox.PasswordChar = '\0';
            this.adresseBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.adresseBox.PlaceHolderText = "Adresse";
            this.adresseBox.Size = new System.Drawing.Size(141, 36);
            this.adresseBox.TabIndex = 2;
            // 
            // plzBox
            // 
            this.plzBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plzBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plzBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.plzBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.plzBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.plzBox.Location = new System.Drawing.Point(382, 20);
            this.plzBox.Margin = new System.Windows.Forms.Padding(20);
            this.plzBox.Name = "plzBox";
            this.plzBox.PaddingLeftRight = new System.Drawing.Point(12, 12);
            this.plzBox.PasswordChar = '\0';
            this.plzBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.plzBox.PlaceHolderText = "Postleitzahl";
            this.plzBox.Size = new System.Drawing.Size(141, 36);
            this.plzBox.TabIndex = 3;
            // 
            // logNameBox
            // 
            this.logNameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logNameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logNameBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.logNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.logNameBox.Location = new System.Drawing.Point(20, 96);
            this.logNameBox.Margin = new System.Windows.Forms.Padding(20);
            this.logNameBox.Name = "logNameBox";
            this.logNameBox.PaddingLeftRight = new System.Drawing.Point(12, 12);
            this.logNameBox.PasswordChar = '\0';
            this.logNameBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.logNameBox.PlaceHolderText = "Log-In Name";
            this.logNameBox.Size = new System.Drawing.Size(141, 36);
            this.logNameBox.TabIndex = 4;
            // 
            // logPwBox
            // 
            this.logPwBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logPwBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logPwBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.logPwBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logPwBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.logPwBox.Location = new System.Drawing.Point(201, 96);
            this.logPwBox.Margin = new System.Windows.Forms.Padding(20);
            this.logPwBox.Name = "logPwBox";
            this.logPwBox.PaddingLeftRight = new System.Drawing.Point(12, 12);
            this.logPwBox.PasswordChar = '*';
            this.logPwBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.logPwBox.PlaceHolderText = "Log-In Passwort";
            this.logPwBox.Size = new System.Drawing.Size(141, 36);
            this.logPwBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(382, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 36);
            this.panel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Controls.Add(this.btnHinzu);
            this.flowLayoutPanel2.Controls.Add(this.btnBea);
            this.flowLayoutPanel2.Controls.Add(this.btnDeak);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(85, 297);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(543, 9999);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(543, 86);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // btnBea
            // 
            this.btnBea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnBea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBea.ForeColor = System.Drawing.Color.White;
            this.btnBea.Location = new System.Drawing.Point(191, 20);
            this.btnBea.Margin = new System.Windows.Forms.Padding(20);
            this.btnBea.Name = "btnBea";
            this.btnBea.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnBea.Size = new System.Drawing.Size(131, 47);
            this.btnBea.TabIndex = 8;
            this.btnBea.Text = "Bearbeiten";
            this.btnBea.UseVisualStyleBackColor = false;
            this.btnBea.Visible = false;
            // 
            // btnDeak
            // 
            this.btnDeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnDeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeak.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeak.ForeColor = System.Drawing.Color.White;
            this.btnDeak.Location = new System.Drawing.Point(362, 20);
            this.btnDeak.Margin = new System.Windows.Forms.Padding(20);
            this.btnDeak.Name = "btnDeak";
            this.btnDeak.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnDeak.Size = new System.Drawing.Size(131, 47);
            this.btnDeak.TabIndex = 9;
            this.btnDeak.Text = "Deaktivieren";
            this.btnDeak.UseVisualStyleBackColor = false;
            this.btnDeak.Visible = false;
            // 
            // Abteilungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 529);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Abteilungen";
            this.Text = "Mitarbeiter";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnHinzu;
        private ZusatzComponents.TextBoxPlus nameBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ZusatzComponents.TextBoxPlus adresseBox;
        private ZusatzComponents.TextBoxPlus plzBox;
        private ZusatzComponents.TextBoxPlus logNameBox;
        private ZusatzComponents.TextBoxPlus logPwBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnBea;
        private System.Windows.Forms.Button btnDeak;
    }
}