using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    Camera cam;
    Ray ray;
    RaycastHit hit;
    void Start ()
    {
        cam = GetComponent<Camera>();
        
        
    }

    void Update()
    {
        ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Cube"))
            {
                hit.collider.GetComponent<Cube>().StartCoroutine("Destroy");
                hit.collider.tag = "Untagged";
            }
        }
    }
}
