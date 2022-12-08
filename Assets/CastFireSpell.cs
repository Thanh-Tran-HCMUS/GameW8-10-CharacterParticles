using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastFireSpell : MonoBehaviour
{
    public GameObject firePosition;
    public GameObject fireParticle;
    public void CastFire()
    {
        
        Vector3 offset = firePosition.transform.position - transform.position;
        Instantiate(fireParticle, offset + transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
