using System.Text;
using System.Windows.Forms;

namespace Tyuiu.ChuginNM.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        public static string[,] GetMatrix(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }

            string[] lines;

            try
            {
                lines = File.ReadAllLines(filePath, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                return null;
            }

            if (lines.Length == 0)
            {
                return new string[0, 0];
            }

            int rowCount = lines.Length;
            int maxColumnCount = 0;

            string[][] tempMatrix = new string[rowCount][];

            for (int i = 0; i < rowCount; i++)
            {
                tempMatrix[i] = ParseCsvLine(lines[i]);

                if (tempMatrix[i].Length > maxColumnCount)
                {
                    maxColumnCount = tempMatrix[i].Length;
                }
            }

            string[,] matrix = new string[rowCount, maxColumnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < maxColumnCount; j++)
                {
                    if (j < tempMatrix[i].Length)
                    {
                        matrix[i, j] = tempMatrix[i][j];
                    }
                    else
                    {
                        matrix[i, j] = "";
                    }
                }
            }

            return matrix;
        }

        public static string[] ParseCsvLine(string line)
        {
            List<string> result = new List<string>();
            StringBuilder current = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    if (i < line.Length - 1 && line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }

            result.Add(current.ToString());

            return result.ToArray();
        }
    }
}
