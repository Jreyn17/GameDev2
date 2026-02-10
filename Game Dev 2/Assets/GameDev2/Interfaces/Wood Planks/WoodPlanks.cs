using UnityEngine;

public class WoodPlanks : MonoBehaviour, IShootable
{
    public void OnShot()
    {
        Destroy(gameObject);
    }
}
