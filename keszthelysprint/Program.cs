using System.ComponentModel.DataAnnotations.Schema;

namespace keszthelysprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<versenyzo> versenyzok = new();
            foreach (var sor in File.ReadAllLines("eredmenyek.txt"))
            {
                versenyzok.Add(new versenyzo(sor));
            }
            Console.WriteLine($"A versenyt {versenyzok.Count} versenyzők fejezték be!");
        }
        int elit_junior = 0;
             
       foreach (var v in versenyzők)
	{
     if (v.Kategória == "elit junior")
	{
     elit_junior++;
	}
    
	} 
   
}
