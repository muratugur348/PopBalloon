using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    oyunKontrol oyunKontrolScript;
    // Start is called before the first frame update
    private void Start()
    {
        oyunKontrolScript = GameObject.Find("_Scripts").GetComponent<oyunKontrol>();
        
    }
    private void OnMouseDown()
    {

        GameObject go = Instantiate(patlama, transform.position, transform.rotation);
        oyunKontrolScript.BalonEkle();
        Destroy(this.gameObject);
        Destroy(go, 0.5f);
    }
    private void Update()
    {
        if(this.transform.position.y>6)
        {
            Destroy(this.gameObject);
        }
    }
}
