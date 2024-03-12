using System.Collections;
using UnityEngine;

namespace Assets._Project.Script.Shop
{[CreateAssetMenu(fileName ="ImageData", menuName = "ImageData", order = 51)]
    public class ItemData : ScriptableObject
    {
        public Sprite[] _sprites;

        public Sprite GetSprite()
        {
            Debug.Log ("Got sprite");
            return _sprites[Random.Range(0, _sprites.Length)];
        }
    }

}