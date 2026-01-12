using UnityEngine;

public class TranslatePlanet : MonoBehaviour
{
    [Header("Target to move")]
    public Transform target; // If null, will default to this.transform

    [Header("Button move step (units)")]
    public float step = 0.25f; // Distance moved per button press

    [Header("Optional: auto translate per frame")]
    public Vector3 autoTranslateSpeed = Vector3.zero; // Units per second
    public bool enableAutoTranslate = false;

    [Header("Optional: destroy on Z threshold")]
    public bool destroyOnZThreshold = false;
    public float zDestroyThreshold = 50f;

    Transform Target => target != null ? target : transform;

    void Update()
    {
        // Optional per-frame translation
        if (enableAutoTranslate)
        {
            Target.Translate(autoTranslateSpeed * Time.deltaTime, Space.World);
        }

        // Optional destroy check
        if (destroyOnZThreshold && Target.position.z > zDestroyThreshold)
        {
            Debug.Log($"Destroying '{Target.gameObject.name}' because z > {zDestroyThreshold} (z={Target.position.z})");
            Destroy(Target.gameObject);
        }
    }

    // Public methods to wire to UI Buttons
    public void MoveX(float amount)
    {
        Target.Translate(new Vector3(amount, 0f, 0f), Space.World);
    }

    public void MoveY(float amount)
    {
        Target.Translate(new Vector3(0f, amount, 0f), Space.World);
    }

    public void MoveZ(float amount)
    {
        Target.Translate(new Vector3(0f, 0f, amount), Space.World);
    }

    // Convenience methods for +/- step without parameters (easier to hook to Buttons)
    public void MoveXPlus()
    {
        MoveX(step);
    }

    public void MoveXMinus()
    {
        MoveX(-step);
    }

    public void MoveYPlus()
    {
        MoveY(step);
    }

    public void MoveYMinus()
    {
        MoveY(-step);
    }

    public void MoveZPlus()
    {
        MoveZ(step);
    }

    public void MoveZMinus()
    {
        MoveZ(-step);
    }
}
