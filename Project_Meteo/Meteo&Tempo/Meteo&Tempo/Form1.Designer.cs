namespace Meteo_Tempo
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            temperatura = new DataGridViewTextBoxColumn();
            orario = new DataGridViewTextBoxColumn();
            buttonShow = new Button();
            buttonChart = new Button();
            buttonExit = new Button();
            buttonClear = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, temperatura, orario });
            dataGridView1.Location = new Point(12, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.Size = new Size(534, 443);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.Frozen = true;
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 51;
            // 
            // temperatura
            // 
            temperatura.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            temperatura.Frozen = true;
            temperatura.HeaderText = "temperatura";
            temperatura.MinimumWidth = 6;
            temperatura.Name = "temperatura";
            temperatura.ReadOnly = true;
            temperatura.Width = 120;
            // 
            // orario
            // 
            orario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orario.HeaderText = "orario";
            orario.MinimumWidth = 6;
            orario.Name = "orario";
            orario.ReadOnly = true;
            orario.Width = 78;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = Color.Yellow;
            buttonShow.Cursor = Cursors.Hand;
            buttonShow.FlatAppearance.BorderColor = Color.FromArgb(228, 197, 0);
            buttonShow.FlatAppearance.BorderSize = 2;
            buttonShow.FlatAppearance.MouseDownBackColor = Color.Gold;
            buttonShow.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 255, 65);
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Font = new Font("Verdana", 12F);
            buttonShow.ForeColor = SystemColors.ControlText;
            buttonShow.Location = new Point(613, 29);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(116, 47);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonChart
            // 
            buttonChart.BackColor = Color.LightSkyBlue;
            buttonChart.Cursor = Cursors.Hand;
            buttonChart.FlatAppearance.BorderColor = Color.MediumTurquoise;
            buttonChart.FlatAppearance.BorderSize = 2;
            buttonChart.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            buttonChart.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            buttonChart.FlatStyle = FlatStyle.Flat;
            buttonChart.Font = new Font("Verdana", 12F);
            buttonChart.Location = new Point(613, 260);
            buttonChart.Name = "buttonChart";
            buttonChart.Size = new Size(116, 47);
            buttonChart.TabIndex = 3;
            buttonChart.Text = "Chart";
            buttonChart.UseVisualStyleBackColor = false;
            buttonChart.Visible = false;
            buttonChart.Click += buttonChart_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DarkRed;
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatAppearance.BorderColor = Color.Black;
            buttonExit.FlatAppearance.BorderSize = 3;
            buttonExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(216, 0, 0);
            buttonExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(197, 19, 12);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Verdana", 18F);
            buttonExit.Location = new Point(613, 405);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(147, 67);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.White;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            buttonClear.FlatAppearance.BorderSize = 2;
            buttonClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 240, 243);
            buttonClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 246, 246);
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Verdana", 12F);
            buttonClear.Location = new Point(613, 184);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(116, 47);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Visible = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(15, 233, 20);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            buttonUpdate.FlatAppearance.BorderSize = 2;
            buttonUpdate.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            buttonUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 247, 50);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Verdana", 12F);
            buttonUpdate.Location = new Point(613, 106);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(116, 47);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Visible = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(771, 479);
            ControlBox = false;
            Controls.Add(buttonUpdate);
            Controls.Add(buttonExit);
            Controls.Add(buttonChart);
            Controls.Add(buttonShow);
            Controls.Add(dataGridView1);
            Controls.Add(buttonClear);
            Name = "Form1";
            Text = "Form_Database";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonShow;
        private Button buttonChart;
        private Button buttonExit;
        private Button buttonClear;
        private Button buttonUpdate;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn temperatura;
        private DataGridViewTextBoxColumn orario;
    }
}
