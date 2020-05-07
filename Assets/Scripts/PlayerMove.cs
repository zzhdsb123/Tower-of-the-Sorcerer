using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    public Player player;
    
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move(KeyCode.LeftArrow);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(KeyCode.RightArrow);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Move(KeyCode.UpArrow);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Move(KeyCode.DownArrow);
        }
    }

    void Move(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case KeyCode.LeftArrow:
                if (!CheckNearObjects(keyCode))
                {
                    Vector3 newPos = transform.position;
                    newPos.x -= 0.32f;
                    transform.position = newPos;
                }
                break;
            case KeyCode.RightArrow:
                if (!CheckNearObjects(keyCode))
                {
                    Vector3 newPos = transform.position;
                    newPos.x += 0.32f;
                    transform.position = newPos;
                }
                break;
            case KeyCode.UpArrow:
                if (!CheckNearObjects(keyCode))
                {
                    Vector3 newPos = transform.position;
                    newPos.y += 0.32f;
                    transform.position = newPos;
                }
                break;
            case KeyCode.DownArrow:
                if (!CheckNearObjects(keyCode))
                {
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
            if (target.tag == "Door")
            {
                player.OpenDoor(target);
            }
            return true;
        }
        else
        {
            return false;
        }
    }


    //private void MoveLeft()
    //{
    //    if (!CheckLeft())
    //    {
    //        Vector3 newPos = transform.position;
    //        newPos.x -= 0.32f;
    //        transform.position = newPos;
    //    }
    //}

    //private void MoveRight()
    //{
    //    if (!CheckRight())
    //    {
    //        Vector3 newPos = transform.position;
    //        newPos.x += 0.32f;
    //        transform.position = newPos;
    //    }
    //}

    //private void MoveUp()
    //{
    //    if (!CheckUp())
    //    {
    //        Vector3 newPos = transform.position;
    //        newPos.y += 0.32f;
    //        transform.position = newPos;
    //    }
    //}

    //private void MoveDown()
    //{
    //    if (!CheckDown())
    //    {
    //        Vector3 newPos = transform.position;
    //        newPos.y -= 0.32f;
    //        transform.position = newPos;
    //    }
    //}

//    private bool CheckLeft()
//    {
//        RaycastHit2D raycastHit2D =  Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.left, 0.32f, LayerMask.GetMask("Obstacle"));
//        if (raycastHit2D.collider != null)
//        {
//            target = raycastHit2D.collider.gameObject;
//            if (target.tag == "Door")
//            {
//                player.OpenDoor(target);
//                target = null;
//            }
//            return true;
//        }
//        else
//        {
//            target = null;
//            return false;
//        }
//        //Color raycolor = Color.green;
//        //Debug.DrawRay(transform.position, Vector2.left * 0.32f, raycolor, 0.5f);
//    }

//    private bool CheckRight()
//    {
//        RaycastHit2D raycastHit2D = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.right, 0.32f, LayerMask.GetMask("Obstacle"));
//        if (raycastHit2D.collider != null)
//        {
//            target = raycastHit2D.collider.gameObject;
//            if (target.tag == "Door")
//            {
//                player.OpenDoor(target);
//                target = null;
//            }
//            return true;
//        }
//        else
//        {
//            target = null;
//            return false;
//        }
//    }

//    private bool CheckUp()
//    {
//        RaycastHit2D raycastHit2D = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.up, 0.32f, LayerMask.GetMask("Obstacle"));
//        if (raycastHit2D.collider != null)
//        {
//            target = raycastHit2D.collider.gameObject;
//            if (target.tag == "Door")
//            {
//                player.OpenDoor(target);
//                target = null;
//            }
//            return true;
//        }
//        else
//        {
//            target = null;
//            return false;
//        }
//    }

//    private bool CheckDown()
//    {
//        RaycastHit2D raycastHit2D = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.down, 0.32f, LayerMask.GetMask("Obstacle"));
//        if (raycastHit2D.collider != null)
//        {
//            target = raycastHit2D.collider.gameObject;
//            if (target.tag == "Door")
//            {
//                player.OpenDoor(target);
//                target = null;
//            }
//            return true;
//        }
//        else
//        {
//            target = null;
//            return false;
//        }
//    }
}
