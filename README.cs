using UnityEngine;
using LethalCompany.Game;

public class ShipExpander : MonoBehaviour
{
    // Le vaisseau game object
    public GameObject ship;

    // Le facteur d'échelle pour le vaisseau
    public float scaleFactor = 2.0f;

    private void Start()
    {
        // Check if the ship game object is assigned
        if (ship == null)
        {
            Debug.LogError("Ship game object is not assigned!");
            return;
        }

        // Check if the ship game object has a Transform component
        if (ship.transform == null)
        {
            Debug.LogError("Ship game object does not have a Transform component!");
            return;
        }

        // Obtenir l'échelle originale du vaisseau
        Vector3 originalScale = ship.transform.localScale;

        // Calculer la nouvelle échelle
        Vector3 newScale = originalScale * scaleFactor;

        // Appliquer la nouvelle échelle au vaisseau
        ship.transform.localScale = newScale;
    }
}
