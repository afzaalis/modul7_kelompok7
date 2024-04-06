// See https://aka.ms/new-console-template for more information
using modul7_kelompok_8;
using modul7_kelompok7;
class Program
{
    static void Main(string[] args)
    {
        dataMahasiswa_1302220104 mhs = new dataMahasiswa_1302220104();
        mhs.ReadJSON();





        teamMember_1302220104 memberData = new teamMember_1302220104();
        memberData.ReadJSON2();

    }
}
