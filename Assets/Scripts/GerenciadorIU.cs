using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorIU : MonoBehaviour
{
    public GameObject tituloDaTela;
    public GameObject _morte;
    public Sprite[] vidas;
    public Image mostrarImagemDasVidas;
    public int placar;
    public Text textoPlacar;
    public GameObject _boss;
    public GameObject[] _objects; 

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

    public void MostrarTelaDeMorte()
    {
        _morte.SetActive(true);
        Time.timeScale = 0;
      
    }

    public void EsconderTelaInicial()
    {
        tituloDaTela.SetActive(false);
        _morte.SetActive(false);
        Time.timeScale = 1;
        placar = 0;
        textoPlacar.text = "PLACAR: 0";
    }
}
