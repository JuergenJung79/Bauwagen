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
            this.TxT_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChK_Aktiv = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CmB_Güter
            // 
            this.CmB_Güter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmB_Güter.FormattingEnabled = true;
            this.CmB_Güter.Location = new System.Drawing.Point(21, 12);
            this.CmB_Güter.Name = "CmB_Güter";
            this.CmB_Güter.Size = new System.Drawing.Size(345, 33);
            this.CmB_Güter.TabIndex = 1;
            this.CmB_Güter.SelectedIndexChanged += new System.EventHandler(this.CmB_Güter_SelectedIndexChanged);
            // 
            // CmD_Save
            // 
            this.CmD_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Save.Location = new System.Drawing.Point(465, 50);
            this.CmD_Save.Name = "CmD_Save";
            this.CmD_Save.Size = new System.Drawing.Size(121, 60);
            this.CmD_Save.TabIndex = 3;
            this.CmD_Save.Text = "Speichern";
            this.CmD_Save.UseVisualStyleBackColor = true;
            // 
            // TxT_Name
            // 
            this.TxT_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT_Name.Location = new System.Drawing.Point(94, 117);
            this.TxT_Name.Name = "TxT_Name";
            this.TxT_Name.Size = new System.Drawing.Size(199, 31);
            this.TxT_Name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preis";
            // 
            // ChK_Aktiv
            // 
            this.ChK_Aktiv.AutoSize = true;
            this.ChK_Aktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChK_Aktiv.Location = new System.Drawing.Point(342, 119);
            this.ChK_Aktiv.Name = "ChK_Aktiv";
            this.ChK_Aktiv.Size = new System.Drawing.Size(76, 29);
            this.ChK_Aktiv.TabIndex = 6;
            this.ChK_Aktiv.Text = "aktiv";
            this.ChK_Aktiv.UseVisualStyleBackColor = true;
            // 
            // Frm_GüterHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 176);
            this.Controls.Add(this.ChK_Aktiv);
            this.Controls.Add(this.TxT_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmD_Save);
            this.Controls.Add(this.CmB_Güter);
            this.Name = "Frm_GüterHinzufügen";
            this.Text = "Getränke bearbeiten";
            this.Load += new System.EventHandler(this.Frm_GüterHinzufügen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmB_Güter;
        private System.Windows.Forms.Button CmD_Save;
        private System.Windows.Forms.TextBox TxT_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChK_Aktiv;
    }
}