using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Dictionary<string, int> items = new Dictionary<string, int>();
    public int GetCount(string item)
    {
        if (items.ContainsKey(item))
            return items[item];
        else
            return 0;
    }
    public void Add(string item, int count)
    {
        if (items.ContainsKey(item))
            items[item] += count;
        else
            items[item] = count;
    }
    public void Remove(string item, int count = -1)
    {
        if (items.ContainsKey(item))
        {
            if (count == -1)
                items.Remove(item);
            else
            {
                int newCount = items[item] - count;
                if (newCount < 1)
                    items.Remove(item);
                else
                    items[item] = newCount;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
