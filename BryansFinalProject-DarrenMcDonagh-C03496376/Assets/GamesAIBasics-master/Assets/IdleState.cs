using System;
using System.Collections.Generic;
using UnityEngine;

public class IdleState:State
{
    static Vector3 initialPos = Vector3.zero;

    GameObject enemyGameObject;

    public override string Description()
    {
        return "Idle State";
    }

    public IdleState(GameObject myGameObject, GameObject enemyGameObject)
        : base(myGameObject)
    {
        this.enemyGameObject = enemyGameObject;
    }

    public override void Enter()
    {
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(0, 0, -20));
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Add(new Vector3(30, 0, 0));
        
        myGameObject.GetComponent<SteeringBehaviours>().path.Looped = true;            
        myGameObject.GetComponent<SteeringBehaviours>().path.draw = true;
        myGameObject.GetComponent<SteeringBehaviours>().TurnOffAll();
        myGameObject.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
    }
    public override void Exit()
    {
        myGameObject.GetComponent<SteeringBehaviours>().path.Waypoints.Clear();
    }

    public override void Update()
    {
        float range = 5.0f;
		float fov = Mathf.PI / 4.0f;
		float angle;
		Vector3 toEnemy = (enemyGameObject.transform.position - myGameObject.transform.position);
		toEnemy.Normalize();
		angle = (float) Math.Acos(Vector3.Dot(toEnemy, myGameObject.transform.forward));
        // Can I see the enemy?
		if ((enemyGameObject.transform.position - myGameObject.transform.position).magnitude < range && angle < fov)  //see if in range and on FOV
        {
            // Is the leader inside my FOV
            myGameObject.GetComponent<StateMachine>().SwitchState(new AttackingState(myGameObject, enemyGameObject));
        }
    }
}
