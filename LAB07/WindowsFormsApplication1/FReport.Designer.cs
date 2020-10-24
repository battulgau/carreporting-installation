namespace WindowsFormsApplication1
{
    partial class FReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CarDataSet = new WindowsFormsApplication1.CarDataSet();
            this.CarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarTableAdapter = new WindowsFormsApplication1.CarDataSetTableAdapters.CarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetCar";
            reportDataSource2.Value = this.CarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.ReportCar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // CarDataSet
            // 
            this.CarDataSet.DataSetName = "CarDataSet";
            this.CarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CarBindingSource
            // 
            this.CarBindingSource.DataMember = "Car";
            this.CarBindingSource.DataSource = this.CarDataSet;
            // 
            // CarTableAdapter
            // 
            this.CarTableAdapter.ClearBeforeFill = true;
            // 
            // FReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FReport";
            this.ShowIcon = false;
            this.Text = "Машины тайлан";
            this.Load += new System.EventHandler(this.FReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CarBindingSource;
        private CarDataSet CarDataSet;
        private CarDataSetTableAdapters.CarTableAdapter CarTableAdapter;
    }
}