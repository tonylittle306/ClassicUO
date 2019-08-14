﻿// Copyright (C) 2019 ClassicUO Development Community on Github.
//
// This project is an alternative client for the game Ultima Online.
// The goal of this is to develop a lightweight client considering
//  new technologies.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.

namespace ClassicUO.Input
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;

    public sealed class MouseEventArgs : EventArgs
    {
        public MouseEventArgs(int x, int y, MouseButton button = MouseButton.None, ButtonState state = ButtonState.Released)
        {
            Location = new Point(x, y);
            Button = button;
            ButtonState = state;
        }

        public Point Location { get; }

        public int X => Location.X;

        public int Y => Location.Y;

        public MouseButton Button { get; }

        public ButtonState ButtonState { get; }
    }
}