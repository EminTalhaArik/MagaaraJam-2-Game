using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewObject : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<ObjectCreater>().waitSpawnable = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<ObjectCreater>().waitSpawnable = false;
    }
}
