using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class MouseClickController : MonoBehaviour
{
    public NavMeshAgent playerNavMeshAgent;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;
            if (Physics.Raycast(myRay, out myRaycastHit))
            {
                //RotatePlayerIntoMouse();
                playerNavMeshAgent.SetDestination(myRaycastHit.point);
                
            }
        }
        if (playerNavMeshAgent.remainingDistance <= playerNavMeshAgent.stoppingDistance)
        {
            
        }
        else
        {
            
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //anim.SetTrigger("CastSpell");
        }

    }

    public void RotatePlayerIntoMouse()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
}
