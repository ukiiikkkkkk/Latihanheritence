using System.Reflection.Emit;
Siswa siswaObj = new Siswa("Kolip", "Kolip@gmail.com", "Kolip123", "Siswa", "X DKV 1");
Guru guruObj = new Guru("Pak Budi", "Budi01@gmail,com", "Budi123", "Guru", "Matematika");

siswaObj.TampilkanInfo();
siswaObj.SubmitTugas();

Console.WriteLine();

guruObj.TampilkanInfo();
guruObj.NilaiTugas();

public class user
{
    public string nama;
    public string email;
    public string password;
    public string role;

    public user(string nama, string email, string password, string role)
    {
        this.nama = nama;
        this.email = email;
        this.password = password;
        this.role = role;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama: {nama} |  Role : {role}");
    }
}
class Siswa : user
{

    public string className;

    public Siswa(string nama, string email, string password, string role, string classname) : base(nama, email, password, role)
    {
        classname = classname;
    }

    public void SubmitTugas(string nama, string className)
    {
        Console.WriteLine($"{nama} dari kelas {className} sudah mengumpulkan tugas");
    }

}

class Guru : user
{
    public string mapel;

    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        mapel = mapel;
    }

    public void NilaiTugas()
    {
        Console.WriteLine($"Guru {nama} telah manilai semua tugas {mapel}");
    }
}