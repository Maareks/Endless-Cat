using UnityEngine;
using System.Collections;

public class DEBUG_LogMessage : MonoBehaviour {
	public string m_Message = "Empty Message";
	private Animation anim;
	public void LogMessage(){
		Debug.Log (m_Message);
	}
	public void Animm(){
		anim = gameObject.GetComponent<Animation> ();
		anim.Play ();
	}
}

