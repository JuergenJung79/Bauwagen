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
            // 
            // CmD_Save
            // 
            this.CmD_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_Save.Location = new System.Drawing.Point(574, 12);
            this.CmD_Save.Name = "CmD_Save";
            this.CmD_Save.Size = new System.Drawing.Size(121, 60);
            this.CmD_Save.TabIndex = 3;
            this.CmD_Save.Text = "Speichern";
            this.CmD_Save.UseVisualStyleBackColor = true;
            // 
            // Frm_GüterHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmD_Save);
            this.Controls.Add(this.CmB_Güter);
            this.Name = "Frm_GüterHinzufügen";
            this.Text = "Getränke bearbeiten";
            this.Load += new System.EventHandler(this.Frm_GüterHinzufügen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmB_Güter;
        private System.Windows.Forms.Button CmD_Save;
    }
}