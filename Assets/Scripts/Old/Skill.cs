using System;

[Serializable]
public class Skills
{
    public int PilotLevel() { return LevelRange(pilotXP); }
    public void AddPilotXP(int _XPAdd) { pilotXP += _XPAdd; }
    private float pilotXP;

    public int CombatLevel() { return LevelRange(combatXP); }
    public void AddCombatXP(int _XPAdd) { combatXP += _XPAdd; }
    private float combatXP;

    public int ScienceLevel() { return LevelRange(ScienceXP); }
    public void AddScienceXP(int _XPAdd) { ScienceXP += _XPAdd; }
    private float ScienceXP;

    public int MiningLevel() { return LevelRange(MiningXP); }
    public void AddMiningXP(int _XPAdd) { MiningXP += _XPAdd; }
    private float MiningXP;

    private int LevelRange(float _xp)
    {
        if(_xp < 25)
        {
            return 0;
        }
        else if (_xp < 50)
        {
            return 1;
        }
        else if (_xp < 100)
        {
            return 2;
        }
        else if (_xp < 250)
        {
            return 3;
        }
        else if (_xp < 700)
        {
            return 4;
        }
        else if (_xp < 1500)
        {
            return 5;
        }
        if(_xp > 1500)
        {
            return 6;
        }
        return -1;
    }
}
