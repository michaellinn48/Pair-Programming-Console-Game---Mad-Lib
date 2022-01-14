using System;

namespace PairProgrammingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface newUser = new UserInterface();

            newUser.WelcomeUser();

            newUser.CollectUserInput();

            newUser.DisplayMadlib();

        }
    }
}
