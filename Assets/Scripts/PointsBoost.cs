using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsBoost : MonoBehaviour
{
    public float pointsBoost = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Scoring.score += pointsBoost;
        Destroy(gameObject);
    }
}

