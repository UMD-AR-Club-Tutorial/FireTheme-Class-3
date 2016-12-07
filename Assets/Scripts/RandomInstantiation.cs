using UnityEngine;
using System.Collections;

public class RandomInstantiation : MonoBehaviour {

    public GameObject fire, smoke, oven;

    private float planeMinX, planeMaxX;
    private float planeMinZ, planeMaxZ;

    void Start()
    {
        planeMinX = transform.position.x - transform.position.x / 2;
        planeMaxX = transform.position.x + transform.position.x / 2;
        planeMinZ = transform.position.z - transform.position.z / 2;
        planeMaxX = transform.position.z + transform.position.z / 2;
    }

    private bool startAgain;

    void Update()
    {
        StartCoroutine(InstantiateOven());
    }

    IEnumerator InstantiateOven()
    {
        if (!startAgain) 
            Instantiate(oven, SetRandTreePos(), Quaternion.identity);
        startAgain = true;
        yield return new WaitForSeconds(5f);
        startAgain = false;
        //fire.GetComponent<ParticleSystem>().enableEmission = false;
    }

	Vector3 SetRandTreePos() { 
	    Vector3 newPos;	            
        newPos = new Vector3(Random.Range(-150f, 150f), transform.position.y, Random.Range(planeMinZ + 1, planeMaxZ - 1)); 
        return newPos; 
    }
 
}
