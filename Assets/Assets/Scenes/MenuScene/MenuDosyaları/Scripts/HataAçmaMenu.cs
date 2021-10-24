using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HataAçmaMenu : MonoBehaviour
{
    public GameObject Hata;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    IEnumerator WaitBedoreShow()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("çalıştı");
    }
    public void kapatma()
    {
        Hata.SetActive(false);
    }
   
}
