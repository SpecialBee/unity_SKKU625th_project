using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController2D : MonoBehaviour
{
    public int itemValue = 10; // 아이템 가치
    public GameObject collectedEffect; // 아이템 수집 시 효과

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 아이템이 플레이어와 충돌할 때
        {

            // 아이템 제거
            Destroy(gameObject);
        }
    }
}
