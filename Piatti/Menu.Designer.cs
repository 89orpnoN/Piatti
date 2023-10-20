namespace Piatti
{
    partial class Menu
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
            SecondoPiattoBox = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            DessertBox = new ComboBox();
            groupBox2 = new GroupBox();
            PrimoPiattoBox = new ComboBox();
            groupBox1 = new GroupBox();
            DessertPicture = new PictureBox();
            SecondoPiattoPicture = new PictureBox();
            PrimoPiattoPicture = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DessertPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondoPiattoPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrimoPiattoPicture).BeginInit();
            SuspendLayout();
            // 
            // SecondoPiattoBox
            // 
            SecondoPiattoBox.Anchor = AnchorStyles.None;
            SecondoPiattoBox.FormattingEnabled = true;
            SecondoPiattoBox.Location = new Point(44, 14);
            SecondoPiattoBox.Name = "SecondoPiattoBox";
            SecondoPiattoBox.Size = new Size(150, 23);
            SecondoPiattoBox.TabIndex = 2;
            SecondoPiattoBox.Text = "Niente";
            SecondoPiattoBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            SecondoPiattoBox.TextChanged += SecondoPiattoBox_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.1511841F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.5154839F));
            tableLayoutPanel1.Controls.Add(groupBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(DessertPicture, 2, 1);
            tableLayoutPanel1.Controls.Add(SecondoPiattoPicture, 1, 1);
            tableLayoutPanel1.Controls.Add(PrimoPiattoPicture, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DessertBox);
            groupBox3.Location = new Point(534, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 44);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dessert";
            // 
            // DessertBox
            // 
            DessertBox.Anchor = AnchorStyles.None;
            DessertBox.FormattingEnabled = true;
            DessertBox.Location = new Point(27, 15);
            DessertBox.Name = "DessertBox";
            DessertBox.Size = new Size(150, 23);
            DessertBox.TabIndex = 4;
            DessertBox.Text = "Niente";
            DessertBox.SelectedIndexChanged += DessertBox_SelectedIndexChanged;
            DessertBox.TextUpdate += DessertBox_TextUpdate;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrimoPiattoBox);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 44);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Primo Piatto";
            // 
            // PrimoPiattoBox
            // 
            PrimoPiattoBox.Anchor = AnchorStyles.None;
            PrimoPiattoBox.FormattingEnabled = true;
            PrimoPiattoBox.Location = new Point(15, 18);
            PrimoPiattoBox.Name = "PrimoPiattoBox";
            PrimoPiattoBox.Size = new Size(150, 23);
            PrimoPiattoBox.TabIndex = 3;
            PrimoPiattoBox.Text = "Niente";
            PrimoPiattoBox.TextChanged += PrimoPiattoBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SecondoPiattoBox);
            groupBox1.Location = new Point(269, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 44);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Secondo Piatto";
            // 
            // DessertPicture
            // 
            DessertPicture.Dock = DockStyle.Fill;
            DessertPicture.Location = new Point(534, 63);
            DessertPicture.Name = "DessertPicture";
            DessertPicture.Size = new Size(263, 384);
            DessertPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            DessertPicture.TabIndex = 7;
            DessertPicture.TabStop = false;
            // 
            // SecondoPiattoPicture
            // 
            SecondoPiattoPicture.Dock = DockStyle.Fill;
            SecondoPiattoPicture.Location = new Point(269, 63);
            SecondoPiattoPicture.Name = "SecondoPiattoPicture";
            SecondoPiattoPicture.Size = new Size(259, 384);
            SecondoPiattoPicture.TabIndex = 5;
            SecondoPiattoPicture.TabStop = false;
            SecondoPiattoPicture.Click += SecondoPiattoPicture_Click;
            // 
            // PrimoPiattoPicture
            // 
            PrimoPiattoPicture.Dock = DockStyle.Fill;
            PrimoPiattoPicture.Location = new Point(3, 63);
            PrimoPiattoPicture.Name = "PrimoPiattoPicture";
            PrimoPiattoPicture.Size = new Size(260, 384);
            PrimoPiattoPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PrimoPiattoPicture.TabIndex = 6;
            PrimoPiattoPicture.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(650, 200);
            Name = "Form1";
            Text = "Scegli il tuo menù";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DessertPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondoPiattoPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrimoPiattoPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox SecondoPiattoBox;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox DessertBox;
        private ComboBox PrimoPiattoBox;
        private PictureBox SecondoPiattoPicture;
        private PictureBox DessertPicture;
        private PictureBox PrimoPiattoPicture;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
    }
}