using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace GameJam.Graphic
{
    public static class Beautifier
    {
        public static void CoolPanel(string panelHeader, string panelText)
        {
            Console.WriteLine("\n");
            var panel = new Panel(panelText);
            panel.Header(panelHeader);
            panel.BorderColor(Color.Red3);
            AnsiConsole.Write(panel);
        }

        public static void CoolLine()
        {
            var rule = new Rule();
            AnsiConsole.Write(rule);
        }

        public static void CoolWrite(string color, string text)
        {
            AnsiConsole.MarkupLine($"[{color}] {text} [/]");
        }

        public static void CoolWrite(string color1, string text1, string color2, string text2)
        {
            AnsiConsole.MarkupLine($"[{color1}] {text1}: [/][{color2}] {text2}[/]");
        }

        public static void CoolBar(int health, int stamina)
        {
            AnsiConsole.Write(new BarChart()
                .Width(60)
                .Label("[green bold underline]Your stats[/]")
                .CenterLabel()
                .AddItem("Health", health, Color.Red)
                .AddItem("Stamina", stamina, Color.Blue));
        }

        public static void CoolCombatBar(int health, int stamina, string EnemyName)
        {
            AnsiConsole.Write(new BarChart()
                .Width(60)
                .Label($"[green bold underline]{EnemyName}[/]")
                .CenterLabel()
                .AddItem("Health", health, Color.Red)
                .AddItem("Stamina", stamina, Color.Blue));
        }


        public static void CoolBarCombat(int health, string name)
        {
            AnsiConsole.Write(new BarChart()
                .Width(60)
                .Label($"[green bold underline]{name}[/]")
                .CenterLabel()
                .AddItem("Health", health, Color.Red));
        }

        public static string CoolMenu(string title, string choice1, string choice2)//Method overload for 2 choices
        {
            CoolLine();
            string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"{title}")
                .PageSize(3)
                .AddChoices(choice1, choice2));
            return playerChoice;
        }

        public static string CoolMenu(string title, string choice1, string choice2, string choice3)//Method overload for 3 choices
        {
            CoolLine();
            string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"{title}")
                .PageSize(4)
                .AddChoices(choice1, choice2, choice3));
            return playerChoice;
        }

        public static string CoolMenu(string title, string choice1, string choice2, string choice3, string choice4)//Method overload for 4 choices
        {
            CoolLine();
            string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"{title}")
                .PageSize(5)
                .AddChoices(choice1, choice2, choice3, choice4));
            return playerChoice;
        }

        public static string CoolMenu(string title, string choice1, string choice2, string choice3, string choice4, string choice5)//Method overload for 4 choices
        {
            CoolLine();
            string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"{title}")
                .PageSize(5)
                .AddChoices(choice1, choice2, choice3, choice4, choice5));
            return playerChoice;
        }

        public static string CoolMenu(string title, string choice1, string choice2, string choice3, string choice4, string choice5, string choice6)//Method overload for 4 choices
        {
            CoolLine();
            string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"{title}")
                .PageSize(5)
                .AddChoices(choice1, choice2, choice3, choice4, choice5, choice5));
            return playerChoice;
        }

        public static void CoolCenterLine(string text, string color)
        {
            var rule = new Rule($"[{color}]{text}[/]");
            rule.Style = Style.Parse("black");

            rule.Centered();

            AnsiConsole.Write(rule);
        }

    }
}
