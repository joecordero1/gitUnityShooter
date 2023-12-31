using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShooted : Target
{
    private float scaleFactor = 0.8f; // Factor para reducir la escala de la esfera
    private int maxImpacts = 3; // Número máximo de impactos para esferas
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
