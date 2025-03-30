string filePath = "GameLibrary.txt";
Console.Write("СКолько игр хотите добавить: ");
int count = int.Parse(Console.ReadLine());
for (int i =0; i < count;i++){
    Console.Write("Введите жанр: ");
    string genre = Console.ReadLine();
    Console.Write("Название игры: ");
    string game = Console.ReadLine();
    Console.Write("Название студии разработи: ");
    string studio = Console.ReadLine();
    string gameInfo = $"Игра  {genre} : {{Название: {game}, Разработчик: {studio}}} ";
    File.AppendAllText(filePath, gameInfo + "\n"); 
}
Console.WriteLine("Игры добавлены в библиотеку");
if (File.Exists(filePath)){
    string[] lines = File.ReadAllLines(filePath); 
    foreach (string line in lines)
    {
    Console.WriteLine(line);
    }
}

