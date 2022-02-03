using UnityEngine;

public class TapArea : MonoBehaviour
{
    //public Vector3 position;
    public void UserTap()
    {
        //position.x = Input.mousePosition.x;
        //position.y = Input.mousePosition.y;
        GameManager.Instance.CollectByTap(Input.mousePosition, transform);
        Debug.Log("Tes");
    }
}
