# BulkyWeb 📚

BulkyWeb is a simple and intuitive online bookstore built using ASP.NET Core. It allows users to manage products (books) and categories. The project provides features for adding, updating, and deleting books and categories. 

## Features 🚀

- **Add, Update, Delete Books (Products)**: Admin can manage the bookstore's inventory by adding new books, updating existing ones, or removing them.
- **Add, Update, Delete Categories**: Categories can be managed separately to better organize the bookstore's inventory.
- **Responsive Design**: The UI is styled with Bootstrap for a modern and responsive design.
  
## Technologies Used 👨‍💻

- **ASP.NET Core**: For building the web application. 
- **Entity Framework Core**: For interacting with the MySQL database.
- **MySQL**: Database used to store products (books) and categories.
- **Bootstrap**: For responsive UI design.
- **jQuery & DataTables**: For handling dynamic table functionality (product listing).
- **TinyMCE**: Rich text editor used for book descriptions.
- **SweetAlert**: Used for user-friendly confirmation modals and alerts for actions like deleting a book or category.
- **Toastr Notifications**: Non-intrusive toast notifications for actions like successful book additions or updates.

## Prerequisites ⚡

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- [MySQL](https://www.mysql.com/) (version 8.0 or higher)
- [Visual Studio or any C# supported IDE](https://code.visualstudio.com/)

## Setup Instructions 💻

1. **Clone the repository:**

   ```bash
   git clone https://github.com/bikash-789/BulkyWeb.git

2. **Update the Connection string:**
    ```bash
    "ConnectionStrings": {
      "DefaultConnection": "server=localhost;user=root;password=yourpassword;database=bulkydb;"
    }

3. **Run Migrations:**
    ```bash
    dotnet ef database update

4. **Restore dependencies:**
    ```bash
      dotnet restore
    
5. **Run the application:**
    ```bash
      dotnet run

**Here are some snapshots of the project:**
<img width="1792" alt="image" src="https://github.com/user-attachments/assets/f1d7866e-b323-4b32-a6e2-94db2d86790a">
<img width="1792" alt="image" src="https://github.com/user-attachments/assets/94b14964-916b-4119-b1f8-51ae62753825">
<img width="1792" alt="image" src="https://github.com/user-attachments/assets/748178a1-c749-46bb-bd34-5ae9412ea09d">
<img width="1792" alt="image" src="https://github.com/user-attachments/assets/0581db7f-8a36-4a6f-8031-ff0f9cdd31ac">
<img width="1792" alt="image" src="https://github.com/user-attachments/assets/eba8d278-6b9d-4828-b435-00ed55f1b394">
<img width="1792" alt="Screenshot 2024-08-28 at 03 29 26" src="https://github.com/user-attachments/assets/43102512-7b0f-499e-9d82-6a08ff555e5a">
<img width="1792" alt="image" src="https://github.com/user-attachments/assets/e9671133-7a83-40ef-9e88-19f5efc7d6c4">
<img width="1792" alt="Screenshot 2024-08-28 at 03 31 53" src="https://github.com/user-attachments/assets/2fc82d9f-c80a-48f5-8ff1-0b069f7f98dc">
<img width="1792" alt="image" src="https://github.com/user-attachments/assets/e61527bd-699a-4fe8-b2d9-5f8ea99a2d55">
