using System;
using System.Collections.Generic;

namespace Navegacao {
    public class Browser {
        private Stack<string> backStack;
        private Stack<string> forwardStack;
        private string currentPage;

        public Browser() {
            backStack = new Stack<string>();
            forwardStack = new Stack<string>();
            currentPage = "home"; // página inicial
        }

        public void Access(string url) {
            backStack.Push(currentPage);
            currentPage = url;
            forwardStack.Clear(); // limpa o histórico futuro
        }

        public void Back() {
            if(backStack.Count == 0) {
                Console.WriteLine("Error: Back error");
                return;
            }

            forwardStack.Push(currentPage);
            currentPage = backStack.Pop();
        }

        public void Forward() {
            if(forwardStack.Count == 0) {
                Console.WriteLine("Error: Forward error");
                return;
            }

            backStack.Push(currentPage);
            currentPage = forwardStack.Pop();
        }

        public string GetCurrentPage() {
            return currentPage;
        }
    }
}
