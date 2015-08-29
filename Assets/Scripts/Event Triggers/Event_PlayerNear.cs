using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class Event_PlayerNear : MonoBehaviour {
	public float m_PlayerNearDistance;
	public UnityEvent m_OnPlayerNear;

	Transform Player{
		get{
			if(s_Player == null)
			{
				s_Player = GameObject.FindGameObjectWithTag("Player").transform;
			}
			return s_Player;
		}
	}

	static Transform s_Player;

	State m_State = State.Far;


	public void ResetState(){
		m_State = State.Far;
	}


	// Update is called once per frame
	void Update () {
		if (m_State == State.Far) {
			if((transform.position - Player.position).magnitude <= m_PlayerNearDistance)
			{
				m_OnPlayerNear.Invoke();
				m_State = State.Near;
			}
		}
	}

	enum State{
		Far,
		Near
	}
}
