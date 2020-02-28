using UnityEngine;

/// <summary>
/// オブジェクトへのクリック処理
/// </summary>
public class ClickSelect : MonoBehaviour
{
    /// <summary>
    /// 選択表示のパーティクルオブジェクト
    /// </summary>
    [SerializeField]
    private GameObject selectCircle;

    /// <summary>
    /// 選択表示のパーティクル
    /// </summary>
    private GameObject circle;

    /// <summary>
    /// 選択中のオブジェクト
    /// </summary>
    private GameObject selectObject;

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
        Debug.Log("ClickSelect Start Method Start");

        Debug.Log("ClickSelect Start Method End");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    private void Update()
    {
        Debug.Log("ClickSelect Update Method Start");

        // Playerが左クリックを押下したら
        if (Input.GetMouseButtonDown(0))
        {
            // UnitPointのレイヤーマスクを取得
            int layerNo = LayerMask.NameToLayer("UnitPoint");

            // UnitPointのレイヤーマスクをbitに変換
            int layerMask = 1 << layerNo;

            // メインカメラ内で押下した座標にRayを飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Rayがヒットしたオブジェクトを設定
            RaycastHit hit = new RaycastHit();

            // UnitPointにRayがヒットしていて、ヒットしたオブジェクトのタグがMapであれば
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask) && hit.collider.gameObject.tag == "Map")
            {
                // 選択表示のパーティクルを削除
                Destroy(circle);

                // ヒットしたオブジェクトを設定
                selectObject = hit.collider.gameObject;

                // 選択表示のパーティクルを作成
                circle = Instantiate(selectCircle, selectObject.transform.position + new Vector3(0.0f, 0.75f, 0.0f), Quaternion.Euler(-90, 0, 0));
            }
        }

        // Playerが左クリックを押下したら
        if (Input.GetMouseButtonDown(1))
        {
            // 選択中のオブジェクトを解除
            selectObject = null;

            // 選択表示のパーティクルを削除
            Destroy(circle);
        }

        Debug.Log("ClickSelect Update Method End");
    }

    /// <summary>
    /// 選択中のオブジェクトを取得
    /// </summary>
    /// <returns>選択中のオブジェクト</returns>
    public GameObject GetSelectObject()
    {
        Debug.Log("ClickSelect GetSelectObject Method Start");

        Debug.Log("ClickSelect GetSelectObject Method End");

        // 選択中のオブジェクトを取得
        return selectObject;
    }
}
