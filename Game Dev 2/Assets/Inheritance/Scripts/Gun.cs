using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public float range = 100;
    public float timeBetweenShots = 0.2f;
    public GameObject hitMarker;
    protected Timer timer;

    void Start()
    {
        timer = GetComponent<Timer>();
    }
    protected virtual void Shoot()
    {
        Debug.Log("Shoot function not defined for: " + gameObject.name);
    }

    public void GetLeftClickInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
            Shoot();
    }
}
