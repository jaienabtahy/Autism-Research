using UnityEngine;

public class Addpoint : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            ScoreManager.instance.Addpoints();
        }
    }
}
