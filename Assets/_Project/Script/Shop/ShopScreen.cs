using Assets._Project.Script.Shop;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopScreen : BaseScreen
{
    [SerializeField] ButtonExit _backButton;
    [SerializeField] MainMenu mainMenu;

   
    private ShopLogic shop;



    [SerializeField] private ShopItem _shopItemPrefab;
    [SerializeField] private ItemData _icon;
    [SerializeField] private RectTransform _layout;

  

    public override void StartScreen()
    {
        base.StartScreen();

        shop = new ShopLogic()
        {
            scriptObj = _icon
        };

        shop.InitShop(_shopItemPrefab, _layout);
              
         _backButton.AddListener(BackToMenu);

    }

    public void BackToMenu()
    {
        CloseScreen();
        mainMenu.StartScreen();
    }

    
}
