using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class BaseScreen : UIScreen
{
   

    public override void CloseScreen()
    {
        gameObject.SetActive(false);

       
    }

    public override void StartScreen()
    {
        Debug.Log("Base Screen");

        gameObject.SetActive(true);

       
    }

    
}
