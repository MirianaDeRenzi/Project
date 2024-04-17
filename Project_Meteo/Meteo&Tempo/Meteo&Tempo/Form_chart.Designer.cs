namespace Meteo_Tempo
{
    partial class Form_chart
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
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            buttonUpdate = new Button();
            buttonExit = new Button();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.Black;
            cartesianChart1.Location = new Point(12, 12);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1065, 632);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Black;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderColor = Color.White;
            buttonUpdate.FlatAppearance.BorderSize = 3;
            buttonUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            buttonUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 13, 13);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Verdana", 12F);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(1083, 44);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(123, 51);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Black;
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatAppearance.BorderColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = 3;
            buttonExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 13, 13);
            buttonExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 13, 13);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Verdana", 14F);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(1083, 577);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(142, 67);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Black;
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.FlatAppearance.BorderColor = Color.White;
            buttonReset.FlatAppearance.BorderSize = 3;
            buttonReset.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            buttonReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 13, 13);
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Verdana", 12F);
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(1083, 127);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(123, 51);
            buttonReset.TabIndex = 10;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form_chart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(1237, 656);
            ControlBox = false;
            Controls.Add(buttonReset);
            Controls.Add(buttonExit);
            Controls.Add(buttonUpdate);
            Controls.Add(cartesianChart1);
            Name = "Form_chart";
            Text = "Form_chart";
            ResumeLayout(false);
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Button buttonUpdate;
        private Button buttonExit;
        private Button buttonReset;
    }
}