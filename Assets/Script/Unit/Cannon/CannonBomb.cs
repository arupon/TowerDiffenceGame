using UnityEngine;

public class CannonBomb : MonoBehaviour
{
    [SerializeField]
    private float time;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Start()
    {
        
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
        time = time - Time.deltaTime;

        if(time <= 0)
        {
            Destroy(gameObject);
        }
    }
}
