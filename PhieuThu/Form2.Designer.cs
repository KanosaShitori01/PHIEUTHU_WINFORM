
namespace PhieuThu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBHDataSet1 = new PhieuThu.QLBHDataSet1();
            this.PHIEUTHUFULLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUTHUFULLTableAdapter = new PhieuThu.QLBHDataSet1TableAdapters.PHIEUTHUFULLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUTHUFULLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PHIEUTHUFULLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhieuThu.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(594, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBHDataSet1
            // 
            this.QLBHDataSet1.DataSetName = "QLBHDataSet1";
            this.QLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PHIEUTHUFULLBindingSource
            // 
            this.PHIEUTHUFULLBindingSource.DataMember = "PHIEUTHUFULL";
            this.PHIEUTHUFULLBindingSource.DataSource = this.QLBHDataSet1;
            // 
            // PHIEUTHUFULLTableAdapter
            // 
            this.PHIEUTHUFULLTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 491);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUTHUFULLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PHIEUTHUFULLBindingSource;
        private QLBHDataSet1 QLBHDataSet1;
        private QLBHDataSet1TableAdapters.PHIEUTHUFULLTableAdapter PHIEUTHUFULLTableAdapter;
    }
}