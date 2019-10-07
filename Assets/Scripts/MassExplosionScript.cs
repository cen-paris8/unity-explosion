using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassExplosionScript : MonoBehaviour
{
    public float force;
    public float radius;

    void Start()
    {
        Invoke("Detonate", 3);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100))
            {
                Collider[] colliders = Physics.OverlapSphere(hit.point, radius);
                //Collider[] colliders = Physics.OverlapBox(hit.point, transform.localScale,  Quaternion.identity);

            foreach(Collider c in colliders)
                {
                    if (c.GetComponent<Rigidbody>() == null) continue;

                    c.GetComponent<Rigidbody>().AddExplosionForce(force, hit.point, radius, 1, ForceMode.Impulse);
                }
            }
        }    
    }

    void Detonate()
    {
        Collider[] colliders = Physics.OverlapSphere(Vector3.zero, 10);

        foreach(Collider col in colliders)
        {
            if (col.GetComponent<Rigidbody>() == null) continue;

            col.GetComponent<Rigidbody>().AddExplosionForce(20, Vector3.zero, 10, 0, ForceMode.Impulse);
        }

    }
}
