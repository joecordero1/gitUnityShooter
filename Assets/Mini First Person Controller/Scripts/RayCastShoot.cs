using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShoot : MonoBehaviour
{
    private Camera _mainCamera;
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

            if (myHit.collider.GetComponent<Rigidbody>() != null) // Cambiado RigidBody a Rigidbody
            {
                myHit.collider.GetComponent<Rigidbody>().AddForce(myHit.normal * force); // Cambiado RigidBody a Rigidbody
            }
        }
    }

    private void OnDrawGizmos() // Cambiado onDraw a OnDrawGizmos
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * range);
    }
}
