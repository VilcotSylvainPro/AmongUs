using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDeplacement : MonoBehaviour
{

    PlayerInput playerInput;
    InputAction MoveAction;
    [SerializeField] private int Speed;
    [SerializeField] private GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        MoveAction = playerInput.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
       
            MovePlayer();
            StopMovePlayer();






        /*if (!Input.GetKeyDown(KeyCode.D) && !Input.GetKeyDown(KeyCode.Q) && !Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.S))
        {

            Player.GetComponent<Animator>().SetBool("Walking", false);
        }*/

    }

   /* void MoveLeftPlayer()
    {
        Player.transform.rotation = new Quaternion(0f, -90f, 0f, 0f);
        Player.GetComponent<Animator>().SetBool("Walking", true);
        */

    void MovePlayer()
    {
        Vector2 direction = MoveAction.ReadValue<Vector2>();
        //transform.position = transform.position + new Vector3(direction.x,0, direction.y) * Speed * Time.deltaTime;

        Debug.Log(direction);

        if (direction.x == 1 && direction.y == 0)
        {
            Player.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            transform.position = transform.position + new Vector3(direction.x, 0, direction.y) * Speed * Time.deltaTime;
            Player.GetComponent<Animator>().SetBool("Walking", true);
        }

        else if (direction.x > 0 && direction.y > 0)
        {
            //Diagonale droite Haut
            Player.transform.rotation = Quaternion.Euler(0f, 45f, 0f);
            transform.position = transform.position + new Vector3(direction.x, 0, direction.y) * Speed * Time.deltaTime;
            Player.GetComponent<Animator>().SetBool("Walking", true);
        }

        else if (direction.x < 0 && direction.y < 0)
        {
            //Diagonale bas gauche
            Player.transform.rotation = Quaternion.Euler(0f, 225f, 0f);
            transform.position = transform.position + new Vector3(direction.x, 0, direction.y) * Speed * Time.deltaTime;
            Player.GetComponent<Animator>().SetBool("Walking", true);
        }

        else if (direction.x > 0 && direction.y < 0)
        {
            //Diagonale bas droite
            Player.transform.rotation = Quaternion.Euler(0f, 135f, 0f);
            transform.position = transform.position + new Vector3(direction.x, 0, direction.y) * Speed * Time.deltaTime;
            Player.GetComponent<Animator>().SetBool("Walking", true);
        }

        else if (direction.y > 0 && direction.x > -1 && direction.x < 0)
        {
            //Diagonale Gauche haut
            Player.transform.rotation = Quaternion.Euler(0f, -45f, 0f);
            transform.position = transform.position + new Vector3(direction.x, 0, direction.y) * Speed * Time.deltaTime;
            Player.GetComponent<Animator>().SetBool("Walking", true);
        }

        else if(direction.x == -1 && direction.y == 0)
        {
            Player.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            transform.position = transform.position + new Vector3(direction.x, 0, direction.y) * Speed * Time.deltaTime;
            Player.GetComponent<Animator>().SetBool("Walking", true);
        }

        else if(direction.y == -1 && direction.x == 0)
        {
            Player.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
            transform.position = transform.position + new Vector3(direction.x, 0, direction.y) * Speed * Time.deltaTime;
            Player.GetComponent<Animator>().SetBool("Walking", true);
        }

        else if(direction.y == 1 && direction.x == 0)
        {
            Player.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            transform.position = transform.position + new Vector3(direction.x, 0, direction.y) * Speed * Time.deltaTime;
            Player.GetComponent<Animator>().SetBool("Walking", true);
        }
        //Player.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    void StopMovePlayer()
    {
        Vector2 direction = MoveAction.ReadValue<Vector2>();
        if (direction.x == 0 && direction.y == 0  )
        {
            Player.GetComponent<Animator>().SetBool("Walking", false);
        }
        // x et y = 0 
    }

}
