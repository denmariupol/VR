using UnityEngine;
using System.Collections;

public class Behavior : MonoBehaviour
{

    public GameObject cubePrefab;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine("Falling");
	}
	
	IEnumerator Falling()
    {
        while (true)
        {
            GameObject cube = Instantiate(cubePrefab, new Vector3(Random.Range(-40, 40), 50, Random.Range(-40, 40)), Quaternion.identity) as GameObject;
            cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
            yield return new WaitForSeconds(3);
        }
    }
}
