using System.Collections;
using UnityEngine;


namespace Assets._Project.Script.Shop
{
    public static class RandomdataGenerator 
    {
        private static string[] names = new string[12] { "arrow", "bone", "book", "bottle", "bow", "hood", "crown", "diamond", "key", "necklace", "ring", "shield" };

        private static string[] subName = new string[11] { "iron", "gold", "silver", "poisonous", "blue", "magic", "standart", "luxury", "boring", "metal", "wood" };

        public static int GetPrice()
        {
            return Random.Range(20, 50);
        }

        public static string GetName()
        {
            return subName[Random.Range(0, names.Length -1)] + " " + names[Random.Range(0, names.Length -1)];
        }
    }

}