using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            // 다른 오브젝트와 충돌하면 아이템을 파괴
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            // 다른 오브젝트와 충돌하면 아이템을 파괴
            Destroy(gameObject);
        }
    }
}
