using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float scrollSpeed; // Tốc độ cuộn
    private Renderer renderer; // Renderer của đối tượng
    private Vector2 savedOffset; // Vị trí Offset đã lưu
    void Start()
    {
        renderer = GetComponent<MeshRenderer>(); // Lấy Renderer của đối tượng
    }
    void Update ()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1); // Tính toán vị trí Offset theo thời gian và tốc độ cuộn
        Vector2 offset = new Vector2(x, 0); // Tạo Vector2 mới với vị trí Offset tính toán được
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset); // Thiết lập vị trí Offset cho Material của Renderer
    }
}
