using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 플레이어 이동 속도

    void Update()
    {
        // 플레이어의 이동을 처리할 코드
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0);
        moveDirection.Normalize(); // 대각선 이동을 일정한 속도로 유지하기 위해 정규화

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
