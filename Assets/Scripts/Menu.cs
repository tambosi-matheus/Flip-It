using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu, credits;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        //Change scene to main game
    }


    
}
