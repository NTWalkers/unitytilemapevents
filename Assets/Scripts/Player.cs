using UnityEngine;

public class Player : MonoBehaviour
{
	private void Update ()
    {
        if (Input.GetKey(KeyCode.DownArrow) ||
            Input.GetKey(KeyCode.S))
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f);

        if (Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.W))
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f);

        if (Input.GetKey(KeyCode.LeftArrow) ||
           Input.GetKey(KeyCode.A))
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y);

        if (Input.GetKey(KeyCode.RightArrow) ||
           Input.GetKey(KeyCode.D))
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y);
    }

    public void LogCollision()
    {
        Debug.Log("Collided!");
    }
}
