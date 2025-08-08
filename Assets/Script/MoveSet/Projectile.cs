using UnityEngine;

public class Projectile : MonoBehaviour
{
  
    [SerializeField] private Rigidbody2D _skillPrefabs;
    [SerializeField] private Transform _castPos;
    [SerializeField] private float _speed;
    public void Casting()
    {
        var _mag = Instantiate(_skillPrefabs,_castPos.position, _castPos.rotation);
        _mag.linearVelocity = Vector3.forward * _speed *Time.deltaTime;
        Destroy(_mag.gameObject,10f);
    }
}
