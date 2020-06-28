namespace Detektivspiel
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.ok_btn_msgbox = new System.Windows.Forms.Button();
            this.lbl_msgbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_btn_msgbox
            // 
            this.ok_btn_msgbox.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn_msgbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn_msgbox.Location = new System.Drawing.Point(680, 246);
            this.ok_btn_msgbox.Margin = new System.Windows.Forms.Padding(6);
            this.ok_btn_msgbox.Name = "ok_btn_msgbox";
            this.ok_btn_msgbox.Size = new System.Drawing.Size(136, 40);
            this.ok_btn_msgbox.TabIndex = 0;
            this.ok_btn_msgbox.Text = "OK";
            this.ok_btn_msgbox.UseVisualStyleBackColor = true;
            // 
            // lbl_msgbox
            // 
            this.lbl_msgbox.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_msgbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msgbox.Location = new System.Drawing.Point(66, 25);
            this.lbl_msgbox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_msgbox.Name = "lbl_msgbox";
            this.lbl_msgbox.Size = new System.Drawing.Size(750, 194);
            this.lbl_msgbox.TabIndex = 1;
            this.lbl_msgbox.Text = "Text_Messagebox";
            // 
            // MsgBox
            // 
            this.AcceptButton = this.ok_btn_msgbox;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 310);
            this.Controls.Add(this.lbl_msgbox);
            this.Controls.Add(this.ok_btn_msgbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(874, 381);
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ok_btn_msgbox;
        private System.Windows.Forms.Label lbl_msgbox;
    }
}