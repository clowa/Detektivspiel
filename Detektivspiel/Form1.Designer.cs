﻿namespace Detektivspiel
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
            resources.ApplyResources(this.OK_Button_Willkommenstext, "OK_Button_Willkommenstext");
            this.OK_Button_Willkommenstext.Name = "OK_Button_Willkommenstext";
            this.OK_Button_Willkommenstext.UseVisualStyleBackColor = true;
            this.OK_Button_Willkommenstext.Click += new System.EventHandler(this.OK_Button_Willkommenstext_Click);
            // 
            // Willkommenstext
            // 
            resources.ApplyResources(this.Willkommenstext, "Willkommenstext");
            this.Willkommenstext.Name = "Willkommenstext";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Willkommenstext);
            this.Controls.Add(this.OK_Button_Willkommenstext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_Button_Willkommenstext;
        private System.Windows.Forms.Label Willkommenstext;

    }
}

