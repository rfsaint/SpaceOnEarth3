using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Player;
    public Player player;
    [SerializeField]
    private GameObject _bossIdle;
    [SerializeField]
    private GameObject _inimigoPrefab;
    [SerializeField]
    private GameObject[] _powerUps;
    public GameObject _tituloDaTela;
    public bool Ativar = false;
    public bool _fimDeJogo = true;
    public int ApetarBotao = 0;
    private GerenciadorIU _iuGerenciador;
    public GerenciadorDoJogo GerenciadorDoJogo;

    // Start is called before the first frame update
    void Start()
    {
        _tituloDaTela.SetActive(true);
        _iuGerenciador = GameObject.Find("Canvas").GetComponent<GerenciadorIU>();
    }

    // Update is called once per frame
    public void Update()
    {

    }

    public IEnumerator RotinaGeracaoInimigo()
    {
            while (GerenciadorDoJogo == false)
            {

                Instantiate(_inimigoPrefab, new Vector3(-9.28f, Random.Range(5.3f, -5.3f), 0), Quaternion.identity);
                yield return new WaitForSeconds(6.0f);

            }
    }

  public IEnumerator RotinaGeracaoPU()
        {
            while (GerenciadorDoJogo == false)
            {
                int PowerUpsAleatorio = Random.Range(0, 2);

                Instantiate((_powerUps[PowerUpsAleatorio]), new Vector3(-9.28f, Random.Range(5.3f, -5.3f), 0), Quaternion.identity);

                yield return new WaitForSeconds(Random.Range(7, 2));
            }
        }

    public void IniciarCoroutines()
    {
        StartCoroutine(RotinaGeracaoInimigo());
        StartCoroutine(RotinaGeracaoPU());

    }
}
