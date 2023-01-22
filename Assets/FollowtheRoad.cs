using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
public class FollowtheRoad : MonoBehaviour
{
    public PathCreator pathCreator;
    public EndOfPathInstruction end;
    public float speed = 4.0f;
    public float dstTravelled = 0;

    private Rigidbody riBody;
    private void Start()
    {
        riBody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        dstTravelled += speed * Time.deltaTime;

        transform.position = pathCreator.path.GetPointAtDistance(dstTravelled, end);
         
      //  riBody.rotation =  pathCreator.path.GetRotationAtDistance(dstTravelled, end);

    }
}
