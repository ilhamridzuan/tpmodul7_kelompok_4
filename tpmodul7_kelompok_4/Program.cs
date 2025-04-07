class Program
{
    public static void Main(string[] args)
    {
        var data = new DataMahasiswa103022300033();
        data.ReadJSON();

        KuliahMahasiswa103022300033 kuliah = new KuliahMahasiswa103022300033();
        kuliah.readJSON();
    }
}