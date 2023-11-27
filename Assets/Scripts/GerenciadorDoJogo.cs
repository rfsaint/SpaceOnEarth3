using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorDoJogo : MonoBehaviour
{
   public bool fimDeJogo;
   public GameObject Player;
   private GerenciadorIU gerenciadorIU;
   public SpawnManager SpawnManager;

    // Start is called before the first frame update
   private void Start()
   {
        gerenciadorIU = GameObject.Find("Canvas").GetComponent<GerenciadorIU>();
        fimDeJogo = true;

    }

    // Update is called once per frame
    private void Update()
    {
        if (fimDeJogo == true)
        {
             if (Input.GetKeyDown(KeyCode.Return))
             {
                fimDeJogo = false;
                Instantiate(Player, Vector3.zero, Quaternion.identity);
                gerenciadorIU.EsconderTelaInicial();
             }
        }
    }
}
