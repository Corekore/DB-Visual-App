
namespace FormUI
{
    partial class Angajat
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
            this.backAngButton = new System.Windows.Forms.Button();
            this.deleteAngButton = new System.Windows.Forms.Button();
            this.searchallAngButton = new System.Windows.Forms.Button();
            this.clientidAngLabel = new System.Windows.Forms.Label();
            this.angajatidAngText = new System.Windows.Forms.TextBox();
            this.insertAngButton = new System.Windows.Forms.Button();
            this.angajatidAngLabel = new System.Windows.Forms.Label();
            this.clientidAngText = new System.Windows.Forms.TextBox();
            this.prenumeAngLabel = new System.Windows.Forms.Label();
            this.prenumeAngText = new System.Windows.Forms.TextBox();
            this.numeAngLabel = new System.Windows.Forms.Label();
            this.numeAngText = new System.Windows.Forms.TextBox();
            this.angajatFoundListbox = new System.Windows.Forms.ListBox();
            this.updateAngButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backAngButton
            // 
            this.backAngButton.Location = new System.Drawing.Point(57, 567);
            this.backAngButton.Name = "backAngButton";
            this.backAngButton.Size = new System.Drawing.Size(113, 38);
            this.backAngButton.TabIndex = 48;
            this.backAngButton.Text = "Back";
            this.backAngButton.UseVisualStyleBackColor = true;
            this.backAngButton.Click += new System.EventHandler(this.backAngButton_Click);
            // 
            // deleteAngButton
            // 
            this.deleteAngButton.Location = new System.Drawing.Point(1003, 22);
            this.deleteAngButton.Name = "deleteAngButton";
            this.deleteAngButton.Size = new System.Drawing.Size(86, 30);
            this.deleteAngButton.TabIndex = 47;
            this.deleteAngButton.Text = "Delete";
            this.deleteAngButton.UseVisualStyleBackColor = true;
            this.deleteAngButton.Click += new System.EventHandler(this.deleteAngButton_Click);
            // 
            // searchallAngButton
            // 
            this.searchallAngButton.Location = new System.Drawing.Point(516, 22);
            this.searchallAngButton.Name = "searchallAngButton";
            this.searchallAngButton.Size = new System.Drawing.Size(132, 30);
            this.searchallAngButton.TabIndex = 46;
            this.searchallAngButton.Text = "Search All";
            this.searchallAngButton.UseVisualStyleBackColor = true;
            this.searchallAngButton.Click += new System.EventHandler(this.searchallAngButton_Click);
            // 
            // clientidAngLabel
            // 
            this.clientidAngLabel.AutoSize = true;
            this.clientidAngLabel.Location = new System.Drawing.Point(848, 220);
            this.clientidAngLabel.Name = "clientidAngLabel";
            this.clientidAngLabel.Size = new System.Drawing.Size(69, 17);
            this.clientidAngLabel.TabIndex = 45;
            this.clientidAngLabel.Text = "CLIENTID";
            // 
            // angajatidAngText
            // 
            this.angajatidAngText.Location = new System.Drawing.Point(937, 77);
            this.angajatidAngText.Name = "angajatidAngText";
            this.angajatidAngText.Size = new System.Drawing.Size(255, 22);
            this.angajatidAngText.TabIndex = 44;
            // 
            // insertAngButton
            // 
            this.insertAngButton.Location = new System.Drawing.Point(894, 22);
            this.insertAngButton.Name = "insertAngButton";
            this.insertAngButton.Size = new System.Drawing.Size(86, 30);
            this.insertAngButton.TabIndex = 43;
            this.insertAngButton.Text = "Insert";
            this.insertAngButton.UseVisualStyleBackColor = true;
            this.insertAngButton.Click += new System.EventHandler(this.insertAngButton_Click);
            // 
            // angajatidAngLabel
            // 
            this.angajatidAngLabel.AutoSize = true;
            this.angajatidAngLabel.Location = new System.Drawing.Point(832, 82);
            this.angajatidAngLabel.Name = "angajatidAngLabel";
            this.angajatidAngLabel.Size = new System.Drawing.Size(85, 17);
            this.angajatidAngLabel.TabIndex = 34;
            this.angajatidAngLabel.Text = "ANGAJATID";
            // 
            // clientidAngText
            // 
            this.clientidAngText.Location = new System.Drawing.Point(937, 218);
            this.clientidAngText.Name = "clientidAngText";
            this.clientidAngText.Size = new System.Drawing.Size(255, 22);
            this.clientidAngText.TabIndex = 31;
            // 
            // prenumeAngLabel
            // 
            this.prenumeAngLabel.AutoSize = true;
            this.prenumeAngLabel.Location = new System.Drawing.Point(852, 172);
            this.prenumeAngLabel.Name = "prenumeAngLabel";
            this.prenumeAngLabel.Size = new System.Drawing.Size(65, 17);
            this.prenumeAngLabel.TabIndex = 30;
            this.prenumeAngLabel.Text = "Prenume";
            // 
            // prenumeAngText
            // 
            this.prenumeAngText.Location = new System.Drawing.Point(937, 170);
            this.prenumeAngText.Name = "prenumeAngText";
            this.prenumeAngText.Size = new System.Drawing.Size(255, 22);
            this.prenumeAngText.TabIndex = 29;
            // 
            // numeAngLabel
            // 
            this.numeAngLabel.AutoSize = true;
            this.numeAngLabel.Location = new System.Drawing.Point(872, 129);
            this.numeAngLabel.Name = "numeAngLabel";
            this.numeAngLabel.Size = new System.Drawing.Size(45, 17);
            this.numeAngLabel.TabIndex = 28;
            this.numeAngLabel.Text = "Nume";
            // 
            // numeAngText
            // 
            this.numeAngText.Location = new System.Drawing.Point(937, 124);
            this.numeAngText.Name = "numeAngText";
            this.numeAngText.Size = new System.Drawing.Size(255, 22);
            this.numeAngText.TabIndex = 27;
            // 
            // angajatFoundListbox
            // 
            this.angajatFoundListbox.FormattingEnabled = true;
            this.angajatFoundListbox.ItemHeight = 16;
            this.angajatFoundListbox.Location = new System.Drawing.Point(47, 77);
            this.angajatFoundListbox.Name = "angajatFoundListbox";
            this.angajatFoundListbox.Size = new System.Drawing.Size(742, 356);
            this.angajatFoundListbox.TabIndex = 26;
            // 
            // updateAngButton
            // 
            this.updateAngButton.Location = new System.Drawing.Point(1106, 22);
            this.updateAngButton.Name = "updateAngButton";
            this.updateAngButton.Size = new System.Drawing.Size(86, 30);
            this.updateAngButton.TabIndex = 49;
            this.updateAngButton.Text = "Update";
            this.updateAngButton.UseVisualStyleBackColor = true;
            this.updateAngButton.Click += new System.EventHandler(this.updateAngButton_Click);
            // 
            // Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 627);
            this.Controls.Add(this.updateAngButton);
            this.Controls.Add(this.backAngButton);
            this.Controls.Add(this.deleteAngButton);
            this.Controls.Add(this.searchallAngButton);
            this.Controls.Add(this.clientidAngLabel);
            this.Controls.Add(this.angajatidAngText);
            this.Controls.Add(this.insertAngButton);
            this.Controls.Add(this.angajatidAngLabel);
            this.Controls.Add(this.clientidAngText);
            this.Controls.Add(this.prenumeAngLabel);
            this.Controls.Add(this.prenumeAngText);
            this.Controls.Add(this.numeAngLabel);
            this.Controls.Add(this.numeAngText);
            this.Controls.Add(this.angajatFoundListbox);
            this.Name = "Angajat";
            this.Text = "Angajat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backAngButton;
        private System.Windows.Forms.Button deleteAngButton;
        private System.Windows.Forms.Button searchallAngButton;
        private System.Windows.Forms.Label clientidAngLabel;
        private System.Windows.Forms.TextBox angajatidAngText;
        private System.Windows.Forms.Button insertAngButton;
        private System.Windows.Forms.Label angajatidAngLabel;
        private System.Windows.Forms.TextBox clientidAngText;
        private System.Windows.Forms.Label prenumeAngLabel;
        private System.Windows.Forms.TextBox prenumeAngText;
        private System.Windows.Forms.Label numeAngLabel;
        private System.Windows.Forms.TextBox numeAngText;
        private System.Windows.Forms.ListBox angajatFoundListbox;
        private System.Windows.Forms.Button updateAngButton;
    }
}