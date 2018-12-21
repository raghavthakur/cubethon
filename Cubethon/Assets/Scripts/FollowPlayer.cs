using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        // transform without the capital T, refers to our current object
        transform.position = player.position + offset;
	}
}
