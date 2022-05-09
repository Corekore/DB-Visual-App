
namespace FormUI
{
    partial class Reprezentant
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
            this.backRepButton = new System.Windows.Forms.Button();
            this.deleteRepButton = new System.Windows.Forms.Button();
            this.searchallRepButton = new System.Windows.Forms.Button();
            this.reprezentantidRepLabel = new System.Windows.Forms.Label();
            this.reprezentantidRepText = new System.Windows.Forms.TextBox();
            this.insertRepButton = new System.Windows.Forms.Button();
            this.dataRepLabel = new System.Windows.Forms.Label();
            this.dataRepText = new System.Windows.Forms.TextBox();
            this.sexRepLabel = new System.Windows.Forms.Label();
            this.sexRepText = new System.Windows.Forms.TextBox();
            this.orasRepLabel = new System.Windows.Forms.Label();
            this.orasRepText = new System.Windows.Forms.TextBox();
            this.numarRepLabel = new System.Windows.Forms.Label();
            this.numarRepText = new System.Windows.Forms.TextBox();
            this.stradaRepLabel = new System.Windows.Forms.Label();
            this.stradaRepText = new System.Windows.Forms.TextBox();
            this.cnpRepLabel = new System.Windows.Forms.Label();
            this.cnpRepText = new System.Windows.Forms.TextBox();
            this.prenumeRepLabel = new System.Windows.Forms.Label();
            this.prenumeRepText = new System.Windows.Forms.TextBox();
            this.numeRepLabel = new System.Windows.Forms.Label();
            this.numeRepText = new System.Windows.Forms.TextBox();
            this.reprezentantFoundListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backRepButton
            // 
            this.backRepButton.Location = new System.Drawing.Point(57, 567);
            this.backRepButton.Name = "backRepButton";
            this.backRepButton.Size = new System.Drawing.Size(113, 38);
            this.backRepButton.TabIndex = 48;
            this.backRepButton.Text = "Back";
            this.backRepButton.UseVisualStyleBackColor = true;
            this.backRepButton.Click += new System.EventHandler(this.backRepButton_Click);
            // 
            // deleteRepButton
            // 
            this.deleteRepButton.Location = new System.Drawing.Point(1046, 22);
            this.deleteRepButton.Name = "deleteRepButton";
            this.deleteRepButton.Size = new System.Drawing.Size(86, 30);
            this.deleteRepButton.TabIndex = 47;
            this.deleteRepButton.Text = "Delete";
            this.deleteRepButton.UseVisualStyleBackColor = true;
            this.deleteRepButton.Click += new System.EventHandler(this.deleteRepButton_Click);
            // 
            // searchallRepButton
            // 
            this.searchallRepButton.Location = new System.Drawing.Point(516, 22);
            this.searchallRepButton.Name = "searchallRepButton";
            this.searchallRepButton.Size = new System.Drawing.Size(132, 30);
            this.searchallRepButton.TabIndex = 46;
            this.searchallRepButton.Text = "Search All";
            this.searchallRepButton.UseVisualStyleBackColor = true;
            this.searchallRepButton.Click += new System.EventHandler(this.searchallRepButton_Click);
            // 
            // reprezentantidRepLabel
            // 
            this.reprezentantidRepLabel.AutoSize = true;
            this.reprezentantidRepLabel.Location = new System.Drawing.Point(800, 80);
            this.reprezentantidRepLabel.Name = "reprezentantidRepLabel";
            this.reprezentantidRepLabel.Size = new System.Drawing.Size(133, 17);
            this.reprezentantidRepLabel.TabIndex = 45;
            this.reprezentantidRepLabel.Text = "REPREZENTANTID";
            // 
            // reprezentantidRepText
            // 
            this.reprezentantidRepText.Location = new System.Drawing.Point(937, 77);
            this.reprezentantidRepText.Name = "reprezentantidRepText";
            this.reprezentantidRepText.Size = new System.Drawing.Size(255, 22);
            this.reprezentantidRepText.TabIndex = 44;
            // 
            // insertRepButton
            // 
            this.insertRepButton.Location = new System.Drawing.Point(937, 22);
            this.insertRepButton.Name = "insertRepButton";
            this.insertRepButton.Size = new System.Drawing.Size(86, 30);
            this.insertRepButton.TabIndex = 43;
            this.insertRepButton.Text = "Insert";
            this.insertRepButton.UseVisualStyleBackColor = true;
            this.insertRepButton.Click += new System.EventHandler(this.insertRepButton_Click);
            // 
            // dataRepLabel
            // 
            this.dataRepLabel.AutoSize = true;
            this.dataRepLabel.Location = new System.Drawing.Point(800, 456);
            this.dataRepLabel.Name = "dataRepLabel";
            this.dataRepLabel.Size = new System.Drawing.Size(90, 17);
            this.dataRepLabel.TabIndex = 42;
            this.dataRepLabel.Text = "Data Nasterii";
            // 
            // dataRepText
            // 
            this.dataRepText.Location = new System.Drawing.Point(937, 450);
            this.dataRepText.Name = "dataRepText";
            this.dataRepText.Size = new System.Drawing.Size(255, 22);
            this.dataRepText.TabIndex = 41;
            // 
            // sexRepLabel
            // 
            this.sexRepLabel.AutoSize = true;
            this.sexRepLabel.Location = new System.Drawing.Point(869, 410);
            this.sexRepLabel.Name = "sexRepLabel";
            this.sexRepLabel.Size = new System.Drawing.Size(31, 17);
            this.sexRepLabel.TabIndex = 40;
            this.sexRepLabel.Text = "Sex";
            // 
            // sexRepText
            // 
            this.sexRepText.Location = new System.Drawing.Point(937, 405);
            this.sexRepText.Name = "sexRepText";
            this.sexRepText.Size = new System.Drawing.Size(255, 22);
            this.sexRepText.TabIndex = 39;
            // 
            // orasRepLabel
            // 
            this.orasRepLabel.AutoSize = true;
            this.orasRepLabel.Location = new System.Drawing.Point(868, 362);
            this.orasRepLabel.Name = "orasRepLabel";
            this.orasRepLabel.Size = new System.Drawing.Size(39, 17);
            this.orasRepLabel.TabIndex = 38;
            this.orasRepLabel.Text = "Oras";
            // 
            // orasRepText
            // 
            this.orasRepText.Location = new System.Drawing.Point(937, 357);
            this.orasRepText.Name = "orasRepText";
            this.orasRepText.Size = new System.Drawing.Size(255, 22);
            this.orasRepText.TabIndex = 37;
            // 
            // numarRepLabel
            // 
            this.numarRepLabel.AutoSize = true;
            this.numarRepLabel.Location = new System.Drawing.Point(853, 316);
            this.numarRepLabel.Name = "numarRepLabel";
            this.numarRepLabel.Size = new System.Drawing.Size(50, 17);
            this.numarRepLabel.TabIndex = 36;
            this.numarRepLabel.Text = "Numar";
            // 
            // numarRepText
            // 
            this.numarRepText.Location = new System.Drawing.Point(937, 311);
            this.numarRepText.Name = "numarRepText";
            this.numarRepText.Size = new System.Drawing.Size(255, 22);
            this.numarRepText.TabIndex = 35;
            // 
            // stradaRepLabel
            // 
            this.stradaRepLabel.AutoSize = true;
            this.stradaRepLabel.Location = new System.Drawing.Point(853, 271);
            this.stradaRepLabel.Name = "stradaRepLabel";
            this.stradaRepLabel.Size = new System.Drawing.Size(50, 17);
            this.stradaRepLabel.TabIndex = 34;
            this.stradaRepLabel.Text = "Strada";
            // 
            // stradaRepText
            // 
            this.stradaRepText.Location = new System.Drawing.Point(937, 266);
            this.stradaRepText.Name = "stradaRepText";
            this.stradaRepText.Size = new System.Drawing.Size(255, 22);
            this.stradaRepText.TabIndex = 33;
            // 
            // cnpRepLabel
            // 
            this.cnpRepLabel.AutoSize = true;
            this.cnpRepLabel.Location = new System.Drawing.Point(869, 223);
            this.cnpRepLabel.Name = "cnpRepLabel";
            this.cnpRepLabel.Size = new System.Drawing.Size(36, 17);
            this.cnpRepLabel.TabIndex = 32;
            this.cnpRepLabel.Text = "CNP";
            // 
            // cnpRepText
            // 
            this.cnpRepText.Location = new System.Drawing.Point(937, 218);
            this.cnpRepText.Name = "cnpRepText";
            this.cnpRepText.Size = new System.Drawing.Size(255, 22);
            this.cnpRepText.TabIndex = 31;
            // 
            // prenumeRepLabel
            // 
            this.prenumeRepLabel.AutoSize = true;
            this.prenumeRepLabel.Location = new System.Drawing.Point(832, 173);
            this.prenumeRepLabel.Name = "prenumeRepLabel";
            this.prenumeRepLabel.Size = new System.Drawing.Size(65, 17);
            this.prenumeRepLabel.TabIndex = 30;
            this.prenumeRepLabel.Text = "Prenume";
            // 
            // prenumeRepText
            // 
            this.prenumeRepText.Location = new System.Drawing.Point(937, 170);
            this.prenumeRepText.Name = "prenumeRepText";
            this.prenumeRepText.Size = new System.Drawing.Size(255, 22);
            this.prenumeRepText.TabIndex = 29;
            // 
            // numeRepLabel
            // 
            this.numeRepLabel.AutoSize = true;
            this.numeRepLabel.Location = new System.Drawing.Point(859, 129);
            this.numeRepLabel.Name = "numeRepLabel";
            this.numeRepLabel.Size = new System.Drawing.Size(45, 17);
            this.numeRepLabel.TabIndex = 28;
            this.numeRepLabel.Text = "Nume";
            // 
            // numeRepText
            // 
            this.numeRepText.Location = new System.Drawing.Point(937, 124);
            this.numeRepText.Name = "numeRepText";
            this.numeRepText.Size = new System.Drawing.Size(255, 22);
            this.numeRepText.TabIndex = 27;
            // 
            // reprezentantFoundListbox
            // 
            this.reprezentantFoundListbox.FormattingEnabled = true;
            this.reprezentantFoundListbox.ItemHeight = 16;
            this.reprezentantFoundListbox.Location = new System.Drawing.Point(47, 77);
            this.reprezentantFoundListbox.Name = "reprezentantFoundListbox";
            this.reprezentantFoundListbox.Size = new System.Drawing.Size(751, 340);
            this.reprezentantFoundListbox.TabIndex = 26;
            // 
            // Reprezentant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 627);
            this.Controls.Add(this.backRepButton);
            this.Controls.Add(this.deleteRepButton);
            this.Controls.Add(this.searchallRepButton);
            this.Controls.Add(this.reprezentantidRepLabel);
            this.Controls.Add(this.reprezentantidRepText);
            this.Controls.Add(this.insertRepButton);
            this.Controls.Add(this.dataRepLabel);
            this.Controls.Add(this.dataRepText);
            this.Controls.Add(this.sexRepLabel);
            this.Controls.Add(this.sexRepText);
            this.Controls.Add(this.orasRepLabel);
            this.Controls.Add(this.orasRepText);
            this.Controls.Add(this.numarRepLabel);
            this.Controls.Add(this.numarRepText);
            this.Controls.Add(this.stradaRepLabel);
            this.Controls.Add(this.stradaRepText);
            this.Controls.Add(this.cnpRepLabel);
            this.Controls.Add(this.cnpRepText);
            this.Controls.Add(this.prenumeRepLabel);
            this.Controls.Add(this.prenumeRepText);
            this.Controls.Add(this.numeRepLabel);
            this.Controls.Add(this.numeRepText);
            this.Controls.Add(this.reprezentantFoundListbox);
            this.Name = "Reprezentant";
            this.Text = "Reprezentant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backRepButton;
        private System.Windows.Forms.Button deleteRepButton;
        private System.Windows.Forms.Button searchallRepButton;
        private System.Windows.Forms.Label reprezentantidRepLabel;
        private System.Windows.Forms.TextBox reprezentantidRepText;
        private System.Windows.Forms.Button insertRepButton;
        private System.Windows.Forms.Label dataRepLabel;
        private System.Windows.Forms.TextBox dataRepText;
        private System.Windows.Forms.Label sexRepLabel;
        private System.Windows.Forms.TextBox sexRepText;
        private System.Windows.Forms.Label orasRepLabel;
        private System.Windows.Forms.TextBox orasRepText;
        private System.Windows.Forms.Label numarRepLabel;
        private System.Windows.Forms.TextBox numarRepText;
        private System.Windows.Forms.Label stradaRepLabel;
        private System.Windows.Forms.TextBox stradaRepText;
        private System.Windows.Forms.Label cnpRepLabel;
        private System.Windows.Forms.TextBox cnpRepText;
        private System.Windows.Forms.Label prenumeRepLabel;
        private System.Windows.Forms.TextBox prenumeRepText;
        private System.Windows.Forms.Label numeRepLabel;
        private System.Windows.Forms.TextBox numeRepText;
        private System.Windows.Forms.ListBox reprezentantFoundListbox;
    }
}