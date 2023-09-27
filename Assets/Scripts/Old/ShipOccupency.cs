using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipOccupency : MonoBehaviour
{
    public Seat pilotSeat,navigatorSeat,weaponsSeat,scienceSeat,crewQuartersSeat,groundTeamSeat,storageRoomSeat,engineSeat,reactorSeat;

    private static ShipOccupency _instance;

    public static ShipOccupency Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);

        }
        else
        {
            _instance = this;
        }
    }

    public void AssignSeat(int num, Astronaut astro)
    {
        EmptyOtherSeats(astro);
        switch (num)
        {
            case 1:
                if (!ShipOccupency.Instance.pilotSeat.IsOccupied()) { ShipOccupency.Instance.pilotSeat.Occupy(astro);  }
                    break;
            case 2:
                if (!ShipOccupency.Instance.navigatorSeat.IsOccupied()) { ShipOccupency.Instance.navigatorSeat.Occupy(astro);  }
                    break;
            case 3:
                if (!ShipOccupency.Instance.weaponsSeat.IsOccupied()) { ShipOccupency.Instance.weaponsSeat.Occupy(astro);  }
                    break;
            case 4:
                if (!ShipOccupency.Instance.scienceSeat.IsOccupied()) { ShipOccupency.Instance.scienceSeat.Occupy(astro);  }
                    break;
            case 5:
                if (!ShipOccupency.Instance.crewQuartersSeat.IsOccupied()) { ShipOccupency.Instance.crewQuartersSeat.Occupy(astro);  }
                    break;
            case 6:
                if (!ShipOccupency.Instance.groundTeamSeat.IsOccupied()) { ShipOccupency.Instance.groundTeamSeat.Occupy(astro);  }
                    break;
            case 7:
                if (!ShipOccupency.Instance.storageRoomSeat.IsOccupied()) { ShipOccupency.Instance.storageRoomSeat.Occupy(astro);  }
                    break;
            case 8:
                if (!ShipOccupency.Instance.engineSeat.IsOccupied()) { ShipOccupency.Instance.engineSeat.Occupy(astro);  }
                    break;
            case 9:
                if (!ShipOccupency.Instance.reactorSeat.IsOccupied()) { ShipOccupency.Instance.reactorSeat.Occupy(astro);  }
                break;
        }
    }

    public void EmptyOtherSeats(Astronaut _astro)
    {
        if (pilotSeat.Occupier() == _astro) { pilotSeat.Occupy(null); return; }
        if (navigatorSeat.Occupier() == _astro) { navigatorSeat.Occupy(null); return; }
        if (weaponsSeat.Occupier() == _astro) { weaponsSeat.Occupy(null); return; }
        if (scienceSeat.Occupier() == _astro) { scienceSeat.Occupy(null); return; }
        if (crewQuartersSeat.Occupier() == _astro) { crewQuartersSeat.Occupy(null); return; }
        if (groundTeamSeat.Occupier() == _astro) { groundTeamSeat.Occupy(null); return; }
        if (storageRoomSeat.Occupier() == _astro) { storageRoomSeat.Occupy(null); return; }
        if (engineSeat.Occupier() == _astro) { engineSeat.Occupy(null); return; }
        if (reactorSeat.Occupier() == _astro) { reactorSeat.Occupy(null); return; }
    }

    [Serializable]
    public class Seat
    {
        [SerializeField]private GameObject seatOBJ;
        private Astronaut astronaut;

        public Astronaut Occupier()
        {
            return astronaut;
        }

        public bool IsOccupied()
        {
            if(astronaut != null) { return true; }
            return false;
        }
        public void Occupy(Astronaut astro)
        {
            astronaut = astro;
        }
    }
}
