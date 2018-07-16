using UnityEngine;

public class Block : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (transform.position.z < FindObjectOfType<PlayerMovement>().rb.position.z - 2f)
        {
            Destroy(gameObject);
        }
	}
}
