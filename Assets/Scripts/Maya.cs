using UnityEngine;
using System.Collections;

public class Maya : MonoBehaviour {
	
	public float			speed = 0.1f;

	// Use this for initialization
	private Vector3			_mousePosition;
	private Vector3			_direction;
	private NavMeshAgent	_agent;
	void Start () {
		_agent = this.GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 100)) {
				_agent.destination = hit.point;
				this.GetComponent<Animator>().SetBool("walk", true);
			}
		}
	}
}
