using UnityEngine;

public class Changelight : MonoBehaviour
{
    private GameObject[] gameObject;
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    private int i = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject = new GameObject[3];
        gameObject[0] = g1;
        gameObject[1] = g2;
        gameObject[2] = g3;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i == 0){
                gameObject[0].SetActive(false);
                gameObject[1].SetActive(true);
                i = 1;
            }
            else if (i == 1)
            {
                gameObject[1].SetActive(false);
                gameObject[2].SetActive(true);
                i = 2;
            }
            else if (i == 2)
            {
                gameObject[2].SetActive(false);
                gameObject[0].SetActive(true);
                i = 0;
            }
        }
    }
}
