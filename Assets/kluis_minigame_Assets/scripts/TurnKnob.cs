using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnKnob : MonoBehaviour
{
	private Camera _camera;
	private Vector3 screenpos;
	private float angleOffset;
	private Collider2D turner;


	// Start is called before the first frame update
	void Start()
	{
		_camera = Camera.main;
		Collider2D turner = GetComponent<Collider2D>();
	}

	// Update is called once per frame
	void Update()
    { 

		Vector3 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
		if (Input.GetMouseButtonDown(0))
		{
			if (turner == Physics2D.OverlapPoint(mousePos))
			{
				screenpos = _camera.ScreenToWorldPoint(transform.position);
				Vector3 vec3 = Input.mousePosition - screenpos;
				angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(vec3.y, vec3.x)) * Mathf.Rad2Deg;

			}
		}
		if (Input.GetMouseButton(0))
		{
			if (turner == Physics2D.OverlapPoint(mousePos))
			{
				Vector3 vec3 = Input.mousePosition - screenpos;
				float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;
				transform.eulerAngles = new Vector3(0, 0, angle + angleOffset);

			}
		}
	}
}
