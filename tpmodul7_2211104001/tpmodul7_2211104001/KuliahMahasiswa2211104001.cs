using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Jadwal
{
    public string Kode { get; set; }
    public string Nama { get; set; }
}

public class KuliahMahasiswa2211104001
{
    public List<Jadwal> Courses { get; set; }

    public static void ReadJSON()
    {
        string path = @"D:\KPL_Devrin_Anggun_Saputri_2211104001_SE0601\07_Grammar-Based_Input_Processing_Parsing\TP\tpmodul7_2211104001\tp7_2_2211104001.json";
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            var mahasiswa = JsonConvert.DeserializeObject<KuliahMahasiswa2211104001>(jsonData);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int index = 1;
            foreach (var course in mahasiswa.Courses)
            {
                Console.WriteLine($"MK {index} {course.Kode} - {course.Nama}");
                index++;
            }
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan!");
        }
    }
}