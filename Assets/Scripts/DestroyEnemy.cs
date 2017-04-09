using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            //foreach (Transform child in other.gameObject.transform)
            //{
            //    Vector3 vector = new Vector3(0.0f, 0.0f, 10);
            //    child.position = vector;
            //    print("Foreach loop: " + child.gameObject);
            //}

            //foreach (Transform child in transform)
            //    print("Foreach loop: " + child.gameObject);
            ////Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }

    }
}
