using UnityEngine;

public class VarExample : MonoBehaviour
{
    int a = 5;

    SpriteRenderer sr;

    void Awake()
    {
        // SpriteRenderer sr = GetComponent<SpriteRenderer>();
        var sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        print(a);
        var b = a;

        var str = "Subhi";

        var number = 10;
        var number2 = 1.5;
        var number3 = 5f;
        var aaa = true;
    }
}
