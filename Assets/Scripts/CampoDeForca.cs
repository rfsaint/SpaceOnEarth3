using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampoDeForca : MonoBehaviour
{
    public GameObject explosaoPrefab; // Prefab da explos�o
    public int vidasEscudo = 3; // N�mero inicial de vidas do escudo
    public GameObject _campoDeForca;

    void Start ()
    {
        _campoDeForca.SetActive(false);
    }

    void Update ()
    {
        if ( Input.GetKeyDown(KeyCode.C))
        {
            _campoDeForca.SetActive(true);
            vidasEscudo += 1;
            if ( vidasEscudo >= 25)
            {
                vidasEscudo = 25;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo"))
        {
            // Colis�o com o inimigo
            ReduzirVidaEscudo();

            // Exibir explos�o
            ExibirExplosao();

            // Opcional: Destruir o inimigo
            Destroy(other.gameObject);
        }
    }


    private void ReduzirVidaEscudo()
    {
        vidasEscudo--;

        if (vidasEscudo == 0)
        {
            // L�gica para o escudo quando todas as vidas s�o perdidas
            Debug.Log("O escudo foi destru�do!");
            Destroy(gameObject); // Ou desative o escudo, dependendo da sua l�gica
        }
    }

    private void ExibirExplosao()
    {
        if (explosaoPrefab != null)
        {
            // Instanciar a explos�o
            Instantiate(explosaoPrefab, transform.position, Quaternion.identity);
        }
    }
}
