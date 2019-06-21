namespace HillClimbingAlgorithmCalculator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fromTb = new System.Windows.Forms.TextBox();
            this.precisionCb = new System.Windows.Forms.ComboBox();
            this.toTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resXRealTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resXBinTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resFXTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // fromTb
            // 
            this.fromTb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromTb.Location = new System.Drawing.Point(73, 6);
            this.fromTb.Name = "fromTb";
            this.fromTb.Size = new System.Drawing.Size(100, 31);
            this.fromTb.TabIndex = 1;
            // 
            // precisionCb
            // 
            this.precisionCb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.precisionCb.FormattingEnabled = true;
            this.precisionCb.Location = new System.Drawing.Point(411, 6);
            this.precisionCb.Name = "precisionCb";
            this.precisionCb.Size = new System.Drawing.Size(121, 31);
            this.precisionCb.TabIndex = 2;
            // 
            // toTb
            // 
            this.toTb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toTb.Location = new System.Drawing.Point(215, 6);
            this.toTb.Name = "toTb";
            this.toTb.Size = new System.Drawing.Size(100, 31);
            this.toTb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(321, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precision";
            // 
            // tTb
            // 
            this.tTb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTb.Location = new System.Drawing.Point(567, 6);
            this.tTb.Name = "tTb";
            this.tTb.Size = new System.Drawing.Size(86, 31);
            this.tTb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(541, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "T";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Azure;
            this.startButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(1102, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 31);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // resXRealTb
            // 
            this.resXRealTb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resXRealTb.Location = new System.Drawing.Point(78, 30);
            this.resXRealTb.Name = "resXRealTb";
            this.resXRealTb.ReadOnly = true;
            this.resXRealTb.Size = new System.Drawing.Size(167, 31);
            this.resXRealTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "x real";
            // 
            // resXBinTb
            // 
            this.resXBinTb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resXBinTb.Location = new System.Drawing.Point(307, 30);
            this.resXBinTb.Name = "resXBinTb";
            this.resXBinTb.ReadOnly = true;
            this.resXBinTb.Size = new System.Drawing.Size(167, 31);
            this.resXBinTb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(252, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "x bin";
            // 
            // resFXTb
            // 
            this.resFXTb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resFXTb.Location = new System.Drawing.Point(530, 30);
            this.resFXTb.Name = "resFXTb";
            this.resFXTb.ReadOnly = true;
            this.resFXTb.Size = new System.Drawing.Size(167, 31);
            this.resFXTb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(484, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "f(x)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resXRealTb);
            this.groupBox1.Controls.Add(this.resFXTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.resXBinTb);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 85);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // resChart
            // 
            chartArea1.Name = "ChartArea1";
            this.resChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resChart.Legends.Add(legend1);
            this.resChart.Location = new System.Drawing.Point(12, 135);
            this.resChart.Name = "resChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.resChart.Series.Add(series1);
            this.resChart.Size = new System.Drawing.Size(1184, 544);
            this.resChart.TabIndex = 16;
            this.resChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 691);
            this.Controls.Add(this.resChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precisionCb);
            this.Controls.Add(this.fromTb);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Hill Climbing Algorithm Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromTb;
        private System.Windows.Forms.ComboBox precisionCb;
        private System.Windows.Forms.TextBox toTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox resXRealTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resXBinTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resFXTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart resChart;
    }
}

