namespace MedicodeForm
{
    partial class TreatmentForm
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
            this.txtTreatmentType = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dateTimePickerTreatmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.comboBoxAppointmentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTreatmentType
            // 
            this.txtTreatmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTreatmentType.Location = new System.Drawing.Point(185, 144);
            this.txtTreatmentType.Name = "txtTreatmentType";
            this.txtTreatmentType.Size = new System.Drawing.Size(436, 31);
            this.txtTreatmentType.TabIndex = 1;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCost.Location = new System.Drawing.Point(185, 222);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(436, 31);
            this.txtCost.TabIndex = 2;
            // 
            // dateTimePickerTreatmentDate
            // 
            this.dateTimePickerTreatmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerTreatmentDate.Location = new System.Drawing.Point(185, 300);
            this.dateTimePickerTreatmentDate.Name = "dateTimePickerTreatmentDate";
            this.dateTimePickerTreatmentDate.Size = new System.Drawing.Size(436, 31);
            this.dateTimePickerTreatmentDate.TabIndex = 3;
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveTreatment.Location = new System.Drawing.Point(519, 361);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(251, 61);
            this.btnSaveTreatment.TabIndex = 12;
            this.btnSaveTreatment.Text = "Save Treatment";
            this.btnSaveTreatment.UseVisualStyleBackColor = true;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxAppointmentID
            // 
            this.comboBoxAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAppointmentID.FormattingEnabled = true;
            this.comboBoxAppointmentID.Location = new System.Drawing.Point(185, 68);
            this.comboBoxAppointmentID.Name = "comboBoxAppointmentID";
            this.comboBoxAppointmentID.Size = new System.Drawing.Size(436, 33);
            this.comboBoxAppointmentID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Appointment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Treatment Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date";
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAppointmentID);
            this.Controls.Add(this.btnSaveTreatment);
            this.Controls.Add(this.dateTimePickerTreatmentDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTreatmentType);
            this.Name = "TreatmentForm";
            this.Text = "TreatmentForm";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTreatmentType;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker dateTimePickerTreatmentDate;
        private System.Windows.Forms.Button btnSaveTreatment;
        private System.Windows.Forms.ComboBox comboBoxAppointmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}