using System.Collections.Generic;
public class SiteRepo {
    Dictionary<int, SiteEntity> all;
    SiteEntity[] tempAarry;
    public SiteRepo() {
        all = new Dictionary<int, SiteEntity>();
        tempAarry = new SiteEntity[100];
    }
    public void Add(SiteEntity site) {
        all.Add(site.id, site);
    }
    public void Remove(SiteEntity site) {
        all.Remove(site.id);
    }
    public void Remove(int siteID) {
        all.Remove(siteID);
    }
    public bool TryGet_Site(int id, out SiteEntity site) {
        return all.TryGetValue(id, out site);
    }
    public int TakeAll(out SiteEntity[] all_site) {
        if (all.Count > tempAarry.Length) {
            tempAarry = new SiteEntity[all.Count];
        }
        all.Values.CopyTo(tempAarry, 0);
        all_site = tempAarry;
        return all.Count;
    }
}