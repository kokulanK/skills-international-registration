# Skills International — Student Registration System

A complete C# WinForms desktop application (.NET Framework 4.7.2) with a **MySQL** database backend.

---

## Prerequisites

| Requirement | Detail |
|---|---|
| Visual Studio | 2019 / 2022 (Community or higher) |
| .NET Framework | 4.7.2 (usually pre-installed on Windows 10/11) |
| MySQL Server | XAMPP, WAMP, or standalone MySQL Server |
| MySQL Client | phpMyAdmin, MySQL Workbench, or Command Line |
| NuGet Package | `MySql.Data` (automatically restored via Visual Studio) |

---

## Step 1 — Set Up the Database

1. Open your MySQL client (e.g., **phpMyAdmin** or **MySQL Workbench**).
2. Create a new database named `Student` (or simply run the provided SQL script which does this).
3. Open the file `CreateDatabase.sql` and execute its contents.
4. The script will create the `Student` database, the `Registration` table, and the `Logins` table, along with sample data.
5. Verify that the tables `Registration` and `Logins` exist in your MySQL server.

---

## Step 2 — Configure the Connection String

Open `App.config` and find the `<connectionStrings>` section:

```xml
<add name="StudentDB"
     connectionString="Server=localhost;Database=Student;Uid=root;Pwd=;"
     providerName="MySql.Data.MySqlClient" />
```

Update the credentials if your MySQL setup requires a different username or password:

| Key | Default XAMPP Value | Description |
|---|---|---|
| `Server` | `localhost` | Your MySQL server address |
| `Database` | `Student` | The name of the database |
| `Uid` | `root` | Your MySQL username |
| `Pwd` | *(empty)* | Your MySQL password (leave blank for default XAMPP) |

---

## Step 3 — Open in Visual Studio

1. Double-click `SkillsInternational.csproj`, or  
   File → Open → Project/Solution → select `SkillsInternational.csproj`.
2. Visual Studio will open the project.
3. Make sure the `MySql.Data` NuGet package is installed (Right-click project -> Manage NuGet Packages).

---

## Step 4 — Build and Run

Press **F5** (or Debug → Start Debugging).  
The **Login** form will appear.

### Default credentials

| Field | Value |
|---|---|
| Username | `Admin` |
| Password | `Skills@123` |

---

## How to Use

| Action | How |
|---|---|
| **Register** a new student | Type a new Reg No, fill all fields, click **Register** |
| **Search** / **view** a student | Select a Reg No from the combo box |
| **Update** a record | Select a Reg No → modify fields → click **Update** |
| **Delete** a record | Select a Reg No → click **Delete** → confirm Yes |
| **Clear** the form | Click **Clear** |
| **Logout** | Click the **Logout** link (top-left of registration form) |
| **Exit** | Click the **Exit** link / button on either form |

---

## Project File Structure

```
esoft/
├── App.config               ← Connection string configuration
├── CreateDatabase.sql       ← Run this in MySQL first!
├── DBHelper.cs              ← Central MySQL database connection helper
├── Form1.cs                 ← Login form logic
├── Form1.Designer.cs        ← Login form layout
├── Form1.resx
├── Form2.cs                 ← Registration form logic (CRUD)
├── Form2.Designer.cs        ← Registration form layout
├── Form2.resx
├── Program.cs               ← App entry point
├── README.md                ← This file
└── SkillsInternational.csproj
```

---

## Extending to DB-Based Login

`Form1.cs` contains a commented-out section for validating credentials against the `Logins` table in MySQL.  
To enable it: comment out the hard-coded `if` block, then uncomment the `/* Option B */` section.  
The `Logins` table already has a seeded `Admin` / `Skills@123` row from the SQL script.

> ⚠️ **Production note:** Passwords in the `Logins` table are stored as plain text for simplicity.  
> In a real application, always hash passwords (e.g., BCrypt) before storing them.

---

## Troubleshooting

| Problem | Solution |
|---|---|
| `Unknown database 'Student'` | Run `CreateDatabase.sql` in MySQL first |
| `Unable to connect to any of the specified MySQL hosts` | Ensure your MySQL server (e.g., Apache/MySQL in XAMPP) is running |
| `Access denied for user 'root'@'localhost'` | Check your `Uid` and `Pwd` in `App.config` |
| Build error (missing MySql.Data) | Go to NuGet Package Manager and install `MySql.Data` |
