using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
public class ScaleFromCollider : MonoBehaviour
{
    // Reference to the BoxCollider component
    public BoxCollider boxCollider;
    [Button]
    void TransferScale()
    {
        boxCollider = GetComponent<BoxCollider>();

        // Get the size of the collider
        Vector3 colliderSize = boxCollider.size;

        // Set the transform scale to the collider size
        transform.localScale = colliderSize;

        // Set the collider size to 1, 1, 1
        boxCollider.size = Vector3.one;
    }
}

