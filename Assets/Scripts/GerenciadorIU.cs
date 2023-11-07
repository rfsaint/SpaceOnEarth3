using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorIU : MonoBehaviour
{
    public GameObject tituloDaTela;
    public Sprite[] vidas;
    public Image mostrarImagemDasVidas;
    public int placar;
    public Text textoPlacar;
    public GameObject _boss;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtualizaVidas (int vidasAtuais) 
    {
        mostrarImagemDasVidas.sprite = vidas[vidasAtuais];
    }

    public void AtualizaPlacar ()
    {
        placar += 100;
        textoPlacar.text = "PLACAR: " + placar;
    }

    public void MostrarTelaInicial()
    {
        tituloDaTela.SetActive(true);
    }

    public void EsconderTelaInicial()
    {
        tituloDaTela.SetActive(false);
    }
}
