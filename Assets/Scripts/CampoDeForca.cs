using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampoDeForca : MonoBehaviour
{
    public int lives = 2;
    public bool livesMult = false;
    public GameObject _campoDeForca;
    public GameObject player;
    public GameObject _explosao; 
    // Start is called before the first frame update
    void Start()
    {
        _campoDeForca.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            MultLives();
        }
        else if ( lives >= 24 )
        {
            StartCoroutine(CampoDePoucaForca());
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "CampoDeForca")
        {
            CampoDeForca campoDeForca = other.GetComponent<CampoDeForca>();
            if (campoDeForca == null || campoDeForca == false)
            {

                lives = 0;
                Destroy(this.gameObject);
            }
        }
        else if (other.tag == "CampoDeForca")
        {
            lives--;
            lives -= 1;
        }
    }

    void MultLives()
    {
        _campoDeForca.SetActive(true);
        lives *= 2;
    
        return;
    }

    IEnumerator CampoDePoucaForca ()
    {

        lives -= 1;
        yield return new WaitForSeconds(1.25f);
    }

}
