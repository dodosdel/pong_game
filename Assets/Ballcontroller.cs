using UnityEngine;
using UnityEngine.UI;
public class Ballcontroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float initialSpeed = 10f;
    public float speedIncrease = 0.2f;
    public Text playerText;
    public Text opponentText;


    private int hitCounter;
    private Rigidbody2D rb;
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
        Invoke("StartBall", 2f);        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
             
    }
}
