using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautsPanel : MonoBehaviour
{
    private static AstronautsPanel _instance;

    public static AstronautsPanel Instance { get { return _instance; } }
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

        //im alive
        GameManager.Instance.GameLoaded();
    }

    public AstronautPanelPiece[] pieces;

    public void SetupAstronauts(Astronaut[] nautsList)
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            pieces[i].UpdatePiece(nautsList[i]);
        }
    }
    private AstronautPanelPiece clickedPiece;
    public void AstronautClicked(int num)
    {
        clickedPiece = pieces[num-1];
    }

    public void ClickedStation(int num)
    {
        switch (num)
        {
            case 1:
                if (!ShipOccupency.Instance.pilotSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut); 
                    UpdateAstroText(clickedPiece.astronaut, "Pilot");
                }
                break;
            case 2:
                if (!ShipOccupency.Instance.navigatorSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut);
                    UpdateAstroText(clickedPiece.astronaut, "Navigator");
                }
                break;
            case 3:
                if (!ShipOccupency.Instance.weaponsSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut);
                    UpdateAstroText(clickedPiece.astronaut, "Gunner");
                }
                break;
            case 4:
                if (!ShipOccupency.Instance.scienceSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut);
                    UpdateAstroText(clickedPiece.astronaut, "Science");
                }
                break;
            case 5:
                if (!ShipOccupency.Instance.crewQuartersSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut);
                    UpdateAstroText(clickedPiece.astronaut, "Relaxing");
                }
                break;
            case 6:
                if (!ShipOccupency.Instance.groundTeamSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut);
                    UpdateAstroText(clickedPiece.astronaut, "GroundTeam");
                }
                break;
            case 7:
                if (!ShipOccupency.Instance.storageRoomSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut);
                    UpdateAstroText(clickedPiece.astronaut, "Storage");
                }
                break;
            case 8:
                if (!ShipOccupency.Instance.engineSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut);
                    UpdateAstroText(clickedPiece.astronaut, "Engine");
                }
                break;
            case 9:
                if (!ShipOccupency.Instance.reactorSeat.IsOccupied()) { 
                    ShipOccupency.Instance.AssignSeat(num, clickedPiece.astronaut);
                    UpdateAstroText(clickedPiece.astronaut, "Reactor");
                }
                break;
        }
    }

    public void UpdateAstroText(Astronaut astro, string taskText)
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            if (pieces[i].astronaut == astro) { pieces[i].ChangeTask(taskText);return; }
        }
    }
}
