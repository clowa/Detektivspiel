namespace Detektivspiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OK_Button_Willkommenstext = new System.Windows.Forms.Button();
            this.Willkommenstext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK_Button_Willkommenstext
            // 
            this.OK_Button_Willkommenstext.Location = new System.Drawing.Point(637, 268);
            this.OK_Button_Willkommenstext.Name = "OK_Button_Willkommenstext";
            this.OK_Button_Willkommenstext.Size = new System.Drawing.Size(75, 23);
            this.OK_Button_Willkommenstext.TabIndex = 3;
            this.OK_Button_Willkommenstext.Text = "OK";
            this.OK_Button_Willkommenstext.UseVisualStyleBackColor = true;
            this.OK_Button_Willkommenstext.Click += new System.EventHandler(this.OK_Button_Willkommenstext_Click);
            // 
            // Willkommenstext
            // 
            this.Willkommenstext.AutoSize = true;
            this.Willkommenstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Willkommenstext.Location = new System.Drawing.Point(12, 9);
            this.Willkommenstext.Name = "Willkommenstext";
            this.Willkommenstext.Size = new System.Drawing.Size(700, 256);
            this.Willkommenstext.TabIndex = 4;
            this.Willkommenstext.Text = resources.GetString("Willkommenstext.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 298);
            this.Controls.Add(this.Willkommenstext);
            this.Controls.Add(this.OK_Button_Willkommenstext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Herzlich willkommen bei unserem Detektivspiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_Button_Willkommenstext;
        private System.Windows.Forms.Label Willkommenstext;

    }
}

