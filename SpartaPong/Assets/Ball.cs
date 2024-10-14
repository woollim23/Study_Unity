using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;

    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        // Random Range(시작숫자, 끝숫자(포함안됨))
        // Random은 static 클래스인가? 선언없이 쓸수가있네?
        // 유니티라 가능한 걸까 일반 C#도 가능한걸까?
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rigidbody.velocity = new Vector2(x* speed, y* speed);
    }

    public void Reset()
    {
        rigidbody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Launch();
    }
}
