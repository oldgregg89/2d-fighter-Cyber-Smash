using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    Animator myAnimator;
    Rigidbody2D myRigidBody;
    private Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        myAnimator = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();
        FlipSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        FlipSprite();
    }
    private void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(myRigidBody.velocity.x), 1f);
        }
				myAnimator.SetBool("attack", playerHasHorizontalSpeed);
    }
}
