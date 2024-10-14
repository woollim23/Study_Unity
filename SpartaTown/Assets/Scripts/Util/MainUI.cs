using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;

public class MainUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayTime;
    private IEnumerator Start()
    {
        // IEnumerator 유니티에서 코루틴을 구현하기 위해 사용하는 인터페이스
        // 코루틴은 비동기적으로 작업을 수행할 수 있게 해주는 기능
        // 주로 게임에서 시간 지연이나 반복적인 작업을 처리할 때 유용
        while (true)
        {
            displayTime.text = GetCurrntTime();
            yield return new WaitForSeconds(1f);
        }
    }

    public static string GetCurrntTime()
    {
        // 현재 시, 분 출력
        return DateTime.Now.ToString(("HH : mm"));
    }
}
