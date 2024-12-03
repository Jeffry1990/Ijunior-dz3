namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalImages = 52;
            int lengthOfImages = 3;
            int columnsOfImages;
            int restOfImages;

            columnsOfImages = totalImages / lengthOfImages;
            restOfImages = totalImages % lengthOfImages;

            Console.WriteLine($"Полностью заполненных рядов можно будет вывести - {columnsOfImages}");
            Console.WriteLine($"Картинок будет сверх меры - {restOfImages}");
    }         
    }
}