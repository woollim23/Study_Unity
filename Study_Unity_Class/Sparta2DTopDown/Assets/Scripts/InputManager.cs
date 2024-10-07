using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        // 퍼프레임마다 Vertical축과 Horizontal축을 가져옴
        // float vertical = Input.GetAxis("Vertical");
        // float horizontal = Input.GetAxis("Horizontal");
        // GetAxis는 보정이 있어서 캐릭터의 움직임이 딱딱 끊기지 않음

        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        // GetAxisRaw 는 +1, -1 입력만 받아서 딱딱 끊김

        Vector2 direction = new Vector2(horizontal, vertical);
        // 정규화를 하고 싶음 : 길이를 1로 만드는 작업
        direction = direction.normalized;

        rb.velocity = direction * speed;
    }
}
