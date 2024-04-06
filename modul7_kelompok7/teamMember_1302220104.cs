using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_7
{
    internal class teamMember_1302220104
    {
        public List<Members> members { get; set; }
        public class Members
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String gender { get; set; }
            public int age { get; set; }
            public String nim { get; set; }

        }

        public void ReadJSON2()
        {
            string json = File.ReadAllText("D:\\New folder\\modul7_kelompok7\\modul7_kelompok7\\jurnal7_2_1302220104.json");


            var members = JsonSerializer.Deserialize<teamMember_1302220104>(json);

            foreach (var member in members.members)
            {
                Console.WriteLine($"Name: {member.firstName} {member.lastName}" +  $"\n gender: {member.gender} \n nim: {member.nim}");
            }

        }
    }
}
