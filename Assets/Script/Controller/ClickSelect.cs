using UnityEngine;

public class ClickSelect : MonoBehaviour
{
    [SerializeField]
    private GameObject selectCircle;
    private GameObject circle;
    private GameObject selectObject;

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
        if (Input.GetMouseButtonDown(0))
        {
            int layerNo = LayerMask.NameToLayer("UnitPoint");
            int layerMask = 1 << layerNo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                if (hit.collider.gameObject.tag == "Map")
                {
                    Destroy(circle);
                    selectObject = hit.collider.gameObject;
                    circle = Instantiate(selectCircle, selectObject.transform.position + new Vector3(0.0f, 0.75f, 0.0f), Quaternion.Euler(-90, 0, 0));
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            selectObject = null;
            Destroy(circle);
        }
    }

    /// <summary>
    /// 選択中のオブジェクトを取得
    /// </summary>
    /// <returns>選択中のオブジェクト</returns>
    public GameObject GetSelectObject()
    {
        return selectObject;
    }
}
