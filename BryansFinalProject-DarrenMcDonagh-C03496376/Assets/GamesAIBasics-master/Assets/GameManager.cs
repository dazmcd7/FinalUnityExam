using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject leader = GameObject.FindGameObjectWithTag("Bot1");
		GameObject leader2 = GameObject.FindGameObjectWithTag("Bot2");
		GameObject leader3 = GameObject.FindGameObjectWithTag("Bot3");
		GameObject leader4 = GameObject.FindGameObjectWithTag("Bot4");
		GameObject leader5 = GameObject.FindGameObjectWithTag("Bot5");
        GameObject teaser = GameObject.FindGameObjectWithTag("teaser");
		GameObject bot = GameObject.FindGameObjectWithTag("Bot1");

       leader.GetComponent<StateMachine>().SwitchState(new IdleState(leader, teaser));
		leader2.GetComponent<StateMachine>().SwitchState(new IdleState(leader2, teaser));
		leader3.GetComponent<StateMachine>().SwitchState(new IdleState(leader3, teaser));
		leader4.GetComponent<StateMachine>().SwitchState(new IdleState(leader4, teaser));
		leader5.GetComponent<StateMachine>().SwitchState(new IdleState(leader5, teaser));


        teaser.GetComponent<StateMachine>().SwitchState(new TeaseState(teaser, leader));
		teaser.GetComponent<StateMachine>().SwitchState(new TeaseState(teaser, leader2));
		teaser.GetComponent<StateMachine>().SwitchState(new TeaseState(teaser, leader3));
		teaser.GetComponent<StateMachine>().SwitchState(new TeaseState(teaser, leader4));
		teaser.GetComponent<StateMachine>().SwitchState(new TeaseState(teaser, leader5));
		//bot.GetComponent<StateMachine>().SwitchState(new IdleState(bot, teaser));

        //leader.renderer.material.color = Color.red;
        //teaser.renderer.material.color = Color.blue;

        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
