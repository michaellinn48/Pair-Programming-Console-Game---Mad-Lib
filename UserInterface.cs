using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgrammingProject
{
    public class UserInterface
    {


        PartsOfSpeechLists inputRepo = new PartsOfSpeechLists();

        public void WelcomeUser ()
        {
            Console.WriteLine("Welcome to our mad lib.\nPress any key to start. Or don't. Doesn't make no nevermind to me.");
            Console.ReadKey();
            Console.Clear();
        }

        public void CollectUserInput()
        {
            string[] InputPlaceholders = { "name", "name", "name", "place", "place", "place", "place", "animal", "animal", "verb", "verb", "verb", "verb", "verb", "adjective", "adjective", "adjective", "adjective", "adverb", "adverb", "adverb", "adverb", "adverb", "adverb", "interjection", "interjection" };

            foreach (string requiredInput in InputPlaceholders)
            {
                switch (requiredInput)
                {
                    case "name":
                        Console.WriteLine("Enter a name: ");
                        string name = Console.ReadLine();
                        inputRepo.AddToNameList(name);
                        break;
                    case "place":
                        Console.WriteLine("Enter a place: ");
                        string place = Console.ReadLine();
                        inputRepo.AddToPlaceList(place);
                        break;
                    case "animal":
                        Console.WriteLine("Enter an animal: ");
                        string animal = Console.ReadLine();
                        inputRepo.AddToAnimalList(animal);
                        break;
                    case "verb":
                        Console.WriteLine("Enter a past-tense verb: ");
                        string verb = Console.ReadLine();
                        inputRepo.AddToVerbList(verb);
                        break;
                    case "adjective":
                        Console.WriteLine("Enter an adjective: ");
                        string adjective = Console.ReadLine();
                        inputRepo.AddToAdjectiveList(adjective);
                        break;
                    case "adverb":
                        Console.WriteLine("Enter an adverb: ");
                        string adverb = Console.ReadLine();
                        inputRepo.AddToAdverbList(adverb);
                        break;
                    case "interjection":
                        Console.WriteLine("Enter an interjection (example: 'Wow!', 'Eureka!'): ");
                        string interjection = Console.ReadLine();
                        inputRepo.AddToInterjectionList(interjection);
                        break;

                }

            }

        }

        public void DisplayMadlib()
        {
            // Name Variables
            string nameInputOne = inputRepo.GetNameByIndex(0);
            string nameInputTwo = inputRepo.GetNameByIndex(1);
            string nameInputThree = inputRepo.GetNameByIndex(2);

            // Place Variables
            string placeInputOne = inputRepo.GetPlaceByIndex(0);
            string placeInputTwo = inputRepo.GetPlaceByIndex(1);
            string placeInputThree = inputRepo.GetPlaceByIndex(2);
            string placeInputFour = inputRepo.GetPlaceByIndex(3);

            // Animal Variables
            string animalInputOne = inputRepo.GetAnimalByIndex(0);
            string animalInputTwo = inputRepo.GetAnimalByIndex(1);

            // Verb Variables
            string verbInputOne = inputRepo.GetVerbByIndex(0);
            string verbInputTwo = inputRepo.GetVerbByIndex(1);
            string verbInputThree = inputRepo.GetVerbByIndex(2);
            string verbInputFour = inputRepo.GetVerbByIndex(3);
            string verbInputFive = inputRepo.GetVerbByIndex(4);
            
            // Adjective Variables
            string adjectiveInputOne = inputRepo.GetAdjectiveByIndex(0);
            string adjectiveInputTwo = inputRepo.GetAdjectiveByIndex(1);
            string adjectiveInputThree = inputRepo.GetAdjectiveByIndex(2);
            string adjectiveInputFour = inputRepo.GetAdjectiveByIndex(3);

            // Adverb Variables
            string adverbInputOne = inputRepo.GetAdverbByIndex(0);
            string adverbInputTwo = inputRepo.GetAdverbByIndex(1);
            string adverbInputThree = inputRepo.GetAdverbByIndex(2);
            string adverbInputFour = inputRepo.GetAdverbByIndex(3);
            string adverbInputFive = inputRepo.GetAdverbByIndex(4);
            string adverbInputSix = inputRepo.GetAdverbByIndex(5);

            // Interjection Variables
            string interjectionInputOne = inputRepo.GetInterjectionByIndex(0);
            string interjectionInputTwo = inputRepo.GetInterjectionByIndex(1);


            Console.WriteLine(
            
                $"On a {adjectiveInputOne} and {adjectiveInputTwo} October afternoon in {placeInputOne}, {nameInputOne} and {nameInputTwo} decided to go for a walk through the local {placeInputTwo}. Upon beginning the walk, they noticed a {adjectiveInputThree} {animalInputOne}. '{interjectionInputOne}!', {nameInputTwo} shouted as the {animalInputOne} {verbInputOne} towards them. To their surprise, the {animalInputOne} approached and {adverbInputOne} said, 'Hello {nameInputOne} and {nameInputTwo}, how are you on this {adjectiveInputFour} day?' Not knowing how to react, {nameInputTwo} replied, 'Not bad, my car's in the shop but I can't complain.' {nameInputOne}, realizing there was a more pertinent question at hand, asked the {animalInputOne}, 'How in the holy heck can you speak?' Suddenly, a {animalInputTwo} {verbInputTwo} up into their space. 'How in the heck can YOU speak?' the {animalInputTwo} replied. 'I don't know where y'all fellers are from,' {nameInputTwo} {adverbInputTwo} said, 'but here in {placeInputOne}, {animalInputOne}s and {animalInputTwo}s can't talk. And that's just fact, Jack.' The {animalInputOne} and {animalInputTwo} looked at one another and then the {animalInputTwo} {adverbInputThree} said, 'Well the two of us just met, but I just got here from Boston to visit family.' The {animalInputOne} then added, 'I come from {placeInputThree}, but our humans don't say nothin' my dude.' '{interjectionInputTwo}!', {nameInputOne} thought, 'these two are total chillers.' {nameInputTwo}, on the other hand, was downright offended by the way the {animalInputOne} and {animalInputTwo} {adverbInputFour} spoke to them. 'Where do you get off?' they asked, 'Coming to the {placeInputTwo} in {placeInputOne}, where my home is. Where my family lives. Acting like you own the place?' Taken aback by the sheer rudeness, {nameInputOne} promptly grabbed {nameInputTwo} and said, 'C'mon now bub, they ain't hurtin' nobody.' The {animalInputTwo} then replied, 'I can sense when I am not welcome, so allow me to {adverbInputFive} exit this situation. Good day.' The {animalInputTwo} then tipped their cowboy hat and {verbInputThree} off into the horizon. 'What about you, son?', {nameInputTwo} asked, 'you got any sense?' The {animalInputOne} then looked at {nameInputOne}, and as they gazed {adverbInputSix} into each other's eyes, they both knew what needed to happen next. 'Get lost, {nameInputTwo},' {nameInputOne} said, 'you're totally harshing our mellow, fool.' Feeling defeated, {nameInputTwo} then slowly {verbInputFour} away. 'My name is {nameInputThree},' the {animalInputOne} said, 'you down for some iced creams, homes?' With a big smile, {nameInputOne} said, 'You just read my mind, dog. Let's hit it up.' The two of them then {verbInputFive} to the {placeInputFour} for some killer ice cream and lived happily ever after."
                        
            );
        }

    }
}