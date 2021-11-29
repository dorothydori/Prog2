using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject cherry;
    public GameObject lemon;
    public GameObject grape;
    public GameObject blueberry;
    public GameObject plum;
    public GameObject hamburger;
    public GameObject hotdog;
    public GameObject pizza;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    private int randomNumber;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
 
    void Spawn()
    {       
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        randomNumber = Random.Range(0, 8);

        if(randomNumber==0)
                Instantiate(cherry, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        else if(randomNumber==1)
                Instantiate(lemon, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        else if(randomNumber==2)
                Instantiate(grape, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        else if(randomNumber==3)
                Instantiate(blueberry, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        else if(randomNumber==4)
                Instantiate(plum, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        else if (randomNumber == 5)
            Instantiate(hamburger, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        else if (randomNumber == 6)
            Instantiate(hotdog, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        else if (randomNumber == 7)
            Instantiate(pizza, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        else
                Debug.LogError("Wrong random number: " + randomNumber );

    }

}
