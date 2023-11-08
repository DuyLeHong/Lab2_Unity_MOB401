using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmit : MonoBehaviour
{
    // Phương thức này được gọi khi đối tượng được tạo ra
    void Start()
    {
        
    }

    // Phương thức này được gọi mỗi khi một khung hình được hiển thị trên màn hình
    void Update()
    {
        // Kiểm tra xem một số ngẫu nhiên từ 0 đến 1 có lớn hơn 0.5 không
        if (Random.value > 0.5f) {
            // Nếu số ngẫu nhiên lớn hơn 0.5, gửi thông điệp tới đối tượng "ReceiveCube"
            ReceiveCube.SendMessage("Hi Hi");
        }
    }
}


// Lớp nội bộ (internal) có tên "ReceiveCube"
internal class ReceiveCube
{
    // Phương thức này được gọi khi nhận được thông điệp với tham số "receivemessage"
    public static void SendMessage(string receivemessage)
    {
            // Thực hiện các hành động mong muốn khi nhận được tin nhắn từ TransmitCube
            Debug.Log("Log tin nhắn");
            // Các hành động khác...
        
    }
}
