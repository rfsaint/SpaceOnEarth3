using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int PorcentagemDaVida = 100;
    public GameObject _player;
    public Transform jogadorTransform; // Referência ao transform do jogador
    public Transform chefeTransform; // Referência ao transform do chefe
    public float velocidadeMovimento = 5.0f; // Velocidade de movimento do chefe

    void Update()
    {
      
        jogadorTransform = _player.transform;
        
        // Obtenha a posição atual do jogador no eixo Y
        float posicaoJogadorY = jogadorTransform.position.y;
        float posicaoChefeY = chefeTransform.position.y;

        // Mova o chefe em direção à posição do jogador no eixo Y
        float passo = velocidadeMovimento * Time.deltaTime;
        chefeTransform.position = Vector3.MoveTowards(chefeTransform.position, new Vector3(chefeTransform.position.x, posicaoJogadorY, chefeTransform.position.z), passo);
        if (posicaoChefeY > 3.9f) {
            posicaoChefeY = 3.9f;
        } else if (posicaoChefeY < -3.9f) {
            posicaoChefeY = -3.9f;
        }
    }

    public void OnCollisionEnter2D (Collision2D collision)
    {

    }
}
