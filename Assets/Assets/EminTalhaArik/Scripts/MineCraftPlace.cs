using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCraftPlace : MonoBehaviour
{
    public float time;
    public GameObject hataMesaji;
    public GameObject createrBar;

    private void FixedUpdate()
    {
        if (!hataMesaji.activeSelf)
        {
            time = Time.time;
        }

        if (time > 20.0)
        {
            hataMesaji.SetActive(true);
            createrBar.SetActive(false);
            
        }
    }
}
