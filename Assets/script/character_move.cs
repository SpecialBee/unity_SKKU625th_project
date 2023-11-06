using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_move : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �÷��̾� �̵� �ӵ�

    void Update()
    {
        // �÷��̾��� �̵��� ó���� �ڵ�
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0);
        moveDirection.Normalize(); // �밢�� �̵��� ������ �ӵ��� �����ϱ� ���� ����ȭ

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
