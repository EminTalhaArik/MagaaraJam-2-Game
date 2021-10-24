using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public float saniye;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        saniye += Time.deltaTime;

        if (saniye > 17)
        {
            SceneManager.LoadScene("SampleScene");
        }
       
    }

   
}
