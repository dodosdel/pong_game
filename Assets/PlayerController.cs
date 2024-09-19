using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 10f;
    public bool isPlayerA = false;
    
    public GameObject circle;


    private Rigidbody2D rb;

    private Vector2 playerMovement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerA){
            PaddleAController();
        }else{
            PaddleBController();
        }
        
    }
    private void PaddleAController(){
        playerMovement = new Vector2(0, Input.GetAxis("Vertical"));
    }
    private void PaddleBController(){
        if(circle.transform.position.y > transform.position.y + 0.5f){
            playerMovement = new Vector2(0,1);
        }else if (circle.transform.position.y < transform.position.y - 0.5f){
            playerMovement = new Vector2(0,-1);
        }else {
            playerMovement = new Vector2 (0,0);
        }
    }
    private void FixedUpdate(){
        rb.linearVelocity = playerMovement * speed;
    }

}
