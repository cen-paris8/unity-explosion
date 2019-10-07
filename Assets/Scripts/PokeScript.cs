using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeScript : MonoBehaviour
{
    public float force;
    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
      

        if (Physics.Raycast(ray, out hit, 100))
            //GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(0, 0, -force), hit.point, ForceMode.Impulse);
            GetComponent<Rigidbody>().AddForceAtPosition((transform.position - hit.point) * force, hit.point, ForceMode.Impulse);

    }
}
