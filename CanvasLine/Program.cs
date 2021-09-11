using System;
using System.Collections.Generic;

namespace CanvasLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int canvasCount = int.Parse(Console.ReadLine());
            List<Canvas> allCanvas = new List<Canvas>();

            for (int i = 0; i < canvasCount; i++)
            {
                string edges = Console.ReadLine();
                string[] edgeActual = edges.Split(" ");
                allCanvas.Add(new Canvas(int.Parse(edgeActual[0]), int.Parse(edgeActual[1])));
            }
            int pegsUsed = int.Parse(Console.ReadLine());
            int[] pegPos = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));

            int pegsNeeded = 0;

            foreach (Canvas sheet in allCanvas)
            {
                foreach (int peg in pegPos)
                {
                    sheet.inBounds(peg);
                }
                if (!sheet.leftClipped)
                    pegsNeeded++;
                if (!sheet.rightClipped)
                    pegsNeeded++;
            }
        }
    }

    class Canvas
    {
        private int start;
        private int end;
        public bool leftClipped;
        public bool rightClipped;
        public Canvas(int start, int end)
        {
            this.start = start;
            this.end = end;
            leftClipped = false;
            rightClipped = false;
        }

        public bool inBounds(int pos)
        {
            //add 1cm error bounds
            if (pos > start && pos < (end / 2))
            {
                leftClipped = true;
                return true;
            } else if(pos > (end / 2) && pos < end)
            {
                rightClipped = true;
                return true;
            } else
            {
                return false;
            }
        }

    }
}
