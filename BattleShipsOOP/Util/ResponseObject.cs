﻿
using System.Collections.Generic;


namespace BattleShipsOOP
{
    public class ResponseObject
    {
        private List<Cell> _shipPosition;
        private bool _success;

        public ResponseObject(bool succes)
        {
            _success = succes;
        }
        public ResponseObject(bool succes,List<Cell> shipPosition)
        {
            _success = succes;
            _shipPosition = shipPosition;
        }

        public bool Success()
        {
            return _success;
        }

        public List<Cell> ShipPosition()
        {
            return _shipPosition;
        }

    }
}
