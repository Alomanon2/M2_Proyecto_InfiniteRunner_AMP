using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchObstacles : MonoBehaviour
{
    public List<GameObject> obstaclesList = new List<GameObject>();
    public GameObject spawnObstacles;
    public static float currentSpeed; 
    public float maxSpeed,speedModifier;
    private float timer = 0f, timeToWait = 4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //Launch obstacles in a random timeframe
        timer += Time.deltaTime;
        

        if (timer >= timeToWait && timer < 1000f) // condicion mal, el timer siempre será mayor...
        {
            Obstacles();
            timer = 0f;
            timeToWait = Random.Range(4.0f, 9.0f);
        }
        //StartCoroutine()

    }
    void Obstacles()
    {
        int randObstacle = Random.Range(0, obstaclesList.Count); //print("Random: "+randObstacle+". List Count: "+obstaclesList.Count); // Debugging, remove this last line.
        Instantiate(obstaclesList[randObstacle], spawnObstacles.transform.position, spawnObstacles.transform.rotation);
    }
 
}

