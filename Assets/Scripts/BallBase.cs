using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE 
// Parent class other balls can inherit behaviours from this class
[RequireComponent(typeof (Rigidbody), typeof(SphereCollider))]
public abstract class BallBase : MonoBehaviour
{

    private float ballSpeed = 10.0f;

    protected Vector3 startPosition = new Vector3(10.0f, 2.0f,0.0f);    //ENCAPSULATION only parent and child classes can access 
    public float SET_BALL_SPEED                                         //ENCAPSULATION speed is valideated between min, max values.
    {
        set { ballSpeed = Mathf.Clamp(value, 1.0f, 100.0f); }
    }

    //POLYMORPHISM 
    //Child classes can override LaunchBall
    public abstract void LaunchBall();    


    public virtual void ResetBall() 
    {
        transform.position = startPosition;
    }
    public virtual void ResetBall(Vector3 newStartPostion) //POLYMORPHISM ResetBall can override with Vector3  parameter     
    {
        transform.position = newStartPostion;
    }

    private void Start() // ABSTRACTION
    {
        ResetBall();
    }
}
