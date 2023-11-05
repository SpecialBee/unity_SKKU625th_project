using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider gaugeSlider; // Slider UI 오브젝트를 연결합니다.
    public float maxGauge = 100f; // 게이지의 최대값을 설정합니다.
    private float currentGauge;

    private void Start()
    {
        currentGauge = maxGauge;
        UpdateGaugeUI();
    }

    private void UpdateGaugeUI()
    {
        gaugeSlider.value = currentGauge / maxGauge; // Slider의 값을 갱신합니다.
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item")) // 아이템과 충돌하면
        {
            currentGauge += 10f; // 게이지 증가량을 조절합니다.
            currentGauge = Mathf.Clamp(currentGauge, 0f, maxGauge); // 최대값을 초과하지 않도록 제한합니다.
            UpdateGaugeUI();
            Destroy(other.gameObject); // 아이템을 제거합니다.
        }
    }

    private void Update()
    {
        // 시간이 지남에 따라 게이지를 감소시키는 로직을 구현합니다.
        currentGauge -= Time.deltaTime;
        currentGauge = Mathf.Clamp(currentGauge, 0f, maxGauge);
        UpdateGaugeUI();
    }
}



