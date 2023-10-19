using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Graphic
{
    public static class AsciiArt
    {
        private static string gameName = "  ____                                    \r\n |  _ \\                                   \r\n | |_) | ___  ___ _ __   _ __ _   _ _ __  \r\n |  _ < / _ \\/ _ \\ '__| | '__| | | | '_ \\ \r\n | |_) |  __/  __/ |    | |  | |_| | | | |\r\n |____/ \\___|\\___|_|    |_|   \\__,_|_| |_|\r\n                                          \r\n                                          ";

        private static string playerStats = "   _____ _        _       \r\n  / ____| |      | |      \r\n | (___ | |_ __ _| |_ ___ \r\n  \\___ \\| __/ _` | __/ __|\r\n  ____) | || (_| | |_\\__ \\\r\n |_____/ \\__\\__,_|\\__|___/\r\n                          \r\n                          ";

        private static string playerLose = "  _    _   _                                          _     \r\n | |  | | | |                                        | |    \r\n | |  | | | | ___   ___  ___  ___   _ __   ___   ___ | |__  \r\n | |  | | | |/ _ \\ / _ \\/ __|/ _ \\ | '_ \\ / _ \\ / _ \\| '_ \\ \r\n | |__| | | | (_) | (_) \\__ \\  __/ | | | | (_) | (_) | |_) |\r\n  \\____/  |_|\\___/ \\___/|___/\\___| |_| |_|\\___/ \\___/|_.__/ \r\n                                                            \r\n                                                            ";

        private static string playerInventory = "  _____                      _                   \r\n |_   _|                    | |                  \r\n   | |  _ ____   _____ _ __ | |_ ___  _ __ _   _ \r\n   | | | '_ \\ \\ / / _ \\ '_ \\| __/ _ \\| '__| | | |\r\n  _| |_| | | \\ V /  __/ | | | || (_) | |  | |_| |\r\n |_____|_| |_|\\_/ \\___|_| |_|\\__\\___/|_|   \\__, |\r\n                                            __/ |\r\n                                           |___/ ";

        private static string playerStatIncrease = "   _____ _        _         _                                    \r\n  / ____| |      | |       (_)                                   \r\n | (___ | |_ __ _| |_ ___   _ _ __   ___ _ __ ___  __ _ ___  ___ \r\n  \\___ \\| __/ _` | __/ __| | | '_ \\ / __| '__/ _ \\/ _` / __|/ _ \\\r\n  ____) | || (_| | |_\\__ \\ | | | | | (__| | |  __/ (_| \\__ \\  __/\r\n |_____/ \\__\\__,_|\\__|___/ |_|_| |_|\\___|_|  \\___|\\__,_|___/\\___|\r\n                                                                 \r\n                                                                 ";

        private static string gameInfo = "  _____        __      \r\n |_   _|      / _|     \r\n   | |  _ __ | |_ ___  \r\n   | | | '_ \\|  _/ _ \\ \r\n  _| |_| | | | || (_) |\r\n |_____|_| |_|_| \\___/ \r\n                       \r\n                       ";

        public static void Ascii_GameInfo()
        {
            Console.WriteLine(gameInfo);
        }

        public static void Ascii_StatIncrease()
        {
            Console.WriteLine(playerStatIncrease);
        }

        public static void Ascii_Inventory()
        {
            Console.WriteLine(playerInventory);
        }

        public static void Ascii_Lose()
        {
            Console.WriteLine(playerLose);
        }

        public static void Ascii_Stats()
        {
            Console.WriteLine(playerStats);
        }

        public static void Ascii_Name() 
        {
            Console.WriteLine(gameName);
        }
    }
}
