using System;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok7
{
    internal class dataMahasiswa_1302220104
    {
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public Course[] courses { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "D:\\New folder\\modul7_kelompok7\\modul7_kelompok7\\jurnal7_1_1302220104.json";
            string jsonText = File.ReadAllText(filePath);

            Mahasiswa dataMahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonText);

            Console.WriteLine($"Nama: {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
            Console.WriteLine($"Gender: {dataMahasiswa.gender}");
            Console.WriteLine($"Age: {dataMahasiswa.age}");
            Console.WriteLine($"Address: {dataMahasiswa.address.streetAddress}\n {dataMahasiswa.address.city}\n {dataMahasiswa.address.state}");
            Console.WriteLine("Courses:");
            foreach (var course in dataMahasiswa.courses)
            {
                Console.WriteLine($"Code: {course.code}, Name: {course.name}");
            }
        }
    }
}