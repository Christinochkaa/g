class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\file\\filePath.txt";
        try
        {
            string text = File.ReadAllText(filePath);

            int totalCharacters = text.Length;
            int charactersWithoutSpaces = text.Replace(" ", "").Length;
            int wordCount = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

            string result = $"Количество символов в тексте: {totalCharacters}\n" +
                            $"Количество символов в тексте без пробелов: {charactersWithoutSpaces}\n" +
                            $"Количество слов: {wordCount}";

            Console.WriteLine(result);

            string outputFilePath = "C:\\file\\fileP.txt";
            File.WriteAllText(outputFilePath, result);
            Console.WriteLine($"Статистика записана в файл: {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}