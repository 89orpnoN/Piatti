namespace Piatti
{
    partial class Riepilogo_Popup
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
            tableLayoutPanel1 = new TableLayoutPanel();
            SalseGroupBox = new GroupBox();
            SalseList = new ListBox();
            PacchettiGroupbox = new GroupBox();
            PacchettiValue = new Label();
            PacchettiText = new Label();
            tableLayoutPanel1.SuspendLayout();
            SalseGroupBox.SuspendLayout();
            PacchettiGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(SalseGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(PacchettiGroupbox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(234, 264);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SalseGroupBox
            // 
            SalseGroupBox.Controls.Add(SalseList);
            SalseGroupBox.Dock = DockStyle.Fill;
            SalseGroupBox.Location = new Point(3, 3);
            SalseGroupBox.Name = "SalseGroupBox";
            SalseGroupBox.Size = new Size(228, 126);
            SalseGroupBox.TabIndex = 1;
            SalseGroupBox.TabStop = false;
            SalseGroupBox.Text = "Salse";
            // 
            // SalseList
            // 
            SalseList.Dock = DockStyle.Fill;
            SalseList.FormattingEnabled = true;
            SalseList.ItemHeight = 15;
            SalseList.Location = new Point(3, 19);
            SalseList.Name = "SalseList";
            SalseList.Size = new Size(222, 104);
            SalseList.TabIndex = 0;
            // 
            // PacchettiGroupbox
            // 
            PacchettiGroupbox.Controls.Add(PacchettiValue);
            PacchettiGroupbox.Controls.Add(PacchettiText);
            PacchettiGroupbox.Dock = DockStyle.Fill;
            PacchettiGroupbox.Location = new Point(3, 135);
            PacchettiGroupbox.Name = "PacchettiGroupbox";
            PacchettiGroupbox.Size = new Size(228, 126);
            PacchettiGroupbox.TabIndex = 0;
            PacchettiGroupbox.TabStop = false;
            PacchettiGroupbox.Text = "Sacchetti";
            // 
            // PacchettiValue
            // 
            PacchettiValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PacchettiValue.AutoSize = true;
            PacchettiValue.Location = new Point(131, 60);
            PacchettiValue.Name = "PacchettiValue";
            PacchettiValue.Size = new Size(13, 15);
            PacchettiValue.TabIndex = 0;
            PacchettiValue.Text = "0";
            PacchettiValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PacchettiText
            // 
            PacchettiText.AutoSize = true;
            PacchettiText.Location = new Point(66, 60);
            PacchettiText.Name = "PacchettiText";
            PacchettiText.Size = new Size(58, 15);
            PacchettiText.TabIndex = 0;
            PacchettiText.Text = "Sacchetti:";
            PacchettiText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Riepilogo_Popup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 264);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Riepilogo_Popup";
            ShowInTaskbar = false;
            Text = "Riepilogo_Popup";
            Load += Riepilogo_Popup_Load;
            tableLayoutPanel1.ResumeLayout(false);
            SalseGroupBox.ResumeLayout(false);
            PacchettiGroupbox.ResumeLayout(false);
            PacchettiGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox SalseGroupBox;
        private GroupBox PacchettiGroupbox;
        private Label PacchettiText;
        private Label PacchettiValue;
        private ListBox SalseList;
    }
}