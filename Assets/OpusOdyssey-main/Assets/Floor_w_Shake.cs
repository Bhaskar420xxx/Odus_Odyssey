using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Floor_w_Shake : MonoBehaviour
{
    public List<Transform> objectsReactingToBasses, objectsReactingToNB, objectsReactingToMiddles, objectsReactingToHighs, objFloor;

    [SerializeField] float t = 0.1f;
    void FixedUpdate()
    {
        makeObjectsShakeScale();
    }
    void makeObjectsShakeScale()
    {
        foreach (Transform obj in objectsReactingToBasses)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(0, 7, 50), 1), t);
        }
        foreach (Transform obj in objectsReactingToNB)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(7, 15, 2000), 1), t);
        }
        foreach (Transform obj in objectsReactingToMiddles)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(15, 30, 2000), 1), t);
        }
        foreach (Transform obj in objectsReactingToHighs)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(30, 32, 2000), 1), t);
        }
        foreach (Transform obj in objFloor)
        {
            obj.localScale = Vector3.Lerp(obj.localScale, new Vector3(1, AudioManager.instance.getFrequenciesinDiapason(0, 7, 30), 1), t/2);
            Debug.Log("Eureka");
        }
    }
}