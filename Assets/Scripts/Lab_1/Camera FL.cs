using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFL : MonoBehaviour
{
    // khai bao nhat vat
    private Transform nhanvat;
    
    void Start()
    {
        //anh xa nhan vat vao code (findByViewID)
        nhanvat = GameObject.Find("Player").transform;
    }

    // cap nhat vi tri cua camera theo nhan vat
    void Update()
    {
        Vector3 cam = transform.position; //camera nhan gia tri cu cua nhan vat
        cam.x = nhanvat.position.x; //chuyen toa do x cua nhan vat cho camera
        transform.position = cam; //nhan vat nhan gia tri moi
    }
}

