using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgrammingProject
{
    public class PartsOfSpeechLists
    {
        private readonly List<string> nameList = new List<string>();
        private readonly List<string> placeList = new List<string>();
        private readonly List<string> animalList = new List<string>();
        private readonly List<string> verbList = new List<string>();
        private readonly List<string> adjectiveList = new List<string>();
        private readonly List<string> adverbList = new List<string>();
        private readonly List<string> interjectionList = new List<string>();

        
        // BEGIN ADD METHODS
        public bool AddToNameList (string name)
        {
            int startingCount = nameList.Count;
            nameList.Add(name);
            return nameList.Count > startingCount;
        }

        public bool AddToPlaceList (string place)
        {
            int startingCount = placeList.Count;
            placeList.Add(place);
            return placeList.Count > startingCount;
        }

        public bool AddToAnimalList (string animal)
        {
            int startingCount = animalList.Count;
            animalList.Add(animal);
            return animalList.Count > startingCount;
        }

        public bool AddToVerbList (string verb)
        {
            int startingCount = verbList.Count;
            verbList.Add(verb);
            return verbList.Count > startingCount;
        }

        public bool AddToAdjectiveList (string adjective)
        {
            int startingCount = adjectiveList.Count;
            adjectiveList.Add(adjective);
            return adjectiveList.Count > startingCount;
        }

        public bool AddToAdverbList(string adverb)
        {
            int startingCount = adverbList.Count;
            adverbList.Add(adverb);
            return adverbList.Count > startingCount;
        }

        public bool AddToInterjectionList(string interjection)
        {
            int startingCount = interjectionList.Count;
            interjectionList.Add(interjection);
            return interjectionList.Count > startingCount;
        }        

        // END ADD METHODS


        /* BEGIN GET METHODS */
       
        public string GetNameByIndex(int i)
        {
            return nameList[i];
        }
        public string GetPlaceByIndex(int i)
        {
            return placeList[i];
        }
        public string GetAnimalByIndex(int i)
        {
            return animalList[i];
        }
        public string GetVerbByIndex(int i)
        {
            return verbList[i];
        }
        public string GetAdjectiveByIndex(int i)
        {
            return adjectiveList[i];
        }
        public string GetAdverbByIndex(int i)
        {
            return adverbList[i];
        }
        public string GetInterjectionByIndex(int i)
        {
            return interjectionList[i];
        }

        /* END GET METHODS */

    }
}