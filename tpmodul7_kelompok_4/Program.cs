using static DataMahasiswa103022330111;
using static KuliahMahasiswa103022330111;
using static DataMahasiswa103022300033;
using static KuliahMahasiswa103022300033;

class Program
{
    public static void Main(string[] args)
    {
        var data1 = new DataMahasiswa103022300033();
        data1.ReadJSON();

        var kuliah1 = new KuliahMahasiswa103022300033();
        kuliah1.ReadJSON();

        var data2 = new DataMahasiswa103022330111();
        data2.ReadJSON();

        var kuliah2 = new KuliahMahasiswa103022330111();
        kuliah2.ReadJSON();
    }
}
