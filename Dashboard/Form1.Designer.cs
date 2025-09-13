namespace Dashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelkpi1 = new Label();
            labelkpi1Desc = new Label();
            labelkpi2 = new Label();
            labelkpi2Desc = new Label();
            labelkpi3 = new Label();
            labelkpi3Desc = new Label();
            labelkpi4 = new Label();
            labelkpi4Desc = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            pieChart2 = new LiveCharts.WinForms.PieChart();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // labelkpi1
            // 
            labelkpi1.AutoSize = true;
            labelkpi1.Location = new Point(38, 59);
            labelkpi1.Name = "labelkpi1";
            labelkpi1.Size = new Size(38, 15);
            labelkpi1.TabIndex = 0;
            labelkpi1.Text = "label1";
            // 
            // labelkpi1Desc
            // 
            labelkpi1Desc.AutoSize = true;
            labelkpi1Desc.Location = new Point(38, 22);
            labelkpi1Desc.Name = "labelkpi1Desc";
            labelkpi1Desc.Size = new Size(38, 15);
            labelkpi1Desc.TabIndex = 1;
            labelkpi1Desc.Text = "label2";
            // 
            // labelkpi2
            // 
            labelkpi2.AutoSize = true;
            labelkpi2.Location = new Point(151, 59);
            labelkpi2.Name = "labelkpi2";
            labelkpi2.Size = new Size(38, 15);
            labelkpi2.TabIndex = 2;
            labelkpi2.Text = "label3";
            // 
            // labelkpi2Desc
            // 
            labelkpi2Desc.AutoSize = true;
            labelkpi2Desc.Location = new Point(151, 22);
            labelkpi2Desc.Name = "labelkpi2Desc";
            labelkpi2Desc.Size = new Size(38, 15);
            labelkpi2Desc.TabIndex = 3;
            labelkpi2Desc.Text = "label4";
            // 
            // labelkpi3
            // 
            labelkpi3.AutoSize = true;
            labelkpi3.Location = new Point(264, 59);
            labelkpi3.Name = "labelkpi3";
            labelkpi3.Size = new Size(38, 15);
            labelkpi3.TabIndex = 4;
            labelkpi3.Text = "label5";
            // 
            // labelkpi3Desc
            // 
            labelkpi3Desc.AutoSize = true;
            labelkpi3Desc.Location = new Point(264, 22);
            labelkpi3Desc.Name = "labelkpi3Desc";
            labelkpi3Desc.Size = new Size(38, 15);
            labelkpi3Desc.TabIndex = 5;
            labelkpi3Desc.Text = "label6";
            // 
            // labelkpi4
            // 
            labelkpi4.AutoSize = true;
            labelkpi4.Location = new Point(371, 59);
            labelkpi4.Name = "labelkpi4";
            labelkpi4.Size = new Size(38, 15);
            labelkpi4.TabIndex = 6;
            labelkpi4.Text = "label7";
            // 
            // labelkpi4Desc
            // 
            labelkpi4Desc.AutoSize = true;
            labelkpi4Desc.Location = new Point(371, 22);
            labelkpi4Desc.Name = "labelkpi4Desc";
            labelkpi4Desc.Size = new Size(38, 15);
            labelkpi4Desc.TabIndex = 7;
            labelkpi4Desc.Text = "label8";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(38, 106);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(456, 198);
            cartesianChart1.TabIndex = 8;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart2
            // 
            pieChart2.Location = new Point(542, 106);
            pieChart2.Name = "pieChart2";
            pieChart2.Size = new Size(246, 231);
            pieChart2.TabIndex = 9;
            pieChart2.Text = "pieChart2";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(294, 385);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar:";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(pieChart2);
            Controls.Add(cartesianChart1);
            Controls.Add(labelkpi4Desc);
            Controls.Add(labelkpi4);
            Controls.Add(labelkpi3Desc);
            Controls.Add(labelkpi3);
            Controls.Add(labelkpi2Desc);
            Controls.Add(labelkpi2);
            Controls.Add(labelkpi1Desc);
            Controls.Add(labelkpi1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelkpi1;
        private Label labelkpi1Desc;
        private Label labelkpi2;
        private Label labelkpi2Desc;
        private Label labelkpi3;
        private Label labelkpi3Desc;
        private Label labelkpi4;
        private Label labelkpi4Desc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart2;
        private Button btnAtualizar;
    }
}
