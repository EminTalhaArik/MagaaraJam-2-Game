using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public void SetSelectedObjectWithID()
    {
        GameObject.FindGameObjectWithTag("GameManager")
            .GetComponent<ObjectCreater>()
            .selectedObjectID = this
            .gameObject
            .GetComponent<CreateObject>()
            .objectID;

        Debug.Log("Selected Object ID Ba�ar�l� Bir �ekilde G�ncellendi!");
    }
}
