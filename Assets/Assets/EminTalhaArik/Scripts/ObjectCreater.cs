using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreater : MonoBehaviour
{
    public int selectedObjectID;
    public List<CreateObject> objects;
    private bool isSpawnable = false;
    private GameObject spawnedPreview;
    public bool waitSpawnable = false;
    public Color positiveColor;
    public Color negativeColor;

    private void Start()
    {
        selectedObjectID = 999;
    }

    private void FixedUpdate()
    {
        ShowPreview();
        if(isSpawnable){
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawnedPreview.transform.position = pos;
        }

        if (!waitSpawnable && isSpawnable)
        {
            spawnedPreview.gameObject.GetComponent<SpriteRenderer>().color = positiveColor;
        }
        else if(waitSpawnable && isSpawnable)
        {
            spawnedPreview.gameObject.GetComponent<SpriteRenderer>().color = negativeColor;
        }
    }

    private void Update()
    {
        Spawn();
    }

    public void ShowPreview()
    {
        if(selectedObjectID != 999 && !isSpawnable)
        {
            spawnedPreview = Instantiate(objects[selectedObjectID].objectPreviewPrefab);
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawnedPreview.transform.position = pos;
            isSpawnable = true;
            
        }
    }   

    public void Spawn()
    {
        if (isSpawnable && Input.GetKeyDown(KeyCode.F) && !waitSpawnable)
        {
            isSpawnable = false;
            Vector2 spawnPosition = spawnedPreview.transform.position;
            Destroy(spawnedPreview);
            GameObject spawnedObject = Instantiate(objects[selectedObjectID].objectPrefab);
            spawnedObject.transform.position = spawnPosition;
            selectedObjectID = 999;
        }
    }
}

