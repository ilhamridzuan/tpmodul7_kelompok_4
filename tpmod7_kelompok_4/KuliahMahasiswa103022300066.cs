using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmod7_kelompok_4
{
    class KuliahMahasiswa103022300066
    {
        public class MataKuliah
        {
            public string code;
            public string name;
        }

        public class Courses
        {
            public MataKuliah[] courses;
        }

        public void readJSON()
        {
            var dataJson = File.ReadAllText("../../../tp7_2_103022300066.json");

            var jadwal = JsonSerializer.Deserialize<Courses>(dataJson, new JsonSerializerOptions { IncludeFields = true });
            Console.WriteLine("Daftar Mata Kuliah");

            for (int i = 0; i < jadwal.courses.Length; i++)
            {
                Console.WriteLine("MK {0} {1} - {2}", i + 1, jadwal.courses[i].code, jadwal.courses[i].name);
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                KuliahMahasiswa103022300066 kuliah = new KuliahMahasiswa103022300066();
                kuliah.readJSON();
            }
        }
    }
}