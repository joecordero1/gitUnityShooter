using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RayCastShoot : MonoBehaviour
{
    
    public float range = 50f;
    public GameObject effect;
    public float force = 4;

    public int div;
    public int div2;
    public int countCubes;
    public int countSpheres;

    public TMP_Text CounterCubesText;
    public TMP_Text CounterSpheresText;

    // Start is called before the first frame update
    void Start()
    {
        CounterCubesText.SetText("Cubes destroyed: "+countCubes);
        CounterSpheresText.SetText("Spheres destroyed: "+countSpheres);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
            CounterCubesText.SetText("Cubes destroyed: "+countCubes);
            CounterSpheresText.SetText("Spheres destroyed: "+countSpheres);
        }
        
    }

    private void Fire()
    {
        RaycastHit myHit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out myHit, range))
        {
            GameObject _effect = Instantiate(effect, myHit.point, Quaternion.identity);
            Destroy(_effect, 0.2f);

            // Comprueba si el objeto impactado tiene el script "Shooted" o "SphereShooted"
            Target target = myHit.collider.GetComponent<Target>();
            if (target != null)
            {
                target.HandleImpact();
            }
            string targetName = myHit.collider.gameObject.name;
            
            if (targetName == "newCube(Clone)")
            {
                Shooted shot = myHit.collider.GetComponent<Shooted>();
                div = shot.currentImpacts / 2;
                countCubes = countCubes + div;
            }else{
                SphereShooted shot = myHit.collider.GetComponent<SphereShooted>();
                div2 = shot.currentImpacts / 3;
                countSpheres = countSpheres + div2;
            }
            CounterCubesText.SetText("Cubes destroyed: "+countCubes);
            CounterSpheresText.SetText("Spheres destroyed: "+countSpheres);
            Debug.Log("Cubos destruidos: " + countCubes);
            Debug.Log("Spheres destruidos: " + countSpheres);
        }
        
    }

    private void OnDrawGizmos() // Cambiado onDraw a OnDrawGizmos
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * range);
    }
}