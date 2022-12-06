using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForMoon : MonoBehaviour
{
    void Start()
    {
        PyramidHotel(5); // 층의 개수
    }

    void PyramidHotel(int floor)
    {
        //for (int i = 0; i < floor; i++) //층의 개수(5)이므로 floor=5 고정
        //{
        //    string pyramid = "";
            
        //    for (int x = 0; x < (floor - 1) - i; x++)
        //    {
        //        pyramid += "　";
        //    }

        //    for (int x = 0; x < (i * 2) + 1; x++)
        //    {
        //        pyramid += "ㅇ";
        //    }

        //    Debug.Log(pyramid);
        //}
        // 강사님꺼는 

        //역피라미드는

        // 용헌님 정피라미드
        for (int i = 1; i <= 5; i++)
        {
            string pyramid = "";

            for (int j = 0; j < 5 -i; j++)
            {
                pyramid += "　";
            }

            for (int x = 1; x <= 2 * i - 1; x++)
            {
                pyramid += "ㅇ";
            }

            Debug.Log(pyramid);
        }
    }
}
