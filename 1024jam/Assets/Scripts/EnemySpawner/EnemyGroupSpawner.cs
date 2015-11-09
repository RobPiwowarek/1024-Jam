﻿using UnityEngine;
using System.Collections;

public class EnemyGroupSpawner: MonoBehaviour  {
    const int MAX_X = 8, MAX_Y = 24, MIN_X = -8, MIN_Y = 16;
    public bool[,] grid = new bool[(MAX_X-MIN_X)/2,(MAX_Y-MIN_Y)/2];
    public GameObject[] enemies = new GameObject[10];
    void Start()
    {
        clearGrid();
        GenerateSingleEnemyGroup(0, 6);
    }

    public void GenerateSingleEnemyGroup(int id, int number)
    {
        int i = 0;
        while (i < number)
        {
            int x = selectXValue();
            int y = selectYValue();

            if (isGridFull((x + 7) / 2, (y - 1) / 2))
                continue;
            else
            {
                Instantiate(enemies[id], new Vector3(x, y), Quaternion.identity);
                grid[(x+7)/2, (y-1)/2] = true;
                ++i;
            }

        }   
    }

    void clearGrid()
    {
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 4; j++)
                grid[i, j] = false;
    }

    bool isGridFull(int x, int y)
    {
        if (grid[x,y] == true)
            return true;
        else
            return false;
    }

    int selectYValue()
    {
        int y = Random.Range(0, 4);

        if (y % 2 == 0)
            ++y;

        return y;
    }

    int selectXValue()
    {
        int x = Random.Range(MIN_X, MAX_X + 1);

        if (x % 2 == 0)
            if (x < 0)
                ++x;
            else
                --x;

        return x;
    }
}
