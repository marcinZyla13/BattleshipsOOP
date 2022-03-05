﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsOOP
{
    internal class Fleet
    {
        private PlayerStatus _playerStatus;

        private List<Ship> _shipList;

        private int _maxShipAmount = 3;

 
        public Fleet(PlayerStatus playerStatus)
        {
            _playerStatus = playerStatus;
            _shipList = new List<Ship>(_maxShipAmount);
        }

        public PlayerStatus CheckFleetOwner()
        {
            return _playerStatus;
        }

        public void AddShips(Ship ship)
        {
            if(ValidateFleetProcess(ship))
            {              
                _shipList.Add(ship);
                Status.Info(5);
            }
                
        }

        public bool ValidateFleetProcess(Ship ship)
        {
            if(ship == null)
            {
                Status.Info(7);
                return false;
            }
            if(_shipList.Count > 3)
            {
                Status.Info(4);
                return false;
            }
            if (_shipList.Contains(ship))
            {
                Status.Info(6);
                return false;
            }
            return true;
        }

    }


}
