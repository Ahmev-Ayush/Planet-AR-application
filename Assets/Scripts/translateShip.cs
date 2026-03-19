using UnityEngine;

public class translateShip : MonoBehaviour
{
    public GameObject ship;
    public Vector3 translateSpeed;

    // Update is called once per frame
    void Update()
    {
        if (ship == null)
            return;

        ship.transform.Translate(translateSpeed * Time.deltaTime);

        // If the ship's global z position exceeds 22, destroy the GameObject
        if (ship.transform.position.z > 22f)
        {
            // Optional: log for debugging
            Debug.Log($"Destroying ship '{ship.name}' because z > 22 (z={ship.transform.position.z})");
            Destroy(ship);
        }
    }
}
