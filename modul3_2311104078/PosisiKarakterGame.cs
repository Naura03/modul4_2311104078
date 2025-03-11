using System;

class PosisiKarakterGame
{
    public enum State
    {
        Berdiri,
        Jongkok,
        Terbang,
        Tengkurap
    }

    private State currentState;

    public PosisiKarakterGame()
    {
        currentState = State.Berdiri;
        Console.WriteLine("State awal: Berdiri");
    }

    public void TombolW(long nim) // Ganti int menjadi long
    {
        if (nim % 3 == 0)
        {
            Console.WriteLine("Tombol arah atas ditekan");
        }
        else if (nim % 3 == 2 && currentState == State.Berdiri)
        {
            currentState = State.Terbang;
            Console.WriteLine("Posisi Take Off");
        }
    }

    public void TombolS(long nim) // Ganti int menjadi long
    {
        if (nim % 3 == 0)
        {
            Console.WriteLine("Tombol arah bawah ditekan");
        }
        else if (nim % 3 == 1 && currentState == State.Berdiri)
        {
            currentState = State.Jongkok;
            Console.WriteLine("Posisi Standby");
        }
        else if (nim % 3 == 1 && currentState == State.Tengkurap)
        {
            Console.WriteLine("Posisi Istirahat");
        }
        else if (nim % 3 == 2 && currentState == State.Terbang)
        {
            currentState = State.Jongkok;
            Console.WriteLine("Posisi Landing");
        }
    }
}
