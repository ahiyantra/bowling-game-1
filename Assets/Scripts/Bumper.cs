//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using Zinnia.Tracking.Collision;

public class Bumper : MonoBehaviour
{
    public void Bounce(CollisionNotifier.EventData data)
    {
        data.CollisionData.rigidbody.velocity = Vector3.Reflect(data.CollisionData.rigidbody.velocity, Vector3.right);
    }

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
