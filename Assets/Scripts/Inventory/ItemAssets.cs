using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }
    public Transform pfItemWorld;
    private void Awake()
    {
        Instance = this;
    }

    public Sprite woodSprite;
    public Sprite waterSprite;
    public Sprite flowerSprite;
    public Sprite mushroomSprite;
    public Sprite herbSprite;
    public Sprite axeSprite;
    public Sprite berriesSprite;
    public Sprite fishingRodSprite;
    public Sprite fishSprite;
    public Sprite potion1Sprite;
    public Sprite potion2Sprite;
    public Sprite potion3Sprite;
}
