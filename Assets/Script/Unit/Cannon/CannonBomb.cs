using UnityEngine;

<<<<<<< HEAD
/// <summary>
/// 爆風処理
/// </summary>
public class CannonBomb : MonoBehaviour
{
    /// <summary>
    /// 爆風の残る時間
    /// </summary>
=======
public class CannonBomb : MonoBehaviour
{
>>>>>>> origin/master
    [SerializeField]
    private float time;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Start()
    {
<<<<<<< HEAD
        Debug.Log("CannonBomb Start Method Start");

        Debug.Log("CannonBomb Start Method End");
=======
        
>>>>>>> origin/master
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
<<<<<<< HEAD
        Debug.Log("CannonBomb Update Method Start");

        // 爆風の消滅時間を減少
        time = time - Time.deltaTime;

        // 爆風の消滅時間が0を下回れば
        if(time <= 0)
        {
            // 爆風を消滅
            Destroy(gameObject);
        }

        Debug.Log("CannonBomb Update Method End");
=======
        time = time - Time.deltaTime;

        if(time <= 0)
        {
            Destroy(gameObject);
        }
>>>>>>> origin/master
    }
}
