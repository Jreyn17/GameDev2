using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Gun : MonoBehaviour
{
    public float range = 100;
    public float timeBetweenShots = 0.2f;
    public GameObject hitMarker;
    protected Timer timer;

    void Start()
    {
        timer = GetComponent<Timer>();
    }
    abstract protected void Shoot();

    public void GetLeftClickInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
            Shoot();
    }
}
