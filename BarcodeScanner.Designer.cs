namespace test_barcode_scanner
{
    partial class BarcodeScanner
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
            label1 = new Label();
            cboCamera = new ComboBox();
            label2 = new Label();
            pictureBox = new PictureBox();
            btnStart = new Button();
            txtBarcode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Camera:";
            // 
            // cboCamera
            // 
            cboCamera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCamera.FormattingEnabled = true;
            cboCamera.Location = new Point(78, 22);
            cboCamera.Name = "cboCamera";
            cboCamera.Size = new Size(229, 23);
            cboCamera.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 203);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Barcode:";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(21, 62);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(286, 125);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(232, 234);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(159, 200);
            txtBarcode.MaxLength = 10;
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(148, 23);
            txtBarcode.TabIndex = 5;
            // 
            // BarcodeScanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 272);
            Controls.Add(txtBarcode);
            Controls.Add(btnStart);
            Controls.Add(pictureBox);
            Controls.Add(label2);
            Controls.Add(cboCamera);
            Controls.Add(label1);
            Name = "BarcodeScanner";
            Text = "BarcodeScanner";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCamera;
        private Label label2;
        private PictureBox pictureBox;
        private Button btnStart;
        private TextBox txtBarcode;
    }
}