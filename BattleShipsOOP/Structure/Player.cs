﻿
using System.Collections.Generic;


namespace BattleShipsOOP
{
    public class Player
    {
        public Fleet _fleet;                   /// CHANGE TO PUBLIC
        private List<Coords> _defenceCoords;
        private List<Coords> _attackCoords;
        private bool _isPrepared;

        public Player()
        {
            _defenceCoords = new List<Coords>();
            _attackCoords = new List<Coords>();
            _isPrepared = false;
        }

        public void CheckFleet()              
        {
            foreach (var item in _fleet.ProvideFleet())
            {
                if (item._shipStatus == ShipStatus.Destroyed)
                {
                    _fleet.ProvideFleet().Remove(item);
                    return;
                }
                    
            }

        }

        public void AddFleet(Fleet fleet)
        {
            _fleet = fleet;
        }
        public bool IsPrepared()
        {
            return _isPrepared;
        }
        public List<Coords> ReturnDefenceList()
        {
            return _defenceCoords;
        }

        public List<Coords> ReturnAttackList()
        {
            return _attackCoords;
        }


        public void CheckIfPlayerIsReady()
        {
            if(_fleet != null)
            {
                _isPrepared = true;
                Status.Info(9);
            }
            else
            {
                _isPrepared = false;
                Status.Info(10);
            }
                       
        }

        public bool CheckIfPlayerLost()
        {
            return _fleet.CheckEndGameConditions();
        }
    }

   
}
