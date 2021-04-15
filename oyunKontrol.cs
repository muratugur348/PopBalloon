using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zaman, skor;
    public float zamanSayaci = 60;
    int patlayanBalon = 0;
    // Start is called before the first frame update
    void Start()
    {
        skor.text = "Balon = " + patlayanBalon;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("anaekran");
        }
        if(zamanSayaci>0)
        zamanSayaci -= Time.deltaTime;
        zaman.text = "Zaman = " + (int)zamanSayaci;
    }
    public void BalonEkle()
    {
        patlayanBalon++;
        skor.text = "Balon = " + patlayanBalon;

    }
}
