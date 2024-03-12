using Assets._Project.Script.Button;
using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets._Project.Script.Shop
{
    public class ShopItem : MonoBehaviour
    {
        [SerializeField] private int _price;
        [SerializeField] private TextMeshProUGUI _name;
        public Image image;
       

        public int Price { get => _price; set => _price = value; }
        
        public TextMeshProUGUI Name { get => _name; set => _name = value; }

        public BuyButton buyButton;

        private void Start()
        {
            _price = RandomdataGenerator.GetPrice();
            _name.text = RandomdataGenerator.GetName();
            
        }

        public void PressBuyButton(Action onBuyButtonPressed)
        {
            buyButton.AddListener(() => onBuyButtonPressed?.Invoke());
        }
    }
}