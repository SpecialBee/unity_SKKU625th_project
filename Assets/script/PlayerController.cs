using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("item"))
        {
            Destroy(other.gameObject); // 오브젝트 제거
        }
    }
}

