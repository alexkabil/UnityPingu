using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public IEnumerator LifeTime(){
		yield return new WaitForSeconds(3.0f);
		GameObject.Destroy(this.gameObject);
		yield return null;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
