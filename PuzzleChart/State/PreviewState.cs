﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleChart.State
{
    public class PreviewState : PuzzleState
    {
        private static PuzzleState instance;

        public static PuzzleState GetInstance()
        {
            if (instance == null)
            {
                instance = new PreviewState();
            }
            return instance;
        }

        public override void Draw(PuzzleObject obj)
        {
            obj.RenderOnPreview();
        }

        public override void Select(PuzzleObject obj)
        {
            obj.ChangeState(EditState.GetInstance());
        }
    }
}
