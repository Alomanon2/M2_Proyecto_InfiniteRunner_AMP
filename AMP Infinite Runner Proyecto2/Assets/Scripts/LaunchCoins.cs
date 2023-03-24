using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCoins: MonoBehaviour
{
    private float timer = 0f, timeToWait2 = 3f;
    public GameObject coins, spawnCoins;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {


        //Launch obstacles in a random timeframe
        timer += Time.deltaTime;
        

        if (timer >= timeToWait2 && timer < 1000f)
        {
            CoinGenerator();
            timer = 0f;
            timeToWait2 = Random.Range(2.0f, 5.0f);
        }
    }
    private void CoinGenerator()
    {
        //use random float number to modify the height of coin spawning.
        float random = Random.Range(-2f, 3f);
        Instantiate(coins, new Vector3(spawnCoins.transform.position.x, spawnCoins.transform.position.y+ random, spawnCoins.transform.position.z), spawnCoins.transform.rotation);
    }
}

