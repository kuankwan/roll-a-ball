using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private Rigidbody rd;
    public int force = 5;
    private int score = 0;
    public Text text;
    public GameObject wintext;


    
	// Use this for initialization
	void Start () {
        rd = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v) * force);

	
	}

    void OnCollisionEnter(Collision collision)
    {
        //string name = collision.collider.name;
        if (collision.collider.tag == "PickUps")
        {
            Destroy(collision.collider.gameObject);
        }
    }

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "PickUps") {
            score++;
            text.text = score.ToString();
            if (score == 10)
            {
                wintext.SetActive(true);
            }
			Destroy(collider.gameObject);
		}
	}
}
