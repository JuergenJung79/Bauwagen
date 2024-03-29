﻿namespace Bauwagen
{
    partial class Frm_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChT_Verbrauch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CmB_Name = new System.Windows.Forms.ComboBox();
            this.DtP_DatumVon = new System.Windows.Forms.DateTimePicker();
            this.DtP_DatumBis = new System.Windows.Forms.DateTimePicker();
            this.ChK_DatumsFilter = new System.Windows.Forms.CheckBox();
            this.CmD_FilterLöschen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChT_Verbrauch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChT_Verbrauch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Allgemein";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChT_Verbrauch
            // 
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.Name = "ChartArea1";
            this.ChT_Verbrauch.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.ChT_Verbrauch.Legends.Add(legend1);
            this.ChT_Verbrauch.Location = new System.Drawing.Point(6, 6);
            this.ChT_Verbrauch.Name = "ChT_Verbrauch";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ausgaben";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Aufladungen";
            this.ChT_Verbrauch.Series.Add(series1);
            this.ChT_Verbrauch.Series.Add(series2);
            this.ChT_Verbrauch.Size = new System.Drawing.Size(964, 613);
            this.ChT_Verbrauch.TabIndex = 0;
            this.ChT_Verbrauch.Text = "Verbrauch";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Übersicht Buchungen";
            title1.Text = "Übersicht Buchungen";
            this.ChT_Verbrauch.Titles.Add(title1);
            // 
            // CmB_Name
            // 
            this.CmB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmB_Name.FormattingEnabled = true;
            this.CmB_Name.Location = new System.Drawing.Point(12, 12);
            this.CmB_Name.Name = "CmB_Name";
            this.CmB_Name.Size = new System.Drawing.Size(267, 28);
            this.CmB_Name.TabIndex = 1;
            this.CmB_Name.SelectedIndexChanged += new System.EventHandler(this.CmB_Name_SelectedIndexChanged);
            // 
            // DtP_DatumVon
            // 
            this.DtP_DatumVon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtP_DatumVon.Location = new System.Drawing.Point(398, 17);
            this.DtP_DatumVon.Name = "DtP_DatumVon";
            this.DtP_DatumVon.Size = new System.Drawing.Size(99, 20);
            this.DtP_DatumVon.TabIndex = 2;
            this.DtP_DatumVon.ValueChanged += new System.EventHandler(this.DtP_DatumVon_ValueChanged);
            // 
            // DtP_DatumBis
            // 
            this.DtP_DatumBis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtP_DatumBis.Location = new System.Drawing.Point(517, 17);
            this.DtP_DatumBis.Name = "DtP_DatumBis";
            this.DtP_DatumBis.Size = new System.Drawing.Size(99, 20);
            this.DtP_DatumBis.TabIndex = 2;
            this.DtP_DatumBis.ValueChanged += new System.EventHandler(this.DtP_DatumBis_ValueChanged);
            // 
            // ChK_DatumsFilter
            // 
            this.ChK_DatumsFilter.AutoSize = true;
            this.ChK_DatumsFilter.Location = new System.Drawing.Point(377, 21);
            this.ChK_DatumsFilter.Name = "ChK_DatumsFilter";
            this.ChK_DatumsFilter.Size = new System.Drawing.Size(15, 14);
            this.ChK_DatumsFilter.TabIndex = 3;
            this.ChK_DatumsFilter.UseVisualStyleBackColor = true;
            this.ChK_DatumsFilter.CheckedChanged += new System.EventHandler(this.ChK_DatumsFilter_CheckedChanged);
            // 
            // CmD_FilterLöschen
            // 
            this.CmD_FilterLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmD_FilterLöschen.Location = new System.Drawing.Point(285, 12);
            this.CmD_FilterLöschen.Name = "CmD_FilterLöschen";
            this.CmD_FilterLöschen.Size = new System.Drawing.Size(75, 52);
            this.CmD_FilterLöschen.TabIndex = 4;
            this.CmD_FilterLöschen.Text = "Filter löschen";
            this.CmD_FilterLöschen.UseVisualStyleBackColor = true;
            this.CmD_FilterLöschen.Click += new System.EventHandler(this.CmD_FilterLöschen_Click);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 711);
            this.Controls.Add(this.CmD_FilterLöschen);
            this.Controls.Add(this.ChK_DatumsFilter);
            this.Controls.Add(this.DtP_DatumBis);
            this.Controls.Add(this.DtP_DatumVon);
            this.Controls.Add(this.CmB_Name);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Dashboard";
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChT_Verbrauch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CmB_Name;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChT_Verbrauch;
        private System.Windows.Forms.DateTimePicker DtP_DatumVon;
        private System.Windows.Forms.DateTimePicker DtP_DatumBis;
        private System.Windows.Forms.CheckBox ChK_DatumsFilter;
        private System.Windows.Forms.Button CmD_FilterLöschen;
    }
}