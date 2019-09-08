namespace Bauwagen
{
    partial class Frm_GüterHinzufügen
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
            this.CmB_Güter = new System.Windows.Forms.ComboBox();
            this.CmD_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChK_Aktiv = new System.Windows.Forms.CheckBox();
            this.TxT_Preis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmB_Güter
            // 
            this.CmB_Güter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmB_Güter.FormattingEnabled = true;
            this.CmB_Güter.Location = new System.Drawing.Point(12, 27);
            this.CmB_Güter.Name = "CmB_Güter";
            this.CmB_Güter.Size = new System.Drawing.Size(345, 33);
            this.CmB_Güter.TabIndex = 1;
            this.CmB_Güter.SelectedIndexChanged += new System.EventHandler(this.CmB_Güter_SelectedIndexChanged);
            this.CmB_Güter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmB_Güter_KeyDown);
            // 
            // CmD_Save
            // 
            this.CmD_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Save.Location = new System.Drawing.Point(691, 12);
            this.CmD_Save.Name = "CmD_Save";
            this.CmD_Save.Size = new System.Drawing.Size(121, 60);
            this.CmD_Save.TabIndex = 4;
            this.CmD_Save.Text = "Speichern";
            this.CmD_Save.UseVisualStyleBackColor = true;
            this.CmD_Save.Click += new System.EventHandler(this.CmD_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preis";
            // 
            // ChK_Aktiv
            // 
            this.ChK_Aktiv.AutoSize = true;
            this.ChK_Aktiv.Checked = true;
            this.ChK_Aktiv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChK_Aktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChK_Aktiv.Location = new System.Drawing.Point(590, 29);
            this.ChK_Aktiv.Name = "ChK_Aktiv";
            this.ChK_Aktiv.Size = new System.Drawing.Size(76, 29);
            this.ChK_Aktiv.TabIndex = 3;
            this.ChK_Aktiv.Text = "aktiv";
            this.ChK_Aktiv.UseVisualStyleBackColor = true;
            // 
            // TxT_Preis
            // 
            this.TxT_Preis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Preis.Location = new System.Drawing.Point(458, 27);
            this.TxT_Preis.Name = "TxT_Preis";
            this.TxT_Preis.Size = new System.Drawing.Size(100, 31);
            this.TxT_Preis.TabIndex = 2;
            // 
            // Frm_GüterHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 93);
            this.Controls.Add(this.TxT_Preis);
            this.Controls.Add(this.ChK_Aktiv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmD_Save);
            this.Controls.Add(this.CmB_Güter);
            this.Name = "Frm_GüterHinzufügen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getränke bearbeiten";
            this.Load += new System.EventHandler(this.Frm_GüterHinzufügen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmB_Güter;
        private System.Windows.Forms.Button CmD_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChK_Aktiv;
        private System.Windows.Forms.TextBox TxT_Preis;
    }
}