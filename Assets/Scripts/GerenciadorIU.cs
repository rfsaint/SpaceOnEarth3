using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorIU : MonoBehaviour
{
    public Sprite[] vidas;
    public Image mostrarImagemDasVidas;
    public int placar;
    public Text textoPlacar;
    public GameObject _boss;
    // Start is called before the first frame update
    void Start()
    {
        _boss.SetActive(false);   
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
        if (placar == 5000)
        {
            _boss.SetActive(true);
        }
        else if (placar == 5500)
        {
             _boss.SetActive(false);
        }
        if (placar == 15000)
        {
            placar = 15000;
        }
        if (placar == 10000)
        {
            _boss.SetActive(true);
        }
        else if (placar < 10000)
        {
            _boss.SetActive(false);
        }
    }
}
