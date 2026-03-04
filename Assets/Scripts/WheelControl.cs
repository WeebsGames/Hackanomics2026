using System.Data;
using UnityEngine;

public class WheelControl : MonoBehaviour
{
    public Transform wheelModel;

    [HideInInspector] public WheelCollider WheelCollider;

    // Create properties for the CarControl script
    // (You should enable/disable these via the 
    // Editor Inspector window)
    public bool steerable;
    public bool motorized;
    public float aSlip = 0.8f;
    public float aValue = 0.5f;
    public float eSlip = 0.4f;
    public float eValue = 1.0f;

    Vector3 position;
    Quaternion rotation;
    WheelFrictionCurve newFriction;

    // Start is called before the first frame update
    private void Start()
    {
        WheelCollider = GetComponent<WheelCollider>();
        newFriction.asymptoteSlip = aSlip;
        newFriction.asymptoteValue = aValue;
        newFriction.extremumSlip = eSlip;
        newFriction.extremumValue = eValue;
        WheelCollider.forwardFriction = newFriction;

    }

    // Update is called once per frame
    void Update()
    {
        // Get the Wheel collider's world pose values and
        // use them to set the wheel model's position and rotation
        WheelCollider.GetWorldPose(out position, out rotation);
        wheelModel.transform.position = position;
        wheelModel.transform.rotation = rotation;
    }
}
