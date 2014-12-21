using UnityEngine;
using System.Collections;

public class MeowMeow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void SetPlat(){
	GameObject go;
		go = GameObject.Instantiate(Resources.Load("Blood")) as GameObject;
		go.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition)+ new Vector3(0,0,9);
		go.transform.parent = transform;
		StartCoroutine(go.GetComponent<Splash>().LifeTime());
		GameObject.Find("Meowww").audio.Play();
	}
	
	void OnMouseDown() {
	SetPlat();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
