using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorDoJogo : MonoBehaviour
{
   public bool fimDeJogo;
   public GameObject Player;
   private GerenciadorIU gerenciadorIU;

    // Start is called before the first frame update
   private void Start()
   {
        gerenciadorIU = GameObject.Find("Canvas").GetComponent<GerenciadorIU>();
        fimDeJogo = true;
         
   }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (fimDeJogo == true)
            {
                fimDeJogo = false;
                Instantiate(Player, Vector3.zero, Quaternion.identity);
                gerenciadorIU.EsconderTelaInicial();
            }
        }
    }
}
