using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
    Transform tr;
	void Start ()
    {
        tr = GetComponent<Transform>();
	}
	

    public IEnumerator Destroy()
    {
        while (tr.position.y < 50)
        {
            tr.Rotate(Vector3.up * 500 * Time.deltaTime);
            tr.position += new Vector3(0, 1, 0);
            yield return null;
            if (tr.position.y >= 50)
                Destroy(gameObject); 
        }
    }
}
