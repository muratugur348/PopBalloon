using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturma : MonoBehaviour
{
    public GameObject balon;
    public GameObject animasyon;
    float balonOlusturmaSuresi = 0.4f;
    float zamanSayaci = 0f;
    oyunKontrol oyunKontrolScript;
    // Start is called before the first frame update
    void Start()
    {
        oyunKontrolScript = GameObject.Find("_Scripts").GetComponent<oyunKontrol>();
    }

    // Update is called once per frame
    // ArrayList balonlar = new ArrayList();
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if (zamanSayaci < 0 && oyunKontrolScript.zamanSayaci>0)
        {

            Instantiate(balon, new Vector3(Random.Range(-1.5f, 1.5f),
                -6, 0), new Quaternion(0, 0, 0, 0));
            zamanSayaci = balonOlusturmaSuresi;

        }
        if(oyunKontrolScript.zamanSayaci<0)
        { 
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i =0;i<go.Length;i++)
            {
                Instantiate(animasyon, go[i].transform.position, go[i].transform.rotation);

                Destroy(go[i]);
            }
        }

    }
}

