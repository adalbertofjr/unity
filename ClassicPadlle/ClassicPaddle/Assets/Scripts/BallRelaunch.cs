using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRelaunch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.position.x > 0)
        {
            Scoring.scorep1++;
        }
        else
        {
            Scoring.scorep2++;
        }

        other.transform.position = new Vector3(0, 0, 0);
    }
}
