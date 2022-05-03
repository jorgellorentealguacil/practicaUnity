using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class ImageFoundScript : DefaultObserverEventHandler
{
    public GameObject controller;
    public ImageTargetType carta;
    
    protected override void OnTrackingFound()
    {
        if (mObserverBehaviour)
        {
            var rendererComponents = mObserverBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mObserverBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mObserverBehaviour.GetComponentsInChildren<Canvas>(true);

            // Enable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Enable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Enable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;
        }

        controller.GetComponent<gameController>().aniadirCarta(carta);
        OnTargetFound?.Invoke();

    }

    protected override void OnTrackingLost()
    {
        if (mObserverBehaviour)
        {
            var rendererComponents = mObserverBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mObserverBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mObserverBehaviour.GetComponentsInChildren<Canvas>(true);

            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = false;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = false;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = false;
        }

        OnTargetLost?.Invoke();
    }
}
