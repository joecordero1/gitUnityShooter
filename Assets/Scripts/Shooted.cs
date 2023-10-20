using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooted : Target
{
    private float scaleFactor = 0.8f;
    private int maxImpacts = 2; 
    public int currentImpacts = 0;

    public void ReduceScale()
    {
        // scale reducer
        transform.localScale *= scaleFactor;
    }

    public override void HandleImpact()
    {
        ReduceScale();

        // impacts counter
        currentImpacts++;
        

        // Checks for max impacts
        if (currentImpacts >= maxImpacts)
        {
            Destroy(gameObject);
            
        }
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
