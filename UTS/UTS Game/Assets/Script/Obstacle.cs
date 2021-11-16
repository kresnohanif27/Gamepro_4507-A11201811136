using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float maxTime;
    float timer;

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    
    int chooseObstacle;

    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            GenerateObstacle();
            timer = 0;
        }
    }

    void GenerateObstacle()
    {
        chooseObstacle = Random.Range(1, 5);
        if (chooseObstacle == 1) { GameObject newObstacle = Instantiate(obstacle1); }
        if (chooseObstacle == 2) { GameObject newObstacle = Instantiate(obstacle2); }
        if (chooseObstacle == 3) { GameObject newObstacle = Instantiate(obstacle3); }
    }
}
