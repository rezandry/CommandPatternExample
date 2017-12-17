using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleChart.Tools;

namespace PuzzleChart
{
    public interface ICanvas
    {
        ITool GetActiveTool();
        void SetActiveTool(ITool tool);
        void Repaint();

        void AddPuzzleObject(PuzzleObject puzzle_object);
        void RemovePuzzleObject(PuzzleObject puzzle_object);
        PuzzleObject GetObjectAt(int x, int y);
        PuzzleObject SelectObjectAt(int x, int y);
        void DeselectAllObjects();

        //Nha ini adalah interface dari Canvas, kelas interface itu rancangan method yang bakal dibuat nantinya dengan mengimplementasi pada Folder Commands/UndoCommand.cs
        //Jadi disini cuman sebatas judul kalau dibuku, nha isi dari judul itu ada di kelas implementasinya
        //Seperti sebelumnya klik kanan di Undo() dan klik allReference, terus dibawah klik yang Commands/UndoCommand.cs
        void Undo();
        void Redo();
    }
}
