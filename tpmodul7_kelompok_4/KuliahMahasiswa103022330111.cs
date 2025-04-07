﻿using System;
using System.IO;
using System.Text.Json;
class KuliahMahasiswa103022330111
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
        var dataJson = File.ReadAllText("../../../tp7_2_103022330111.json");

        var jadwal = JsonSerializer.Deserialize<Courses>(dataJson, new JsonSerializerOptions { IncludeFields = true });
        Console.WriteLine("Daftar Mata Kuliah");

        for (int i = 0; i < jadwal.courses.Length; i++)
        {
            Console.WriteLine("MK {0} {1} - {2}", i + 1, jadwal.courses[i].code, jadwal.courses[i].name);
        }
    }

    
}