using System;
class programinput
{
    static void Main (string[] args)
    {
        Console.WriteLine("==========DATA PSERTA DIDIK SMK NEGERI 1 LUBUK SIKAPING==========");
        Console.Write("Tuliskan Nama Kamu :");
        string nama = Console.ReadLine();
        Console.Write("Tuliskan Alamat Kamu :");
        string alamat = Console.ReadLine();
        Console.WriteLine("Tuliskan Kelas Kamu");
        string kelas = Console.ReadLine();
        Console.Write("Tuliskan Jurusan Kamu :");
        string jurusan = Console.ReadLine();
        Console.Write("Tuliskan Agama Kamu :");
        string agama = Console.ReadLine();
        Console.WriteLine("Tuliskan Hobby Kamu");
        string hobby = Console.ReadLine();
        Console.Write("Tuliskan cita-cita Kamu :");
        string cita_cita = Console.ReadLine();
        Console.Write("Tuliskan Anak ke Berapa Kamu :");
        string anak_ke = Console.ReadLine();

        Console.WriteLine("==========DATA ORANG TUA PESERTA DIDIK SMK NEGERI 1 LUBUK SIKAPING==========");
        Console.Write("Tuliskan Nama Ayah Kamu :");
        string n_a = Console.ReadLine();
        Console.Write("Tuliskan Nama Ibu Kamu :");
        string n_i = Console.ReadLine();
        Console.WriteLine("Tuliskan Pekerjaan Ortu Kamu");
        string pekerjaan_ortu = Console.ReadLine();
        Console.Write("Tuliskan No.Hp Kamu :");
        string no_hp = Console.ReadLine();
        Console.Write("Tuliskan Alamat Ortu Kamu :");
        string alamat_ortu = Console.ReadLine();
        Console.WriteLine("Tuliskan Status Anak Kamu");
        string SA = Console.ReadLine();
        Console.WriteLine("==========DATA PSERTA DIDIK SMK NEGERI 1 LUBUK SIKAPING==========");
        Console.WriteLine("Nama Lengkap : {0} ", nama);
        Console.WriteLine("Alamat       : {0} ", alamat);
        Console.WriteLine("Kelas        : {0} ", kelas);
        Console.WriteLine("Jurusan      : {0} ", jurusan);
        Console.WriteLine("Agama        : {0} ", agama);
        Console.WriteLine("Hobby        : {0} ", hobby);
        Console.WriteLine("Cita-Cita    : {0} ", cita_cita);
        Console.WriteLine("Anak ke      : {0} ", anak_ke);
        Console.WriteLine("====================");

        Console.WriteLine(" ==========DATA ORANG TUA PESERTA DIDIK SMK NEGERI 1 LUBUK SIKAPING==========");
        Console.WriteLine("Nama Ayah        : {0} ", n_a);
        Console.WriteLine("Nama Ibu         : {0} ", n_i);
        Console.WriteLine("Pekerjaan        : {0} ", pekerjaan_ortu);
        Console.WriteLine("No.Hp            : {0} ", no_hp);
        Console.WriteLine("Alamat           : {0} ", alamat_ortu);
        Console.WriteLine("Status anak      : {0} ", SA);
        Console.WriteLine("====================");
    }

}