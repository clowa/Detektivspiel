﻿namespace Detektivspiel
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_hinweis = new System.Windows.Forms.Label();
            this.Hinweistext = new System.Windows.Forms.Label();
            this.lbl_hinweis = new System.Windows.Forms.Label();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.btn_weiter = new System.Windows.Forms.Button();
            this.Frage = new System.Windows.Forms.Label();
            this.btn_Antwort_bestaetigen = new System.Windows.Forms.Button();
            this.Antwortfeld = new System.Windows.Forms.TextBox();
            this.btn_Verlassen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Fallgeloest = new System.Windows.Forms.Button();
            this.Lbl_QueryResult = new System.Windows.Forms.Label();
            this.btn_RunQuery = new System.Windows.Forms.Button();
            this.Lbl_QueryCmd = new System.Windows.Forms.Label();
            this.Txt_QueryCmd = new System.Windows.Forms.TextBox();
            this.Grid_QueryResult = new System.Windows.Forms.DataGridView();
            this.Lbl_horizontalLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_QueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label_hinweis
            // 
            this.label_hinweis.AutoSize = true;
            this.label_hinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hinweis.Location = new System.Drawing.Point(21, 10);
            this.label_hinweis.Name = "label_hinweis";
            this.label_hinweis.Size = new System.Drawing.Size(0, 13);
            this.label_hinweis.TabIndex = 0;
            // 
            // Hinweistext
            // 
            this.Hinweistext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hinweistext.BackColor = System.Drawing.SystemColors.Info;
            this.Hinweistext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hinweistext.Location = new System.Drawing.Point(21, 36);
            this.Hinweistext.Name = "Hinweistext";
            this.Hinweistext.Size = new System.Drawing.Size(401, 100);
            this.Hinweistext.TabIndex = 1;
            this.Hinweistext.Text = "Hinweistext";
            // 
            // lbl_hinweis
            // 
            this.lbl_hinweis.AutoSize = true;
            this.lbl_hinweis.BackColor = System.Drawing.SystemColors.GrayText;
            this.lbl_hinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hinweis.Location = new System.Drawing.Point(21, 10);
            this.lbl_hinweis.Name = "lbl_hinweis";
            this.lbl_hinweis.Size = new System.Drawing.Size(62, 16);
            this.lbl_hinweis.TabIndex = 2;
            this.lbl_hinweis.Text = "Hinweis";
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.AutoSize = true;
            this.btn_zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zurueck.Location = new System.Drawing.Point(24, 143);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(170, 26);
            this.btn_zurueck.TabIndex = 3;
            this.btn_zurueck.Text = "Vorheriger Hinweis";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            this.btn_zurueck.Click += new System.EventHandler(this.btn_zurueck_Click);
            // 
            // btn_weiter
            // 
            this.btn_weiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_weiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_weiter.Location = new System.Drawing.Point(264, 143);
            this.btn_weiter.Name = "btn_weiter";
            this.btn_weiter.Size = new System.Drawing.Size(158, 26);
            this.btn_weiter.TabIndex = 4;
            this.btn_weiter.Text = "Nächster Hinweis";
            this.btn_weiter.UseVisualStyleBackColor = true;
            this.btn_weiter.Click += new System.EventHandler(this.btn_weiter_Click);
            // 
            // Frage
            // 
            this.Frage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frage.Location = new System.Drawing.Point(21, 188);
            this.Frage.Name = "Frage";
            this.Frage.Size = new System.Drawing.Size(415, 35);
            this.Frage.TabIndex = 5;
            this.Frage.Text = "Frage";
            // 
            // btn_Antwort_bestaetigen
            // 
            this.btn_Antwort_bestaetigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Antwort_bestaetigen.AutoSize = true;
            this.btn_Antwort_bestaetigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Antwort_bestaetigen.Location = new System.Drawing.Point(323, 240);
            this.btn_Antwort_bestaetigen.Name = "btn_Antwort_bestaetigen";
            this.btn_Antwort_bestaetigen.Size = new System.Drawing.Size(99, 26);
            this.btn_Antwort_bestaetigen.TabIndex = 6;
            this.btn_Antwort_bestaetigen.Text = "Bestätigen";
            this.btn_Antwort_bestaetigen.UseVisualStyleBackColor = true;
            this.btn_Antwort_bestaetigen.Click += new System.EventHandler(this.Antwort_bestaetigen_Click);
            // 
            // Antwortfeld
            // 
            this.Antwortfeld.AcceptsReturn = true;
            this.Antwortfeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antwortfeld.Location = new System.Drawing.Point(24, 244);
            this.Antwortfeld.Name = "Antwortfeld";
            this.Antwortfeld.Size = new System.Drawing.Size(130, 22);
            this.Antwortfeld.TabIndex = 0;
            this.Antwortfeld.Text = "Antwortfeld";
            this.Antwortfeld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Antwortfeld_KeyDown);
            // 
            // btn_Verlassen
            // 
            this.btn_Verlassen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Verlassen.AutoSize = true;
            this.btn_Verlassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verlassen.Location = new System.Drawing.Point(323, 272);
            this.btn_Verlassen.Name = "btn_Verlassen";
            this.btn_Verlassen.Size = new System.Drawing.Size(99, 26);
            this.btn_Verlassen.TabIndex = 8;
            this.btn_Verlassen.Text = "Verlassen";
            this.btn_Verlassen.UseVisualStyleBackColor = true;
            this.btn_Verlassen.Click += new System.EventHandler(this.btn_Verlassen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(24, 175);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(398, 10);
            this.progressBar1.TabIndex = 11;
            // 
            // btn_Fallgeloest
            // 
            this.btn_Fallgeloest.AutoSize = true;
            this.btn_Fallgeloest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fallgeloest.Location = new System.Drawing.Point(24, 273);
            this.btn_Fallgeloest.Name = "btn_Fallgeloest";
            this.btn_Fallgeloest.Size = new System.Drawing.Size(130, 26);
            this.btn_Fallgeloest.TabIndex = 10;
            this.btn_Fallgeloest.Text = "Fall gelöst";
            this.btn_Fallgeloest.UseVisualStyleBackColor = true;
            this.btn_Fallgeloest.Visible = false;
            this.btn_Fallgeloest.Click += new System.EventHandler(this.btn_Fallschliessen_Click);
            // 
            // Lbl_QueryResult
            // 
            this.Lbl_QueryResult.AutoSize = true;
            this.Lbl_QueryResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QueryResult.Location = new System.Drawing.Point(24, 480);
            this.Lbl_QueryResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_QueryResult.Name = "Lbl_QueryResult";
            this.Lbl_QueryResult.Size = new System.Drawing.Size(97, 16);
            this.Lbl_QueryResult.TabIndex = 23;
            this.Lbl_QueryResult.Text = "Query Result";
            // 
            // btn_RunQuery
            // 
            this.btn_RunQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RunQuery.AutoSize = true;
            this.btn_RunQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RunQuery.Location = new System.Drawing.Point(323, 460);
            this.btn_RunQuery.Name = "btn_RunQuery";
            this.btn_RunQuery.Size = new System.Drawing.Size(99, 26);
            this.btn_RunQuery.TabIndex = 22;
            this.btn_RunQuery.Text = "Run Query";
            this.btn_RunQuery.UseVisualStyleBackColor = true;
            this.btn_RunQuery.Click += new System.EventHandler(this.btn_RunQuery_Click);
            // 
            // Lbl_QueryCmd
            // 
            this.Lbl_QueryCmd.AutoSize = true;
            this.Lbl_QueryCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QueryCmd.Location = new System.Drawing.Point(24, 341);
            this.Lbl_QueryCmd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_QueryCmd.Name = "Lbl_QueryCmd";
            this.Lbl_QueryCmd.Size = new System.Drawing.Size(87, 16);
            this.Lbl_QueryCmd.TabIndex = 21;
            this.Lbl_QueryCmd.Text = "SQL-Query:";
            // 
            // Txt_QueryCmd
            // 
            this.Txt_QueryCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_QueryCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Txt_QueryCmd.Location = new System.Drawing.Point(24, 366);
            this.Txt_QueryCmd.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_QueryCmd.MaxLength = 10000;
            this.Txt_QueryCmd.Multiline = true;
            this.Txt_QueryCmd.Name = "Txt_QueryCmd";
            this.Txt_QueryCmd.Size = new System.Drawing.Size(398, 80);
            this.Txt_QueryCmd.TabIndex = 20;
            // 
            // Grid_QueryResult
            // 
            this.Grid_QueryResult.AllowUserToAddRows = false;
            this.Grid_QueryResult.AllowUserToDeleteRows = false;
            this.Grid_QueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_QueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_QueryResult.Location = new System.Drawing.Point(24, 515);
            this.Grid_QueryResult.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_QueryResult.Name = "Grid_QueryResult";
            this.Grid_QueryResult.ReadOnly = true;
            this.Grid_QueryResult.RowHeadersVisible = false;
            this.Grid_QueryResult.RowHeadersWidth = 82;
            this.Grid_QueryResult.RowTemplate.Height = 33;
            this.Grid_QueryResult.Size = new System.Drawing.Size(398, 95);
            this.Grid_QueryResult.TabIndex = 24;
            // 
            // Lbl_horizontalLine
            // 
            this.Lbl_horizontalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_horizontalLine.Location = new System.Drawing.Point(24, 320);
            this.Lbl_horizontalLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_horizontalLine.Name = "Lbl_horizontalLine";
            this.Lbl_horizontalLine.Size = new System.Drawing.Size(398, 1);
            this.Lbl_horizontalLine.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 621);
            this.Controls.Add(this.Lbl_horizontalLine);
            this.Controls.Add(this.Grid_QueryResult);
            this.Controls.Add(this.Lbl_QueryResult);
            this.Controls.Add(this.btn_RunQuery);
            this.Controls.Add(this.Lbl_QueryCmd);
            this.Controls.Add(this.Txt_QueryCmd);
            this.Controls.Add(this.btn_Fallgeloest);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Verlassen);
            this.Controls.Add(this.Antwortfeld);
            this.Controls.Add(this.btn_Antwort_bestaetigen);
            this.Controls.Add(this.Frage);
            this.Controls.Add(this.btn_weiter);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.lbl_hinweis);
            this.Controls.Add(this.Hinweistext);
            this.Controls.Add(this.label_hinweis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(455, 660);
            this.Name = "Form2";
            this.Text = "Detektivspiel";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_QueryResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hinweis;
        private System.Windows.Forms.Label Hinweistext;
        private System.Windows.Forms.Label lbl_hinweis;
        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.Button btn_weiter;
        private System.Windows.Forms.Label Frage;
        private System.Windows.Forms.Button btn_Antwort_bestaetigen;
        private System.Windows.Forms.TextBox Antwortfeld;
        private System.Windows.Forms.Button btn_Verlassen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Fallgeloest;
        private System.Windows.Forms.Label Lbl_QueryResult;
        private System.Windows.Forms.Button btn_RunQuery;
        private System.Windows.Forms.Label Lbl_QueryCmd;
        private System.Windows.Forms.TextBox Txt_QueryCmd;
        private System.Windows.Forms.DataGridView Grid_QueryResult;
        private System.Windows.Forms.Label Lbl_horizontalLine;
    }
}