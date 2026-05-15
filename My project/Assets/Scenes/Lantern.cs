using UnityEngine;

public class Lantern : MonoBehaviour
{
    public GameObject lantern;
    public bool isTurnedOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTurnedOn == false)
            {
                isTurnedOn = true;
            }
            else
            {
                isTurnedOn = false;

            }
            lantern.SetActive(isTurnedOn);
        }
    }
}
