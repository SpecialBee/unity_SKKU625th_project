using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour
{
    public Slider Grade_bar;
    public float fillSpeed = 0.5f;
    public float healthDecreaseRate = 1.0f; // 체력 감소 속도

    private float currentHealth; // 현재 체력

    void Start()
    {
        currentHealth = Grade_bar.maxValue; // 게이지를 최대 체력으로 초기화
    }

    void Update()
    {
        // 게이지를 조절하려면 원하는 방식으로 slider.value를 업데이트합니다.
        // 예를 들어, 시간이 지남에 따라 체력을 감소시킴
        currentHealth -= healthDecreaseRate * Time.deltaTime;
        currentHealth = Mathf.Clamp(currentHealth, 0f, Grade_bar.maxValue); // 최소값은 0, 최대값은 최대 체력으로 제한
        Grade_bar.value = currentHealth;
    }
}

