# Lecturer Management System

A Windows Forms application built in C# for managing lecturer information in an academic environment. This system is designed to be used by receptionists and administrators to register, view, and search for lecturers, all stored in a Microsoft Access database.

---

## 📌 Features

- **Login System**  
  Separate login form for:
  - Receptionist
  - Administrator

- **Lecturer Registration**  
  Add new lecturers by entering:
  - Faculty Number *(Primary Key)*
  - Lecturer Number
  - Lecturer Name
  - Module Code
  - Credit Hours
  - Class Size  
  Automatically calculates:
  - **Contact Hours** = `(Class Size / 50) * Credit Hours`

- **Lecturer Lookup**  
  View and search all registered lecturers in the system using various filters.

---

## 🧑‍💻 Technologies Used

| Area             | Technology         |
|------------------|--------------------|
| Frontend / UI    | C# (Windows Forms) |
| Backend / Logic  | C#                 |
| Database         | Microsoft Access   |

---

## 🗃️ Database Schema

**Table:** `Teachers`

| Column Name     | Data Type | Description                         |
|-----------------|-----------|-------------------------------------|
| FacultyNumber   | Text      | Primary Key                         |
| LecturerNumber  | Text      | Unique ID for the lecturer          |
| LecturerName    | Text      | Full name of the lecturer           |
| ModuleCode      | Text      | Subject/Module assigned             |
| CreditHours     | Number    | Module credit hours                 |
| ClassSize       | Number    | Number of students in the class     |
| ContactHours    | Calculated| `(ClassSize / 50) * CreditHours`   |

---

## 🚀 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Lecturer-Management-System.git
