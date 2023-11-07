using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDoJogo : MonoBehaviour
{
    public bool FimDeJogo = false;
    public GameObject player;
    private GerenciadorIU _gerenciadorIU;
    // Start is called before the first frame update
   private void Start()
   {
        _gerenciadorIU = GameObject.Find("Canvas").GetComponent<GerenciadorIU>();
   }

    // Update is called once per frame
    private void Update()
    {
        if (FimDeJogo == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(player, Vector3.zero, Quaternion.identity);
                FimDeJogo = false;
                _gerenciadorIU.EsconderTelaInicial();
            }

        }

    }
}
