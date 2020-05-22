using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    public Player player;
    public Animator animator;
    public bool mobDictionary = false;
    public AudioSource audioSource;

    float timeBetweenMoveStatic = 0.2f;
    float timeBetweenMove;

    public void ResetTimeBetweenMove()
    {
        timeBetweenMove = timeBetweenMoveStatic;
    }

    private void Start()
    {
        timeBetweenMove = timeBetweenMoveStatic;
    }

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (timeBetweenMove == timeBetweenMoveStatic)
            {
                Move(KeyCode.LeftArrow);
                timeBetweenMove -= Time.deltaTime;
            }
            else if (timeBetweenMove <= 0f)
            {
                Move(KeyCode.LeftArrow);
                timeBetweenMove = timeBetweenMoveStatic - Time.deltaTime;
            }
            else
            {
                timeBetweenMove -= Time.deltaTime;
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            timeBetweenMove = timeBetweenMoveStatic;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (timeBetweenMove == timeBetweenMoveStatic)
            {
                Move(KeyCode.RightArrow);
                timeBetweenMove -= Time.deltaTime;
            }
            else if (timeBetweenMove <= 0f)
            {
                Move(KeyCode.RightArrow);
                timeBetweenMove = timeBetweenMoveStatic - Time.deltaTime;
            }
            else
            {
                timeBetweenMove -= Time.deltaTime;
            }   
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            timeBetweenMove = timeBetweenMoveStatic;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (timeBetweenMove == timeBetweenMoveStatic)
            {
                Move(KeyCode.UpArrow);
                timeBetweenMove -= Time.deltaTime;
            }
            else if (timeBetweenMove <= 0f)
            {
                Move(KeyCode.UpArrow);
                timeBetweenMove = timeBetweenMoveStatic - Time.deltaTime;
            }
            else
            {
                timeBetweenMove -= Time.deltaTime;
            }
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            timeBetweenMove = timeBetweenMoveStatic;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (timeBetweenMove == timeBetweenMoveStatic)
            {
                Move(KeyCode.DownArrow);
                timeBetweenMove -= Time.deltaTime;
            }
            else if (timeBetweenMove <= 0f)
            {
                Move(KeyCode.DownArrow);
                timeBetweenMove = timeBetweenMoveStatic - Time.deltaTime;
            }
            else
            {
                timeBetweenMove -= Time.deltaTime;
            }
            

        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            timeBetweenMove = timeBetweenMoveStatic;
        }
    }

    void Move(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case KeyCode.LeftArrow:
                if (!CheckNearObjects(keyCode))
                {
                    animator.SetTrigger("moveLeft");
                    Vector3 newPos = transform.position;
                    newPos.x -= 0.32f;
                    transform.position = newPos;
                }
                break;
            case KeyCode.RightArrow:
                if (!CheckNearObjects(keyCode))
                {
                    animator.SetTrigger("moveRight");
                    Vector3 newPos = transform.position;
                    newPos.x += 0.32f;
                    transform.position = newPos;
                }
                break;
            case KeyCode.UpArrow:
                if (!CheckNearObjects(keyCode))
                {
                    animator.SetTrigger("moveUp");
                    Vector3 newPos = transform.position;
                    newPos.y += 0.32f;
                    transform.position = newPos;
                }
                break;
            case KeyCode.DownArrow:
                if (!CheckNearObjects(keyCode))
                {
                    animator.SetTrigger("moveDown");
                    Vector3 newPos = transform.position;
                    newPos.y -= 0.32f;
                    transform.position = newPos;
                }
                break;
        }
        
    }

    bool CheckNearObjects(KeyCode keyCode)
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.left, 0);
        switch (keyCode)
        {
            case KeyCode.LeftArrow:
                raycastHit2D = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.left, 0.32f, LayerMask.GetMask("Obstacle"));
                break;
            case KeyCode.RightArrow:
                raycastHit2D = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.right, 0.32f, LayerMask.GetMask("Obstacle"));
                break;
            case KeyCode.UpArrow:
                raycastHit2D = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.up, 0.32f, LayerMask.GetMask("Obstacle"));
                break;
            case KeyCode.DownArrow:
                raycastHit2D = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.down, 0.32f, LayerMask.GetMask("Obstacle"));
                break;
        }
        if (raycastHit2D.collider != null)
        {
            GameObject target = raycastHit2D.collider.gameObject;
            if (target.tag == "Objects")
            {
                target.GetComponent<Objects>().Trigger();
            }
            else if (target.tag == "Monster")
            {
                target.GetComponent<Monster>().Trigger();
            }
            
            return true;
            
        }
        else
        {
            audioSource.Play();
            return false;
        }
    }
}
