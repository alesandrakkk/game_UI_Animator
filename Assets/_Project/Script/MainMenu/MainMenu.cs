using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : BaseScreen
{
    [SerializeField] private Button _gameButton, _optionsButton, _shopButton;

   
   

    public override void StartScreen()
    {
        Debug.Log("Menu screen start screen");

        gameObject.SetActive(true);
    }

    

    public void PressShopButton(Action onShopPressed)
    {
        _shopButton.onClick.AddListener(() => onShopPressed?.Invoke());
    }
}
