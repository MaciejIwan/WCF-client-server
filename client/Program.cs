using System;
using System.Text.RegularExpressions;
using client.ServiceBookReference;
using Dto;
using static System.Net.Mime.MediaTypeNames;

namespace client
{
    enum Command
    {
        exit,
        details,
        list,
        invalid,
        help
    }
    struct UserInput
    {
        public Command Command { get; set; }
        public string Argument { get; set; }
    }

    internal class Program
    {
        ServiceBookClient client;

        Program()
        {
            client = new ServiceBookClient();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Console.WriteLine("The book fetcher 2023. Use \"help\" command for details");
            while (true)
            {
                try
                {
                    UserInput input = GetUserInput();
                    HandleCommand(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid argument");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Book not found");
                }
                catch
                {
                    Console.WriteLine("Unkown error");
                }
            }
        }
        private UserInput GetUserInput()
        {
            Console.Write("Enter command: ");
            string userInput = Console.ReadLine();

            var input = new UserInput { Command = Command.invalid, Argument = string.Empty };
            string pattern = @"^(?<command>\w+)(?:\s+(?<argument>.*))?$";
            Match match = Regex.Match(userInput, pattern);
            if (match.Success)
            {
                string commandString = match.Groups["command"].Value;
                Command command;

                if (Enum.TryParse(commandString, true, out command) && Enum.IsDefined(typeof(Command), command))
                {
                    input.Command = command;

                    string argument = match.Groups["argument"].Value.Trim();
                    input.Argument = argument;
                }
            }

            return input;
        }
        private void HandleCommand(UserInput input)
        {

            switch (input.Command)
            {
                case Command.exit:
                    System.Environment.Exit(0);
                    break;
                case Command.details:
                    ExecGetBookDetails(input.Argument);
                    break;
                case Command.list:
                    ExecGetBookList(input.Argument);
                    break;
                case Command.help:
                    ExecHelp();
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }

        }

        private void ExecHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Available commands:");
            Console.WriteLine("\"exit\" - exit the program");
            Console.WriteLine("\"details <bookId>\" - return details about book with given <bookId>. <bookId> is int");
            Console.WriteLine("\"list <phrase>\" - fetch list of books ids that contain given pgrase in title. <phrase> is string");
            Console.WriteLine("\"help\" - show informations");
            Console.WriteLine();
            Console.WriteLine();
        }

        private void ExecGetBookList(string phrase)
        {
            var ids = client.GetAllBooksIdsByPhrase(phrase);
            Console.WriteLine("Books ids:");
            foreach (var id in ids)
            {
                Console.WriteLine(id);
            }
            Console.WriteLine();
        }

        private void ExecGetBookDetails(string argument)
        {
            var book = client.GetBookById(argument);
            Console.WriteLine(book);
        }
    }
}
