using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuong : MonoBehaviour
{
    public float up, down; // Giới hạn di chuyển lên và xuống
    public float threshold = 0.1f; // Ngưỡng cho việc so sánh giới hạn

    private bool isUp; // Biến kiểm tra hướng di chuyển

    void Update()
    {
        var caY = transform.position.y; // Lấy giá trị vị trí y của đối tượng

        // Kiểm tra giới hạn di chuyển lên và xuống với ngưỡng
        if (caY < down + threshold)
        {
            isUp = true;
        }
        else if (caY > up - threshold)
        {
            isUp = false;
        }

        // Di chuyển lên hoặc xuống dựa vào giá trị của isUp
        if (isUp)
        {
            transform.Translate(new Vector3(0, Time.deltaTime * 1, 0));
        }
        else
        {
            transform.Translate(new Vector3(0, -Time.deltaTime * 1, 0));
        }
    }


}
