using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // 배경 이동 속도

    void Update()
    {
        // 현재 위치에서 왼쪽으로 이동할 벡터를 계산합니다.
        Vector3 newPosition = transform.position + Vector3.left * scrollSpeed * Time.deltaTime;

        // 새 위치를 배경의 위치로 설정합니다.
        transform.position = newPosition;
    }
}
