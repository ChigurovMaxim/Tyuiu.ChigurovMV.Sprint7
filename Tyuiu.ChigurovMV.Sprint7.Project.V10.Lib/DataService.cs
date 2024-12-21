namespace Tyuiu.ChigurovMV.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            int rows = File.ReadLines(path).Count();
            string[] strings = File.ReadAllText(path).Split("\n");
            int columns = strings[0].Split(';').Length;
            string[,] matrix = new string[rows, columns];

            using (StreamReader stream = new StreamReader(path))
            {
                string line;
                int count = 0;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] row = line.Split(';');
                    for (int i = 0; i < columns; i++)
                    {
                        matrix[count, i] = row[i];
                    }
                    count++;
                }
            }
            return matrix;
        }
    }
}
