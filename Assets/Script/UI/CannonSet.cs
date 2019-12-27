using UnityEngine;

public class CannonSet : MonoBehaviour
{
    [SerializeField]
    private GameObject gameController;

    [SerializeField]
    private GameObject cannon;

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
        
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    private void Update()
    {
        
    }

    public void Onclick()
    {
        GameObject selectObject = gameController.GetComponent<>().GetSelectObject();

        Instantiate(cannon, selectObject.transform.position + new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
    }
}
