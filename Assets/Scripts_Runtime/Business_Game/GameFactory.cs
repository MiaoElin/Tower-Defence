using UnityEngine;
public static class GameFactory {
    // public static SkillModel CreateSkillModel(GameContext con,int typeID){
    //     // bool 
    // }
    // public static TowerEntity CreateTower(GameContext con, IDService iDService, int typeID, Vector2 pos) {
    //     bool has = con.tempCon.TryGet_TowerTM(typeID, out TowerTM tm);
    //     if (!has) {
    //         Debug.LogError($"Factory.CreateTower: {typeID} not Found");
    //         return default;
    //     }
    //     con.assets.TryGet_Entity(typeof(TowerEntity).Name, out GameObject prefab);
    //     TowerEntity tower = GameObject.Instantiate(prefab).GetComponent<TowerEntity>();
    //     tower.typeID = typeID;
    //     tower.id = iDService.towerIDRecord++;
    //     tower.SetPos(pos);
    //     // SkillModelTM[] skillModelTMs = tm.skillModelTMs;
    //     // foreach (var skillTM in skillModelTMs) {
    //     //     SkillModel skill = new SkillModel();
    //     //     skill.typeID = skillTM.typeID;
    //     //     skill.SkillLevel = skillTM.SkillLevel;
    //     //     skill.skillType = skillTM.skillType;
    //     //     SkillLevelTM levelTM = skillTM.skillLevelTMs[skill.SkillLevel - 1];
    //     //     skill.cd = 0;
    //     //     // skill.cdMax = levelTM.cdMax;
    //     //     // skill.maintain = levelTM.maintain;
    //     //     // skill.maintainTimer = 0;
    //     //     // skill.interval = levelTM.interval;
    //     //     // skill.intervalTimer = 0;
    //     //     // skill.sprite = levelTM.sprite;
    //     //     // tower.skillModelComponent.Add(skill);
    //     }
    //     return tower;
    // }
    public static TowerEntity CreateTower(GameContext con, IDService iDService, int typeID, Vector2 pos, Ally ally) {
        bool has = con.tempCon.TryGet_TowerTM(typeID, out TowerTM tm);
        if (!has) {
            Debug.LogError($"Factory.CreateTower: {typeID} not Found");
            return default;
        }
        con.assets.TryGet_Entity(typeof(TowerEntity).Name, out GameObject prefab);
        TowerEntity tower = GameObject.Instantiate(prefab).GetComponent<TowerEntity>();
        tower.typeID = typeID;
        tower.id = iDService.towerIDRecord++;
        tower.SetPos(pos);
        tower.typeName = tm.typeName;
        tower.price = tm.price;
        tower.size = tm.size;
        tower.sr.sprite = tm.sprite;
        tower.allowBuildTypeIDs = tm.allowBuildTowers;
        SpawnerTM[] spawnerTMs = tm.spawnerTMs;
        foreach (var spawnerTM in spawnerTMs) {
            Spawner spawner = new Spawner();
            spawner.ally = ally;
            spawner.isSpawn = true;
            spawner.roleTypeID=spawnerTM.roleTypeID;
            spawner.rolePath = spawnerTM.rolePath;
            spawner.roleCount = spawnerTM.roleCount;
            spawner.cd = spawnerTM.cd;
            spawner.cdMax = spawnerTM.cdMax;
            spawner.maintain = spawnerTM.maintain;
            spawner.maintainTimer = spawnerTM.maintainTimer;
            spawner.interval = spawnerTM.interval;
            spawner.timer = spawnerTM.timer;
            tower.spawners.Add(spawner);
        }
        return tower;
    }
    public static void CreateHome() {

    }
    public static RoleEntity CreateRole(GameContext con, IDService iDService, int typeID, Ally ally, Vector2 pos) {
        bool has = con.tempCon.TryGet_RoleTM(typeID, out RoleTM tm);
        if (!has) {
            Debug.LogError($"Factory.CreateRole:{typeID} not Found");
            return default;
        }
        con.assets.TryGet_Entity(typeof(RoleEntity).Name, out GameObject prefab);
        RoleEntity role = GameObject.Instantiate(prefab).GetComponent<RoleEntity>();
        role.typeID = typeID;
        role.id = iDService.roleIDRecord++;
        role.SetPos(pos);
        role.sr.sprite = tm.sprite;
        role.moveSpeed = tm.moveSpeed;
        role.path = tm.path;
        SkillModelTM[] skillModelTMs = tm.skillModelTMs;
        foreach (var modeltm in skillModelTMs) {
            SkillModel skill = new SkillModel();
            skill.SkillLevel = modeltm.SkillLevel;
            skill.skillType = modeltm.skillType;
            SkillLevelTM levelTM = modeltm.skillLevelTMs[skill.SkillLevel - 1];
            skill.bulTypeID = levelTM.bulTypeID;
            skill.cd = 0;
            skill.cdMax = levelTM.cdMax;
            skill.maintainTimer = 0;
            skill.maintain = levelTM.maintain;
            skill.interval = levelTM.interval;
            skill.intervalTimer = 0;
            role.skillModelComponent.Add(skill);
            // skill(有多种技能，那图片该跟随那种技能？
            // 图片不应该跟随技能，应该跟随技能等级，不同的等级就属于不同的role，图片只要跟role就行？？)
            // 生成role的时候要给TypeID 和int level 按这两种需求来生成，图片属于技能等级。
            // 塔升级了，对应塔的兵要怎么原地升级。
        }
        return role;
    }
    public static void CreateBullet() {

    }
    // public static T EntityCreate<T>(GameContext con) where T : MonoBehaviour {
    //     string str = typeof(T).Name;
    //     if (!con.assets.TryGet_Entity(str, out GameObject tm)) {
    //         Debug.LogError($"Factory.EntityCreate: {str} not Found");
    //         return default;
    //     }
    //     return GameObject.Instantiate(tm, tm.transform).GetComponent<T>();
    // }
    // public static SiteEntity CreateSite(GameContext con, Vector2 pos) {
    //     bool has = con.assets.TryGet_Entity("SiteEntity", out GameObject sitePrefab);
    //     if (!has) {
    //         Debug.LogError("找不到siteEntity");
    //         return default;
    //     }
    //     SiteEntity site = GameObject.Instantiate(sitePrefab).GetComponent<SiteEntity>();
    //     site.Ctor();
    //     site.SetPos(pos);
    //     site.id = con.iDService.siteIDRecord++;
    //     site.OnSiteClickHandle = () => { con.uicon.UIEventCenter.Onclick_Site(site.id, site.transform.position); };
    //     con.siteRepo.Add(site);
    //     return site;
    // }
}