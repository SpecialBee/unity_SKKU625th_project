using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public float spawnRate = 2.0f;
    public float itemSpeed = 5.0f;
    public float verticalRange = 2.0f; // 위아래로 이동할 범위
    public float verticalSpeed = 1.0f; // 스폰 지점 이동 속도

    private float nextSpawnTime = 0;
    private bool movingUp = true;

    private void Update()
    {
        // 스폰 지점 위아래로 이동
        float verticalMovement = verticalSpeed * Time.deltaTime;
        if (movingUp)
        {
            transform.Translate(Vector3.up * verticalMovement);
            if (transform.position.y >= verticalRange)
                movingUp = false;
        }
        else
        {
            transform.Translate(Vector3.down * verticalMovement);
            if (transform.position.y <= -verticalRange)
                movingUp = true;
        }

        if (Time.time > nextSpawnTime)
        {
            SpawnItem();
            nextSpawnTime = Time.time + 1 / spawnRate;
        }
    }

    private void SpawnItem()
    {
        GameObject newItem = Instantiate(itemPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = newItem.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-itemSpeed, 0);

    }
}
