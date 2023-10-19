using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShoot : MonoBehaviour
{
    
    public float range = 10f;
    public GameObject effect;
    public float force = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        RaycastHit myHit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out myHit, range))
        {
            GameObject _effect = Instantiate(effect, myHit.point, Quaternion.identity);
            Destroy(_effect, 0.5f);

            // Comprueba si el objeto impactado tiene el script "Shooted" o "SphereShooted"
            Target target = myHit.collider.GetComponent<Target>();
            if (target != null)
            {
                target.HandleImpact();
            }
        }
    }

    private void OnDrawGizmos() // Cambiado onDraw a OnDrawGizmos
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * range);
    }
}