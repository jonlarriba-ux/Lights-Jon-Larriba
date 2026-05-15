using UnityEngine;

public class Movement : MonoBehaviour
{
    public int velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CapsuleMove();
    }

    void CapsuleMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += Vector3.forward * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += Vector3.left * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += Vector3.back * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += Vector3.right * velocity * Time.deltaTime;
        }
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    gameObject.transform.position += Vector3.up * velocity * Time.deltaTime;
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    gameObject.transform.position += Vector3.down * velocity * Time.deltaTime;
        //}
        //if (Input.anyKeyDown)
        //{
        //    Debug.Log(gameObject.transform.position);
        //}
    }
}
