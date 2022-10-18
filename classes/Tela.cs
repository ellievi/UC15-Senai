namespace UC_15_SENAI.cl{
    
    public static class Tela{

        public static void LoadingScreen(string text){
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write($"{text}");
            for (int i = 0; i < 8; i++){
                Console.Write($"-");
                Thread.Sleep(200);
            }
            Console.ResetColor();
            Console.Clear();

        }
    }
}