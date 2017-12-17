using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleChart.Commands
{
    public class UndoCommand : ICommand
    {
        //*2 variable Icanvas ini
        private ICanvas canvas;
        //Author: Reza 140
        //Class: Redo
        //Date : 11/9/2016
        //Membuat class dasar Undo untuk command pattern

        //Nha kan logic dari undo udah ada di Default Canvas, sekarang gimana dia dipanggil? 
        //Dia dipanggil disini, diatas ada tulisan UndoCOmmand : ICommand, dia berarti mengimplementasikan Kelas Interface ICommand
        //Coba cek disana, bakal ada method Execute yang dipanggil disini*1 
        //Terus ini apa kok ada UndoCommand?
        //Ini adalah COnstructor kelas, dimana dia pasti dipanggil sebelum code lainnya dieksekusi, nama methodnya sama kayak dengan nama kelasnya
        //Di kelas constructor ini dia inisialisasi variable ini*2 
        //Dia akan menerima variable ICanvas ketika dipanggil dan dimasukkan ke dalam variable lokal
        //Kenapa kudu dimasukin ke variable local? Kenapa ngga langsung dieksekusi aja?
        //Jawabannya karena biar aman, jadi apa yang dikirim adalah variable public yang bisa diakses oleh kelas lain, gabisa diganti valuenya
        //Ketika udah diinisialisasi (dimasukan ke variable) lokal, yang bersifat private, maka yang bisa akses cuman kelas ini aja
        //Nah, udah undo udah bisa dipakai dan command pattern udah diimplementasi, gimana pakainya?
        //Seperti sebelumnya klik kanan di UndoCommand dan klik Find All Reference
        public UndoCommand(ICanvas canvas)
        {
            this.canvas = canvas;
        }

        //*1 Yang ini
        public void Execute()
        {
            canvas.Undo();
        }
    }
}
