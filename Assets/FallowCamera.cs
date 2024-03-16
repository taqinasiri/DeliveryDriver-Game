using UnityEngine;

public class FallowCamera : MonoBehaviour
{
    [SerializeField] private GameObject thingToFallow;

    private void LateUpdate()
    {
        transform.position = thingToFallow.transform.position + new Vector3(0,0,-10);
    }
}