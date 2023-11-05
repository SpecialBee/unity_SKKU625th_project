using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour
{
    public Slider gaugeSlider; // Slider UI 요소를 연결할 변수

    private float currentGaugeValue = 1.0f; // 초기 게이지 값 (0.0에서 1.0까지)

    private void Start()
    {
        // Slider의 값을 초기 게이지 값으로 설정
        gaugeSlider.value = currentGaugeValue;
    }

    // 아이템을 먹을 때 게이지를 올리는 함수
    public void IncreaseGauge(float amount)
    {
        currentGaugeValue = Mathf.Clamp01(currentGaugeValue + amount); // 0에서 1 사이 값으로 제한
        gaugeSlider.value = currentGaugeValue; // Slider 업데이트
    }

    // 시간이 지남에 따라 게이지를 감소하는 함수
    public void DecreaseGauge(float amount)
    {
        currentGaugeValue = Mathf.Clamp01(currentGaugeValue - amount); // 0에서 1 사이 값으로 제한
        gaugeSlider.value = currentGaugeValue; // Slider 업데이트
    }
}

