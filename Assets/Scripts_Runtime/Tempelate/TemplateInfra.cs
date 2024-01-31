using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
// using UnityEngine.ResourceManagement.AsyncOperations;
// using System.Threading.Tasks;
public static class TempelateInfra {
    public static void LoadAll(TempelateContext tempCon) {
        {
            // AssetLabelReference labelReference = new AssetLabelReference();
            // labelReference.labelString = "TowerTM";
            const string lable = "TowerTM";
            IList<TowerTM> all = Addressables.LoadAssetsAsync<TowerTM>(lable, null).WaitForCompletion();
            foreach (var tm in all) {
                tempCon.Add_TowerTM(tm);
            }
        }
        {
            const string lable = "SkillModelTM";
            IList<SkillModelTM> all = Addressables.LoadAssetsAsync<SkillModelTM>(lable, null).WaitForCompletion();
            foreach (var tm in all) {
                tempCon.Add_SkillModelTM(tm);
            }
        }
        {
            // const string lable = "SkillLevelTM";
            // IList<SkillLevelTM> all = Addressables.LoadAssetsAsync<SkillLevelTM>(lable, null).WaitForCompletion();
            // foreach (var tm in all) {
            //     tempCon.Add_SkillLevelTM(tm);
            // }
        }
        {
            const string label = "RoleTM";
            IList<RoleTM> all = Addressables.LoadAssetsAsync<RoleTM>(label, null).WaitForCompletion();
            foreach (var tm in all) {
                tempCon.Add_RoleTM(tm);
            }
        }
        {
            // const string label = "SpawnerTM";
            // IList<SpawnerTM> all = Addressables.LoadAssetsAsync<SpawnerTM>(label, null).WaitForCompletion();
            // foreach (var tm in all) {
            //     tempCon.Add_SpawnerTM(tm);
            // }
        }
        {
            const string label = "BulletTM";
            IList<BulletTM> all = Addressables.LoadAssetsAsync<BulletTM>(label, null).WaitForCompletion();
            foreach (var tm in all) {
                tempCon.Add_BulletTM(tm);
            }
        }
        {
            const string label = "LevelTM";
            IList<LevelTM> all = Addressables.LoadAssetsAsync<LevelTM>(label, null).WaitForCompletion();
            foreach (var tm in all) {
                tempCon.Add_levelTM(tm);
            }
        }
    }
}