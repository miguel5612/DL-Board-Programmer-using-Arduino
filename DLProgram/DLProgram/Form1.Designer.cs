namespace DLProgram
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.ddPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExe = new System.Windows.Forms.TextBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.lblExe = new System.Windows.Forms.Label();
            this.lblMExe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumBytes = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSendMode = new System.Windows.Forms.ComboBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(499, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Conectar!";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // ddPorts
            // 
            this.ddPorts.FormattingEnabled = true;
            this.ddPorts.Location = new System.Drawing.Point(120, 34);
            this.ddPorts.Name = "ddPorts";
            this.ddPorts.Size = new System.Drawing.Size(121, 21);
            this.ddPorts.TabIndex = 1;
            this.ddPorts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puerto Serie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ddBaudRate
            // 
            this.ddBaudRate.FormattingEnabled = true;
            this.ddBaudRate.Location = new System.Drawing.Point(347, 35);
            this.ddBaudRate.Name = "ddBaudRate";
            this.ddBaudRate.Size = new System.Drawing.Size(121, 21);
            this.ddBaudRate.TabIndex = 3;
            this.ddBaudRate.SelectedIndexChanged += new System.EventHandler(this.ddBaudRate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BaudRate";
            // 
            // txtExe
            // 
            this.txtExe.Location = new System.Drawing.Point(32, 189);
            this.txtExe.Multiline = true;
            this.txtExe.Name = "txtExe";
            this.txtExe.Size = new System.Drawing.Size(338, 544);
            this.txtExe.TabIndex = 5;
            this.txtExe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(417, 189);
            this.txtMod.Multiline = true;
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(327, 544);
            this.txtMod.TabIndex = 6;
            // 
            // lblExe
            // 
            this.lblExe.AutoSize = true;
            this.lblExe.Location = new System.Drawing.Point(29, 173);
            this.lblExe.Name = "lblExe";
            this.lblExe.Size = new System.Drawing.Size(57, 13);
            this.lblExe.TabIndex = 7;
            this.lblExe.Text = "EXE Leido";
            this.lblExe.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMExe
            // 
            this.lblMExe.AutoSize = true;
            this.lblMExe.Location = new System.Drawing.Point(414, 173);
            this.lblMExe.Name = "lblMExe";
            this.lblMExe.Size = new System.Drawing.Size(138, 13);
            this.lblMExe.TabIndex = 8;
            this.lblMExe.Text = "Datos escritos en el arduino";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Actualizar puertos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtRoute
            // 
            this.txtRoute.Location = new System.Drawing.Point(347, 126);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(366, 20);
            this.txtRoute.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fallos:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(120, 72);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(120, 31);
            this.btnReadFile.TabIndex = 12;
            this.btnReadFile.Text = "Leer archivo";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Proceso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "# de bytes del programa";
            // 
            // txtNumBytes
            // 
            this.txtNumBytes.Location = new System.Drawing.Point(395, 81);
            this.txtNumBytes.Name = "txtNumBytes";
            this.txtNumBytes.Size = new System.Drawing.Size(73, 20);
            this.txtNumBytes.TabIndex = 15;
            this.txtNumBytes.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Programar tarjeta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSendMode
            // 
            this.cmbSendMode.FormattingEnabled = true;
            this.cmbSendMode.Location = new System.Drawing.Point(474, 80);
            this.cmbSendMode.Name = "cmbSendMode";
            this.cmbSendMode.Size = new System.Drawing.Size(139, 21);
            this.cmbSendMode.TabIndex = 17;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.label4);
            this.panelBack.Controls.Add(this.pbLoad);
            this.panelBack.Controls.Add(this.label6);
            this.panelBack.Controls.Add(this.label3);
            this.panelBack.Controls.Add(this.lblExe);
            this.panelBack.Controls.Add(this.label5);
            this.panelBack.Controls.Add(this.txtNumBytes);
            this.panelBack.Controls.Add(this.cmbSendMode);
            this.panelBack.Controls.Add(this.label2);
            this.panelBack.Controls.Add(this.button2);
            this.panelBack.Controls.Add(this.ddBaudRate);
            this.panelBack.Controls.Add(this.btnReadFile);
            this.panelBack.Controls.Add(this.txtRoute);
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(777, 777);
            this.panelBack.TabIndex = 18;
            // 
            // pbLoad
            // 
            this.pbLoad.Location = new System.Drawing.Point(120, 126);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(120, 23);
            this.pbLoad.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMExe);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtExe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddPorts);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.panelBack);
            this.Name = "Form1";
            this.Text = "DL-PROGRAMMER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox ddPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExe;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Label lblExe;
        private System.Windows.Forms.Label lblMExe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumBytes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbSendMode;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbLoad;
    }
}

