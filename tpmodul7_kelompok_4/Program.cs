using static DataMahasiswa103022330111;
using static KuliahMahasiswa103022330111;
class Program
{
    public static void Main(string[] args)
    {
        var data = new DataMahasiswa103022330111();
        data.ReadJSON();
        KuliahMahasiswa103022330111 kuliah = new KuliahMahasiswa103022330111();
        kuliah.readJSON();
    }
}