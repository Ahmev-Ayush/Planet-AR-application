using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public GameObject planet;
    public Vector3 rotationSpeed;


    // Update is called once per frame
    void Update()
    {
        planet.transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
