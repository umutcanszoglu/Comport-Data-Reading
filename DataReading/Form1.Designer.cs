
namespace DataReading
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbPort = new System.Windows.Forms.ComboBox();
            this.CmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBaglan = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.LabelBaglanti = new System.Windows.Forms.Label();
            this.TxtGiden = new System.Windows.Forms.TextBox();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.TxtGelen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "com port";
            // 
            // CmbPort
            // 
            this.CmbPort.FormattingEnabled = true;
            this.CmbPort.Location = new System.Drawing.Point(117, 40);
            this.CmbPort.Name = "CmbPort";
            this.CmbPort.Size = new System.Drawing.Size(121, 28);
            this.CmbPort.TabIndex = 1;
            // 
            // CmbBaudRate
            // 
            this.CmbBaudRate.FormattingEnabled = true;
            this.CmbBaudRate.Location = new System.Drawing.Point(117, 87);
            this.CmbBaudRate.Name = "CmbBaudRate";
            this.CmbBaudRate.Size = new System.Drawing.Size(121, 28);
            this.CmbBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "baudrate";
            // 
            // BtnBaglan
            // 
            this.BtnBaglan.Location = new System.Drawing.Point(323, 43);
            this.BtnBaglan.Name = "BtnBaglan";
            this.BtnBaglan.Size = new System.Drawing.Size(114, 59);
            this.BtnBaglan.TabIndex = 4;
            this.BtnBaglan.Text = "bağlan";
            this.BtnBaglan.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(556, 43);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(112, 59);
            this.BtnTemizle.TabIndex = 5;
            this.BtnTemizle.Text = "temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            // 
            // LabelBaglanti
            // 
            this.LabelBaglanti.AutoSize = true;
            this.LabelBaglanti.Location = new System.Drawing.Point(319, 122);
            this.LabelBaglanti.Name = "LabelBaglanti";
            this.LabelBaglanti.Size = new System.Drawing.Size(33, 20);
            this.LabelBaglanti.TabIndex = 7;
            this.LabelBaglanti.Text = "......";
            // 
            // TxtGiden
            // 
            this.TxtGiden.Location = new System.Drawing.Point(32, 512);
            this.TxtGiden.Name = "TxtGiden";
            this.TxtGiden.Size = new System.Drawing.Size(370, 26);
            this.TxtGiden.TabIndex = 8;
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(441, 496);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(114, 59);
            this.BtnGonder.TabIndex = 9;
            this.BtnGonder.Text = "gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            // 
            // TxtGelen
            // 
            this.TxtGelen.Location = new System.Drawing.Point(32, 157);
            this.TxtGelen.Multiline = true;
            this.TxtGelen.Name = "TxtGelen";
            this.TxtGelen.Size = new System.Drawing.Size(712, 311);
            this.TxtGelen.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.TxtGelen);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.TxtGiden);
            this.Controls.Add(this.LabelBaglanti);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnBaglan);
            this.Controls.Add(this.CmbBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPort;
        private System.Windows.Forms.ComboBox CmbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBaglan;
        private System.Windows.Forms.Button BtnTemizle;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label LabelBaglanti;
        private System.Windows.Forms.TextBox TxtGiden;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.TextBox TxtGelen;
    }
}

