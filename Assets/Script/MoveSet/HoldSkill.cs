using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;

public class HoldSkill : MonoBehaviour
{
    //Automatic Shoot
    [SerializeField] private InputActionReference _charge;
    [SerializeField] private GameObject _skillVfx;
    [SerializeField] Slider _skillChargeSlider;
    [SerializeField] private Transform chargePos;
    public UnityEvent OnCast;
    public bool isCharging;
    public float chargingtime;

    private void OnEnable()
    {
        _charge.action.started += StartCharge;
        _charge.action.canceled += EndCharge;
        _charge.action.Enable();
    }
    private void OnDisable()
    {
        _charge.action.started -= StartCharge;
        _charge.action.canceled -= EndCharge;
        _charge.action.Disable();
    }
    void StartCharge(InputAction.CallbackContext context)
    {
        isCharging = true;
        Instantiate(_skillVfx, chargePos);
        _skillChargeSlider.gameObject.SetActive(true);
        _skillChargeSlider.value = 0;

    }
    void EndCharge(InputAction.CallbackContext context)
    {
        isCharging = false;
        Destroy(_skillVfx);
        Cast();
    }
    private void Update()
    {
       
        
    }
    public void Cast()
    {
        OnCast?.Invoke();
        _skillChargeSlider.gameObject.SetActive(false);
    }

}
