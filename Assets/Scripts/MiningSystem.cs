using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningSystem : MonoBehaviour
{
    public void AttemptMining()
    {
        if (ShipOccupency.Instance.groundTeamSeat.IsOccupied())
        {
            ShipOccupency.Instance.groundTeamSeat.Occupier().skills.AddMiningXP(1);
            GameManager.Instance.shipStats.ore += 1 + ShipOccupency.Instance.groundTeamSeat.Occupier().skills.MiningLevel();
        }
    }
}
