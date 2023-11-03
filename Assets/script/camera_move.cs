using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 카메라가 따라갈 대상 유닛(Transform)
    public float smoothing = 5.0f; // 카메라 이동 스무딩 값

    private Vector3 offset; // 카메라와 대상 간의 초기 거리

    void Start()
    {
        offset = transform.position - target.position; // 초기 거리 계산
    }

    void Update()
    {
        // 대상 유닛의 현재 위치와 초기 거리를 사용하여 카메라 위치 업데이트
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
    }
}
