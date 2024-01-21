namespace Parcial2LUG
{
    partial class FRReporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bEResumenReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbJugador = new System.Windows.Forms.ComboBox();
            this.chJugador = new System.Windows.Forms.CheckBox();
            this.cmbJuego = new System.Windows.Forms.ComboBox();
            this.chJuego = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.chartJuego = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHistorial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHistorial2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.bEResumenReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorial2)).BeginInit();
            this.SuspendLayout();
            // 
            // bEResumenReporteBindingSource
            // 
            this.bEResumenReporteBindingSource.DataSource = typeof(BE.BEResumenReporte);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bEResumenReporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Parcial2LUG.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 100);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(606, 321);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbJugador
            // 
            this.cmbJugador.FormattingEnabled = true;
            this.cmbJugador.Location = new System.Drawing.Point(95, 22);
            this.cmbJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbJugador.Name = "cmbJugador";
            this.cmbJugador.Size = new System.Drawing.Size(119, 21);
            this.cmbJugador.TabIndex = 1;
            // 
            // chJugador
            // 
            this.chJugador.AutoSize = true;
            this.chJugador.Location = new System.Drawing.Point(22, 25);
            this.chJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chJugador.Name = "chJugador";
            this.chJugador.Size = new System.Drawing.Size(64, 17);
            this.chJugador.TabIndex = 2;
            this.chJugador.Text = "Jugador";
            this.chJugador.UseVisualStyleBackColor = true;
            // 
            // cmbJuego
            // 
            this.cmbJuego.FormattingEnabled = true;
            this.cmbJuego.Location = new System.Drawing.Point(95, 57);
            this.cmbJuego.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbJuego.Name = "cmbJuego";
            this.cmbJuego.Size = new System.Drawing.Size(119, 21);
            this.cmbJuego.TabIndex = 3;
            // 
            // chJuego
            // 
            this.chJuego.AutoSize = true;
            this.chJuego.Location = new System.Drawing.Point(22, 58);
            this.chJuego.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chJuego.Name = "chJuego";
            this.chJuego.Size = new System.Drawing.Size(55, 17);
            this.chJuego.TabIndex = 4;
            this.chJuego.Text = "Juego";
            this.chJuego.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(230, 22);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(82, 31);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(336, 22);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(82, 31);
            this.btnMostrarTodo.TabIndex = 6;
            this.btnMostrarTodo.Text = "MostrarTodo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // chartJuego
            // 
            chartArea1.Name = "ChartArea1";
            this.chartJuego.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartJuego.Legends.Add(legend1);
            this.chartJuego.Location = new System.Drawing.Point(642, 100);
            this.chartJuego.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartJuego.Name = "chartJuego";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartJuego.Series.Add(series1);
            this.chartJuego.Size = new System.Drawing.Size(331, 321);
            this.chartJuego.TabIndex = 7;
            this.chartJuego.Text = "chart1";
            // 
            // chartHistorial
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHistorial.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHistorial.Legends.Add(legend2);
            this.chartHistorial.Location = new System.Drawing.Point(22, 426);
            this.chartHistorial.Name = "chartHistorial";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHistorial.Series.Add(series2);
            this.chartHistorial.Size = new System.Drawing.Size(283, 268);
            this.chartHistorial.TabIndex = 8;
            this.chartHistorial.Text = "chartHistorial";
            // 
            // chartHistorial2
            // 
            chartArea3.Name = "ChartArea1";
            this.chartHistorial2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartHistorial2.Legends.Add(legend3);
            this.chartHistorial2.Location = new System.Drawing.Point(336, 426);
            this.chartHistorial2.Name = "chartHistorial2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartHistorial2.Series.Add(series3);
            this.chartHistorial2.Size = new System.Drawing.Size(262, 268);
            this.chartHistorial2.TabIndex = 9;
            this.chartHistorial2.Text = "chartHistorial2";
            // 
            // FRReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 754);
            this.Controls.Add(this.chartHistorial2);
            this.Controls.Add(this.chartHistorial);
            this.Controls.Add(this.chartJuego);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chJuego);
            this.Controls.Add(this.cmbJuego);
            this.Controls.Add(this.chJugador);
            this.Controls.Add(this.cmbJugador);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRReporte";
            this.Text = "FRReporte";
            this.Load += new System.EventHandler(this.FRReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bEResumenReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorial2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bEResumenReporteBindingSource;
        private System.Windows.Forms.ComboBox cmbJugador;
        private System.Windows.Forms.CheckBox chJugador;
        private System.Windows.Forms.ComboBox cmbJuego;
        private System.Windows.Forms.CheckBox chJuego;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartJuego;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistorial;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistorial2;
    }
}