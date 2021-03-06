/**
 * Copyright (c) 2017-present, PFW Contributors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in
 * compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the License is
 * distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See
 * the License for the specific language governing permissions and limitations under the License.
 */

using UnityEngine;
using PFW.Model.Armory.JsonContents;

namespace PFW.Model.Armory
{
    /// <summary>
    /// Decks share unit objects.
    /// </summary>
    //[Serializable]
    public class Unit
    {
        // Identifies which category the unit is in.
        public byte CategoryId;
        // Unique for an category, 
        // should match the index in the unit list.
        public int Id;

        public string Name { get; }
        public int Price { get; }

        public readonly UnitConfig Config;

        //[Tooltip("The gameobject this will be cloned from.")]
        public GameObject Prefab { get; }
        public GameObject ArtPrefab { get; }

        public Sprite ArmoryImage { get; }

        /// <summary>
        /// If multiple units have the same mobility stats, they share
        /// references to the same mobility data.
        /// 
        /// TODO only stored here so we can create the DataComponent later,
        /// maybe just create the DataComponent earlier and cache it here..
        /// </summary>
        public MobilityData MobilityData { get; }

        public Unit(UnitConfig config, MobilityData mobility)
        {
            MobilityData = mobility;
            Name = config.Name;
            Price = config.Price;
            Prefab = Resources.Load<GameObject>(config.PrefabPath);
            ArtPrefab = Resources.Load<GameObject>(config.ArtPrefabPath);
            ArmoryImage = Resources.Load<Sprite>(config.ArmoryImage);
            Config = config;
        }
    }
}
