using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampoDeForca : MonoBehaviour
{
    public GameObject explosaoPrefab; // Prefab da explosão
    public int vidasEscudo = 3; // Número inicial de vidas do escudo
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
            // Colisão com o inimigo
            ReduzirVidaEscudo();

            // Exibir explosão
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
            // Lógica para o escudo quando todas as vidas são perdidas
            Debug.Log("O escudo foi destruído!");
            Destroy(gameObject); // Ou desative o escudo, dependendo da sua lógica
        }
    }

    private void ExibirExplosao()
    {
        if (explosaoPrefab != null)
        {
            // Instanciar a explosão
            Instantiate(explosaoPrefab, transform.position, Quaternion.identity);
        }
    }
}
