using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    RaycastHit hit;

    Vector3 click;

    float movespeed;

    //public Animation anime;

    // Use this for initialization
    void Start () {

        movespeed = 5f;

        //anime.Play("HumanoidWalk");
        
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButton(0))
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
            
            click = hit.point;
            click.y = 0;
            
            transform.Translate((click - transform.position).normalized * movespeed * Time.deltaTime);

            //anime.Play("HumanoidIdle");

        }
        else
        {
            //anime.Play("HumanoidWalk");
        }
	}
}
