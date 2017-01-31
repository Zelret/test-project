using UnityEngine;
using System.Collections;

public class turn : MonoBehaviour {

    RaycastHit hit;

    Vector3 click;

    Quaternion dir;

    float turnspeed;

    // Use this for initialization
    void Start()
    {
        
        turnspeed = 5f;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);

            click = hit.point;
            click.y = 0;

            dir = Quaternion.LookRotation((click - transform.position).normalized);

            dir.x = 0;
            dir.z = 0;

            transform.rotation = Quaternion.Slerp(transform.rotation, dir, turnspeed * Time.deltaTime);

        }
    }
}
