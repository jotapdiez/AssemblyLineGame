using UnityEngine;

public class RollerController : MonoBehaviour
{

    public float speed = 2.0f;
    private float startTime;
    private float journeyLength;
    private bool started = false;

    public Transform startMarker;
    public Transform endMarker;

    void Start()
    {
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Debug.Log("OnTriggerStay2D::name= " + other.name);
        // other.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        float rollerAngle = transform.eulerAngles.z;
        // Debug.Log("RollerAngle: " + rollerAngle);
        // if (target.transform.eulerAngles.z == rollerAngle)
        // {
        //     return;
        // }

        // Vector3 targetPosition = target.transform.position;
        // Vector3 size = GetComponent<Renderer>().bounds.size;

        // bool rotateTarget = false;
        // if (rollerAngle == 90 || rollerAngle == -90){
        //     float middle = size.y/2;
        //     Debug.Log("middle Vertical: " + middle);
        //     if (middle == targetPosition.y){
        //         rotateTarget = true;
        //     }
        // }else if (rollerAngle == 0 || rollerAngle == 180){
        //     float middle = size.x / 2;
        //     Debug.Log("middle horizontal: " + middle);
        //     if (middle == targetPosition.x)
        //     {
        //         rotateTarget = true;
        //     }
        // }

        // if (rotateTarget){
            Vector3 eulerRotation = new Vector3(target.transform.eulerAngles.x, target.transform.eulerAngles.y, rollerAngle);
            target.transform.rotation = Quaternion.Euler(eulerRotation);
        // }
    }

}
