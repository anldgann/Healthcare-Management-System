# 🏥 Medicode Healthcare Clinic Management System

## 📌 Project Description
**Medicode Healthcare Clinic Management System** is a **Windows Forms Application** developed in **C#** with **SQL Server** as the backend.  
It provides a complete clinic management solution for **administrators**, **doctors**, and **patients** — enabling appointment scheduling, treatment tracking, prescription management, and automated billing in a user-friendly interface.

---

## 🛠 Libraries and Tools Used
- **.NET Framework (Windows Forms)** – UI and logic layer  
- **Entity Framework 6** – ORM for database operations  
- **SQL Server / SQL Server Express** – Relational database backend  
- **System.Windows.Forms.DataVisualization.Charting** – Statistical charting for admin panel  
- **Microsoft Visual Studio** – Development environment  
- **NuGet Packages** – EntityFramework (6.x)  

---

## ⚙️ How to Set up and Run the Application

### **A. Database Setup**
1. **Install SQL Server** (or SQL Server Express).
2. **Create the Database**:  
   - Use the provided `script.sql` to generate the `Medicode` database.  
   - Open **SQL Server Management Studio (SSMS)** → connect to your server → open `script.sql` → execute.  
   - This will create all tables, relations, and triggers.

### **B. Application Setup**
1. **Open the Project**  
   - Open `Medicode.sln` in Visual Studio.
2. **Check the Connection String**  
   - In `App.config` files of **Medicode** and **MedicodeForm** projects, set your SQL Server instance name:
     ```xml
     <add name="MedicodeEntities" 
          connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;
          provider=System.Data.SqlClient;provider connection string=&quot;data source=YOUR_SERVER_NAME;initial catalog=Medicode;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" 
          providerName="System.Data.EntityClient" />
     ```
     Replace `YOUR_SERVER_NAME` with your actual SQL Server name (e.g., `DESKTOP-1234\SQLEXPRESS`).
3. **Build the Solution**  
   - Visual Studio → **Build > Build Solution**
4. **Run the Application**  
   - Press **F5** or click **Start**.

---

## 🔑 Default Login Credentials
**Admin**  
- UserID: `1` | Password: `admin123` | Role: `Admin`

**Doctors**  
- UserID: `1` | Password: `Smith` | Role: `Doctor` (John Smith)  
- UserID: `5` | Password: `Cano` | Role: `Doctor` (Ahmet Cano)  

**Patients**  
- UserID: `4` | Password: `patient123` | Role: `Patient` (Anıl Doğan)  
- UserID: `2` | Password: `1234` | Role: `Patient` (Alice Brown)  

---

## 🚀 Application Features

### **Admin Panel**
- Manage doctors, patients, appointments, and treatments.
- View statistics with charts.
- Add/update/delete users and appointments.

### **Doctor Panel**
- Manage own appointments and patients.
- Create/delete prescriptions.
- Add/update treatments.

### **Patient Panel**
- Book/cancel appointments.
- View prescriptions and bills.
- See treatment and payment history.

### **Billing**
- Auto-generated via SQL trigger when a treatment is added.
- Viewable by both patients and admin.

### **Prescriptions**
- Doctors can create prescriptions with medication, dosage, and instructions.
- Patients can view all past prescriptions.

### **Treatments**
- Includes procedure details, cost, and doctor notes.
- Linked to prescriptions and appointments.
- Triggers automatic billing.

---

## 📝 Notes & Troubleshooting
- If you move the project to another computer, update the **connection string** in `App.config`.
- If you get connection errors, verify server name & database existence.
- All triggers, views, and constraints are in the provided script.

---

## 👨‍💻 Credits
**Developer:** Anıl Doğan  
📅 Date: 26.05.2025  
📧 Contact: anil.dogan@tedu.edu.tr
