﻿using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Configs
{
    [CreateAssetMenu(fileName = "Item_", menuName = "Configs/ItemConfig", order = 0)]
    public class ItemConfig : ScriptableObject
    {
        public string Id;
        public ItemType Type;
        public string Name;
        public string Description;
        public AssetReferenceSprite IconRef;
        public float BuyPrice;
        public float SellPrice;

        private void OnEnable()
        {
            if (string.IsNullOrEmpty(Id))
                Id = name;
        }
    }

    public enum ItemType
    {
        None,
        Seed,
        Fruit,
    }

}