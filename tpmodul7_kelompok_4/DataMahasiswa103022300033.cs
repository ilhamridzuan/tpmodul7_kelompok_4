using System.Text.Json;
using static DataMahasiswa103022300033;

class DataMahasiswa103022300033
{
    public class Nama
    {
        public String depan;
        public String belakang;
    }
    public class Mahasiswa103022300033
    {
        public Nama nama;
        public long nim;
        public String fakultas;
    }

    public void ReadJSON()
    {
        var dataJson = File.ReadAllText("../../../tp7_1_103022300033.json");

        var mahasiswa = JsonSerializer.Deserialize<Mahasiswa103022300033>(dataJson, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Nama {0} {1} dengan NIM {2} dari fakultas {3} ", mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim, mahasiswa.fakultas);
    }
}