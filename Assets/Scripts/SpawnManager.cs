using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _bossIdle;
    [SerializeField]
    private GameObject _inimigoPrefab;
    [SerializeField]
    private GameObject [] _powerUps;
    public GameObject _tituloDaTela;
    public bool Ativar = false;
    public bool _fimDeJogo = false;
    // Start is called before the first frame update
    void Start()
    {
        _tituloDaTela.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !Ativar)
        {
            _tituloDaTela.SetActive(false);
            Debug.Log("Ativar Gerenciador de objetos.");
            StartCoroutine(TimerButton());
        }
    }
    public IEnumerator TimerButton ()
    {
        Ativar = true;
        StartCoroutine(RotinaGeracaoInimigo());
        StartCoroutine(RotinaGeracaoPU());
        yield return new WaitForSeconds(1.50f);
    }

    public IEnumerator RotinaGeracaoInimigo(){

       while (true) 

        {

            Instantiate(_inimigoPrefab, new Vector3(-9.28f, Random.Range(5.3f, -5.3f), 0), Quaternion.identity);
            yield return new WaitForSeconds(6.0f);

        }
    }

    public IEnumerator RotinaGeracaoPU()
    {
        while (true)
        {
            int PowerUpsAleatorio  = Random.Range(0, 2);

            Instantiate((_powerUps[PowerUpsAleatorio]), new Vector3(-9.28f, Random.Range(5.3f, -5.3f), 0), Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(7, 2));
        }
    }
}
