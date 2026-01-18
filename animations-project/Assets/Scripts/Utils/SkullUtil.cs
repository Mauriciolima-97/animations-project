using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

public static class SkullUtil
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Test")]

    public static void Test()
    {
        Debug.Log("Test");

    }
    [UnityEditor.MenuItem("Ebac/Test2 %g")]

    public static void Test2()
    {
        Debug.Log("Test2");
    }
#endif

    public static SphereCollider AddTrigger(Transform parent, float radius = 1)
    {
        GameObject _trigger = new GameObject("Trigger", typeof(SphereCollider));
        _trigger.transform.SetParent(parent);
        _trigger.transform.localPosition = Vector3.zero;
        _trigger.transform.localScale = Vector3.one;
        _trigger.layer = LayerMask.NameToLayer("Triggers");

        SphereCollider _triggerCollider = _trigger.GetComponent<SphereCollider>();
        _triggerCollider.radius = radius;
        _triggerCollider.isTrigger = true;

        return _triggerCollider;

    }

    public static void Scale (this Transform t, float size = 1.2f)
    {
        t.transform.localScale = Vector3.one * size;
    }
    public static void Scale(this GameObject t, float size = 1.2f)
    {
        t.transform.localScale = Vector3.one * size;
    }

    public static void ScaleVector(this Vector3 t, float size = 1.2f)
    {
       // t.transform.localScale = Vector3.one * size;
    }


}
