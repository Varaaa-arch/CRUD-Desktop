# CRUD Application – C# Windows Forms & SQL Server

Project ini adalah aplikasi **CRUD (Create, Read, Update, Delete)** sederhana menggunakan **C# Windows Forms** dan **SQL Server (Local / Express)**.  
Aplikasi ini memungkinkan pengguna untuk menambahkan, mengedit, menghapus, dan menampilkan data siswa dari database.

---

## 🚀 Fitur Aplikasi

✔ **Create** – Tambah data siswa  
✔ **Read** – Tampilkan semua data dari database ke DataGridView  
✔ **Update** – Edit / ubah data yang dipilih  
✔ **Delete** – Hapus data berdasarkan ID  
✔ **Auto-Refresh** setelah CRUD  
✔ **Exit Button** untuk menutup aplikasi  
✔ Terhubung ke database SQL Server dengan `SqlConnection`

---

## 🗂 Struktur Database

Nama Database: **db_smkn1jkt**  
Nama Tabel: **tb_xirpl25**

Kolom yang digunakan:

| Kolom           | Tipe Data      |
|-----------------|----------------|
| id_nomorsiswa   | INT  |
| nama            | VARCHAR        |
| nis             | INT  |
| kelas           | VARCHAR        |
| nowhatsapp      | VARCHAR        |

> Pastikan nama kolom sama persis dengan project agar tidak error.

---

## 🔧 Teknologi yang Digunakan

- **C# .NET Framework**
- **Windows Forms**
- **SQL Server Express**
- **ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)**

---

## ⚙️ Cara Menjalankan Project

1. Clone atau download project.
2. Buka dengan **Visual Studio**.
3. Sesuaikan `connectionString` dengan SQL Server kamu:

    ```csharp
    string connectionString = @"Data Source=DESKTOP-9OQQDC3\SQLEXPRESS;
                                Database=db_smkn1jkt;
                                Integrated Security=True;
                                Encrypt=False";
    ```

4. Jalankan SQL Server dan pastikan tabel tersedia.
5. Tekan **Start / F5** di Visual Studio.
6. Aplikasi siap digunakan.

---

