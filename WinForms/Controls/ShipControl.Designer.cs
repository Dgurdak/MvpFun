namespace WinForms.Controls
{
    partial class ShipControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitId = new System.Windows.Forms.Button();
            this.btnSubmitWeight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblShippedCount = new System.Windows.Forms.Label();
            this.btnCustomizeScale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScaleStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(38, 90);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(192, 20);
            this.tbId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // btnSubmitId
            // 
            this.btnSubmitId.Location = new System.Drawing.Point(236, 88);
            this.btnSubmitId.Name = "btnSubmitId";
            this.btnSubmitId.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitId.TabIndex = 2;
            this.btnSubmitId.Text = "Submit ID";
            this.btnSubmitId.UseVisualStyleBackColor = true;
            // 
            // btnSubmitWeight
            // 
            this.btnSubmitWeight.Location = new System.Drawing.Point(236, 114);
            this.btnSubmitWeight.Name = "btnSubmitWeight";
            this.btnSubmitWeight.Size = new System.Drawing.Size(75, 47);
            this.btnSubmitWeight.TabIndex = 5;
            this.btnSubmitWeight.Text = "Submit Weight";
            this.btnSubmitWeight.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weight:";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(58, 116);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(172, 20);
            this.tbWeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(55, 148);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(25, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "???";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 47);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ship Count:";
            // 
            // lblShippedCount
            // 
            this.lblShippedCount.AutoSize = true;
            this.lblShippedCount.Location = new System.Drawing.Point(76, 11);
            this.lblShippedCount.Name = "lblShippedCount";
            this.lblShippedCount.Size = new System.Drawing.Size(13, 13);
            this.lblShippedCount.TabIndex = 10;
            this.lblShippedCount.Text = "0";
            // 
            // btnCustomizeScale
            // 
            this.btnCustomizeScale.Location = new System.Drawing.Point(11, 257);
            this.btnCustomizeScale.Name = "btnCustomizeScale";
            this.btnCustomizeScale.Size = new System.Drawing.Size(172, 23);
            this.btnCustomizeScale.TabIndex = 11;
            this.btnCustomizeScale.Text = "Customize Scale";
            this.btnCustomizeScale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Scale Status:";
            // 
            // lblScaleStatus
            // 
            this.lblScaleStatus.AutoSize = true;
            this.lblScaleStatus.Location = new System.Drawing.Point(84, 38);
            this.lblScaleStatus.Name = "lblScaleStatus";
            this.lblScaleStatus.Size = new System.Drawing.Size(23, 13);
            this.lblScaleStatus.TabIndex = 13;
            this.lblScaleStatus.Text = "ON";
            // 
            // ShipControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblScaleStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCustomizeScale);
            this.Controls.Add(this.lblShippedCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmitWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.btnSubmitId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbId);
            this.Name = "ShipControl";
            this.Size = new System.Drawing.Size(700, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitId;
        private System.Windows.Forms.Button btnSubmitWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShippedCount;
        private System.Windows.Forms.Button btnCustomizeScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblScaleStatus;
    }
}
