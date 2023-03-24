using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAckgroundMovement : MonoBehaviour
{
    public float speedModifier, maxSpeed, minSpeed,currentSpeed;
    public GameObject spawnBackground, sceneDestroyer;
    private float originalPositionY,originalPositionZ;              //Save original position Y,Z to avoid bad rendering
    //public GameObject background;

    private void Start()
    {
        currentSpeed = minSpeed;
        sceneDestroyer = GameObject.FindGameObjectWithTag("SceneDestroyer");
        spawnBackground = GameObject.FindGameObjectWithTag("SpawnBackground");
        originalPositionY = this.transform.position.y;
        originalPositionZ = this.transform.position.z;
    }
    private void Update()
    {
        
        //Makes the background increase in speed
        this.transform.Translate(-1*currentSpeed * Time.deltaTime, 0, 0);
        //if (currentSpeed < maxSpeed)
        //{
        //    currentSpeed += speedModifier;
        //}
        //print("Background position is:"+this.transform.position.x+". Destroyer position is: "+sceneDestroyer.transform.position.x);
        if (this.transform.position.x < sceneDestroyer.transform.position.x) 
        {
            this.transform.position = new Vector3(spawnBackground.transform.position.x, originalPositionY, originalPositionZ);
        }
    }
}
