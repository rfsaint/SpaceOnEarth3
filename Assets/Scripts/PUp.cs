using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUp : MonoBehaviour
{
    [SerializeField]
    private float Velocidade = 3.5f;
    public int PUpID = 0;
    public int _vidaParaAdicionar = 1;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Velocidade += 0.001f;
        isPaused = !isPaused;
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = isPaused ? 1 : 0;
        }

        transform.Translate(Vector3.left * Velocidade * Time.deltaTime);
        if (transform.position.x < -9.3f)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Fui Pego no flagra");
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                if (PUpID == 0)
                {
                    player.LigarPUDisparoTriplo();
                }
                else if (PUpID == 1)
                {
                    player.VidasExtras(_vidaParaAdicionar);
                }
            }
            Destroy(this.gameObject);
        }

    }

}