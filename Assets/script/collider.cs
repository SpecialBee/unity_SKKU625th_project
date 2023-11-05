using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float increaseAmount = 0.1f; // 각 아이템의 증가량을 설정할 변수

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GaugeController gaugeController = other.GetComponent<GaugeController>();
            if (gaugeController != null)
            {
                gaugeController.IncreaseGauge(increaseAmount);
                Destroy(gameObject); // 아이템 파괴
            }
        }
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
