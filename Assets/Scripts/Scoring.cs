using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static float score = 0;
    public float scoreCheck = score;
    public float pointsPerTimeCount = 10;
    public float timeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        timeCount += Time.deltaTime;
        if (timeCount >= 5) // to add: && !destroyed
        {
            score += pointsPerTimeCount;
            timeCount = 0;
        }
        scoreCheck = score;
    }

}

