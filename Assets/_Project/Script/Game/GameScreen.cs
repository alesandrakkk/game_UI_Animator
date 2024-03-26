using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScreen : BaseScreen
{
    [SerializeField] ButtonExit _returnMenu;


    public override void CloseScreen()
    {
        base.CloseScreen();
        _returnMenu.AddListener(BackToMenu);
    }

    private void BackToMenu()
    { 
       
      SceneTransition.StartLodingScene("SampleScene");
             
    }

    public void GoToGame()
    {
        Debug.Log("Welcome!");
        SceneTransition.StartLodingScene("Game");
    }
}
