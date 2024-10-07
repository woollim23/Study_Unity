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
        // �������Ӹ��� Vertical��� Horizontal���� ������
        // float vertical = Input.GetAxis("Vertical");
        // float horizontal = Input.GetAxis("Horizontal");
        // GetAxis�� ������ �־ ĳ������ �������� ���� ������ ����

        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        // GetAxisRaw �� +1, -1 �Է¸� �޾Ƽ� ���� ����

        Vector2 direction = new Vector2(horizontal, vertical);
        // ����ȭ�� �ϰ� ���� : ���̸� 1�� ����� �۾�
        direction = direction.normalized;

        rb.velocity = direction * speed;
    }
}
