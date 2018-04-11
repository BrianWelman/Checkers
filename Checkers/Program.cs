﻿using System;
using System.Collections.Generic;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        #region Interfaces

        public interface IBoard
        {
            IPiece Occupant(int position);
            IEnumerable<int> Pieces(Color color);
            void Move(IPiece piece, int destination);
            void RemoveCapturedPieces();
            void Promote(IPiece piece);
        }
        public enum Color { Black, White }
        public enum Status { Captured, Active }
        public interface IPiece
        {
            IEnumerable<int> NormalMoves(IBoard board);
            IEnumerable<int> CapturingMoves(IBoard board);
            Status Status { get; }
            Color Color { get; }
            int Position { get; }
            void Move(int destination);
        }
        public interface IPlayer
        {
            string Name { get; }
            (int, int) GetMove(); // Installed System.ValueTuple for this
        }
        public interface IReferee
        {
            IPlayer Winner();
            bool IsDraw();
            void Play();
        }
        public class IllegalMoveException : Exception { } //Changed to Exception { }

        #endregion

        #region Classes

        public class Board : IBoard
        {
            public void Move(IPiece piece, int destination)
            {
                throw new NotImplementedException();
            }

            public IPiece Occupant(int position)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<int> Pieces(Color color)
            {
                throw new NotImplementedException();
            }

            public void Promote(IPiece piece)
            {
                throw new NotImplementedException();
            }

            public void RemoveCapturedPieces()
            {
                throw new NotImplementedException();
            }
        }

        public class Piece : IPiece
        {
            public virtual Status Status => throw new NotImplementedException();

            public virtual Color Color => throw new NotImplementedException();

            public virtual int Position => throw new NotImplementedException();

            public virtual IEnumerable<int> CapturingMoves(IBoard board)
            {
                throw new NotImplementedException();
            }

            public virtual void Move(int destination)
            {
                throw new NotImplementedException();
            }
             
            public virtual IEnumerable<int> NormalMoves(IBoard board)
            {
                throw new NotImplementedException();
            }
        }

        public class King : Piece
        {
        }

        #endregion
    }
}
