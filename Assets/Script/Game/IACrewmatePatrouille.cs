using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class IACrewmatePatrouille : MonoBehaviour
{


    GameObject player;

    NavMeshAgent Agent;

    [SerializeField] LayerMask groudLayer;


    Vector3 DestPoint;
    bool WalkpointsSet;
    [SerializeField] float Walkrange;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Astrounalt_Pink Variant");
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
        //Debug.Log("Valeur WalkpointsSet = " + WalkpointsSet);

    }

    public void Patrol()
    {
        if(!WalkpointsSet)
        {
            SeachForDestination();
        }
        if(WalkpointsSet)
        {
            Agent.SetDestination(DestPoint);
        }
        if(Vector3.Distance(transform.position, DestPoint) < 10)
        {
            WalkpointsSet = false;
        }

    }

    public void SeachForDestination()
    {
        float z = Random.Range(-Walkrange, Walkrange);
        float x = Random.Range(-Walkrange, Walkrange);

        //Debug.Log("Valeur Flaot X = " + x);
        //Debug.Log("Valeur Flaot Z = " + z);

        DestPoint = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

        if(Physics.Raycast(DestPoint,Vector3.down, groudLayer))
        {
            WalkpointsSet=true;
        }
    }


    



}
