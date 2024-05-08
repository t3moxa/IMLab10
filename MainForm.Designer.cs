namespace IMLab10
{
    partial class MainForm
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
            LogoBox = new PictureBox();
            TableQuarters1 = new TableLayoutPanel();
            GenerateTeamsButton = new Button();
            TableQuarters2 = new TableLayoutPanel();
            TableSemis1 = new TableLayoutPanel();
            TableFinals = new TableLayoutPanel();
            TableSemis2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            TableQuarters3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            TableQuarters4 = new TableLayoutPanel();
            WinnerCaptionLabel = new Label();
            WinnerNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // LogoBox
            // 
            LogoBox.BackColor = Color.Transparent;
            LogoBox.Image = Properties.Resources.Logo;
            LogoBox.Location = new Point(21, 12);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(1213, 81);
            LogoBox.SizeMode = PictureBoxSizeMode.AutoSize;
            LogoBox.TabIndex = 1;
            LogoBox.TabStop = false;
            // 
            // TableQuarters1
            // 
            TableQuarters1.BackColor = Color.White;
            TableQuarters1.ColumnCount = 2;
            TableQuarters1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            TableQuarters1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0991745F));
            TableQuarters1.Location = new Point(150, 200);
            TableQuarters1.Name = "TableQuarters1";
            TableQuarters1.RowCount = 2;
            TableQuarters1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableQuarters1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableQuarters1.Size = new Size(120, 60);
            TableQuarters1.TabIndex = 4;
            TableQuarters1.Visible = false;
            // 
            // GenerateTeamsButton
            // 
            GenerateTeamsButton.BackColor = Color.Blue;
            GenerateTeamsButton.FlatAppearance.BorderSize = 2;
            GenerateTeamsButton.FlatStyle = FlatStyle.Popup;
            GenerateTeamsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            GenerateTeamsButton.ForeColor = Color.Gold;
            GenerateTeamsButton.Location = new Point(590, 310);
            GenerateTeamsButton.Name = "GenerateTeamsButton";
            GenerateTeamsButton.Size = new Size(100, 35);
            GenerateTeamsButton.TabIndex = 5;
            GenerateTeamsButton.Text = "Начать";
            GenerateTeamsButton.UseVisualStyleBackColor = false;
            GenerateTeamsButton.Click += GenerateTeamsButton_Click;
            // 
            // TableQuarters2
            // 
            TableQuarters2.BackColor = Color.White;
            TableQuarters2.ColumnCount = 2;
            TableQuarters2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            TableQuarters2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0991745F));
            TableQuarters2.Location = new Point(150, 400);
            TableQuarters2.Name = "TableQuarters2";
            TableQuarters2.RowCount = 2;
            TableQuarters2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableQuarters2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableQuarters2.Size = new Size(120, 60);
            TableQuarters2.TabIndex = 6;
            TableQuarters2.Visible = false;
            // 
            // TableSemis1
            // 
            TableSemis1.BackColor = Color.White;
            TableSemis1.ColumnCount = 2;
            TableSemis1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            TableSemis1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0991745F));
            TableSemis1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableSemis1.Location = new Point(350, 300);
            TableSemis1.Name = "TableSemis1";
            TableSemis1.RowCount = 2;
            TableSemis1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableSemis1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableSemis1.Size = new Size(120, 60);
            TableSemis1.TabIndex = 6;
            TableSemis1.Visible = false;
            // 
            // TableFinals
            // 
            TableFinals.BackColor = Color.White;
            TableFinals.ColumnCount = 2;
            TableFinals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            TableFinals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0991745F));
            TableFinals.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableFinals.Location = new Point(580, 300);
            TableFinals.Name = "TableFinals";
            TableFinals.RowCount = 2;
            TableFinals.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableFinals.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableFinals.Size = new Size(120, 60);
            TableFinals.TabIndex = 7;
            TableFinals.Visible = false;
            // 
            // TableSemis2
            // 
            TableSemis2.BackColor = Color.White;
            TableSemis2.ColumnCount = 2;
            TableSemis2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            TableSemis2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0991745F));
            TableSemis2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableSemis2.Location = new Point(810, 300);
            TableSemis2.Name = "TableSemis2";
            TableSemis2.RowCount = 2;
            TableSemis2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableSemis2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableSemis2.Size = new Size(120, 60);
            TableSemis2.TabIndex = 8;
            TableSemis2.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // TableQuarters3
            // 
            TableQuarters3.BackColor = Color.White;
            TableQuarters3.ColumnCount = 2;
            TableQuarters3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            TableQuarters3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0991745F));
            TableQuarters3.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableQuarters3.Location = new Point(1010, 200);
            TableQuarters3.Name = "TableQuarters3";
            TableQuarters3.RowCount = 2;
            TableQuarters3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableQuarters3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableQuarters3.Size = new Size(120, 60);
            TableQuarters3.TabIndex = 9;
            TableQuarters3.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.White;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // TableQuarters4
            // 
            TableQuarters4.BackColor = Color.White;
            TableQuarters4.ColumnCount = 2;
            TableQuarters4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.9008255F));
            TableQuarters4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0991745F));
            TableQuarters4.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TableQuarters4.Location = new Point(1010, 400);
            TableQuarters4.Name = "TableQuarters4";
            TableQuarters4.RowCount = 2;
            TableQuarters4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableQuarters4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableQuarters4.Size = new Size(120, 60);
            TableQuarters4.TabIndex = 10;
            TableQuarters4.Visible = false;
            // 
            // WinnerCaptionLabel
            // 
            WinnerCaptionLabel.AutoSize = true;
            WinnerCaptionLabel.BackColor = Color.Transparent;
            WinnerCaptionLabel.Font = new Font("Segoe UI", 20F);
            WinnerCaptionLabel.ForeColor = Color.Gold;
            WinnerCaptionLabel.Location = new Point(551, 400);
            WinnerCaptionLabel.Name = "WinnerCaptionLabel";
            WinnerCaptionLabel.Size = new Size(172, 37);
            WinnerCaptionLabel.TabIndex = 11;
            WinnerCaptionLabel.Text = "Победитель:";
            WinnerCaptionLabel.Visible = false;
            // 
            // WinnerNameLabel
            // 
            WinnerNameLabel.AutoSize = true;
            WinnerNameLabel.BackColor = Color.Transparent;
            WinnerNameLabel.Font = new Font("Segoe UI", 20F);
            WinnerNameLabel.ForeColor = Color.Gold;
            WinnerNameLabel.Location = new Point(548, 452);
            WinnerNameLabel.Name = "WinnerNameLabel";
            WinnerNameLabel.Size = new Size(185, 37);
            WinnerNameLabel.TabIndex = 12;
            WinnerNameLabel.Text = "-победитель-";
            WinnerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            WinnerNameLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.splash;
            ClientSize = new Size(1264, 681);
            Controls.Add(WinnerNameLabel);
            Controls.Add(WinnerCaptionLabel);
            Controls.Add(TableQuarters4);
            Controls.Add(TableQuarters3);
            Controls.Add(TableSemis2);
            Controls.Add(TableFinals);
            Controls.Add(TableSemis1);
            Controls.Add(TableQuarters2);
            Controls.Add(GenerateTeamsButton);
            Controls.Add(TableQuarters1);
            Controls.Add(LogoBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Ц";
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoBox;
        private TableLayoutPanel TableQuarters1;
        private Button GenerateTeamsButton;
        private TableLayoutPanel TableQuarters2;
        private TableLayoutPanel TableSemis1;
        private TableLayoutPanel TableFinals;
        private TableLayoutPanel TableSemis2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel TableQuarters3;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel TableQuarters4;
        private Label WinnerCaptionLabel;
        private Label WinnerNameLabel;
    }
}
