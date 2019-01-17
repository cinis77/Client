namespace TCP_Connection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.groupBoxSend = new System.Windows.Forms.GroupBox();
            this.textBoxEcho = new System.Windows.Forms.TextBox();
            this.groupBoxCartesian = new System.Windows.Forms.GroupBox();
            this.buttonSendCartessian = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.Z = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.groupBoxAxis = new System.Windows.Forms.GroupBox();
            this.buttonSendA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A6 = new System.Windows.Forms.TextBox();
            this.A5 = new System.Windows.Forms.TextBox();
            this.A4 = new System.Windows.Forms.TextBox();
            this.A3 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.A1 = new System.Windows.Forms.TextBox();
            this.checkBoxCartesian = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxSend.SuspendLayout();
            this.groupBoxCartesian.SuspendLayout();
            this.groupBoxAxis.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIp);
            this.groupBox1.Location = new System.Drawing.Point(1372, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(467, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(275, 223);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(175, 51);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(189, 125);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(256, 35);
            this.textBoxPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(189, 42);
            this.textBoxIp.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(258, 35);
            this.textBoxIp.TabIndex = 0;
            // 
            // groupBoxSend
            // 
            this.groupBoxSend.Controls.Add(this.textBoxEcho);
            this.groupBoxSend.Controls.Add(this.groupBoxCartesian);
            this.groupBoxSend.Controls.Add(this.groupBoxAxis);
            this.groupBoxSend.Controls.Add(this.checkBoxCartesian);
            this.groupBoxSend.Controls.Add(this.checkBoxA);
            this.groupBoxSend.Location = new System.Drawing.Point(30, 29);
            this.groupBoxSend.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBoxSend.Name = "groupBoxSend";
            this.groupBoxSend.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBoxSend.Size = new System.Drawing.Size(1328, 948);
            this.groupBoxSend.TabIndex = 1;
            this.groupBoxSend.TabStop = false;
            this.groupBoxSend.Text = "DataToSendGroup";
            // 
            // textBoxEcho
            // 
            this.textBoxEcho.Location = new System.Drawing.Point(47, 489);
            this.textBoxEcho.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxEcho.Multiline = true;
            this.textBoxEcho.Name = "textBoxEcho";
            this.textBoxEcho.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEcho.Size = new System.Drawing.Size(1220, 397);
            this.textBoxEcho.TabIndex = 9;
            // 
            // groupBoxCartesian
            // 
            this.groupBoxCartesian.Controls.Add(this.buttonSendCartessian);
            this.groupBoxCartesian.Controls.Add(this.label9);
            this.groupBoxCartesian.Controls.Add(this.label10);
            this.groupBoxCartesian.Controls.Add(this.label11);
            this.groupBoxCartesian.Controls.Add(this.label12);
            this.groupBoxCartesian.Controls.Add(this.label13);
            this.groupBoxCartesian.Controls.Add(this.label14);
            this.groupBoxCartesian.Controls.Add(this.C);
            this.groupBoxCartesian.Controls.Add(this.B);
            this.groupBoxCartesian.Controls.Add(this.A);
            this.groupBoxCartesian.Controls.Add(this.Z);
            this.groupBoxCartesian.Controls.Add(this.Y);
            this.groupBoxCartesian.Controls.Add(this.X);
            this.groupBoxCartesian.Location = new System.Drawing.Point(138, 290);
            this.groupBoxCartesian.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBoxCartesian.Name = "groupBoxCartesian";
            this.groupBoxCartesian.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBoxCartesian.Size = new System.Drawing.Size(1108, 136);
            this.groupBoxCartesian.TabIndex = 8;
            this.groupBoxCartesian.TabStop = false;
            this.groupBoxCartesian.Text = "Cartesina motion";
            // 
            // buttonSendCartessian
            // 
            this.buttonSendCartessian.Location = new System.Drawing.Point(901, 78);
            this.buttonSendCartessian.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonSendCartessian.Name = "buttonSendCartessian";
            this.buttonSendCartessian.Size = new System.Drawing.Size(175, 51);
            this.buttonSendCartessian.TabIndex = 8;
            this.buttonSendCartessian.Text = "Send";
            this.buttonSendCartessian.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(754, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(611, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 29);
            this.label11.TabIndex = 6;
            this.label11.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 29);
            this.label12.TabIndex = 7;
            this.label12.Text = "Z";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 29);
            this.label13.TabIndex = 6;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 49);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 29);
            this.label14.TabIndex = 5;
            this.label14.Text = "X";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(761, 78);
            this.C.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(81, 35);
            this.C.TabIndex = 3;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(618, 78);
            this.B.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(81, 35);
            this.B.TabIndex = 4;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(476, 78);
            this.A.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(81, 35);
            this.A.TabIndex = 3;
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(338, 78);
            this.Z.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(81, 35);
            this.Z.TabIndex = 2;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(205, 78);
            this.Y.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(81, 35);
            this.Y.TabIndex = 1;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(79, 78);
            this.X.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(81, 35);
            this.X.TabIndex = 0;
            // 
            // groupBoxAxis
            // 
            this.groupBoxAxis.Controls.Add(this.buttonSendA);
            this.groupBoxAxis.Controls.Add(this.label8);
            this.groupBoxAxis.Controls.Add(this.label7);
            this.groupBoxAxis.Controls.Add(this.label6);
            this.groupBoxAxis.Controls.Add(this.label5);
            this.groupBoxAxis.Controls.Add(this.label4);
            this.groupBoxAxis.Controls.Add(this.label3);
            this.groupBoxAxis.Controls.Add(this.A6);
            this.groupBoxAxis.Controls.Add(this.A5);
            this.groupBoxAxis.Controls.Add(this.A4);
            this.groupBoxAxis.Controls.Add(this.A3);
            this.groupBoxAxis.Controls.Add(this.A2);
            this.groupBoxAxis.Controls.Add(this.A1);
            this.groupBoxAxis.Location = new System.Drawing.Point(138, 87);
            this.groupBoxAxis.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBoxAxis.Name = "groupBoxAxis";
            this.groupBoxAxis.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBoxAxis.Size = new System.Drawing.Size(1108, 136);
            this.groupBoxAxis.TabIndex = 2;
            this.groupBoxAxis.TabStop = false;
            this.groupBoxAxis.Text = "Axis motion";
            // 
            // buttonSendA
            // 
            this.buttonSendA.Location = new System.Drawing.Point(901, 78);
            this.buttonSendA.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonSendA.Name = "buttonSendA";
            this.buttonSendA.Size = new System.Drawing.Size(175, 51);
            this.buttonSendA.TabIndex = 8;
            this.buttonSendA.Text = "Send";
            this.buttonSendA.UseVisualStyleBackColor = true;
            this.buttonSendA.Click += new System.EventHandler(this.buttonSendA_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "A6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "A5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "A4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "A3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "A2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "A1";
            // 
            // A6
            // 
            this.A6.Location = new System.Drawing.Point(761, 78);
            this.A6.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(81, 35);
            this.A6.TabIndex = 3;
            // 
            // A5
            // 
            this.A5.Location = new System.Drawing.Point(618, 78);
            this.A5.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(81, 35);
            this.A5.TabIndex = 4;
            // 
            // A4
            // 
            this.A4.Location = new System.Drawing.Point(476, 78);
            this.A4.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(81, 35);
            this.A4.TabIndex = 3;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(338, 78);
            this.A3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(81, 35);
            this.A3.TabIndex = 2;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(205, 78);
            this.A2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(81, 35);
            this.A2.TabIndex = 1;
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(79, 78);
            this.A1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(81, 35);
            this.A1.TabIndex = 0;
            // 
            // checkBoxCartesian
            // 
            this.checkBoxCartesian.AutoSize = true;
            this.checkBoxCartesian.Location = new System.Drawing.Point(47, 337);
            this.checkBoxCartesian.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.checkBoxCartesian.Name = "checkBoxCartesian";
            this.checkBoxCartesian.Size = new System.Drawing.Size(28, 27);
            this.checkBoxCartesian.TabIndex = 1;
            this.checkBoxCartesian.UseVisualStyleBackColor = true;
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(47, 123);
            this.checkBoxA.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(28, 27);
            this.checkBoxA.TabIndex = 0;
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(53, 223);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(7);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(175, 51);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.groupBoxSend);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSend.ResumeLayout(false);
            this.groupBoxSend.PerformLayout();
            this.groupBoxCartesian.ResumeLayout(false);
            this.groupBoxCartesian.PerformLayout();
            this.groupBoxAxis.ResumeLayout(false);
            this.groupBoxAxis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.GroupBox groupBoxSend;
        private System.Windows.Forms.GroupBox groupBoxCartesian;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox Z;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.GroupBox groupBoxAxis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox A6;
        private System.Windows.Forms.TextBox A5;
        private System.Windows.Forms.TextBox A4;
        private System.Windows.Forms.TextBox A3;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.CheckBox checkBoxCartesian;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.Button buttonSendCartessian;
        private System.Windows.Forms.Button buttonSendA;
        private System.Windows.Forms.TextBox textBoxEcho;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

