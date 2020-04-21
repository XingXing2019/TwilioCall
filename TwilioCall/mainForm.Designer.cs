namespace TwilioCall
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbSms = new System.Windows.Forms.CheckBox();
            this.cbCall = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.cbApi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnText = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select API to Use:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 485);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: waiting...";
            // 
            // cbSms
            // 
            this.cbSms.AutoSize = true;
            this.cbSms.Location = new System.Drawing.Point(26, 70);
            this.cbSms.Name = "cbSms";
            this.cbSms.Size = new System.Drawing.Size(184, 21);
            this.cbSms.TabIndex = 2;
            this.cbSms.Text = "Can Send Text Message";
            this.cbSms.UseVisualStyleBackColor = true;
            // 
            // cbCall
            // 
            this.cbCall.AutoSize = true;
            this.cbCall.Location = new System.Drawing.Point(26, 97);
            this.cbCall.Name = "cbCall";
            this.cbCall.Size = new System.Drawing.Size(82, 21);
            this.cbCall.TabIndex = 3;
            this.cbCall.Text = "Can Call";
            this.cbCall.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(73, 139);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(288, 22);
            this.txtFrom.TabIndex = 5;
            // 
            // cbApi
            // 
            this.cbApi.FormattingEnabled = true;
            this.cbApi.Location = new System.Drawing.Point(169, 30);
            this.cbApi.Name = "cbApi";
            this.cbApi.Size = new System.Drawing.Size(192, 24);
            this.cbApi.TabIndex = 6;
            this.cbApi.SelectedValueChanged += new System.EventHandler(this.cbApi_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(73, 167);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(288, 22);
            this.txtTo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "To:";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(26, 234);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(335, 179);
            this.txtBody.TabIndex = 10;
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(26, 438);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(158, 27);
            this.btnText.TabIndex = 11;
            this.btnText.Text = "SMS";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(203, 438);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(158, 27);
            this.btnCall.TabIndex = 12;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(279, 481);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(82, 27);
            this.btnUpdateStatus.TabIndex = 13;
            this.btnUpdateStatus.Text = "Refresh";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 532);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbApi);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCall);
            this.Controls.Add(this.cbSms);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbSms;
        private System.Windows.Forms.CheckBox cbCall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ComboBox cbApi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}

