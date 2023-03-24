using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Obstacles : MonoBehaviour
{

    public ObstacleMovement ObstacleMovement;
    public List<GameObject> obstaclesList = new List<GameObject>();
    public GameObject spawnObstacle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ObstacleGenerator()
    {
        int random = Random.Range (1, 6);
        Instantiate(obstaclesList[random], spawnObstacle.transform.position, spawnObstacle.transform.rotation);
        
        //Flying Enemies dont go on the ground

        //if (obstaclesList[random].gameObject.tag=="FlyingEnemy")
        //{
        //    Instantiate(obstaclesList[random], spawnObstacle.transform.position*2, spawnObstacle.transform.rotation);
        //}
        //else
        //{
        //    Instantiate(obstaclesList[random], spawnObstacle.transform.position, spawnObstacle.transform.rotation);
        //}

    }


}
