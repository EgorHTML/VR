using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private int speed;
    private Transform positionCube;
    void Start()
    {
        positionCube = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        OnMoveCube();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("ScoreScript").GetComponent<ScoreCollision>().IncScore();
    }

    private void OnMoveCube()
    {
        if (Input.GetKey(KeyCode.D))
            MoveTo(new Vector3(0.1f, 0, 0));
        if (Input.GetKey(KeyCode.A))
            MoveTo(new Vector3(-0.1f, 0, 0));
        if (Input.GetKey(KeyCode.W))
            MoveTo(new Vector3(0, 0.1f, 0));
        if (Input.GetKey(KeyCode.S))
            MoveTo(new Vector3(0, -0.1f, 0));
    }

    private void MoveTo(Vector3 vector)
    {
        positionCube.position += vector * Time.deltaTime * speed;
    }
}
