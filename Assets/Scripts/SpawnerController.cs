using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject prefab;

    public float minX, maxX;

    public float startTime;
    private float time;

    public Sprite[] sprites;
    

    
    void Update()
    {
        if (time <= 0)
        {
            SpawnObject();
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    private void SpawnObject()
    {
        GameObject newPrefab = Instantiate(prefab);
        newPrefab.transform.position = new Vector2(
            Random.Range(minX, maxX),
            transform.position.y
            );

        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        newPrefab.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }
}
