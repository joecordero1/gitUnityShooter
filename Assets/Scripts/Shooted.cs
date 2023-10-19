using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooted : Target
{
    private float scaleFactor = 0.8f; // Factor para reducir la escala del cubo
    private int maxImpacts = 2; // Número máximo de impactos para cubos
    private int currentImpacts = 0;

    public void ReduceScale()
    {
        // Reducir la escala del cubo
        transform.localScale *= scaleFactor;
    }

    public override void HandleImpact()
    {
        ReduceScale();

        // Incrementar el contador de impactos
        currentImpacts++;

        // Comprobar si se ha alcanzado el número máximo de impactos
        if (currentImpacts >= maxImpacts)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
