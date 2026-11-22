using UnityEngine;

public class ArraysExample : MonoBehaviour
{
    // Arrays
    float[] players = { 40f, 3.5f, 10.5f, 5f, 6f };

    int[] enemyWaves = new int[10];

    void Start()
    {
        print(players[0]);
        print(players[1]);
        print(players[2]);
        print(players[3]);
        print(players[4]);

        enemyWaves[0] = 3;
        enemyWaves[1] = 4;
        enemyWaves[2] = 8;
        enemyWaves[3] = 4;
        enemyWaves[4] = 9;
        enemyWaves[5] = 3;
        enemyWaves[6] = 7;
        enemyWaves[7] = 12;
        enemyWaves[8] = 15;
        enemyWaves[9] = 2;

        var largerstWave = enemyWaves[8];
        print(largerstWave);

        print($"Number of elements in enemywaves is {enemyWaves.Length}");
    }
}
