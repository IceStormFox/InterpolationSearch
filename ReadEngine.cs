namespace InterpolationSearch
{
    internal class ReadEngine
    {
        public static List<int> Read(string path)
        {
            List<int> dynamicArray = new();
            string reader, line;
            StreamReader dane = new(path);
            while ((line = dane.ReadLine()) != null)
            {
                reader = line;
                dynamicArray.Add(int.Parse(reader));
            }
            return dynamicArray;
        }
    }
}