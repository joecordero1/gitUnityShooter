using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShooted : Target
{
    private float scaleFactor = 0.8f; // Factor para reducir la escala de la esfera
    private int maxImpacts = 3; // Número máximo de impactos para esferas
    private int currentImpacts = 0;

    public void ReduceScale()
    {
        // Reducir la escala de la esfera
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
