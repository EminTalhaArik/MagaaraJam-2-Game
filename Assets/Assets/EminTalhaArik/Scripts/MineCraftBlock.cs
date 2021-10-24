using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCraftBlock : MonoBehaviour
{
    private void Start()
    {
        Destroy(this.gameObject, 6);
    }
}
