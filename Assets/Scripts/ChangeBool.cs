﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBool : StateMachineBehaviour {

    public string BoolName;
    public bool StateOnOnEnter;

	//OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(BoolName, StateOnOnEnter);
	}



	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(BoolName, !StateOnOnEnter);
    }



}
