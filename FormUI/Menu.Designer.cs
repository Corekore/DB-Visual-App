
namespace FormUI
{
    partial class Menu
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
            this.menuClientButton = new System.Windows.Forms.Button();
            this.menuAngajatButton = new System.Windows.Forms.Button();
            this.menuReprezentantButton = new System.Windows.Forms.Button();
            this.menuDocumenteButton = new System.Windows.Forms.Button();
            this.menuIstoricButton = new System.Windows.Forms.Button();
            this.menuSimpleButton = new System.Windows.Forms.Button();
            this.menuComplexeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuClientButton
            // 
            this.menuClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientButton.Location = new System.Drawing.Point(64, 28);
            this.menuClientButton.Name = "menuClientButton";
            this.menuClientButton.Size = new System.Drawing.Size(159, 95);
            this.menuClientButton.TabIndex = 0;
            this.menuClientButton.Text = "Actiuni Clienti";
            this.menuClientButton.UseVisualStyleBackColor = true;
            this.menuClientButton.Click += new System.EventHandler(this.menuClientButton_Click);
            // 
            // menuAngajatButton
            // 
            this.menuAngajatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAngajatButton.Location = new System.Drawing.Point(64, 150);
            this.menuAngajatButton.Name = "menuAngajatButton";
            this.menuAngajatButton.Size = new System.Drawing.Size(159, 95);
            this.menuAngajatButton.TabIndex = 1;
            this.menuAngajatButton.Text = "Actiuni Angajati";
            this.menuAngajatButton.UseVisualStyleBackColor = true;
            this.menuAngajatButton.Click += new System.EventHandler(this.menuAngajatButton_Click);
            // 
            // menuReprezentantButton
            // 
            this.menuReprezentantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReprezentantButton.Location = new System.Drawing.Point(64, 270);
            this.menuReprezentantButton.Name = "menuReprezentantButton";
            this.menuReprezentantButton.Size = new System.Drawing.Size(159, 95);
            this.menuReprezentantButton.TabIndex = 2;
            this.menuReprezentantButton.Text = "Actiuni Reprezentanti";
            this.menuReprezentantButton.UseVisualStyleBackColor = true;
            this.menuReprezentantButton.Click += new System.EventHandler(this.menuReprezentantButton_Click);
            // 
            // menuDocumenteButton
            // 
            this.menuDocumenteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDocumenteButton.Location = new System.Drawing.Point(64, 387);
            this.menuDocumenteButton.Name = "menuDocumenteButton";
            this.menuDocumenteButton.Size = new System.Drawing.Size(159, 95);
            this.menuDocumenteButton.TabIndex = 3;
            this.menuDocumenteButton.Text = "Actiuni Documente";
            this.menuDocumenteButton.UseVisualStyleBackColor = true;
            this.menuDocumenteButton.Click += new System.EventHandler(this.menuDocumenteButton_Click);
            // 
            // menuIstoricButton
            // 
            this.menuIstoricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuIstoricButton.Location = new System.Drawing.Point(64, 504);
            this.menuIstoricButton.Name = "menuIstoricButton";
            this.menuIstoricButton.Size = new System.Drawing.Size(159, 95);
            this.menuIstoricButton.TabIndex = 4;
            this.menuIstoricButton.Text = "Actiuni Istoric";
            this.menuIstoricButton.UseVisualStyleBackColor = true;
            this.menuIstoricButton.Click += new System.EventHandler(this.menuIstoricButton_Click);
            // 
            // menuSimpleButton
            // 
            this.menuSimpleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSimpleButton.Location = new System.Drawing.Point(276, 28);
            this.menuSimpleButton.Name = "menuSimpleButton";
            this.menuSimpleButton.Size = new System.Drawing.Size(159, 95);
            this.menuSimpleButton.TabIndex = 5;
            this.menuSimpleButton.Text = "Actiuni Suplimentare Simple";
            this.menuSimpleButton.UseVisualStyleBackColor = true;
            this.menuSimpleButton.Click += new System.EventHandler(this.menuSimpleButton_Click);
            // 
            // menuComplexeButton
            // 
            this.menuComplexeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuComplexeButton.Location = new System.Drawing.Point(276, 150);
            this.menuComplexeButton.Name = "menuComplexeButton";
            this.menuComplexeButton.Size = new System.Drawing.Size(159, 95);
            this.menuComplexeButton.TabIndex = 6;
            this.menuComplexeButton.Text = "Actiuni Suplimentare Complexe";
            this.menuComplexeButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 627);
            this.Controls.Add(this.menuComplexeButton);
            this.Controls.Add(this.menuSimpleButton);
            this.Controls.Add(this.menuIstoricButton);
            this.Controls.Add(this.menuDocumenteButton);
            this.Controls.Add(this.menuReprezentantButton);
            this.Controls.Add(this.menuAngajatButton);
            this.Controls.Add(this.menuClientButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuClientButton;
        private System.Windows.Forms.Button menuAngajatButton;
        private System.Windows.Forms.Button menuReprezentantButton;
        private System.Windows.Forms.Button menuDocumenteButton;
        private System.Windows.Forms.Button menuIstoricButton;
        private System.Windows.Forms.Button menuSimpleButton;
        private System.Windows.Forms.Button menuComplexeButton;
    }
}