using System;

namespace Navegacao {
    class Program {
        static void Main(string[] args) {
            Browser browser = new Browser();

            // Exemplo: Entrada do PDF (pode ser alterada para testar outros cenários)
            string[] commands = {
                "get-current",
                "access,https://amazon.com",
                "access,https://cnn.com",
                "get-current",
                "back",
                "get-current",
                "back",
                "get-current",
                "back"
            };

            TestNavigation(browser, commands);
        }

        static void TestNavigation(Browser browser, string[] commands) {
            foreach(var command in commands) {
                if(command.StartsWith("access")) {
                    string[] parts = command.Split(',');
                    browser.Access(parts[1]);
                }
                else if(command == "back") {
                    browser.Back();
                }
                else if(command == "forward") {
                    browser.Forward();
                }
                else if(command == "get-current") {
                    Console.WriteLine(browser.GetCurrentPage());
                }
            }
        }
    }
}
