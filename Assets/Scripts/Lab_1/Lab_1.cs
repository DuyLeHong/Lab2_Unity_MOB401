using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lab_1 : MonoBehaviour
{
    private Animator animator; // Animator để điều khiển animation của nhân vật
    private bool isMovingRight = false; // Biến kiểm tra xem nhân vật có đang di chuyển về phải không

    int score = 0;
    public int dem = 0;
    public Text Diem;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Lấy Animator từ đối tượng GameObject này khi bắt đầu chạy
    }
    
    

    void Update()
    {
        
       
        // Xử lý khi nhấn phím D (di chuyển về phải)
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Chay", true); // Thiết lập trạng thái "Chạy" trong animator để chơi animation chạy
            animator.Play("Chay"); // Chơi animation chạy
            transform.Translate(Time.deltaTime * 5, 0, 0); // Di chuyển nhân vật về phải
            transform.localScale = new Vector3(0.3F, 0.3F, 1F); // Đặt tỷ lệ của nhân vật để hướng về phải
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            isMovingRight = false; // Ngưng di chuyển về phải khi nhấc phím D
            animator.SetBool("Chay", false); // Ngưng chạy animation
        }
    
        // Xử lý khi nhấn phím A (di chuyển về trái)
        if (Input.GetKey(KeyCode.A))
        {
            isMovingRight = false; // Ngưng di chuyển về phải
            animator.SetBool("Chay", true); // Thiết lập trạng thái "Chạy" trong animator để chơi animation chạy
            animator.Play("Chay"); // Chơi animation chạy
            transform.Translate(-Time.deltaTime * 3, 0, 0); // Di chuyển nhân vật về trái
            transform.localScale = new Vector3(-0.3F, 0.3F, 1F); // Đặt tỷ lệ của nhân vật để hướng về trái
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            isMovingRight = false; // Ngưng di chuyển về trái khi nhấc phím A
            animator.SetBool("Chay", false); // Ngưng chạy animation
        }
    
        // Xử lý khi nhấn phím W (nhảy)
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, Time.deltaTime * 12, 0); // Di chuyển nhân vật lên trên (nhảy)
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Nhay", false); // Ngưng animation nhảy khi nhấc phím W
        }
    }

   

    // ăn tiền nhận điểm
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Tien")
        {
            score +=1;
            Destroy(other.gameObject);
            Diem.text = score.ToString();
        }
        
        if(other.gameObject.tag == "ChuyenMan")
        {
            SceneManager.LoadScene("MH_Win");
        }
        
    }
    
    public void chuyenman()
    {
        SceneManager.LoadScene("MH1_fix");
    }
    
    public void ReloadManChoi()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    
}

