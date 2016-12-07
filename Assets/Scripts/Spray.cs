using UnityEngine;
using System.Collections;

public class Spray : MonoBehaviour {
    public Transform water;
	// Use this for initialization
	void Start () {
        water.GetComponent<ParticleSystem>().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("e"))
        {
            water.GetComponent<ParticleSystem>().enableEmission = true;
        } else
        {
            water.GetComponent<ParticleSystem>().enableEmission = false;
        }
	}
}
