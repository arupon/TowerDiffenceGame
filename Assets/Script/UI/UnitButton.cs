using UnityEngine;

public class UnitButton: MonoBehaviour
{
    [SerializeField]
    private GameObject controller;
    [SerializeField]
    private GameObject unit;
    
    public void OnClick()
    {
        Debug.Log("Click");

        controller.GetComponent<UnitSelectController>().SetObject(Instantiate(unit, Camera.main.transform.position - new Vector3(0.0f,0.0f,-100.0f), Quaternion.identity));
    }
}
