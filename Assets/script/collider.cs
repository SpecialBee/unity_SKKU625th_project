using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            // �ٸ� ������Ʈ�� �浹�ϸ� �������� �ı�
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            // �ٸ� ������Ʈ�� �浹�ϸ� �������� �ı�
            Destroy(gameObject);
        }
    }
}
