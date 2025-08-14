namespace MedicodeForm
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTreatments = new System.Windows.Forms.TabPage();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.btnEditTreatment = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnEditAppointment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.tabPageDoctors = new System.Windows.Forms.TabPage();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnEditDoctor = new System.Windows.Forms.Button();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.btnLogout = new System.Windows.Forms.Button();
            this.chartAppointments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTreatments = new System.Windows.Forms.DataGridView();
            this.tabPageTreatments.SuspendLayout();
            this.tabPageAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.tabPagePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabPageDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.tabControlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Admin Panel!";
            // 
            // tabPageTreatments
            // 
            this.tabPageTreatments.Controls.Add(this.dataGridViewTreatments);
            this.tabPageTreatments.Controls.Add(this.btnDeleteTreatment);
            this.tabPageTreatments.Controls.Add(this.btnEditTreatment);
            this.tabPageTreatments.Controls.Add(this.btnAddTreatment);
            this.tabPageTreatments.Location = new System.Drawing.Point(4, 29);
            this.tabPageTreatments.Name = "tabPageTreatments";
            this.tabPageTreatments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTreatments.Size = new System.Drawing.Size(939, 656);
            this.tabPageTreatments.TabIndex = 4;
            this.tabPageTreatments.Text = "Treatments";
            this.tabPageTreatments.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteTreatment.Location = new System.Drawing.Point(659, 574);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(251, 61);
            this.btnDeleteTreatment.TabIndex = 10;
            this.btnDeleteTreatment.Text = "Delete Treatment";
            this.btnDeleteTreatment.UseVisualStyleBackColor = true;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDeleteTreatment_Click);
            // 
            // btnEditTreatment
            // 
            this.btnEditTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditTreatment.Location = new System.Drawing.Point(341, 574);
            this.btnEditTreatment.Name = "btnEditTreatment";
            this.btnEditTreatment.Size = new System.Drawing.Size(251, 61);
            this.btnEditTreatment.TabIndex = 9;
            this.btnEditTreatment.Text = "Edit Treatment";
            this.btnEditTreatment.UseVisualStyleBackColor = true;
            this.btnEditTreatment.Click += new System.EventHandler(this.btnEditTreatment_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTreatment.Location = new System.Drawing.Point(27, 574);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(251, 61);
            this.btnAddTreatment.TabIndex = 8;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.Controls.Add(this.btnDeleteAppointment);
            this.tabPageAppointments.Controls.Add(this.btnEditAppointment);
            this.tabPageAppointments.Controls.Add(this.btnAddAppointment);
            this.tabPageAppointments.Controls.Add(this.dataGridViewAppointments);
            this.tabPageAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 29);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppointments.Size = new System.Drawing.Size(939, 656);
            this.tabPageAppointments.TabIndex = 2;
            this.tabPageAppointments.Text = "Appointments";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteAppointment.Location = new System.Drawing.Point(663, 572);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(251, 61);
            this.btnDeleteAppointment.TabIndex = 8;
            this.btnDeleteAppointment.Text = "Delete Appointment";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditAppointment.Location = new System.Drawing.Point(342, 572);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(251, 61);
            this.btnEditAppointment.TabIndex = 7;
            this.btnEditAppointment.Text = "Edit Appointment";
            this.btnEditAppointment.UseVisualStyleBackColor = true;
            this.btnEditAppointment.Click += new System.EventHandler(this.btnEditAppointment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAppointment.Location = new System.Drawing.Point(21, 572);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(251, 61);
            this.btnAddAppointment.TabIndex = 6;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(939, 555);
            this.dataGridViewAppointments.TabIndex = 0;
            this.dataGridViewAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointments_CellContentClick);
            // 
            // tabPagePatients
            // 
            this.tabPagePatients.Controls.Add(this.btnDeletePatient);
            this.tabPagePatients.Controls.Add(this.btnEditPatient);
            this.tabPagePatients.Controls.Add(this.btnAddPatient);
            this.tabPagePatients.Controls.Add(this.dataGridViewPatients);
            this.tabPagePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPagePatients.Location = new System.Drawing.Point(4, 29);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatients.Size = new System.Drawing.Size(939, 656);
            this.tabPagePatients.TabIndex = 1;
            this.tabPagePatients.Text = "Patients";
            this.tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeletePatient.Location = new System.Drawing.Point(666, 572);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(251, 61);
            this.btnDeletePatient.TabIndex = 7;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditPatient.Location = new System.Drawing.Point(341, 572);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(251, 61);
            this.btnEditPatient.TabIndex = 6;
            this.btnEditPatient.Text = "Edit Patient";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPatient.Location = new System.Drawing.Point(19, 572);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(251, 61);
            this.btnAddPatient.TabIndex = 5;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.Size = new System.Drawing.Size(939, 556);
            this.dataGridViewPatients.TabIndex = 0;
            // 
            // tabPageDoctors
            // 
            this.tabPageDoctors.Controls.Add(this.btnDeleteDoctor);
            this.tabPageDoctors.Controls.Add(this.dataGridViewDoctors);
            this.tabPageDoctors.Controls.Add(this.btnAddDoctor);
            this.tabPageDoctors.Controls.Add(this.btnEditDoctor);
            this.tabPageDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageDoctors.Location = new System.Drawing.Point(4, 29);
            this.tabPageDoctors.Name = "tabPageDoctors";
            this.tabPageDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctors.Size = new System.Drawing.Size(939, 656);
            this.tabPageDoctors.TabIndex = 0;
            this.tabPageDoctors.Text = "Doctors";
            this.tabPageDoctors.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteDoctor.Location = new System.Drawing.Point(671, 572);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(251, 61);
            this.btnDeleteDoctor.TabIndex = 6;
            this.btnDeleteDoctor.Text = "Delete Doctor";
            this.btnDeleteDoctor.UseVisualStyleBackColor = true;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.Size = new System.Drawing.Size(939, 555);
            this.dataGridViewDoctors.TabIndex = 0;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddDoctor.Location = new System.Drawing.Point(18, 572);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(251, 61);
            this.btnAddDoctor.TabIndex = 4;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditDoctor.Location = new System.Drawing.Point(340, 572);
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.Size = new System.Drawing.Size(251, 61);
            this.btnEditDoctor.TabIndex = 5;
            this.btnEditDoctor.Text = "Edit Doctor";
            this.btnEditDoctor.UseVisualStyleBackColor = true;
            this.btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageDoctors);
            this.tabControlAdmin.Controls.Add(this.tabPagePatients);
            this.tabControlAdmin.Controls.Add(this.tabPageAppointments);
            this.tabControlAdmin.Controls.Add(this.tabPageTreatments);
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlAdmin.Location = new System.Drawing.Point(22, 60);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(947, 689);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Location = new System.Drawing.Point(714, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(251, 61);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // chartAppointments
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAppointments.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAppointments.Legends.Add(legend1);
            this.chartAppointments.Location = new System.Drawing.Point(975, 177);
            this.chartAppointments.Name = "chartAppointments";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAppointments.Series.Add(series1);
            this.chartAppointments.Size = new System.Drawing.Size(403, 399);
            this.chartAppointments.TabIndex = 13;
            this.chartAppointments.Text = "chart1";
            // 
            // dataGridViewTreatments
            // 
            this.dataGridViewTreatments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTreatments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTreatments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTreatments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTreatments.Name = "dataGridViewTreatments";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTreatments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTreatments.Size = new System.Drawing.Size(939, 555);
            this.dataGridViewTreatments.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.chartAppointments);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.tabPageTreatments.ResumeLayout(false);
            this.tabPageAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.tabPagePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabPageDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.tabControlAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageTreatments;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.Button btnEditTreatment;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.TabPage tabPageAppointments;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnEditAppointment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.TabPage tabPagePatients;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.TabPage tabPageDoctors;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnEditDoctor;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointments;
        private System.Windows.Forms.DataGridView dataGridViewTreatments;
    }
}