using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {

    public Transform PlayerTransform;

    private Vector3 offset;
	// Use this for initialization
	void Start () {

        offset = transform.position + PlayerTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = PlayerTransform.position + offset;
	
	}
}
