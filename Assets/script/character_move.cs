using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_move : MonoBehaviour
{
     Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Rigidbody의 회전을 고정하여 캐릭터가 넘어지지 않도록 합니다.
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }
}



