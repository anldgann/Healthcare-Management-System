namespace MedicodeForm
{
    partial class DoctorDashboard
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.dataGridViewPrescriptions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletePrescription = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWeeklyAppointments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.Location = new System.Drawing.Point(8, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(96, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome ";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1019, 274);
            this.dataGridViewAppointments.TabIndex = 1;
            this.dataGridViewAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellContentClick);
            this.dataGridViewAppointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(269, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(250, 62);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Appointment ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrescription.Location = new System.Drawing.Point(525, 345);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(250, 62);
            this.btnPrescription.TabIndex = 5;
            this.btnPrescription.Text = "Write Prescription";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // dataGridViewPrescriptions
            // 
            this.dataGridViewPrescriptions.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescriptions.Location = new System.Drawing.Point(12, 464);
            this.dataGridViewPrescriptions.Name = "dataGridViewPrescriptions";
            this.dataGridViewPrescriptions.Size = new System.Drawing.Size(1019, 261);
            this.dataGridViewPrescriptions.TabIndex = 6;
            this.dataGridViewPrescriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescriptions_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prescriptions for Selected Appointment";
            // 
            // btnDeletePrescription
            // 
            this.btnDeletePrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeletePrescription.Location = new System.Drawing.Point(781, 345);
            this.btnDeletePrescription.Name = "btnDeletePrescription";
            this.btnDeletePrescription.Size = new System.Drawing.Size(250, 62);
            this.btnDeletePrescription.TabIndex = 8;
            this.btnDeletePrescription.Text = "Delete Prescription";
            this.btnDeletePrescription.UseVisualStyleBackColor = true;
            this.btnDeletePrescription.Click += new System.EventHandler(this.btnDeletePrescription_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAppointment.Location = new System.Drawing.Point(12, 345);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(250, 62);
            this.btnAddAppointment.TabIndex = 9;
            this.btnAddAppointment.Text = "Add Appointment ";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Location = new System.Drawing.Point(866, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 54);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWeeklyAppointments
            // 
            this.lblWeeklyAppointments.AutoSize = true;
            this.lblWeeklyAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeeklyAppointments.Location = new System.Drawing.Point(400, 24);
            this.lblWeeklyAppointments.Name = "lblWeeklyAppointments";
            this.lblWeeklyAppointments.Size = new System.Drawing.Size(193, 24);
            this.lblWeeklyAppointments.TabIndex = 15;
            this.lblWeeklyAppointments.Text = "Weekly Appointments";
            // 
            // DoctorDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this.lblWeeklyAppointments);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnDeletePrescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPrescriptions);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DoctorDashboard";
            this.Load += new System.EventHandler(this.DoctorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.DataGridView dataGridViewPrescriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletePrescription;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWeeklyAppointments;
    }
}