using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    /// <summary>
    /// 弾が消えるまでの時間
    /// </summary>
    [SerializeField]
    private float destroyInterval;

    /// <summary>
    /// 衝突判定
    /// </summary>
    private bool destroyCheck;

    // Start is called before the first frame update
    public void Start()
    {
        //Debug.Log("CannonBall StartFunctio Start");

        //球が消える判定
        destroyCheck = false;

        destroyInterval = 0.0f;

        //Debug.Log("CannonBall StartFunctio End");
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.Log("CannonBall UpdateFunctio Start");
        if (destroyCheck == true)
        {
            destroyInterval = destroyInterval - Time.deltaTime;
        }

        if (destroyCheck == true && destroyInterval <= 0)
        {
            Destroy(this.gameObject);
        }
        Debug.Log("CannonBall UpdateFunctio End");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Character" || collision.gameObject.tag == "Map")
        {
            destroyCheck = true;
        }
    }
}
