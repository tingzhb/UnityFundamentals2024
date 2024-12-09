using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour {
    [SerializeField] Transform target;
    NavMeshAgent agent;
    void OnEnable(){
        agent = GetComponent<NavMeshAgent>();
    }
    void Update() {
        agent.SetDestination(target.position);
    }
}
