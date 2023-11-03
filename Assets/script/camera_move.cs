using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // ī�޶� ���� ��� ����(Transform)
    public float smoothing = 5.0f; // ī�޶� �̵� ������ ��

    private Vector3 offset; // ī�޶�� ��� ���� �ʱ� �Ÿ�

    void Start()
    {
        offset = transform.position - target.position; // �ʱ� �Ÿ� ���
    }

    void Update()
    {
        // ��� ������ ���� ��ġ�� �ʱ� �Ÿ��� ����Ͽ� ī�޶� ��ġ ������Ʈ
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
    }
}
