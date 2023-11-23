using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
  private bool isPaused = false;
  public GameObject _telaDePause;

   void Start ()
    {
        _telaDePause.SetActive(false);
    }

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.P))
      {
        TogglePause();
      }
   }

   public void TogglePause()
   {
       isPaused = !isPaused;
       Time.timeScale = isPaused ? 0 : 1; // Pausar o tempo do jogo
        if (Time.timeScale == 0)
        {
            _telaDePause.SetActive(true);
        }
        else if (Time.timeScale == 1)
        {
            _telaDePause.SetActive(false); 
        }
   }
   
}

