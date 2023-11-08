using UnityEngine;

public class Receive : MonoBehaviour
{
    public Material[] materials;
    private int messageCount = 0;

    void Start()
    {
        GetComponent<Renderer>().material = materials[0];
    }

    public void ReceiveMessage()
    {
        messageCount++;
        Debug.Log("I have received " + messageCount + " messages from the transmit script");

        if (messageCount > 500 && messageCount <= 700)
        {
            GetComponent<Renderer>().material = materials[1]; // Màu đỏ
        }
        else if (messageCount > 700 && messageCount <= 1000)
        {
            GetComponent<Renderer>().material = materials[2]; // Màu cam
        }
        else if (messageCount > 1000)
        {
            GetComponent<Renderer>().material = materials[3]; // Màu xanh lá cây
        }
        else
        {
            GetComponent<Renderer>().material = materials[0]; // Màu mặc định
        }
    }
}
