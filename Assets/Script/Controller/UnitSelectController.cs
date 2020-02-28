using UnityEngine;

/// <summary>
/// ユニットの選択に関するコントローラー
/// </summary>
public class UnitSelectController : MonoBehaviour
{
<<<<<<< HEAD
    /// <summary>
    /// 
    /// </summary>
=======
>>>>>>> origin/master
    private GameObject selectObject;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Start()
    {
        // gameObjects = new List<GameObject>();
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
        
    }

    public void SetObject(GameObject gameObject)
    {
        Destroy(selectObject);
        selectObject = gameObject;
    }

    public GameObject GetObject()
    {
        return gameObject;
    }
}
