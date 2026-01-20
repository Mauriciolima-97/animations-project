using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

#if UNITY_EDITOR
using UnityEditor;
#endif

public static class SkullUtil
{
#if UNITY_EDITOR
    [MenuItem("Ebac/Exercicio")]
    public static void Test()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.name = "EBAC Cube";
        cube.transform.position = Vector3.zero;

        Selection.activeGameObject = cube;
    }
#endif

    public static SphereCollider AddTrigger(Transform parent, float radius = 1)
    {
        GameObject trigger = new GameObject("Trigger", typeof(SphereCollider));
        trigger.transform.SetParent(parent);
        trigger.transform.localPosition = Vector3.zero;
        trigger.transform.localScale = Vector3.one;

        SphereCollider triggerCollider = trigger.GetComponent<SphereCollider>();
        triggerCollider.radius = radius;
        triggerCollider.isTrigger = true;

        return triggerCollider;
    }

    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }

    public static void Scale(this GameObject t, float size = 1.2f)
    {
        t.transform.localScale = Vector3.one * size;
    }

    #region RANDOM STUFF

    public static T GetRandom<T>(this T[] array)
    {
        if (array.Length == 0)
            return default;

        return array[Random.Range(0, array.Length)];
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static void Shuffle<T>(this List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = Random.Range(i, list.Count);
            (list[i], list[randomIndex]) = (list[randomIndex], list[i]);
        }
    }

    public static void Shuffle<T>(this T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int randomIndex = Random.Range(i, array.Length);
            (array[i], array[randomIndex]) = (array[randomIndex], array[i]);
        }
    }

    #endregion
}
