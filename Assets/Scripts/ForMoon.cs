using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForMoon : MonoBehaviour
{
    void Start()
    {
        PyramidHotel(5); // ���� ����
    }

    void PyramidHotel(int floor)
    {
        //for (int i = 0; i < floor; i++) //���� ����(5)�̹Ƿ� floor=5 ����
        //{
        //    string pyramid = "";
            
        //    for (int x = 0; x < (floor - 1) - i; x++)
        //    {
        //        pyramid += "��";
        //    }

        //    for (int x = 0; x < (i * 2) + 1; x++)
        //    {
        //        pyramid += "��";
        //    }

        //    Debug.Log(pyramid);
        //}
        // ����Բ��� 

        //���Ƕ�̵��

        // ����� ���Ƕ�̵�
        for (int i = 1; i <= 5; i++)
        {
            string pyramid = "";

            for (int j = 0; j < 5 -i; j++)
            {
                pyramid += "��";
            }

            for (int x = 1; x <= 2 * i - 1; x++)
            {
                pyramid += "��";
            }

            Debug.Log(pyramid);
        }
    }
}
