using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunubaslat : MonoBehaviour
{
    // Start is called before the first frame update
    public void oyunuBaslat()
    {
        SceneManager.LoadScene("oyun");   
    }

}
