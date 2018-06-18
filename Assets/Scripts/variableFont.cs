using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class variableFont : MonoBehaviour {

	public GameObject cam;
	public Vector3 startPos;

	public int x;
	public int z;

	public float size = 3;

	public Text text;

	public Font A100L;
	public Font A100R;
	public Font A100M;
	public Font A100B;
	public Font A100EB;
	public Font A100Blk;
	public Font A110L;
	public Font A110R;
	public Font A110M;
	public Font A110B;
	public Font A110EB;
	public Font A110Blk;
	public Font A120L;
	public Font A120R;
	public Font A120M;
	public Font A120B;
	public Font A120EB;
	public Font A120Blk;
	public Font A130L;
	public Font A130R;
	public Font A130M;
	public Font A130B;
	public Font A130EB;
	public Font A130Blk;
	public Font A140L;
	public Font A140R;
	public Font A140M;
	public Font A140B;
	public Font A140EB;
	public Font A140Blk;
	public Font A150L;
	public Font A150R;
	public Font A150M;
	public Font A150B;
	public Font A150EB;
	public Font A150Blk;

	public Font[,] AgendaFont;

	// Use this for initialization
	void Start () {



		AgendaFont = new Font[6,6];

		AgendaFont [0, 0] = A100L;
		AgendaFont [0, 1] = A100R;
		AgendaFont [0, 2] = A100M;
		AgendaFont [0, 3] = A100B;
		AgendaFont [0, 4] = A100EB;
		AgendaFont [0, 5] = A100Blk;

		AgendaFont [1, 0] = A110L;
		AgendaFont [1, 1] = A110R;
		AgendaFont [1, 2] = A110M;
		AgendaFont [1, 3] = A110B;
		AgendaFont [1, 4] = A110EB;
		AgendaFont [1, 5] = A110Blk;

		AgendaFont [2, 0] = A120L;
		AgendaFont [2, 1] = A120R;
		AgendaFont [2, 2] = A120M;
		AgendaFont [2, 3] = A120B;
		AgendaFont [2, 4] = A120EB;
		AgendaFont [2, 5] = A120Blk;

		AgendaFont [3, 0] = A130L;
		AgendaFont [3, 1] = A130R;
		AgendaFont [3, 2] = A130M;
		AgendaFont [3, 3] = A130B;
		AgendaFont [3, 4] = A130EB;
		AgendaFont [3, 5] = A130Blk;

		AgendaFont [4, 0] = A140L;
		AgendaFont [4, 1] = A140R;
		AgendaFont [4, 2] = A140M;
		AgendaFont [4, 3] = A140B;
		AgendaFont [4, 4] = A140EB;
		AgendaFont [4, 5] = A140Blk;

		AgendaFont [5, 0] = A120L;
		AgendaFont [5, 1] = A120R;
		AgendaFont [5, 2] = A120M;
		AgendaFont [5, 3] = A120B;
		AgendaFont [5, 4] = A120EB;
		AgendaFont [5, 5] = A120Blk;
	}
	
	// Update is called once per frame
	void Update () {

		float dist = Vector3.Distance(cam.transform.position, transform.position);
		float zDist = transform.position.z - cam.transform.position.z;
		float angle = Mathf.Acos (zDist / dist) * Mathf.Rad2Deg;
		Vector3 camPos = cam.transform.position;
		//Debug.Log (angle);



		x = Mathf.RoundToInt(angle/10);
		z = Mathf.RoundToInt((dist-5f)/size);
		if (x > 5) {
			x = 5;
		}
		if (x < 0) {
			x = 0;
		}
		if (z > 5) {
			z = 5;
		}
		if (z < 0) {
			z = 0;
		}
		text.GetComponent<Text>().font = AgendaFont [x, z];
		//print ("x:"+angle/5+"  y:"+dist);
	}
}
