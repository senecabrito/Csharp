using System.IO;

namespace ContagemVotos
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, int> votesMap = new Dictionary<string, int>();
                string path = @"/home/seneca/Csharp/Generics_Set_Dictionary/ContagemVotos/votos.txt";

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] datas = sr.ReadLine().Split(',');
                        string name = datas[0];
                        int votes = int.Parse(datas[1]);

                        if (votesMap.ContainsKey(name))
                        {
                            votesMap[name] += votes;
                        }
                        else
                        {
                            votesMap[name] = votes;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> item in votesMap)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}