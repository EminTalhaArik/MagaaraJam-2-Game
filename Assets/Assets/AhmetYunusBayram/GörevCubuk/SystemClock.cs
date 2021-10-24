using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemClock : MonoBehaviour
{
    public int saat;
    public int dakika;
    public int saniye;

    public Text SaatText;

    // Update is called once per frame
    void Update()
    {
        saat = System.DateTime.Now.Hour;
        dakika = System.DateTime.Now.Minute;
        saniye = System.DateTime.Now.Second;

        SaatText.text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString();
    }
}
