using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
   
    public float currentSpeed = 20f,speedModifier, maxSpeed, minSpeed;
    
    public GameObject spawnObstacles;

    //public GameObject background;

    private void Awake()
    {
        //currentSpeed = backgroundMovement.currentSpeed;
    }

    private void Start()
    {
        //currentSpeed = minSpeed;
        //currentSpeed = launchObstacles.currentSpeed;
        spawnObstacles = GameObject.FindGameObjectWithTag("SpawnObstacles");
    }
    private void Update()
    {
        // Makes obstacles go faster, should be same speed as floor
        //float currentSpeed = LaunchObstacles.currentSpeed; 
        this.transform.Translate(1 * currentSpeed * Time.deltaTime, 0, 0);
        //if (currentSpeed < maxSpeed)
        //{
        //    currentSpeed += speedModifier;
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("ObstacleDestroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}
