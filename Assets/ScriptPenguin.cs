using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScriptPenguin : MonoBehaviour
{
    private NavMeshAgent NavMeshAgent;
    private ScriptPlayer ScriptPlayer;

    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        this.LoadValues();
    }

    // Update is called once per frame
    void Update()
    {
        this.HandleBenhavior();
    }

    void OnTriggerEnter(Collider collider) 
    {
        if (collider.tag == "Player") {
            this.ScriptPlayer.Die();
        }
    }

    void LoadValues()
    {
        this.NavMeshAgent = this.GetComponent<NavMeshAgent>();
        this.ScriptPlayer = this.Target.GetComponent<ScriptPlayer>();
    }

    void HandleBenhavior()
    {
        this.NavMeshAgent.SetDestination(this.Target.transform.position);
    }
}