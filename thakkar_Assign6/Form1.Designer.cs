namespace thakkar_Assign6
{
    partial class Form1
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
            this.StackedBarChart_Button = new System.Windows.Forms.Button();
            this.PieChart_Button = new System.Windows.Forms.Button();
            this.BubbleChart_Button = new System.Windows.Forms.Button();
            this.LineChart_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StackedBarChart_Button
            // 
            this.StackedBarChart_Button.Location = new System.Drawing.Point(12, 12);
            this.StackedBarChart_Button.Name = "StackedBarChart_Button";
            this.StackedBarChart_Button.Size = new System.Drawing.Size(235, 142);
            this.StackedBarChart_Button.TabIndex = 0;
            this.StackedBarChart_Button.Text = "Stacked Bar Chart";
            this.StackedBarChart_Button.UseVisualStyleBackColor = true;
            this.StackedBarChart_Button.Click += new System.EventHandler(this.StackedBarChart_Button_Click);
            // 
            // PieChart_Button
            // 
            this.PieChart_Button.Location = new System.Drawing.Point(309, 12);
            this.PieChart_Button.Name = "PieChart_Button";
            this.PieChart_Button.Size = new System.Drawing.Size(235, 142);
            this.PieChart_Button.TabIndex = 1;
            this.PieChart_Button.Text = "Pie Chart";
            this.PieChart_Button.UseVisualStyleBackColor = true;
            this.PieChart_Button.Click += new System.EventHandler(this.PieChart_Button_Click);
            // 
            // BubbleChart_Button
            // 
            this.BubbleChart_Button.Location = new System.Drawing.Point(309, 214);
            this.BubbleChart_Button.Name = "BubbleChart_Button";
            this.BubbleChart_Button.Size = new System.Drawing.Size(235, 142);
            this.BubbleChart_Button.TabIndex = 2;
            this.BubbleChart_Button.Text = "Bubble Chart";
            this.BubbleChart_Button.UseVisualStyleBackColor = true;
            this.BubbleChart_Button.Click += new System.EventHandler(this.BubbleChart_Button_Click);
            // 
            // LineChart_Button
            // 
            this.LineChart_Button.Location = new System.Drawing.Point(12, 214);
            this.LineChart_Button.Name = "LineChart_Button";
            this.LineChart_Button.Size = new System.Drawing.Size(235, 142);
            this.LineChart_Button.TabIndex = 3;
            this.LineChart_Button.Text = "Line Chart";
            this.LineChart_Button.UseVisualStyleBackColor = true;
            this.LineChart_Button.Click += new System.EventHandler(this.LineChart_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 610);
            this.Controls.Add(this.LineChart_Button);
            this.Controls.Add(this.BubbleChart_Button);
            this.Controls.Add(this.PieChart_Button);
            this.Controls.Add(this.StackedBarChart_Button);
            this.Name = "Form1";
            this.Text = "Uncharted";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StackedBarChart_Button;
        private System.Windows.Forms.Button PieChart_Button;
        private System.Windows.Forms.Button BubbleChart_Button;
        private System.Windows.Forms.Button LineChart_Button;
    }
}

