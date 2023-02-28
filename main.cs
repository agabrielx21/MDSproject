using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        Vector2 newPosition = transform.position + new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;

        transform.position = newPosition;
    }
}
