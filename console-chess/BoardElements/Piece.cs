﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.BoardElements
{
    abstract class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int moveAmount { get; protected set; }
        public Board board { get; protected set; }
        
        public Piece(Board board ,Color color)
        {
            this.position = null;
            this.board = board;
            this.color = color;
            this.moveAmount = 0;
        }

        public void increaseMovementAmount()
        {
            moveAmount++;
        }

        public abstract bool[,] possibleMovements();
        
    }
}
