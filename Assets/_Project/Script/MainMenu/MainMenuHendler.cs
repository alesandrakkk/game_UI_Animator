using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenuHendler : MonoBehaviour
{
    [SerializeField] MainMenu menuScreen;

    [SerializeField] BaseScreen  shopScreen;
    [SerializeField] GameScreen gameScreen;

    void Start()
    {
        menuScreen.StartScreen();

       
        menuScreen.PressShopButton(() =>
        {
            menuScreen.CloseScreen();
            shopScreen.StartScreen();
        });

        menuScreen.PressGameButtom(() =>
        {
            menuScreen.CloseScreen();
            gameScreen.StartScreen();
        });
    }


    public void BackToMenu()
    {

    }
}
