namespace Praktikum_Week_5
{
    partial class formWeek5
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblKoleksi = new System.Windows.Forms.Label();
            this.tboxInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSetting = new System.Windows.Forms.Label();
            this.cBoxAktif = new System.Windows.Forms.CheckBox();
            this.lboxKoleksi = new System.Windows.Forms.ListBox();
            this.rButtonMerah = new System.Windows.Forms.RadioButton();
            this.rButtonBiru = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCetak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(96, 28);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // lblKoleksi
            // 
            this.lblKoleksi.AutoSize = true;
            this.lblKoleksi.Location = new System.Drawing.Point(90, 82);
            this.lblKoleksi.Name = "lblKoleksi";
            this.lblKoleksi.Size = new System.Drawing.Size(59, 20);
            this.lblKoleksi.TabIndex = 1;
            this.lblKoleksi.Text = "Koleksi:";
            // 
            // tboxInput
            // 
            this.tboxInput.Location = new System.Drawing.Point(165, 25);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(391, 27);
            this.tboxInput.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(598, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Location = new System.Drawing.Point(422, 86);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(59, 20);
            this.lblSetting.TabIndex = 4;
            this.lblSetting.Text = "Setting:";
            // 
            // cBoxAktif
            // 
            this.cBoxAktif.AutoSize = true;
            this.cBoxAktif.Location = new System.Drawing.Point(525, 86);
            this.cBoxAktif.Name = "cBoxAktif";
            this.cBoxAktif.Size = new System.Drawing.Size(62, 24);
            this.cBoxAktif.TabIndex = 5;
            this.cBoxAktif.Text = "Aktif";
            this.cBoxAktif.UseVisualStyleBackColor = true;
            this.cBoxAktif.CheckedChanged += new System.EventHandler(this.cBoxAktif_CheckedChanged);
            // 
            // lboxKoleksi
            // 
            this.lboxKoleksi.FormattingEnabled = true;
            this.lboxKoleksi.ItemHeight = 20;
            this.lboxKoleksi.Location = new System.Drawing.Point(30, 131);
            this.lboxKoleksi.Name = "lboxKoleksi";
            this.lboxKoleksi.Size = new System.Drawing.Size(320, 404);
            this.lboxKoleksi.TabIndex = 6;
            this.lboxKoleksi.SelectedIndexChanged += new System.EventHandler(this.lboxKoleksi_SelectedIndexChanged);
            // 
            // rButtonMerah
            // 
            this.rButtonMerah.AutoSize = true;
            this.rButtonMerah.Location = new System.Drawing.Point(469, 131);
            this.rButtonMerah.Name = "rButtonMerah";
            this.rButtonMerah.Size = new System.Drawing.Size(118, 24);
            this.rButtonMerah.TabIndex = 7;
            this.rButtonMerah.TabStop = true;
            this.rButtonMerah.Text = "Warna Merah";
            this.rButtonMerah.UseVisualStyleBackColor = true;
            this.rButtonMerah.CheckedChanged += new System.EventHandler(this.rButtonMerah_CheckedChanged);
            // 
            // rButtonBiru
            // 
            this.rButtonBiru.AutoSize = true;
            this.rButtonBiru.Location = new System.Drawing.Point(469, 161);
            this.rButtonBiru.Name = "rButtonBiru";
            this.rButtonBiru.Size = new System.Drawing.Size(102, 24);
            this.rButtonBiru.TabIndex = 8;
            this.rButtonBiru.TabStop = true;
            this.rButtonBiru.Text = "Warna Biru";
            this.rButtonBiru.UseVisualStyleBackColor = true;
            this.rButtonBiru.CheckedChanged += new System.EventHandler(this.rButtonBiru_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(422, 223);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(58, 20);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output:";
            this.lblOutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(422, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(323, 39);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCetak
            // 
            this.lblCetak.AutoSize = true;
            this.lblCetak.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCetak.Location = new System.Drawing.Point(525, 337);
            this.lblCetak.Name = "lblCetak";
            this.lblCetak.Size = new System.Drawing.Size(98, 41);
            this.lblCetak.TabIndex = 11;
            this.lblCetak.Text = "Cetak";
            // 
            // formWeek5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.lblCetak);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rButtonBiru);
            this.Controls.Add(this.rButtonMerah);
            this.Controls.Add(this.lboxKoleksi);
            this.Controls.Add(this.cBoxAktif);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboxInput);
            this.Controls.Add(this.lblKoleksi);
            this.Controls.Add(this.lblData);
            this.Name = "formWeek5";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.formWeek5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblKoleksi;
        private System.Windows.Forms.TextBox tboxInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.CheckBox cBoxAktif;
        private System.Windows.Forms.ListBox lboxKoleksi;
        private System.Windows.Forms.RadioButton rButtonMerah;
        private System.Windows.Forms.RadioButton rButtonBiru;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCetak;
    }
}
