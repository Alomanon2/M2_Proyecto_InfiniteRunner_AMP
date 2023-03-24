using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float jumpForce;
    Rigidbody2D rb;
    public GameObject playerAnimator,player,endPanel;
    
    private bool isGrounded = true;
    private Animator animator;

    public TextMeshProUGUI textoPuntos, textoTime, textFinalPoints,textFinalTime;
    public int puntos = 0;
    public float timerCount=0;

    ButtonPause buttonPause;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator =playerAnimator.gameObject.GetComponent<Animator>();
        textoPuntos.text = "Points: " + puntos;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForce*10);
                isGrounded = false;
                animator.SetBool("Jumping", !isGrounded);
            }
        }

        //Return player to original position in case of delay
        if(player.transform.position.x <-17)
        {
            player.transform.Translate(0.05f, 0, 0);
        }

        timerCount += Time.deltaTime; 
        textoPuntos.text = "Points: " + puntos;
        textoTime.text = "Time: " + Mathf.Round(timerCount*10)/10;
        

        textFinalPoints.text = "Points: " + puntos;
        textFinalTime.text = "Time: " + Mathf.Round(timerCount*10)/10+"s";

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = true;
            animator.SetBool("Jumping", !isGrounded);
        }

        if (collision.gameObject.tag == "Enemy") // Add this code || collision.gameObject.tag == "PlayerDestroyer"
        {
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Points")
        {
            puntos++;
            //textoPuntos.text = "Points: " + puntos; //redundante? already on update
            Destroy(collision.gameObject);
        }
    }
}
