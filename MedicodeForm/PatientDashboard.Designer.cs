namespace MedicodeForm
{
    partial class PatientDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.dataGridViewPrescriptions = new System.Windows.Forms.DataGridView();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.btnViewBills = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.Location = new System.Drawing.Point(11, 30);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(91, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(16, 80);
            this.dataGridViewAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1359, 321);
            this.dataGridViewAppointments.TabIndex = 1;
            this.dataGridViewAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellContentClick);
            this.dataGridViewAppointments.SelectionChanged += new System.EventHandler(this.dataGridViewAppointments_SelectionChanged);
            // 
            // dataGridViewPrescriptions
            // 
            this.dataGridViewPrescriptions.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescriptions.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPrescriptions.Location = new System.Drawing.Point(16, 601);
            this.dataGridViewPrescriptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPrescriptions.Name = "dataGridViewPrescriptions";
            this.dataGridViewPrescriptions.Size = new System.Drawing.Size(1359, 321);
            this.dataGridViewPrescriptions.TabIndex = 2;
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookAppointment.Location = new System.Drawing.Point(16, 427);
            this.btnBookAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(333, 76);
            this.btnBookAppointment.TabIndex = 3;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelAppointment.Location = new System.Drawing.Point(357, 426);
            this.btnCancelAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(333, 76);
            this.btnCancelAppointment.TabIndex = 4;
            this.btnCancelAppointment.Text = "Cancel Appointment";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Location = new System.Drawing.Point(1040, 427);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(335, 75);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrescription.Location = new System.Drawing.Point(16, 546);
            this.lblPrescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(149, 24);
            this.lblPrescription.TabIndex = 14;
            this.lblPrescription.Text = "Prescriptions for ";
            // 
            // btnViewBills
            // 
            this.btnViewBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewBills.Location = new System.Drawing.Point(699, 427);
            this.btnViewBills.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewBills.Name = "btnViewBills";
            this.btnViewBills.Size = new System.Drawing.Size(335, 75);
            this.btnViewBills.TabIndex = 15;
            this.btnViewBills.Text = "View Bills";
            this.btnViewBills.UseVisualStyleBackColor = true;
            this.btnViewBills.Click += new System.EventHandler(this.btnViewBills_Click);
            // 
            // PatientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 937);
            this.Controls.Add(this.btnViewBills);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.dataGridViewPrescriptions);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientDashboard";
            this.Text = "PatientDashboard";
            this.Load += new System.EventHandler(this.PatientDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.DataGridView dataGridViewPrescriptions;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.Button btnViewBills;
    }
}