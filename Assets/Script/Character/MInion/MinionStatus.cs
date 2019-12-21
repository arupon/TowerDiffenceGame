using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionStatus : MonoBehaviour
{
    [SerializeField]
    private int hp;

    // Start is called before the first frame update
    public void Start()
    {
        //Debug.Log("MinionStatus StartFunction Start");
        //Debug.Log("MinionStatus StartFunction Finish");
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.Log("MinionStatus UpdateFunction Start");

        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }

        Debug.Log("MinionStatus UpdateFunction Finish");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "CannonBall")
        {
            hp = hp - 500;
        }
    }
}
