using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private Vector3 _posoffset;

    [SerializeField]
    private Vector3 _rotationoffset;

    [SerializeField]
    private float _smoothSpeed = 10f;

    private void LateUpdate()
    {
        if(_target.gameObject.activeInHierarchy)
        {
            Vector3 desiredPos = transform.position = _target.position + _posoffset;
            Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, _smoothSpeed * Time.deltaTime);
            transform.position = smoothPos;
            Quaternion _qrotationoffset = Quaternion.Euler(_rotationoffset);
        }
      
        //transform.rotation = _target.rotation * _qrotationoffset;
    }
}
